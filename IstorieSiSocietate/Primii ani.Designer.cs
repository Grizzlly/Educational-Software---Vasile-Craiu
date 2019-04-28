namespace IstorieSiSocietate
{
    partial class Primii_ani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primii_ani));
            this.TitluBox = new System.Windows.Forms.Label();
            this.PozaMama = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanouInfo = new System.Windows.Forms.Panel();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.CuprinsBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PozaMama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanouInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitluBox
            // 
            this.TitluBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitluBox.AutoSize = true;
            this.TitluBox.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluBox.Location = new System.Drawing.Point(350, 9);
            this.TitluBox.Name = "TitluBox";
            this.TitluBox.Size = new System.Drawing.Size(113, 28);
            this.TitluBox.TabIndex = 0;
            this.TitluBox.Text = "Primii ani";
            // 
            // PozaMama
            // 
            this.PozaMama.Image = ((System.Drawing.Image)(resources.GetObject("PozaMama.Image")));
            this.PozaMama.Location = new System.Drawing.Point(12, 46);
            this.PozaMama.Name = "PozaMama";
            this.PozaMama.Size = new System.Drawing.Size(218, 392);
            this.PozaMama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PozaMama.TabIndex = 1;
            this.PozaMama.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanouInfo
            // 
            this.PanouInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanouInfo.Controls.Add(this.InfoBox);
            this.PanouInfo.Location = new System.Drawing.Point(236, 46);
            this.PanouInfo.Name = "PanouInfo";
            this.PanouInfo.Size = new System.Drawing.Size(324, 363);
            this.PanouInfo.TabIndex = 3;
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.Location = new System.Drawing.Point(3, 3);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.InfoBox.Size = new System.Drawing.Size(316, 355);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = resources.GetString("InfoBox.Text");
            // 
            // CuprinsBtn
            // 
            this.CuprinsBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CuprinsBtn.Location = new System.Drawing.Point(236, 415);
            this.CuprinsBtn.Name = "CuprinsBtn";
            this.CuprinsBtn.Size = new System.Drawing.Size(161, 23);
            this.CuprinsBtn.TabIndex = 4;
            this.CuprinsBtn.Text = "Cuprins";
            this.CuprinsBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.NextBtn.Location = new System.Drawing.Point(403, 415);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(157, 23);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "Next -->";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // Primii_ani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CuprinsBtn);
            this.Controls.Add(this.PanouInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PozaMama);
            this.Controls.Add(this.TitluBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Primii_ani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primii ani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Primii_ani_FormClosing);
            this.Load += new System.EventHandler(this.Primii_ani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PozaMama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanouInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitluBox;
        private System.Windows.Forms.PictureBox PozaMama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanouInfo;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button CuprinsBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}