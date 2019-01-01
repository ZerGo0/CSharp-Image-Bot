using System.Windows.Forms;

namespace BotTemplate
{
    partial class DebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DebugImageBox = new System.Windows.Forms.PictureBox();
            this.BotLog = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FarmAdvMan = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.ClickAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClickYCoord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClickXCoord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DWMCapButton = new System.Windows.Forms.Button();
            this.GDICapButton = new System.Windows.Forms.Button();
            this.ScreenCapButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClickSendMSGButton = new System.Windows.Forms.Button();
            this.ClickMouseButton = new System.Windows.Forms.Button();
            this.ClickPostMSGButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CSharpISButton = new System.Windows.Forms.Button();
            this.AutoItISButton = new System.Windows.Forms.Button();
            this.ImagePathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EMGUISButton = new System.Windows.Forms.Button();
            this.ControlNameBox = new System.Windows.Forms.TextBox();
            this.WindowNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ADBPackageNameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ADBActivityNameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ADBClickAmountTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ADBClickYTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ADBClickXTextBox = new System.Windows.Forms.TextBox();
            this.ADBAppActiveButton = new System.Windows.Forms.Button();
            this.ADBCurActiveAppButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ADBStartAppButton = new System.Windows.Forms.Button();
            this.ADBInstalledButton = new System.Windows.Forms.Button();
            this.ADBStopAppButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ADBScreenshotButton = new System.Windows.Forms.Button();
            this.ADBClickButton = new System.Windows.Forms.Button();
            this.ADBClickDragButton = new System.Windows.Forms.Button();
            this.EmulatorInstComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckEmulatorButton = new System.Windows.Forms.Button();
            this.StartEmuButton = new System.Windows.Forms.Button();
            this.EmuListInstanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DebugImageBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebugImageBox
            // 
            this.DebugImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugImageBox.Location = new System.Drawing.Point(1557, 81);
            this.DebugImageBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DebugImageBox.Name = "DebugImageBox";
            this.DebugImageBox.Size = new System.Drawing.Size(1277, 1028);
            this.DebugImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DebugImageBox.TabIndex = 3;
            this.DebugImageBox.TabStop = false;
            // 
            // BotLog
            // 
            this.BotLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BotLog.Location = new System.Drawing.Point(32, 29);
            this.BotLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BotLog.Name = "BotLog";
            this.BotLog.ReadOnly = true;
            this.BotLog.Size = new System.Drawing.Size(713, 1006);
            this.BotLog.TabIndex = 6;
            this.BotLog.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(32, 1054);
            this.StartButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 55);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start Bot";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PauseButton.Location = new System.Drawing.Point(288, 1054);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(200, 55);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause Bot";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(552, 1054);
            this.StopButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(200, 55);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop Bot";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.FarmAdvMan);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(753, 1029);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 124);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 39);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 124);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 39);
            this.comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 69);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(321, 36);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Farm Adventure Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FarmAdvMan
            // 
            this.FarmAdvMan.AutoSize = true;
            this.FarmAdvMan.Location = new System.Drawing.Point(16, 14);
            this.FarmAdvMan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FarmAdvMan.Name = "FarmAdvMan";
            this.FarmAdvMan.Size = new System.Drawing.Size(377, 36);
            this.FarmAdvMan.TabIndex = 0;
            this.FarmAdvMan.Text = "Farm Adventure Manually";
            this.FarmAdvMan.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(768, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 1087);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ClickAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ClickYCoord);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ClickXCoord);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.DWMCapButton);
            this.tabPage2.Controls.Add(this.GDICapButton);
            this.tabPage2.Controls.Add(this.ScreenCapButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ClickSendMSGButton);
            this.tabPage2.Controls.Add(this.ClickMouseButton);
            this.tabPage2.Controls.Add(this.ClickPostMSGButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CSharpISButton);
            this.tabPage2.Controls.Add(this.AutoItISButton);
            this.tabPage2.Controls.Add(this.ImagePathBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.EMGUISButton);
            this.tabPage2.Controls.Add(this.ControlNameBox);
            this.tabPage2.Controls.Add(this.WindowNameBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(753, 1029);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 448);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 32);
            this.label11.TabIndex = 35;
            this.label11.Text = "n:";
            // 
            // ClickAmount
            // 
            this.ClickAmount.Location = new System.Drawing.Point(576, 441);
            this.ClickAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickAmount.Name = "ClickAmount";
            this.ClickAmount.Size = new System.Drawing.Size(153, 38);
            this.ClickAmount.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 448);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 32);
            this.label10.TabIndex = 33;
            this.label10.Text = "Y:";
            // 
            // ClickYCoord
            // 
            this.ClickYCoord.Location = new System.Drawing.Point(307, 441);
            this.ClickYCoord.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickYCoord.Name = "ClickYCoord";
            this.ClickYCoord.Size = new System.Drawing.Size(153, 38);
            this.ClickYCoord.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 448);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "X:";
            // 
            // ClickXCoord
            // 
            this.ClickXCoord.Location = new System.Drawing.Point(77, 441);
            this.ClickXCoord.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickXCoord.Name = "ClickXCoord";
            this.ClickXCoord.Size = new System.Drawing.Size(145, 38);
            this.ClickXCoord.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "Window Capture Test:";
            // 
            // DWMCapButton
            // 
            this.DWMCapButton.Location = new System.Drawing.Point(523, 241);
            this.DWMCapButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DWMCapButton.Name = "DWMCapButton";
            this.DWMCapButton.Size = new System.Drawing.Size(213, 55);
            this.DWMCapButton.TabIndex = 24;
            this.DWMCapButton.Text = "DWM";
            this.DWMCapButton.UseVisualStyleBackColor = true;
            this.DWMCapButton.Click += new System.EventHandler(this.DWMCapButton_Click);
            // 
            // GDICapButton
            // 
            this.GDICapButton.Location = new System.Drawing.Point(253, 241);
            this.GDICapButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GDICapButton.Name = "GDICapButton";
            this.GDICapButton.Size = new System.Drawing.Size(253, 55);
            this.GDICapButton.TabIndex = 23;
            this.GDICapButton.Text = "GDI Cap";
            this.GDICapButton.UseVisualStyleBackColor = true;
            this.GDICapButton.Click += new System.EventHandler(this.GDICapButton_Click);
            // 
            // ScreenCapButton
            // 
            this.ScreenCapButton.Location = new System.Drawing.Point(24, 241);
            this.ScreenCapButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ScreenCapButton.Name = "ScreenCapButton";
            this.ScreenCapButton.Size = new System.Drawing.Size(213, 55);
            this.ScreenCapButton.TabIndex = 22;
            this.ScreenCapButton.Text = "Screen Cap";
            this.ScreenCapButton.UseVisualStyleBackColor = true;
            this.ScreenCapButton.Click += new System.EventHandler(this.ScreenCapButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Click Test:";
            // 
            // ClickSendMSGButton
            // 
            this.ClickSendMSGButton.Location = new System.Drawing.Point(523, 503);
            this.ClickSendMSGButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickSendMSGButton.Name = "ClickSendMSGButton";
            this.ClickSendMSGButton.Size = new System.Drawing.Size(213, 55);
            this.ClickSendMSGButton.TabIndex = 20;
            this.ClickSendMSGButton.Text = "SendMSG";
            this.ClickSendMSGButton.UseVisualStyleBackColor = true;
            this.ClickSendMSGButton.Click += new System.EventHandler(this.ClickSendMSGButton_Click);
            // 
            // ClickMouseButton
            // 
            this.ClickMouseButton.Location = new System.Drawing.Point(253, 503);
            this.ClickMouseButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickMouseButton.Name = "ClickMouseButton";
            this.ClickMouseButton.Size = new System.Drawing.Size(253, 55);
            this.ClickMouseButton.TabIndex = 19;
            this.ClickMouseButton.Text = "Mouse";
            this.ClickMouseButton.UseVisualStyleBackColor = true;
            this.ClickMouseButton.Click += new System.EventHandler(this.ClickMouseButton_Click);
            // 
            // ClickPostMSGButton
            // 
            this.ClickPostMSGButton.Location = new System.Drawing.Point(24, 503);
            this.ClickPostMSGButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickPostMSGButton.Name = "ClickPostMSGButton";
            this.ClickPostMSGButton.Size = new System.Drawing.Size(213, 55);
            this.ClickPostMSGButton.TabIndex = 18;
            this.ClickPostMSGButton.Text = "PostMSG";
            this.ClickPostMSGButton.UseVisualStyleBackColor = true;
            this.ClickPostMSGButton.Click += new System.EventHandler(this.ClickPostMSGButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "ImageSearch Test:";
            // 
            // CSharpISButton
            // 
            this.CSharpISButton.Location = new System.Drawing.Point(523, 341);
            this.CSharpISButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CSharpISButton.Name = "CSharpISButton";
            this.CSharpISButton.Size = new System.Drawing.Size(213, 55);
            this.CSharpISButton.TabIndex = 16;
            this.CSharpISButton.Text = "C# IS";
            this.CSharpISButton.UseVisualStyleBackColor = true;
            this.CSharpISButton.Click += new System.EventHandler(this.CSharpISButton_Click);
            // 
            // AutoItISButton
            // 
            this.AutoItISButton.Location = new System.Drawing.Point(253, 341);
            this.AutoItISButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AutoItISButton.Name = "AutoItISButton";
            this.AutoItISButton.Size = new System.Drawing.Size(253, 55);
            this.AutoItISButton.TabIndex = 14;
            this.AutoItISButton.Text = "AutoIt IS";
            this.AutoItISButton.UseVisualStyleBackColor = true;
            this.AutoItISButton.Click += new System.EventHandler(this.AutoItISButton_Click);
            // 
            // ImagePathBox
            // 
            this.ImagePathBox.Location = new System.Drawing.Point(237, 148);
            this.ImagePathBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ImagePathBox.Name = "ImagePathBox";
            this.ImagePathBox.Size = new System.Drawing.Size(492, 38);
            this.ImagePathBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Image Path:";
            // 
            // EMGUISButton
            // 
            this.EMGUISButton.Location = new System.Drawing.Point(24, 341);
            this.EMGUISButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EMGUISButton.Name = "EMGUISButton";
            this.EMGUISButton.Size = new System.Drawing.Size(213, 55);
            this.EMGUISButton.TabIndex = 11;
            this.EMGUISButton.Text = "EMGU IS";
            this.EMGUISButton.UseVisualStyleBackColor = true;
            this.EMGUISButton.Click += new System.EventHandler(this.EMGUISButton_Click);
            // 
            // ControlNameBox
            // 
            this.ControlNameBox.Location = new System.Drawing.Point(237, 86);
            this.ControlNameBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ControlNameBox.Name = "ControlNameBox";
            this.ControlNameBox.Size = new System.Drawing.Size(492, 38);
            this.ControlNameBox.TabIndex = 3;
            // 
            // WindowNameBox
            // 
            this.WindowNameBox.Location = new System.Drawing.Point(237, 24);
            this.WindowNameBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WindowNameBox.Name = "WindowNameBox";
            this.WindowNameBox.Size = new System.Drawing.Size(492, 38);
            this.WindowNameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Control Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Window Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ADBPackageNameTextBox);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.ADBActivityNameTextBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.ADBClickAmountTextBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.ADBClickYTextBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.ADBClickXTextBox);
            this.tabPage3.Controls.Add(this.ADBAppActiveButton);
            this.tabPage3.Controls.Add(this.ADBCurActiveAppButton);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.ADBStartAppButton);
            this.tabPage3.Controls.Add(this.ADBInstalledButton);
            this.tabPage3.Controls.Add(this.ADBStopAppButton);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.ADBScreenshotButton);
            this.tabPage3.Controls.Add(this.ADBClickButton);
            this.tabPage3.Controls.Add(this.ADBClickDragButton);
            this.tabPage3.Controls.Add(this.EmulatorInstComboBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.CheckEmulatorButton);
            this.tabPage3.Controls.Add(this.StartEmuButton);
            this.tabPage3.Controls.Add(this.EmuListInstanButton);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Size = new System.Drawing.Size(753, 1029);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Emu Debug";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ADBPackageNameTextBox
            // 
            this.ADBPackageNameTextBox.Location = new System.Drawing.Point(244, 642);
            this.ADBPackageNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBPackageNameTextBox.Name = "ADBPackageNameTextBox";
            this.ADBPackageNameTextBox.Size = new System.Drawing.Size(492, 38);
            this.ADBPackageNameTextBox.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 645);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 32);
            this.label17.TabIndex = 49;
            this.label17.Text = "Package Name:";
            // 
            // ADBActivityNameTextBox
            // 
            this.ADBActivityNameTextBox.Location = new System.Drawing.Point(244, 694);
            this.ADBActivityNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBActivityNameTextBox.Name = "ADBActivityNameTextBox";
            this.ADBActivityNameTextBox.Size = new System.Drawing.Size(492, 38);
            this.ADBActivityNameTextBox.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 697);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 32);
            this.label16.TabIndex = 47;
            this.label16.Text = "Activity Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(517, 749);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 32);
            this.label13.TabIndex = 46;
            this.label13.Text = "n:";
            // 
            // ADBClickAmountTextBox
            // 
            this.ADBClickAmountTextBox.Location = new System.Drawing.Point(572, 746);
            this.ADBClickAmountTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBClickAmountTextBox.Name = "ADBClickAmountTextBox";
            this.ADBClickAmountTextBox.Size = new System.Drawing.Size(164, 38);
            this.ADBClickAmountTextBox.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 749);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 32);
            this.label14.TabIndex = 44;
            this.label14.Text = "Y:";
            // 
            // ADBClickYTextBox
            // 
            this.ADBClickYTextBox.Location = new System.Drawing.Point(305, 746);
            this.ADBClickYTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBClickYTextBox.Name = "ADBClickYTextBox";
            this.ADBClickYTextBox.Size = new System.Drawing.Size(153, 38);
            this.ADBClickYTextBox.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 749);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 32);
            this.label15.TabIndex = 42;
            this.label15.Text = "X:";
            // 
            // ADBClickXTextBox
            // 
            this.ADBClickXTextBox.Location = new System.Drawing.Point(76, 746);
            this.ADBClickXTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBClickXTextBox.Name = "ADBClickXTextBox";
            this.ADBClickXTextBox.Size = new System.Drawing.Size(145, 38);
            this.ADBClickXTextBox.TabIndex = 41;
            // 
            // ADBAppActiveButton
            // 
            this.ADBAppActiveButton.Location = new System.Drawing.Point(24, 936);
            this.ADBAppActiveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBAppActiveButton.Name = "ADBAppActiveButton";
            this.ADBAppActiveButton.Size = new System.Drawing.Size(213, 55);
            this.ADBAppActiveButton.TabIndex = 38;
            this.ADBAppActiveButton.Text = "App active";
            this.ADBAppActiveButton.UseVisualStyleBackColor = true;
            this.ADBAppActiveButton.Click += new System.EventHandler(this.ADBAppActiveButton_Click);
            // 
            // ADBCurActiveAppButton
            // 
            this.ADBCurActiveAppButton.Location = new System.Drawing.Point(253, 936);
            this.ADBCurActiveAppButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBCurActiveAppButton.Name = "ADBCurActiveAppButton";
            this.ADBCurActiveAppButton.Size = new System.Drawing.Size(253, 55);
            this.ADBCurActiveAppButton.TabIndex = 39;
            this.ADBCurActiveAppButton.Text = "Cur Active App";
            this.ADBCurActiveAppButton.UseVisualStyleBackColor = true;
            this.ADBCurActiveAppButton.Click += new System.EventHandler(this.ADBCurActiveAppButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(523, 936);
            this.button9.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 55);
            this.button9.TabIndex = 40;
            this.button9.Text = "Placeholder";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // ADBStartAppButton
            // 
            this.ADBStartAppButton.Location = new System.Drawing.Point(24, 867);
            this.ADBStartAppButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBStartAppButton.Name = "ADBStartAppButton";
            this.ADBStartAppButton.Size = new System.Drawing.Size(213, 55);
            this.ADBStartAppButton.TabIndex = 35;
            this.ADBStartAppButton.Text = "Start App";
            this.ADBStartAppButton.UseVisualStyleBackColor = true;
            this.ADBStartAppButton.Click += new System.EventHandler(this.ADBStartAppButton_Click);
            // 
            // ADBInstalledButton
            // 
            this.ADBInstalledButton.Location = new System.Drawing.Point(253, 867);
            this.ADBInstalledButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBInstalledButton.Name = "ADBInstalledButton";
            this.ADBInstalledButton.Size = new System.Drawing.Size(253, 55);
            this.ADBInstalledButton.TabIndex = 36;
            this.ADBInstalledButton.Text = "App Installed";
            this.ADBInstalledButton.UseVisualStyleBackColor = true;
            this.ADBInstalledButton.Click += new System.EventHandler(this.ADBInstalledButton_Click);
            // 
            // ADBStopAppButton
            // 
            this.ADBStopAppButton.Location = new System.Drawing.Point(523, 867);
            this.ADBStopAppButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBStopAppButton.Name = "ADBStopAppButton";
            this.ADBStopAppButton.Size = new System.Drawing.Size(213, 55);
            this.ADBStopAppButton.TabIndex = 37;
            this.ADBStopAppButton.Text = "Stop App";
            this.ADBStopAppButton.UseVisualStyleBackColor = true;
            this.ADBStopAppButton.Click += new System.EventHandler(this.ADBStopAppButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 601);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 32);
            this.label12.TabIndex = 34;
            this.label12.Text = "ADB Test:";
            // 
            // ADBScreenshotButton
            // 
            this.ADBScreenshotButton.Location = new System.Drawing.Point(24, 798);
            this.ADBScreenshotButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBScreenshotButton.Name = "ADBScreenshotButton";
            this.ADBScreenshotButton.Size = new System.Drawing.Size(213, 55);
            this.ADBScreenshotButton.TabIndex = 31;
            this.ADBScreenshotButton.Text = "Screenshot";
            this.ADBScreenshotButton.UseVisualStyleBackColor = true;
            this.ADBScreenshotButton.Click += new System.EventHandler(this.ADBScreenshotButton_Click);
            // 
            // ADBClickButton
            // 
            this.ADBClickButton.Location = new System.Drawing.Point(253, 798);
            this.ADBClickButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBClickButton.Name = "ADBClickButton";
            this.ADBClickButton.Size = new System.Drawing.Size(253, 55);
            this.ADBClickButton.TabIndex = 32;
            this.ADBClickButton.Text = "Click";
            this.ADBClickButton.UseVisualStyleBackColor = true;
            this.ADBClickButton.Click += new System.EventHandler(this.ADBClickButton_Click);
            // 
            // ADBClickDragButton
            // 
            this.ADBClickDragButton.Location = new System.Drawing.Point(523, 798);
            this.ADBClickDragButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ADBClickDragButton.Name = "ADBClickDragButton";
            this.ADBClickDragButton.Size = new System.Drawing.Size(213, 55);
            this.ADBClickDragButton.TabIndex = 33;
            this.ADBClickDragButton.Text = "Click Drag";
            this.ADBClickDragButton.UseVisualStyleBackColor = true;
            this.ADBClickDragButton.Click += new System.EventHandler(this.ADBClickDragButton_Click);
            // 
            // EmulatorInstComboBox
            // 
            this.EmulatorInstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmulatorInstComboBox.FormattingEnabled = true;
            this.EmulatorInstComboBox.Location = new System.Drawing.Point(24, 14);
            this.EmulatorInstComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmulatorInstComboBox.Name = "EmulatorInstComboBox";
            this.EmulatorInstComboBox.Size = new System.Drawing.Size(215, 39);
            this.EmulatorInstComboBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Emulator Test:";
            // 
            // CheckEmulatorButton
            // 
            this.CheckEmulatorButton.Location = new System.Drawing.Point(24, 110);
            this.CheckEmulatorButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CheckEmulatorButton.Name = "CheckEmulatorButton";
            this.CheckEmulatorButton.Size = new System.Drawing.Size(213, 55);
            this.CheckEmulatorButton.TabIndex = 26;
            this.CheckEmulatorButton.Text = "Check Emu";
            this.CheckEmulatorButton.UseVisualStyleBackColor = true;
            this.CheckEmulatorButton.Click += new System.EventHandler(this.CheckEmulatorButton_Click);
            // 
            // StartEmuButton
            // 
            this.StartEmuButton.Location = new System.Drawing.Point(253, 110);
            this.StartEmuButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StartEmuButton.Name = "StartEmuButton";
            this.StartEmuButton.Size = new System.Drawing.Size(253, 55);
            this.StartEmuButton.TabIndex = 27;
            this.StartEmuButton.Text = "Start Emu";
            this.StartEmuButton.UseVisualStyleBackColor = true;
            this.StartEmuButton.Click += new System.EventHandler(this.StartEmuButton_Click);
            // 
            // EmuListInstanButton
            // 
            this.EmuListInstanButton.Location = new System.Drawing.Point(523, 110);
            this.EmuListInstanButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmuListInstanButton.Name = "EmuListInstanButton";
            this.EmuListInstanButton.Size = new System.Drawing.Size(213, 55);
            this.EmuListInstanButton.TabIndex = 28;
            this.EmuListInstanButton.Text = "List Instances";
            this.EmuListInstanButton.UseVisualStyleBackColor = true;
            this.EmuListInstanButton.Click += new System.EventHandler(this.EmuListInstanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1549, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Debug ImageSearch:";
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2867, 1137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BotLog);
            this.Controls.Add(this.DebugImageBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DebugForm";
            this.Text = "ZerGo0\'s Private Test Bot";
            this.Load += new System.EventHandler(this.MainBotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DebugImageBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox DebugImageBox;
        private System.Windows.Forms.RichTextBox BotLog;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox FarmAdvMan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClickSendMSGButton;
        private System.Windows.Forms.Button ClickMouseButton;
        private System.Windows.Forms.Button ClickPostMSGButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CSharpISButton;
        private System.Windows.Forms.Button AutoItISButton;
        private System.Windows.Forms.TextBox ImagePathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EMGUISButton;
        private System.Windows.Forms.TextBox ControlNameBox;
        private System.Windows.Forms.TextBox WindowNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DWMCapButton;
        private System.Windows.Forms.Button GDICapButton;
        private System.Windows.Forms.Button ScreenCapButton;
        private Label label8;
        private Button EmuListInstanButton;
        private Button StartEmuButton;
        private Button CheckEmulatorButton;
        private Label label11;
        private TextBox ClickAmount;
        private Label label10;
        private TextBox ClickYCoord;
        private Label label9;
        private TextBox ClickXCoord;
        private TabPage tabPage3;
        private ComboBox EmulatorInstComboBox;
        private TextBox ADBPackageNameTextBox;
        private Label label17;
        private TextBox ADBActivityNameTextBox;
        private Label label16;
        private Label label13;
        private TextBox ADBClickAmountTextBox;
        private Label label14;
        private TextBox ADBClickYTextBox;
        private Label label15;
        private TextBox ADBClickXTextBox;
        private Button ADBAppActiveButton;
        private Button ADBCurActiveAppButton;
        private Button button9;
        private Button ADBStartAppButton;
        private Button ADBInstalledButton;
        private Button ADBStopAppButton;
        private Label label12;
        private Button ADBScreenshotButton;
        private Button ADBClickButton;
        private Button ADBClickDragButton;
    }
}