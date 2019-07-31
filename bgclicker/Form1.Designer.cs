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
            this.txtBoxWindowTitle = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerBGClicker = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioBackground = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioRightHold = new System.Windows.Forms.RadioButton();
            this.radioRightClick = new System.Windows.Forms.RadioButton();
            this.radioLeftHold = new System.Windows.Forms.RadioButton();
            this.radioLeftClick = new System.Windows.Forms.RadioButton();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timerFGClicker = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxWindowTitle
            // 
            this.txtBoxWindowTitle.Location = new System.Drawing.Point(82, 64);
            this.txtBoxWindowTitle.Name = "txtBoxWindowTitle";
            this.txtBoxWindowTitle.Size = new System.Drawing.Size(139, 21);
            this.txtBoxWindowTitle.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 255);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerBGClicker
            // 
            this.timerBGClicker.Interval = 500;
            this.timerBGClicker.Tick += new System.EventHandler(this.timerClicker_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioBackground);
            this.groupBox1.Controls.Add(this.radioNormal);
            this.groupBox1.Controls.Add(this.txtBoxWindowTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作模式";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "捕获窗口标题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericInterval);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioRightHold);
            this.groupBox2.Controls.Add(this.radioRightClick);
            this.groupBox2.Controls.Add(this.radioLeftHold);
            this.groupBox2.Controls.Add(this.radioLeftClick);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "点击方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "秒";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(177, 74);
            this.comboBox1.MaxDropDownItems = 12;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "热键";
            // 
            // numericInterval
            // 
            this.numericInterval.DecimalPlaces = 2;
            this.numericInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericInterval.Location = new System.Drawing.Point(49, 74);
            this.numericInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(63, 21);
            this.numericInterval.TabIndex = 5;
            this.numericInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "频率";
            // 
            // radioRightHold
            // 
            this.radioRightHold.AutoSize = true;
            this.radioRightHold.Location = new System.Drawing.Point(100, 46);
            this.radioRightHold.Name = "radioRightHold";
            this.radioRightHold.Size = new System.Drawing.Size(71, 16);
            this.radioRightHold.TabIndex = 3;
            this.radioRightHold.Text = "右键按住";
            this.radioRightHold.UseVisualStyleBackColor = true;
            // 
            // radioRightClick
            // 
            this.radioRightClick.AutoSize = true;
            this.radioRightClick.Checked = true;
            this.radioRightClick.Location = new System.Drawing.Point(100, 24);
            this.radioRightClick.Name = "radioRightClick";
            this.radioRightClick.Size = new System.Drawing.Size(71, 16);
            this.radioRightClick.TabIndex = 2;
            this.radioRightClick.TabStop = true;
            this.radioRightClick.Text = "右键单击";
            this.radioRightClick.UseVisualStyleBackColor = true;
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
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 255);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "关于";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timerFGClicker
            // 
            this.timerFGClicker.Tick += new System.EventHandler(this.timerFGClicker_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FLY BGClicker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(88, 48);
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 288);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "FLY BGClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.SizeChanged += new System.EventHandler(this.formMain_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxWindowTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerBGClicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioBackground;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioLeftHold;
        private System.Windows.Forms.RadioButton radioLeftClick;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioRightHold;
        private System.Windows.Forms.RadioButton radioRightClick;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerFGClicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

