namespace Portable_Mp3_Player
{
    partial class FreeMp3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeMp3Player));
            this.UpsidePanel = new System.Windows.Forms.Panel();
            this.Minimize_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.filename_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpsidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpsidePanel
            // 
            this.UpsidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(165)))));
            this.UpsidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpsidePanel.BackgroundImage")));
            this.UpsidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpsidePanel.Controls.Add(this.Minimize_BTN);
            this.UpsidePanel.Controls.Add(this.label1);
            this.UpsidePanel.Controls.Add(this.Exit_BTN);
            this.UpsidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpsidePanel.Font = new System.Drawing.Font("Hellion", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpsidePanel.Location = new System.Drawing.Point(0, 0);
            this.UpsidePanel.Name = "UpsidePanel";
            this.UpsidePanel.Size = new System.Drawing.Size(520, 40);
            this.UpsidePanel.TabIndex = 0;
            this.UpsidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpsidePanel_MouseDown);
            this.UpsidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpsidePanel_MouseMove);
            this.UpsidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpsidePanel_MouseUp);
            // 
            // Minimize_BTN
            // 
            this.Minimize_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(242)))));
            this.Minimize_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_BTN.FlatAppearance.BorderSize = 0;
            this.Minimize_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Minimize_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_BTN.Font = new System.Drawing.Font("Impact", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_BTN.Location = new System.Drawing.Point(442, 0);
            this.Minimize_BTN.Name = "Minimize_BTN";
            this.Minimize_BTN.Size = new System.Drawing.Size(39, 40);
            this.Minimize_BTN.TabIndex = 3;
            this.Minimize_BTN.Text = "_";
            this.Minimize_BTN.UseVisualStyleBackColor = false;
            this.Minimize_BTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vampire Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portable Mp3 Player";
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(242)))));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_BTN.FlatAppearance.BorderSize = 0;
            this.Exit_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_BTN.Font = new System.Drawing.Font("Marshal The Dead", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ForeColor = System.Drawing.Color.White;
            this.Exit_BTN.Location = new System.Drawing.Point(481, 0);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(39, 40);
            this.Exit_BTN.TabIndex = 1;
            this.Exit_BTN.Text = "X";
            this.Exit_BTN.UseVisualStyleBackColor = false;
            this.Exit_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 155);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openfile_btn
            // 
            this.openfile_btn.BackColor = System.Drawing.Color.Transparent;
            this.openfile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openfile_btn.BackgroundImage")));
            this.openfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openfile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openfile_btn.FlatAppearance.BorderSize = 0;
            this.openfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfile_btn.Location = new System.Drawing.Point(282, 54);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(55, 41);
            this.openfile_btn.TabIndex = 2;
            this.openfile_btn.UseVisualStyleBackColor = false;
            this.openfile_btn.Click += new System.EventHandler(this.openfile_btn_Click);
            // 
            // filename_box
            // 
            this.filename_box.BackColor = System.Drawing.Color.DodgerBlue;
            this.filename_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_box.Location = new System.Drawing.Point(9, 59);
            this.filename_box.Name = "filename_box";
            this.filename_box.Size = new System.Drawing.Size(267, 29);
            this.filename_box.TabIndex = 7;
            this.filename_box.TextChanged += new System.EventHandler(this.filename_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vampire Calligraphy", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Vampire Calligraphy", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Play";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Vampire Calligraphy", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stop";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FreeMp3Player
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 192);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filename_box);
            this.Controls.Add(this.openfile_btn);
            this.Controls.Add(this.UpsidePanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Hellion", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreeMp3Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valhalla Portable mp3-Player";
            this.UpsidePanel.ResumeLayout(false);
            this.UpsidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpsidePanel;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Minimize_BTN;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.TextBox filename_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

