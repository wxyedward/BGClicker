using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace bgclicker
{
    public partial class formMain : Form
    {
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_RBUTTONUP = 0x0205;
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public IntPtr Hwnd;//窗口句柄
        public Boolean runningStatus;//连点运行状态
        public int key1;//连点循环中按键按下的消息
        public int key2;//连点循环中按键抬起的消息
        public Boolean buttonHold;//连点循环中是否要发出抬起的消息
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
            comboBox1.SelectedIndex = 7;//默认热键是F8
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (radioBackground.Checked)//工作模式为后台模式
            {
                Hwnd = FindWindow(null, txtBoxWindowTitle.Text);
                timerBGClicker.Interval = (int)(numericInterval.Value * 1000);
                if (radioRightClick.Checked)//右键单击
                {
                    key1 = WM_RBUTTONDOWN;
                    key2 = WM_RBUTTONUP;
                    buttonHold = false;
                }
                else
                {
                    if (radioLeftClick.Checked)//左键单击
                    {
                        key1 = WM_LBUTTONDOWN;
                        key2 = WM_LBUTTONUP;
                        buttonHold = false;
                    }
                    else
                    {
                        if (radioLeftHold.Checked)//左键按住
                        {
                            key1 = WM_LBUTTONDOWN;
                            key2 = WM_LBUTTONUP;
                            buttonHold = true;
                        }
                        else
                        {
                            if (radioRightHold.Checked)//右键按住
                            {
                                key1 = WM_RBUTTONDOWN;
                                key2 = WM_RBUTTONUP;
                                buttonHold = true;
                            }
                        }
                    }
                }
                timerBGClicker.Start();
                
            }
            else//工作模式为一般模式
            {
                timerFGClicker.Interval = (int)(numericInterval.Value * 1000);
                
                if (radioRightClick.Checked)//右键单击
                {
                    key1 = MOUSEEVENTF_RIGHTDOWN;
                    key2 = MOUSEEVENTF_RIGHTUP;
                    buttonHold = false;
                }
                else
                {
                    if (radioLeftClick.Checked)//左键单击
                    {
                        key1 = MOUSEEVENTF_LEFTDOWN;
                        key2 = MOUSEEVENTF_LEFTUP;
                        buttonHold = false;
                    }
                    else
                    {
                        if (radioLeftHold.Checked)//左键按住
                        {
                            key1 = MOUSEEVENTF_LEFTDOWN;
                            key2 = MOUSEEVENTF_LEFTUP;
                            buttonHold = true;
                        }
                        else
                        {
                            if (radioRightHold.Checked)//右键按住
                            {
                                key1 = MOUSEEVENTF_RIGHTDOWN;
                                key2 = MOUSEEVENTF_RIGHTUP;
                                buttonHold = true;
                            }
                        }
                    }
                }
                timerFGClicker.Start();
            }
            notifyIcon1.ShowBalloonTip(1000, "鼠标连点开始运行", " ", ToolTipIcon.Info);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
            runningStatus = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            
            if (radioBackground.Checked)//工作模式为后台模式
            {
                timerBGClicker.Stop();
                PostMessage(Hwnd, key2, 0, 0);//抬起按键
            }
            else
            {
                timerFGClicker.Stop();
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;
                mouse_event(key2, X, Y, 0, 0);//抬起按键
            }
            notifyIcon1.ShowBalloonTip(1000, "鼠标连点停止运行", " ", ToolTipIcon.Info);
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            runningStatus = false;
        }

        private void timerClicker_Tick(object sender, EventArgs e)//后台模式的Timer
        {
            PostMessage(Hwnd, key1, 0, 0);
            if (!buttonHold)
            {
                PostMessage(Hwnd, key2, 0, 0);
            }
        }

        private void timerFGClicker_Tick(object sender, EventArgs e)//一般模式的Timer
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(key1, X, Y, 0, 0);
            if (!buttonHold)
            {
                mouse_event(key2, X, Y, 0, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)//捕获窗口标题按钮
        {
            Hotkey.UnregisterHotKey(Handle, 101);
            if(Hotkey.RegisterHotKey(Handle, 101, Hotkey.KeyModifiers.Shift, 113))
            {
                button2.Text = "请转到对应的窗口按下Shift+F2...";
            }
            else
            {
                MessageBox.Show("热键注册失败，请尝试关闭热键冲突的程序或手动输入窗口标题", "错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotkey.UnregisterHotKey(Handle, 100);
            int key = comboBox1.SelectedIndex + 112;
            Hotkey.RegisterHotKey(Handle, 100, Hotkey.KeyModifiers.None, key);
        }

        protected override void WndProc(ref Message m)//热键处理
        {
            const int WM_HOTKEY = 0x0312;//热键消息
            if (m.Msg == WM_HOTKEY)
            {
                switch (m.WParam.ToInt32())
                {
                    case 100:
                        if (runningStatus)
                        {
                            buttonStop_Click(null, null);
                        }
                        else
                        {
                            buttonStart_Click(null, null);
                        }

                        break;
                    case 101:
                        IntPtr FGHwnd = GetForegroundWindow();
                        int length = GetWindowTextLength(FGHwnd);
                        StringBuilder windowTitle = new StringBuilder(length + 1);
                        GetWindowText(FGHwnd, windowTitle, windowTitle.Capacity);
                        txtBoxWindowTitle.Text = windowTitle.ToString();
                        Hotkey.UnregisterHotKey(Handle, 101);
                        button2.Text = "捕获";
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)//退出前卸载热键
        {
            Hotkey.UnregisterHotKey(Handle, 100);
            Hotkey.UnregisterHotKey(Handle, 101);
        }



        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            modeChange();
        }
        private void modeChange()
        {
            if (radioNormal.Checked)
            {
                txtBoxWindowTitle.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                txtBoxWindowTitle.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();
            formAbout.Show();
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                this.Hide();   //隐藏窗体
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
