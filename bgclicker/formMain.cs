using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Threading;
using System.Diagnostics;

namespace bgclicker
{
    public partial class formMain : Form
    {
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public IntPtr Hwnd;//窗口句柄
        public Boolean runningStatus;//连点运行状态
        public int key1;//连点循环中按键按下的消息
        public int key2;//连点循环中按键抬起的消息
        private Configuration configuration;//程序设置
        private delegate void DoClickFunc();//点击方法委托
        private volatile int currentThreadID = 0;//当前正在运行的线程ID
        private volatile int threadIDAccumulator = 0;//为每个线程编号
        private DoClickFunc doClickFunc;
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int nMaxCount);
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public formMain()
        {
            InitializeComponent();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ReadConfig();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void ShowNotify(string info)
        {
            if (chkboxEnableNotify.Checked)
            {
                notifyIcon.ShowBalloonTip(1000, info, " ", ToolTipIcon.Info);
            }
        }
        #region 点击方法
        private void DoBGClick()//后台单击
        {
            PostMessage(Hwnd, key1, 0, 0);
            PostMessage(Hwnd, key2, 0, 0);
        }
        private void DoBGHoldClick()//后台按住
        {
            PostMessage(Hwnd, key1, 0, 0);
        }
        private void DoFGClick()//前台单击
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(key1, X, Y, 0, 0);
            mouse_event(key2, X, Y, 0, 0);
        }
        private void DoFGHoldClick()//前台按住
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(key1, X, Y, 0, 0);
        }
        #endregion
        private void Start()
        {
            //设置鼠标消息
            if (radioBackground.Checked)//工作模式为后台模式
            {
                Hwnd = FindWindow(null, txtboxWindowTitle.Text);
                if (radioRightClick.Checked)//右键单击
                {
                    key1 = WM_RBUTTONDOWN;
                    key2 = WM_RBUTTONUP;
                    doClickFunc = new DoClickFunc(DoBGClick);
                }
                else
                {
                    if (radioLeftClick.Checked)//左键单击
                    {
                        key1 = WM_LBUTTONDOWN;
                        key2 = WM_LBUTTONUP;
                        doClickFunc = new DoClickFunc(DoBGClick);
                    }
                    else
                    {
                        if (radioLeftHold.Checked)//左键按住
                        {
                            key1 = WM_LBUTTONDOWN;
                            key2 = WM_LBUTTONUP;
                            doClickFunc = new DoClickFunc(DoBGHoldClick);
                        }
                        else
                        {
                            if (radioRightHold.Checked)//右键按住
                            {
                                key1 = WM_RBUTTONDOWN;
                                key2 = WM_RBUTTONUP;
                                doClickFunc = new DoClickFunc(DoBGHoldClick);
                            }
                        }
                    }
                }
            }
            else//工作模式为一般模式
            {
                if (radioRightClick.Checked)//右键单击
                {
                    key1 = MOUSEEVENTF_RIGHTDOWN;
                    key2 = MOUSEEVENTF_RIGHTUP;
                    doClickFunc = new DoClickFunc(DoFGClick);
                }
                else
                {
                    if (radioLeftClick.Checked)//左键单击
                    {
                        key1 = MOUSEEVENTF_LEFTDOWN;
                        key2 = MOUSEEVENTF_LEFTUP;
                        doClickFunc = new DoClickFunc(DoFGClick);
                    }
                    else
                    {
                        if (radioLeftHold.Checked)//左键按住
                        {
                            key1 = MOUSEEVENTF_LEFTDOWN;
                            key2 = MOUSEEVENTF_LEFTUP;
                            doClickFunc = new DoClickFunc(DoFGHoldClick);
                        }
                        else
                        {
                            if (radioRightHold.Checked)//右键按住
                            {
                                key1 = MOUSEEVENTF_RIGHTDOWN;
                                key2 = MOUSEEVENTF_RIGHTUP;
                                doClickFunc = new DoClickFunc(DoFGHoldClick);
                            }
                        }
                    }
                }
            }
            if (radioFixedInterval.Checked)//若为固定频率模式
            {
                Thread thread = new Thread(FixedIntervalClickThread);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                if (radioRandomInterval.Checked)//若为随机频率模式
                {
                    if (numericInterval.Value > numericRandomUpperLimit.Value)
                    {
                        MessageBox.Show("随机区间的下限必须小于上限", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Thread thread = new Thread(RandomIntervalClickThread);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            if (chkboxEnableAutoStop.Checked & radioStopAfterAPeriodOfTime.Checked)//若启用了一段时间后自动停止
            {
                timerStopAfterAPeriodOfTime.Interval = (int)numericAutoStopTimePeriod.Value * 1000;
                timerStopAfterAPeriodOfTime.Start();
            }
            ShowNotify("鼠标连点开始运行");
            runningStatus = true;
            ChangeConfigFieldAvailability(false);
        }
        private void Stop()
        {
            currentThreadID = 0;//使所有先前的线程在下一个连点循环时自动终止
            timerStopAfterAPeriodOfTime.Stop();//停止计时
            //发出一次抬起按键的消息，确保停止连点后按键均为抬起状态
            if (radioBackground.Checked)
            {
                
                PostMessage(Hwnd, key2, 0, 0);
            }
            else
            {
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;
                mouse_event(key2, X, Y, 0, 0);
            }
            ShowNotify("鼠标连点停止运行");
            runningStatus = false;
            ChangeConfigFieldAvailability(true);
        }
        /// <summary>
        /// 随机频率模式的连点线程
        /// </summary>
        private void RandomIntervalClickThread()
        {
            //分配新的线程ID
            threadIDAccumulator++;
            currentThreadID = threadIDAccumulator;
            int thisThreadID = currentThreadID;
            Debug.WriteLine("thisThreadID:" + thisThreadID);
            int minInterval = (int)(numericInterval.Value * 1000);
            int maxInterval = (int)(numericRandomUpperLimit.Value * 1000);
            Random random = new Random();
            if (chkboxEnableAutoStop.Checked & radioStopAfterSeveralTimesOfClick.Checked)//如果启用了n次点击后自动停止
            {
                int clickCount = 0;
                int autoStopClickTimes = (int)numericAutoStopClickTimes.Value;
                //连点循环体-首
                while ((currentThreadID == thisThreadID) & (clickCount < autoStopClickTimes))
                {
                    int interval = random.Next(minInterval, maxInterval);
                    Debug.WriteLine("interval:" + interval);
                    doClickFunc();
                    clickCount++;
                    Thread.Sleep(interval);
                }
                //连点循环体-尾
                if (clickCount == autoStopClickTimes)//仅当线程是由于点击数量达标时，自动Stop
                {
                    MethodInvoker methodInvoker = new MethodInvoker(Stop);//跨线程访问UI控件
                    this.Invoke(methodInvoker);
                }
            }
            else
            {
                //连点循环体-首
                while (currentThreadID == thisThreadID)
                {
                    int interval = random.Next(minInterval, maxInterval);
                    Debug.WriteLine("interval:" + interval);
                    doClickFunc();
                    Thread.Sleep(interval);
                }
                //连点循环体-尾
            }
        }
        /// <summary>
        /// 固定频率模式的连点线程
        /// </summary>
        private void FixedIntervalClickThread()
        {
            threadIDAccumulator++;
            currentThreadID = threadIDAccumulator;
            int thisThreadID = currentThreadID;
            Debug.WriteLine("thisThreadID:" + thisThreadID);
            int interval = (int)(numericInterval.Value * 1000);
            if(chkboxEnableAutoStop.Checked & radioStopAfterSeveralTimesOfClick.Checked)//如果启用了n次点击后自动停止
            {
                int clickCount = 0;
                int autoStopClickTimes = (int)numericAutoStopClickTimes.Value;
                while ((currentThreadID == thisThreadID) & (clickCount < autoStopClickTimes))
                {
                    doClickFunc();
                    clickCount++;
                    Thread.Sleep(interval);
                }
                if (clickCount == autoStopClickTimes)
                {
                    MethodInvoker methodInvoker = new MethodInvoker(Stop);//跨线程访问UI控件
                    this.Invoke(methodInvoker);
                }
            }
            else
            {
                while (currentThreadID == thisThreadID)
                {
                    doClickFunc();
                    Thread.Sleep(interval);
                }
            }
        }
        /// <summary>
        /// 全局热键处理
        /// </summary>
        /// <param name="m">消息</param>
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                switch (m.WParam.ToInt32())
                {
                    case 100:
                        if (runningStatus)
                        {
                            Stop();
                        }
                        else
                        {
                            Start();
                        }

                        break;
                    case 101:
                        IntPtr FGHwnd = GetForegroundWindow();
                        int length = GetWindowTextLength(FGHwnd);
                        StringBuilder windowTitle = new StringBuilder(length + 1);
                        GetWindowText(FGHwnd, windowTitle, windowTitle.Capacity);
                        txtboxWindowTitle.Text = windowTitle.ToString();
                        Hotkey.UnregisterHotKey(Handle, 101);
                        btnCaptureWindowTitle.Text = "捕获窗口标题";
                        break;
                }
            }
            base.WndProc(ref m);
        }
        #region 程序设置相关
        /// <summary>
        /// 若配置项存在则直接更新，若不存在则创建
        /// </summary>
        /// <param name="key">配置项名称</param>
        /// <param name="value">值</param>
        private void UpdateConfigItem(string key,string value)
        {
            if (configuration.AppSettings.Settings[key] == null)
            {
                configuration.AppSettings.Settings.Add(key, value);
            }
            else
            {
                configuration.AppSettings.Settings[key].Value = value;
            }
        }
        private void SaveConfig()
        {
            
            //运行模式
            if (radioNormal.Checked)
            {
                UpdateConfigItem("WorkMode", "Normal");
            }
            else
            {
                if (radioBackground.Checked)
                {
                    UpdateConfigItem("WorkMode", "Background");
                }
            }
            //窗口标题
            UpdateConfigItem("WindowTitle", txtboxWindowTitle.Text);
            //点击方式
            if (radioRightClick.Checked)
            {
                UpdateConfigItem("ClickMode", "RightClick");
            }
            else
            {
                if (radioLeftClick.Checked)
                {
                    UpdateConfigItem("ClickMode", "LeftClick");
                }
                else
                {
                    if (radioLeftHold.Checked)
                    {
                        UpdateConfigItem("ClickMode", "LeftHold");
                    }
                    else
                    {
                        if (radioRightHold.Checked)
                        {
                            UpdateConfigItem("ClickMode", "RightHold");
                        }
                    }
                }
            }
            //频率类型
            if (radioFixedInterval.Checked)
            {
                UpdateConfigItem("IntervalMode", "Fixed");
            }
            else
            {
                if (radioRandomInterval.Checked)
                {
                    UpdateConfigItem("IntervalMode", "Random");
                }
            }
            //频率值
            UpdateConfigItem("Interval", numericInterval.Value.ToString());
            UpdateConfigItem("IntervalRandomUpperLimit", numericRandomUpperLimit.Value.ToString());
            //自动停止
            UpdateConfigItem("AutoStopEnabled", chkboxEnableAutoStop.Checked ? "true" : "false");
            if (radioStopAfterAPeriodOfTime.Checked)
            {
                UpdateConfigItem("AutoStopMode", "TimePeriod");
            }
            else
            {
                if (radioStopAfterSeveralTimesOfClick.Checked)
                {
                    UpdateConfigItem("AutoStopMode", "ClickTimes");
                }
            }
            UpdateConfigItem("AutoStopTimePeriod", numericAutoStopTimePeriod.Value.ToString());
            UpdateConfigItem("AutoStopClickTimes", numericAutoStopClickTimes.Value.ToString());
            //设置
            UpdateConfigItem("Hotkey", comboboxHotkey.SelectedIndex.ToString());
            UpdateConfigItem("NotifyEnabled", chkboxEnableNotify.Checked ? "true" : "false");

            configuration.Save();
        }
        private void ReadConfig()
        {
            var settings = configuration.AppSettings.Settings;
            if (settings["WorkMode"] != null)
            {
                switch (settings["WorkMode"].Value)
                {
                    case "Normal":
                        radioNormal.Checked = true;
                        break;
                    case "Background":
                        radioBackground.Checked = true;
                        break;
                }

            }

            if (settings["WindowTitle"] != null)
            {
                txtboxWindowTitle.Text = settings["WindowTitle"].Value;

            }

            if (settings["ClickMode"] != null)
            {
                switch (settings["ClickMode"].Value)
                {
                    case "RightClick":
                        radioRightClick.Checked = true;
                        break;
                    case "LeftClick":
                        radioLeftClick.Checked = true;
                        break;
                    case "RightHold":
                        radioRightHold.Checked = true;
                        break;
                    case "LeftHold":
                        radioLeftHold.Checked = true;
                        break;
                }

            }

            if (settings["IntervalMode"] != null)
            {
                switch (settings["IntervalMode"].Value)
                {
                    case "Fixed":
                        radioFixedInterval.Checked = true;
                        break;
                    case "Random":
                        radioRandomInterval.Checked = true;
                        break;
                }

            }
            else
            {
                radioFixedInterval.Checked = true;
            }

            if (settings["Interval"] != null)
            {
                numericInterval.Value = decimal.Parse(settings["Interval"].Value);
            }
            if (settings["IntervalRandomUpperLimit"] != null)
            {
                numericRandomUpperLimit.Value = decimal.Parse(settings["IntervalRandomUpperLimit"].Value);
            }

            if (settings["AutoStopEnabled"] != null)
            {
                chkboxEnableAutoStop.Checked = settings["AutoStopEnabled"].Value == "true" ? true : false;
            }
            else
            {
                chkboxEnableAutoStop.Checked = false;
            }
            if (settings["AutoStopMode"] != null)
            {
                switch (settings["AutoStopMode"].Value)
                {
                    case "TimePeriod":
                        radioStopAfterAPeriodOfTime.Checked = true;
                        break;
                    case "ClickTimes":
                        radioStopAfterSeveralTimesOfClick.Checked = true;
                        break;
                }

            }
            if (settings["AutoStopTimePeriod"] != null)
            {
                numericAutoStopTimePeriod.Value = int.Parse(settings["AutoStopTimePeriod"].Value);
            }
            if (settings["AutoStopClickTimes"] != null)
            {
                numericAutoStopClickTimes.Value = int.Parse(settings["AutoStopClickTimes"].Value);
            }

            if (settings["Hotkey"] != null)
            {
                comboboxHotkey.SelectedIndex = int.Parse(settings["Hotkey"].Value);
            }
            else
            {
                comboboxHotkey.SelectedIndex = 7;//默认热键是F8
            }

            if (settings["NotifyEnabled"] != null)
            {
                chkboxEnableNotify.Checked = settings["NotifyEnabled"].Value == "true" ? true : false;
            }
        }

        #endregion
        #region 界面控件关联逻辑
        private void ChangeConfigFieldAvailability(Boolean enabled)
        {
            if (enabled)
            {
                groupboxWorkMode.Enabled = true;
                groupboxClickMode.Enabled = true;
                groupboxAutoStop.Enabled = true;
                groupboxInterval.Enabled = true;
                groupboxSettings.Enabled = true;
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                runningStatus = false;
            }
            else
            {
                groupboxWorkMode.Enabled = false;
                groupboxClickMode.Enabled = false;
                groupboxAutoStop.Enabled = false;
                groupboxInterval.Enabled = false;
                groupboxSettings.Enabled = false;
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                runningStatus = true;
            }
        }
        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            WorkModeChanged();
        }
        private void radioBackground_CheckedChanged(object sender, EventArgs e)
        {
            WorkModeChanged();
        }
        private void WorkModeChanged()
        {
            if (radioNormal.Checked)
            {
                txtboxWindowTitle.Enabled = false;
                btnCaptureWindowTitle.Enabled = false;
            }
            else
            {
                txtboxWindowTitle.Enabled = true;
                btnCaptureWindowTitle.Enabled = true;
            }
        }
        private void radioLeftClick_CheckedChanged(object sender, EventArgs e)
        {
            ClickModeChanged();
        }

        private void radioRightClick_CheckedChanged(object sender, EventArgs e)
        {
            ClickModeChanged();
        }

        private void radioLeftHold_CheckedChanged(object sender, EventArgs e)
        {
            ClickModeChanged();
        }

        private void radioRightHold_CheckedChanged(object sender, EventArgs e)
        {
            ClickModeChanged();
        }
        private void ClickModeChanged()
        {
            if(radioLeftHold.Checked | radioRightHold.Checked)
            {
                if (chkboxEnableAutoStop.Checked)
                {
                    radioStopAfterAPeriodOfTime.Checked = true;
                    radioStopAfterSeveralTimesOfClick.Enabled = false;
                }
            }
            else
            {
                if (chkboxEnableAutoStop.Checked)
                {
                    radioStopAfterSeveralTimesOfClick.Enabled = true;
                }
                    
            }
            
        }
        private void radioFixedInterval_CheckedChanged(object sender, EventArgs e)
        {
            IntervalModeChanged();
        }
        private void radioRandomInterval_CheckedChanged(object sender, EventArgs e)
        {
            IntervalModeChanged();
        }
        private void IntervalModeChanged()
        {
            if (radioFixedInterval.Checked)
            {
                numericRandomUpperLimit.Enabled = false;
            }
            else
            {
                numericRandomUpperLimit.Enabled = true;
            }
        }
        private void chkboxEnableAutoStop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxEnableAutoStop.Checked)
            {
                radioStopAfterAPeriodOfTime.Enabled = true;
                radioStopAfterSeveralTimesOfClick.Enabled = true;
                numericAutoStopClickTimes.Enabled = true;
                numericAutoStopTimePeriod.Enabled = true;
            }
            else
            {
                radioStopAfterAPeriodOfTime.Enabled = false;
                radioStopAfterSeveralTimesOfClick.Enabled = false;
                numericAutoStopClickTimes.Enabled = false;
                numericAutoStopTimePeriod.Enabled = false;

            }
            ClickModeChanged();
        }
        #endregion
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出前卸载热键
            Hotkey.UnregisterHotKey(Handle, 100);
            Hotkey.UnregisterHotKey(Handle, 101);
            //保存设置
            SaveConfig();
            if (currentThreadID != 0)
            {
                Stop();
            }
        }


        private void formMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                this.Hide();   //隐藏窗体
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void btnCaptureWindowTitle_Click(object sender, EventArgs e)
        {
            Hotkey.UnregisterHotKey(Handle, 101);
            if (Hotkey.RegisterHotKey(Handle, 101, Hotkey.KeyModifiers.Shift, 113))
            {
                btnCaptureWindowTitle.Text = "请转到对应的窗口按下Shift+F2...";
            }
            else
            {
                MessageBox.Show("热键注册失败，请尝试关闭热键冲突的程序或手动输入窗口标题", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboboxHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotkey.UnregisterHotKey(Handle, 100);
            int key = comboboxHotkey.SelectedIndex + 112;
            if(!Hotkey.RegisterHotKey(Handle, 100, Hotkey.KeyModifiers.None, key))
            {
                MessageBox.Show("热键注册失败，请尝试关闭热键冲突的程序或更改热键", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxHotkey.SelectedIndex = -1;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();
            formAbout.Show();
        }

        private void menuitemShowMainForm_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerStopAfterAPeriodOfTime_Tick(object sender, EventArgs e)
        {
            Stop();
            
        }


    }
}
