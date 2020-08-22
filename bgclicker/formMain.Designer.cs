namespace bgclicker
{
    partial class formMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.txtboxWindowTitle = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupboxWorkMode = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaptureWindowTitle = new System.Windows.Forms.Button();
            this.radioBackground = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.groupboxClickMode = new System.Windows.Forms.GroupBox();
            this.radioRightHold = new System.Windows.Forms.RadioButton();
            this.radioRightClick = new System.Windows.Forms.RadioButton();
            this.radioLeftHold = new System.Windows.Forms.RadioButton();
            this.radioLeftClick = new System.Windows.Forms.RadioButton();
            this.comboboxHotkey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitemShowMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxInterval = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioRandomInterval = new System.Windows.Forms.RadioButton();
            this.radioFixedInterval = new System.Windows.Forms.RadioButton();
            this.numericRandomUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.groupboxSettings = new System.Windows.Forms.GroupBox();
            this.chkboxEnableNotify = new System.Windows.Forms.CheckBox();
            this.groupboxAutoStop = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioStopAfterSeveralTimesOfClick = new System.Windows.Forms.RadioButton();
            this.radioStopAfterAPeriodOfTime = new System.Windows.Forms.RadioButton();
            this.chkboxEnableAutoStop = new System.Windows.Forms.CheckBox();
            this.numericAutoStopClickTimes = new System.Windows.Forms.NumericUpDown();
            this.numericAutoStopTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.timerStopAfterAPeriodOfTime = new System.Windows.Forms.Timer(this.components);
            this.groupboxWorkMode.SuspendLayout();
            this.groupboxClickMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.groupboxInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomUpperLimit)).BeginInit();
            this.groupboxSettings.SuspendLayout();
            this.groupboxAutoStop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoStopClickTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoStopTimePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxWindowTitle
            // 
            this.txtboxWindowTitle.Location = new System.Drawing.Point(82, 64);
            this.txtboxWindowTitle.Name = "txtboxWindowTitle";
            this.txtboxWindowTitle.Size = new System.Drawing.Size(139, 21);
            this.txtboxWindowTitle.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 482);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupboxWorkMode
            // 
            this.groupboxWorkMode.Controls.Add(this.label1);
            this.groupboxWorkMode.Controls.Add(this.btnCaptureWindowTitle);
            this.groupboxWorkMode.Controls.Add(this.radioBackground);
            this.groupboxWorkMode.Controls.Add(this.radioNormal);
            this.groupboxWorkMode.Controls.Add(this.txtboxWindowTitle);
            this.groupboxWorkMode.Location = new System.Drawing.Point(12, 12);
            this.groupboxWorkMode.Name = "groupboxWorkMode";
            this.groupboxWorkMode.Size = new System.Drawing.Size(237, 125);
            this.groupboxWorkMode.TabIndex = 2;
            this.groupboxWorkMode.TabStop = false;
            this.groupboxWorkMode.Text = "工作模式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "窗口标题";
            // 
            // btnCaptureWindowTitle
            // 
            this.btnCaptureWindowTitle.Location = new System.Drawing.Point(18, 91);
            this.btnCaptureWindowTitle.Name = "btnCaptureWindowTitle";
            this.btnCaptureWindowTitle.Size = new System.Drawing.Size(205, 23);
            this.btnCaptureWindowTitle.TabIndex = 4;
            this.btnCaptureWindowTitle.Text = "捕获窗口标题";
            this.btnCaptureWindowTitle.UseVisualStyleBackColor = true;
            this.btnCaptureWindowTitle.Click += new System.EventHandler(this.btnCaptureWindowTitle_Click);
            // 
            // radioBackground
            // 
            this.radioBackground.AutoSize = true;
            this.radioBackground.Checked = true;
            this.radioBackground.Location = new System.Drawing.Point(17, 42);
            this.radioBackground.Name = "radioBackground";
            this.radioBackground.Size = new System.Drawing.Size(71, 16);
            this.radioBackground.TabIndex = 2;
            this.radioBackground.TabStop = true;
            this.radioBackground.Text = "后台模式";
            this.radioBackground.UseVisualStyleBackColor = true;
            this.radioBackground.CheckedChanged += new System.EventHandler(this.radioBackground_CheckedChanged);
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Location = new System.Drawing.Point(17, 20);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(71, 16);
            this.radioNormal.TabIndex = 1;
            this.radioNormal.Text = "一般模式";
            this.radioNormal.UseVisualStyleBackColor = true;
            this.radioNormal.CheckedChanged += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // groupboxClickMode
            // 
            this.groupboxClickMode.Controls.Add(this.radioRightHold);
            this.groupboxClickMode.Controls.Add(this.radioRightClick);
            this.groupboxClickMode.Controls.Add(this.radioLeftHold);
            this.groupboxClickMode.Controls.Add(this.radioLeftClick);
            this.groupboxClickMode.Location = new System.Drawing.Point(12, 143);
            this.groupboxClickMode.Name = "groupboxClickMode";
            this.groupboxClickMode.Size = new System.Drawing.Size(237, 74);
            this.groupboxClickMode.TabIndex = 3;
            this.groupboxClickMode.TabStop = false;
            this.groupboxClickMode.Text = "点击方式";
            // 
            // radioRightHold
            // 
            this.radioRightHold.AutoSize = true;
            this.radioRightHold.Location = new System.Drawing.Point(116, 46);
            this.radioRightHold.Name = "radioRightHold";
            this.radioRightHold.Size = new System.Drawing.Size(71, 16);
            this.radioRightHold.TabIndex = 3;
            this.radioRightHold.Text = "右键按住";
            this.radioRightHold.UseVisualStyleBackColor = true;
            this.radioRightHold.CheckedChanged += new System.EventHandler(this.radioRightHold_CheckedChanged);
            // 
            // radioRightClick
            // 
            this.radioRightClick.AutoSize = true;
            this.radioRightClick.Checked = true;
            this.radioRightClick.Location = new System.Drawing.Point(116, 24);
            this.radioRightClick.Name = "radioRightClick";
            this.radioRightClick.Size = new System.Drawing.Size(71, 16);
            this.radioRightClick.TabIndex = 2;
            this.radioRightClick.TabStop = true;
            this.radioRightClick.Text = "右键单击";
            this.radioRightClick.UseVisualStyleBackColor = true;
            this.radioRightClick.CheckedChanged += new System.EventHandler(this.radioRightClick_CheckedChanged);
            // 
            // radioLeftHold
            // 
            this.radioLeftHold.AutoSize = true;
            this.radioLeftHold.Location = new System.Drawing.Point(17, 46);
            this.radioLeftHold.Name = "radioLeftHold";
            this.radioLeftHold.Size = new System.Drawing.Size(71, 16);
            this.radioLeftHold.TabIndex = 1;
            this.radioLeftHold.Text = "左键按住";
            this.radioLeftHold.UseVisualStyleBackColor = true;
            this.radioLeftHold.CheckedChanged += new System.EventHandler(this.radioLeftHold_CheckedChanged);
            // 
            // radioLeftClick
            // 
            this.radioLeftClick.AutoSize = true;
            this.radioLeftClick.Location = new System.Drawing.Point(17, 24);
            this.radioLeftClick.Name = "radioLeftClick";
            this.radioLeftClick.Size = new System.Drawing.Size(71, 16);
            this.radioLeftClick.TabIndex = 0;
            this.radioLeftClick.Text = "左键单击";
            this.radioLeftClick.UseVisualStyleBackColor = true;
            this.radioLeftClick.CheckedChanged += new System.EventHandler(this.radioLeftClick_CheckedChanged);
            // 
            // comboboxHotkey
            // 
            this.comboboxHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxHotkey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboboxHotkey.Location = new System.Drawing.Point(51, 22);
            this.comboboxHotkey.MaxDropDownItems = 12;
            this.comboboxHotkey.Name = "comboboxHotkey";
            this.comboboxHotkey.Size = new System.Drawing.Size(42, 20);
            this.comboboxHotkey.TabIndex = 7;
            this.comboboxHotkey.SelectedIndexChanged += new System.EventHandler(this.comboboxHotkey_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "热键";
            // 
            // numericInterval
            // 
            this.numericInterval.DecimalPlaces = 3;
            this.numericInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericInterval.Location = new System.Drawing.Point(17, 49);
            this.numericInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(76, 21);
            this.numericInterval.TabIndex = 5;
            this.numericInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(94, 482);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(175, 482);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FLY BGClicker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemShowMainForm,
            this.menuitemExit});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(88, 48);
            // 
            // menuitemShowMainForm
            // 
            this.menuitemShowMainForm.Name = "menuitemShowMainForm";
            this.menuitemShowMainForm.Size = new System.Drawing.Size(87, 22);
            this.menuitemShowMainForm.Text = "主界面";
            this.menuitemShowMainForm.Click += new System.EventHandler(this.menuitemShowMainForm_Click);
            // 
            // menuitemExit
            // 
            this.menuitemExit.Name = "menuitemExit";
            this.menuitemExit.Size = new System.Drawing.Size(87, 22);
            this.menuitemExit.Text = "退出";
            this.menuitemExit.Click += new System.EventHandler(this.menuitemExit_Click);
            // 
            // groupboxInterval
            // 
            this.groupboxInterval.Controls.Add(this.label4);
            this.groupboxInterval.Controls.Add(this.label2);
            this.groupboxInterval.Controls.Add(this.radioRandomInterval);
            this.groupboxInterval.Controls.Add(this.radioFixedInterval);
            this.groupboxInterval.Controls.Add(this.numericRandomUpperLimit);
            this.groupboxInterval.Controls.Add(this.numericInterval);
            this.groupboxInterval.Location = new System.Drawing.Point(12, 223);
            this.groupboxInterval.Name = "groupboxInterval";
            this.groupboxInterval.Size = new System.Drawing.Size(237, 83);
            this.groupboxInterval.TabIndex = 6;
            this.groupboxInterval.TabStop = false;
            this.groupboxInterval.Text = "点击频率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // radioRandomInterval
            // 
            this.radioRandomInterval.AutoSize = true;
            this.radioRandomInterval.Checked = true;
            this.radioRandomInterval.Location = new System.Drawing.Point(116, 24);
            this.radioRandomInterval.Name = "radioRandomInterval";
            this.radioRandomInterval.Size = new System.Drawing.Size(71, 16);
            this.radioRandomInterval.TabIndex = 0;
            this.radioRandomInterval.TabStop = true;
            this.radioRandomInterval.Text = "区间随机";
            this.radioRandomInterval.UseVisualStyleBackColor = true;
            this.radioRandomInterval.CheckedChanged += new System.EventHandler(this.radioRandomInterval_CheckedChanged);
            // 
            // radioFixedInterval
            // 
            this.radioFixedInterval.AutoSize = true;
            this.radioFixedInterval.Location = new System.Drawing.Point(17, 24);
            this.radioFixedInterval.Name = "radioFixedInterval";
            this.radioFixedInterval.Size = new System.Drawing.Size(59, 16);
            this.radioFixedInterval.TabIndex = 0;
            this.radioFixedInterval.Text = "固定值";
            this.radioFixedInterval.UseVisualStyleBackColor = true;
            this.radioFixedInterval.CheckedChanged += new System.EventHandler(this.radioFixedInterval_CheckedChanged);
            // 
            // numericRandomUpperLimit
            // 
            this.numericRandomUpperLimit.DecimalPlaces = 3;
            this.numericRandomUpperLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericRandomUpperLimit.Location = new System.Drawing.Point(116, 49);
            this.numericRandomUpperLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericRandomUpperLimit.Name = "numericRandomUpperLimit";
            this.numericRandomUpperLimit.Size = new System.Drawing.Size(76, 21);
            this.numericRandomUpperLimit.TabIndex = 5;
            this.numericRandomUpperLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericRandomUpperLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // groupboxSettings
            // 
            this.groupboxSettings.Controls.Add(this.chkboxEnableNotify);
            this.groupboxSettings.Controls.Add(this.comboboxHotkey);
            this.groupboxSettings.Controls.Add(this.label3);
            this.groupboxSettings.Location = new System.Drawing.Point(12, 419);
            this.groupboxSettings.Name = "groupboxSettings";
            this.groupboxSettings.Size = new System.Drawing.Size(237, 56);
            this.groupboxSettings.TabIndex = 7;
            this.groupboxSettings.TabStop = false;
            this.groupboxSettings.Text = "设置";
            // 
            // chkboxEnableNotify
            // 
            this.chkboxEnableNotify.AutoSize = true;
            this.chkboxEnableNotify.Checked = true;
            this.chkboxEnableNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxEnableNotify.Location = new System.Drawing.Point(103, 24);
            this.chkboxEnableNotify.Name = "chkboxEnableNotify";
            this.chkboxEnableNotify.Size = new System.Drawing.Size(120, 16);
            this.chkboxEnableNotify.TabIndex = 8;
            this.chkboxEnableNotify.Text = "启用托盘消息提示";
            this.chkboxEnableNotify.UseVisualStyleBackColor = true;
            // 
            // groupboxAutoStop
            // 
            this.groupboxAutoStop.Controls.Add(this.label6);
            this.groupboxAutoStop.Controls.Add(this.label5);
            this.groupboxAutoStop.Controls.Add(this.radioStopAfterSeveralTimesOfClick);
            this.groupboxAutoStop.Controls.Add(this.radioStopAfterAPeriodOfTime);
            this.groupboxAutoStop.Controls.Add(this.chkboxEnableAutoStop);
            this.groupboxAutoStop.Controls.Add(this.numericAutoStopClickTimes);
            this.groupboxAutoStop.Controls.Add(this.numericAutoStopTimePeriod);
            this.groupboxAutoStop.Location = new System.Drawing.Point(12, 312);
            this.groupboxAutoStop.Name = "groupboxAutoStop";
            this.groupboxAutoStop.Size = new System.Drawing.Size(237, 101);
            this.groupboxAutoStop.TabIndex = 8;
            this.groupboxAutoStop.TabStop = false;
            this.groupboxAutoStop.Text = "自动停止";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "秒";
            // 
            // radioStopAfterSeveralTimesOfClick
            // 
            this.radioStopAfterSeveralTimesOfClick.AutoSize = true;
            this.radioStopAfterSeveralTimesOfClick.Location = new System.Drawing.Point(30, 69);
            this.radioStopAfterSeveralTimesOfClick.Name = "radioStopAfterSeveralTimesOfClick";
            this.radioStopAfterSeveralTimesOfClick.Size = new System.Drawing.Size(107, 16);
            this.radioStopAfterSeveralTimesOfClick.TabIndex = 1;
            this.radioStopAfterSeveralTimesOfClick.Text = "点击一定次数后";
            this.radioStopAfterSeveralTimesOfClick.UseVisualStyleBackColor = true;
            // 
            // radioStopAfterAPeriodOfTime
            // 
            this.radioStopAfterAPeriodOfTime.AutoSize = true;
            this.radioStopAfterAPeriodOfTime.Checked = true;
            this.radioStopAfterAPeriodOfTime.Location = new System.Drawing.Point(30, 44);
            this.radioStopAfterAPeriodOfTime.Name = "radioStopAfterAPeriodOfTime";
            this.radioStopAfterAPeriodOfTime.Size = new System.Drawing.Size(107, 16);
            this.radioStopAfterAPeriodOfTime.TabIndex = 1;
            this.radioStopAfterAPeriodOfTime.TabStop = true;
            this.radioStopAfterAPeriodOfTime.Text = "运行一段时间后";
            this.radioStopAfterAPeriodOfTime.UseVisualStyleBackColor = true;
            // 
            // chkboxEnableAutoStop
            // 
            this.chkboxEnableAutoStop.AutoSize = true;
            this.chkboxEnableAutoStop.Checked = true;
            this.chkboxEnableAutoStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxEnableAutoStop.Location = new System.Drawing.Point(17, 21);
            this.chkboxEnableAutoStop.Name = "chkboxEnableAutoStop";
            this.chkboxEnableAutoStop.Size = new System.Drawing.Size(48, 16);
            this.chkboxEnableAutoStop.TabIndex = 0;
            this.chkboxEnableAutoStop.Text = "启用";
            this.chkboxEnableAutoStop.UseVisualStyleBackColor = true;
            this.chkboxEnableAutoStop.CheckedChanged += new System.EventHandler(this.chkboxEnableAutoStop_CheckedChanged);
            // 
            // numericAutoStopClickTimes
            // 
            this.numericAutoStopClickTimes.Location = new System.Drawing.Point(142, 67);
            this.numericAutoStopClickTimes.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericAutoStopClickTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAutoStopClickTimes.Name = "numericAutoStopClickTimes";
            this.numericAutoStopClickTimes.Size = new System.Drawing.Size(63, 21);
            this.numericAutoStopClickTimes.TabIndex = 5;
            this.numericAutoStopClickTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericAutoStopClickTimes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericAutoStopTimePeriod
            // 
            this.numericAutoStopTimePeriod.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericAutoStopTimePeriod.Location = new System.Drawing.Point(142, 42);
            this.numericAutoStopTimePeriod.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericAutoStopTimePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAutoStopTimePeriod.Name = "numericAutoStopTimePeriod";
            this.numericAutoStopTimePeriod.Size = new System.Drawing.Size(63, 21);
            this.numericAutoStopTimePeriod.TabIndex = 5;
            this.numericAutoStopTimePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericAutoStopTimePeriod.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // timerStopAfterAPeriodOfTime
            // 
            this.timerStopAfterAPeriodOfTime.Tick += new System.EventHandler(this.timerStopAfterAPeriodOfTime_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 517);
            this.Controls.Add(this.groupboxAutoStop);
            this.Controls.Add(this.groupboxSettings);
            this.Controls.Add(this.groupboxInterval);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupboxClickMode);
            this.Controls.Add(this.groupboxWorkMode);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "FLY BGClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.SizeChanged += new System.EventHandler(this.formMain_SizeChanged);
            this.groupboxWorkMode.ResumeLayout(false);
            this.groupboxWorkMode.PerformLayout();
            this.groupboxClickMode.ResumeLayout(false);
            this.groupboxClickMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupboxInterval.ResumeLayout(false);
            this.groupboxInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomUpperLimit)).EndInit();
            this.groupboxSettings.ResumeLayout(false);
            this.groupboxSettings.PerformLayout();
            this.groupboxAutoStop.ResumeLayout(false);
            this.groupboxAutoStop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoStopClickTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoStopTimePeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxWindowTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupboxWorkMode;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.Button btnCaptureWindowTitle;
        private System.Windows.Forms.RadioButton radioBackground;
        private System.Windows.Forms.GroupBox groupboxClickMode;
        private System.Windows.Forms.RadioButton radioLeftHold;
        private System.Windows.Forms.RadioButton radioLeftClick;
        private System.Windows.Forms.ComboBox comboboxHotkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.RadioButton radioRightHold;
        private System.Windows.Forms.RadioButton radioRightClick;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuitemShowMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuitemExit;
        private System.Windows.Forms.GroupBox groupboxInterval;
        private System.Windows.Forms.RadioButton radioFixedInterval;
        private System.Windows.Forms.RadioButton radioRandomInterval;
        private System.Windows.Forms.GroupBox groupboxSettings;
        private System.Windows.Forms.NumericUpDown numericRandomUpperLimit;
        private System.Windows.Forms.CheckBox chkboxEnableNotify;
        private System.Windows.Forms.GroupBox groupboxAutoStop;
        private System.Windows.Forms.RadioButton radioStopAfterSeveralTimesOfClick;
        private System.Windows.Forms.RadioButton radioStopAfterAPeriodOfTime;
        private System.Windows.Forms.CheckBox chkboxEnableAutoStop;
        private System.Windows.Forms.NumericUpDown numericAutoStopClickTimes;
        private System.Windows.Forms.NumericUpDown numericAutoStopTimePeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerStopAfterAPeriodOfTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

