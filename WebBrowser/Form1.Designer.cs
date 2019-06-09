namespace WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFwd = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 719);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 693);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1045, 687);
            this.webBrowser1.TabIndex = 0;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(329, 25);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(486, 20);
            this.textAddress.TabIndex = 1;
            this.textAddress.Text = "http://www.google.com";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(821, 19);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(38, 31);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-back-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-next-page-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-delete-64.png");
            this.imageList1.Images.SetKeyName(4, "icons8-light-on-64.png");
            this.imageList1.Images.SetKeyName(5, "icons8-back-to-64.png");
            this.imageList1.Images.SetKeyName(6, "icons8-next-page-64 (1).png");
            this.imageList1.Images.SetKeyName(7, "icons8-homebrew-64.png");
            this.imageList1.Images.SetKeyName(8, "icons8-delete-64 (1).png");
            this.imageList1.Images.SetKeyName(9, "icons8-light-on-64 (1).png");
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SlateGray;
            this.buttonBack.ImageIndex = 0;
            this.buttonBack.ImageList = this.imageList1;
            this.buttonBack.Location = new System.Drawing.Point(16, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(53, 44);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            this.buttonBack.MouseHover += new System.EventHandler(this.buttonBack_MouseHover);
            // 
            // buttonFwd
            // 
            this.buttonFwd.BackColor = System.Drawing.Color.SlateGray;
            this.buttonFwd.ImageIndex = 1;
            this.buttonFwd.ImageList = this.imageList1;
            this.buttonFwd.Location = new System.Drawing.Point(75, 12);
            this.buttonFwd.Name = "buttonFwd";
            this.buttonFwd.Size = new System.Drawing.Size(53, 44);
            this.buttonFwd.TabIndex = 4;
            this.buttonFwd.UseVisualStyleBackColor = false;
            this.buttonFwd.Click += new System.EventHandler(this.button1_Click);
            this.buttonFwd.MouseLeave += new System.EventHandler(this.buttonFwd_MouseLeave);
            this.buttonFwd.MouseHover += new System.EventHandler(this.buttonFwd_MouseHover);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.SlateGray;
            this.buttonHome.ImageIndex = 2;
            this.buttonHome.ImageList = this.imageList1;
            this.buttonHome.Location = new System.Drawing.Point(134, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(53, 44);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.button2_Click);
            this.buttonHome.MouseLeave += new System.EventHandler(this.buttonHome_MouseLeave);
            this.buttonHome.MouseHover += new System.EventHandler(this.buttonHome_MouseHover);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.SlateGray;
            this.buttonStop.ImageIndex = 3;
            this.buttonStop.ImageList = this.imageList1;
            this.buttonStop.Location = new System.Drawing.Point(193, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(53, 44);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.button3_Click);
            this.buttonStop.MouseLeave += new System.EventHandler(this.buttonStop_MouseLeave);
            this.buttonStop.MouseHover += new System.EventHandler(this.buttonStop_MouseHover);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.SlateGray;
            this.buttonRefresh.ImageIndex = 4;
            this.buttonRefresh.ImageList = this.imageList1;
            this.buttonRefresh.Location = new System.Drawing.Point(252, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(53, 44);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.button4_Click);
            this.buttonRefresh.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            this.buttonRefresh.MouseHover += new System.EventHandler(this.buttonRefresh_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1083, 801);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonFwd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Chichi\'s Web Browser";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFwd;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

