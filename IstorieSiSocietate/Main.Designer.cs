namespace IstorieSiSocietate
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PortretBox = new System.Windows.Forms.PictureBox();
            this.TitluBox = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ElevBox = new System.Windows.Forms.Label();
            this.ProfBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortretBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PortretBox
            // 
            this.PortretBox.Image = ((System.Drawing.Image)(resources.GetObject("PortretBox.Image")));
            this.PortretBox.Location = new System.Drawing.Point(12, 12);
            this.PortretBox.Margin = new System.Windows.Forms.Padding(6);
            this.PortretBox.Name = "PortretBox";
            this.PortretBox.Size = new System.Drawing.Size(342, 426);
            this.PortretBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PortretBox.TabIndex = 0;
            this.PortretBox.TabStop = false;
            // 
            // TitluBox
            // 
            this.TitluBox.AutoSize = true;
            this.TitluBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluBox.Location = new System.Drawing.Point(379, 171);
            this.TitluBox.Name = "TitluBox";
            this.TitluBox.Size = new System.Drawing.Size(393, 26);
            this.TitluBox.TabIndex = 1;
            this.TitluBox.Text = "Vasile Craiu - Asul aviației românești";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(384, 293);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(697, 293);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Ieșire";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ElevBox
            // 
            this.ElevBox.AutoSize = true;
            this.ElevBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevBox.Location = new System.Drawing.Point(440, 319);
            this.ElevBox.Name = "ElevBox";
            this.ElevBox.Size = new System.Drawing.Size(278, 44);
            this.ElevBox.TabIndex = 4;
            this.ElevBox.Text = "Elev: Stan Andrei, clasa a IX-a B\r\n C.N. \"Tudor Vladimirescu\"";
            // 
            // ProfBox
            // 
            this.ProfBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfBox.AutoSize = true;
            this.ProfBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfBox.Location = new System.Drawing.Point(425, 397);
            this.ProfBox.Name = "ProfBox";
            this.ProfBox.Size = new System.Drawing.Size(363, 44);
            this.ProfBox.TabIndex = 5;
            this.ProfBox.Text = "Prof. Coord.: Mrejeru Marcela - Istorie\r\n                        Popescu Sanda - " +
    "Informatică";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfBox);
            this.Controls.Add(this.ElevBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TitluBox);
            this.Controls.Add(this.PortretBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vasile V. Craiu";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortretBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PortretBox;
        private System.Windows.Forms.Label TitluBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label ElevBox;
        private System.Windows.Forms.Label ProfBox;
    }
}

