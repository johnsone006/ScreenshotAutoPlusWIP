﻿namespace ScreenShotAutoPlus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.waitB4_TB = new System.Windows.Forms.TextBox();
            this.waitAfter_TB = new System.Windows.Forms.TextBox();
            this.colorCode_TB = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.fileName_LB = new System.Windows.Forms.ListBox();
            this.filePath_LB = new System.Windows.Forms.ListBox();
            this.import_BTN = new System.Windows.Forms.Button();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.pauseAndPlay_BTN = new System.Windows.Forms.Button();
            this.processStatus_LBL = new System.Windows.Forms.Label();
            this.screenshotNumber_LBL = new System.Windows.Forms.Label();
            this.timeLeft_LBL = new System.Windows.Forms.Label();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.CalculateTimeBTN = new System.Windows.Forms.Button();
            this.screenshotFiles_LB = new System.Windows.Forms.ListBox();
            this.screenshot_PB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.waitB4_LBL = new System.Windows.Forms.Label();
            this.waitAfter_LBL = new System.Windows.Forms.Label();
            this.min_WaitB4_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screenshot_PB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1980, 91);
            this.topPanel.TabIndex = 22;
            // 
            // waitB4_TB
            // 
            this.waitB4_TB.Location = new System.Drawing.Point(57, 62);
            this.waitB4_TB.Name = "waitB4_TB";
            this.waitB4_TB.Size = new System.Drawing.Size(100, 22);
            this.waitB4_TB.TabIndex = 14;
            this.toolTip1.SetToolTip(this.waitB4_TB, "Type the number of miliseconds you want the program to wait prior to taking each " +
        "screenshot");
            this.waitB4_TB.WordWrap = false;
            // 
            // waitAfter_TB
            // 
            this.waitAfter_TB.Location = new System.Drawing.Point(48, 174);
            this.waitAfter_TB.Name = "waitAfter_TB";
            this.waitAfter_TB.Size = new System.Drawing.Size(100, 22);
            this.waitAfter_TB.TabIndex = 15;
            this.toolTip1.SetToolTip(this.waitAfter_TB, "Type the number of miliseconds you want the program to wait after taking each scr" +
        "eenshot");
            // 
            // colorCode_TB
            // 
            this.colorCode_TB.Location = new System.Drawing.Point(12, 265);
            this.colorCode_TB.Name = "colorCode_TB";
            this.colorCode_TB.Size = new System.Drawing.Size(100, 22);
            this.colorCode_TB.TabIndex = 26;
            this.toolTip1.SetToolTip(this.colorCode_TB, "Type  in hexadecimal color code for the background of the viewport in Nifskope he" +
        "re");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileName_LB
            // 
            this.fileName_LB.FormattingEnabled = true;
            this.fileName_LB.ItemHeight = 16;
            this.fileName_LB.Location = new System.Drawing.Point(12, 418);
            this.fileName_LB.Name = "fileName_LB";
            this.fileName_LB.Size = new System.Drawing.Size(190, 52);
            this.fileName_LB.TabIndex = 16;
            // 
            // filePath_LB
            // 
            this.filePath_LB.BackColor = System.Drawing.SystemColors.Window;
            this.filePath_LB.FormattingEnabled = true;
            this.filePath_LB.HorizontalScrollbar = true;
            this.filePath_LB.ItemHeight = 16;
            this.filePath_LB.Location = new System.Drawing.Point(11, 362);
            this.filePath_LB.Name = "filePath_LB";
            this.filePath_LB.Size = new System.Drawing.Size(190, 36);
            this.filePath_LB.TabIndex = 17;
            // 
            // import_BTN
            // 
            this.import_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_BTN.Location = new System.Drawing.Point(11, 317);
            this.import_BTN.Name = "import_BTN";
            this.import_BTN.Size = new System.Drawing.Size(186, 23);
            this.import_BTN.TabIndex = 18;
            this.import_BTN.Text = "Import file names and paths";
            this.import_BTN.UseVisualStyleBackColor = true;
            this.import_BTN.Click += new System.EventHandler(this.Import_BTN_Click);
            // 
            // Start_BTN
            // 
            this.Start_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_BTN.Location = new System.Drawing.Point(63, 547);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(61, 29);
            this.Start_BTN.TabIndex = 0;
            this.Start_BTN.Text = "Start";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // pauseAndPlay_BTN
            // 
            this.pauseAndPlay_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseAndPlay_BTN.Location = new System.Drawing.Point(48, 582);
            this.pauseAndPlay_BTN.Name = "pauseAndPlay_BTN";
            this.pauseAndPlay_BTN.Size = new System.Drawing.Size(109, 28);
            this.pauseAndPlay_BTN.TabIndex = 1;
            this.pauseAndPlay_BTN.Text = "Restart/Pause ";
            this.pauseAndPlay_BTN.UseVisualStyleBackColor = true;
            this.pauseAndPlay_BTN.Click += new System.EventHandler(this.PauseAndPlay_BTN_Click);
            // 
            // processStatus_LBL
            // 
            this.processStatus_LBL.AutoSize = true;
            this.processStatus_LBL.Location = new System.Drawing.Point(60, 850);
            this.processStatus_LBL.Name = "processStatus_LBL";
            this.processStatus_LBL.Size = new System.Drawing.Size(61, 16);
            this.processStatus_LBL.TabIndex = 2;
            this.processStatus_LBL.Text = "Waiting...";
            // 
            // screenshotNumber_LBL
            // 
            this.screenshotNumber_LBL.AutoSize = true;
            this.screenshotNumber_LBL.Location = new System.Drawing.Point(19, 913);
            this.screenshotNumber_LBL.Name = "screenshotNumber_LBL";
            this.screenshotNumber_LBL.Size = new System.Drawing.Size(148, 16);
            this.screenshotNumber_LBL.TabIndex = 3;
            this.screenshotNumber_LBL.Text = "Number of screenshots:";
            // 
            // timeLeft_LBL
            // 
            this.timeLeft_LBL.AutoSize = true;
            this.timeLeft_LBL.Location = new System.Drawing.Point(19, 884);
            this.timeLeft_LBL.Name = "timeLeft_LBL";
            this.timeLeft_LBL.Size = new System.Drawing.Size(157, 16);
            this.timeLeft_LBL.TabIndex = 4;
            this.timeLeft_LBL.Text = "Time left (in miliseconds):";
            // 
            // stateTxt
            // 
            this.stateTxt.Location = new System.Drawing.Point(74, 490);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(47, 22);
            this.stateTxt.TabIndex = 21;
            // 
            // CalculateTimeBTN
            // 
            this.CalculateTimeBTN.Location = new System.Drawing.Point(48, 518);
            this.CalculateTimeBTN.Name = "CalculateTimeBTN";
            this.CalculateTimeBTN.Size = new System.Drawing.Size(109, 23);
            this.CalculateTimeBTN.TabIndex = 22;
            this.CalculateTimeBTN.Text = "CalculateTime";
            this.CalculateTimeBTN.UseVisualStyleBackColor = true;
            this.CalculateTimeBTN.Click += new System.EventHandler(this.CalculateTimeBTN_Click);
            // 
            // screenshotFiles_LB
            // 
            this.screenshotFiles_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotFiles_LB.FormattingEnabled = true;
            this.screenshotFiles_LB.HorizontalScrollbar = true;
            this.screenshotFiles_LB.Location = new System.Drawing.Point(6, 616);
            this.screenshotFiles_LB.Name = "screenshotFiles_LB";
            this.screenshotFiles_LB.Size = new System.Drawing.Size(178, 69);
            this.screenshotFiles_LB.TabIndex = 23;
            this.screenshotFiles_LB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenshotFiles_LB_MouseClick);
            // 
            // screenshot_PB
            // 
            this.screenshot_PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenshot_PB.Location = new System.Drawing.Point(10, 691);
            this.screenshot_PB.Name = "screenshot_PB";
            this.screenshot_PB.Size = new System.Drawing.Size(174, 156);
            this.screenshot_PB.TabIndex = 24;
            this.screenshot_PB.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.min_WaitB4_LBL);
            this.panel1.Controls.Add(this.colorCode_TB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.screenshot_PB);
            this.panel1.Controls.Add(this.screenshotFiles_LB);
            this.panel1.Controls.Add(this.CalculateTimeBTN);
            this.panel1.Controls.Add(this.stateTxt);
            this.panel1.Controls.Add(this.timeLeft_LBL);
            this.panel1.Controls.Add(this.waitB4_LBL);
            this.panel1.Controls.Add(this.screenshotNumber_LBL);
            this.panel1.Controls.Add(this.processStatus_LBL);
            this.panel1.Controls.Add(this.pauseAndPlay_BTN);
            this.panel1.Controls.Add(this.Start_BTN);
            this.panel1.Controls.Add(this.waitAfter_LBL);
            this.panel1.Controls.Add(this.import_BTN);
            this.panel1.Controls.Add(this.filePath_LB);
            this.panel1.Controls.Add(this.fileName_LB);
            this.panel1.Controls.Add(this.waitAfter_TB);
            this.panel1.Controls.Add(this.waitB4_TB);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 949);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hex color code of background 4 viewport of nifskope:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitB4_LBL
            // 
            this.waitB4_LBL.AutoEllipsis = true;
            this.waitB4_LBL.Location = new System.Drawing.Point(3, 3);
            this.waitB4_LBL.Name = "waitB4_LBL";
            this.waitB4_LBL.Size = new System.Drawing.Size(221, 56);
            this.waitB4_LBL.TabIndex = 6;
            this.waitB4_LBL.Text = "Number of miliseconds for program to wait prior to each screenshot";
            this.waitB4_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitAfter_LBL
            // 
            this.waitAfter_LBL.Location = new System.Drawing.Point(3, 114);
            this.waitAfter_LBL.Name = "waitAfter_LBL";
            this.waitAfter_LBL.Size = new System.Drawing.Size(213, 48);
            this.waitAfter_LBL.TabIndex = 7;
            this.waitAfter_LBL.Text = "Number of miliseconds for program to wait  after each screenshot";
            this.waitAfter_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min_WaitB4_LBL
            // 
            this.min_WaitB4_LBL.AutoSize = true;
            this.min_WaitB4_LBL.Location = new System.Drawing.Point(54, 98);
            this.min_WaitB4_LBL.Name = "min_WaitB4_LBL";
            this.min_WaitB4_LBL.Size = new System.Drawing.Size(94, 16);
            this.min_WaitB4_LBL.TabIndex = 27;
            this.min_WaitB4_LBL.Text = "Minimum time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1980, 1040);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenshot_PB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox waitB4_TB;
        private System.Windows.Forms.TextBox waitAfter_TB;
        private System.Windows.Forms.ListBox fileName_LB;
        private System.Windows.Forms.ListBox filePath_LB;
        private System.Windows.Forms.Button import_BTN;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.Button pauseAndPlay_BTN;
        private System.Windows.Forms.Label processStatus_LBL;
        private System.Windows.Forms.Label screenshotNumber_LBL;
        private System.Windows.Forms.Label timeLeft_LBL;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.Button CalculateTimeBTN;
        private System.Windows.Forms.ListBox screenshotFiles_LB;
        private System.Windows.Forms.PictureBox screenshot_PB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox colorCode_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label waitB4_LBL;
        private System.Windows.Forms.Label waitAfter_LBL;
        private System.Windows.Forms.Label min_WaitB4_LBL;
    }
}

