namespace EmlakSistemi
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.slideA = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuMetroTextbox3 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new ns1.BunifuMetroTextbox();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.slideA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // slideA
            // 
            this.slideA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideA.Controls.Add(this.pictureBox1);
            this.slideA.Controls.Add(this.bunifuMetroTextbox3);
            this.slideA.Controls.Add(this.bunifuCustomLabel4);
            this.slideA.Controls.Add(this.bunifuCustomLabel3);
            this.slideA.Controls.Add(this.bunifuCustomLabel2);
            this.slideA.Controls.Add(this.bunifuMetroTextbox2);
            this.slideA.Controls.Add(this.bunifuMetroTextbox1);
            this.slideA.Controls.Add(this.bunifuThinButton21);
            this.slideA.Location = new System.Drawing.Point(58, 23);
            this.slideA.Name = "slideA";
            this.slideA.Size = new System.Drawing.Size(453, 594);
            this.slideA.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmlakSistemi.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(139, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox3.BorderThickness = 2;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = true;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(53, 433);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(339, 47);
            this.bunifuMetroTextbox3.TabIndex = 7;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(58, 408);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(50, 20);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Parola";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(58, 313);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(96, 20);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Kullanıcı Adı ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(58, 216);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(46, 20);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Email";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox2.BorderThickness = 2;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(53, 338);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(339, 47);
            this.bunifuMetroTextbox2.TabIndex = 2;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.bunifuMetroTextbox1.BorderThickness = 2;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(53, 241);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(339, 49);
            this.bunifuMetroTextbox1.TabIndex = 1;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Cornsilk;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Kaydol";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.Location = new System.Drawing.Point(75, 518);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(292, 69);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(576, 662);
            this.Controls.Add(this.slideA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.slideA.ResumeLayout(false);
            this.slideA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel slideA;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}