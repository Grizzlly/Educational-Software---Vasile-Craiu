namespace IstorieSiSocietate
{
    partial class Nori_negrii_pe_cerul_Romaniei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nori_negrii_pe_cerul_Romaniei));
            this.TitluBox = new System.Windows.Forms.Label();
            this.SpitalImage = new System.Windows.Forms.PictureBox();
            this.TranseeImage = new System.Windows.Forms.PictureBox();
            this.PanouInfo = new System.Windows.Forms.Panel();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.CuprinsBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpitalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranseeImage)).BeginInit();
            this.PanouInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitluBox
            // 
            this.TitluBox.AutoSize = true;
            this.TitluBox.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluBox.Location = new System.Drawing.Point(254, 9);
            this.TitluBox.Name = "TitluBox";
            this.TitluBox.Size = new System.Drawing.Size(310, 28);
            this.TitluBox.TabIndex = 0;
            this.TitluBox.Text = "Nori negrii pe cerul României";
            // 
            // SpitalImage
            // 
            this.SpitalImage.Image = ((System.Drawing.Image)(resources.GetObject("SpitalImage.Image")));
            this.SpitalImage.Location = new System.Drawing.Point(562, 58);
            this.SpitalImage.Name = "SpitalImage";
            this.SpitalImage.Size = new System.Drawing.Size(226, 380);
            this.SpitalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpitalImage.TabIndex = 1;
            this.SpitalImage.TabStop = false;
            // 
            // TranseeImage
            // 
            this.TranseeImage.Image = ((System.Drawing.Image)(resources.GetObject("TranseeImage.Image")));
            this.TranseeImage.Location = new System.Drawing.Point(12, 58);
            this.TranseeImage.Name = "TranseeImage";
            this.TranseeImage.Size = new System.Drawing.Size(237, 380);
            this.TranseeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TranseeImage.TabIndex = 2;
            this.TranseeImage.TabStop = false;
            // 
            // PanouInfo
            // 
            this.PanouInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanouInfo.Controls.Add(this.InfoBox);
            this.PanouInfo.Location = new System.Drawing.Point(255, 58);
            this.PanouInfo.Name = "PanouInfo";
            this.PanouInfo.Size = new System.Drawing.Size(301, 350);
            this.PanouInfo.TabIndex = 3;
            // 
            // InfoBox
            // 
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.Location = new System.Drawing.Point(3, 3);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.InfoBox.Size = new System.Drawing.Size(293, 335);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = resources.GetString("InfoBox.Text");
            // 
            // CuprinsBtn
            // 
            this.CuprinsBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CuprinsBtn.Location = new System.Drawing.Point(259, 414);
            this.CuprinsBtn.Name = "CuprinsBtn";
            this.CuprinsBtn.Size = new System.Drawing.Size(131, 23);
            this.CuprinsBtn.TabIndex = 4;
            this.CuprinsBtn.Text = "Cuprins";
            this.CuprinsBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BackBtn.Location = new System.Drawing.Point(396, 414);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "<-- Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.NextBtn.Location = new System.Drawing.Point(477, 414);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "Next -->";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // Nori_negrii_pe_cerul_Romaniei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CuprinsBtn);
            this.Controls.Add(this.PanouInfo);
            this.Controls.Add(this.TranseeImage);
            this.Controls.Add(this.SpitalImage);
            this.Controls.Add(this.TitluBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nori_negrii_pe_cerul_Romaniei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nori negrii pe cerul Romaniei";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nori_negrii_pe_cerul_Romaniei_FormClosing);
            this.Load += new System.EventHandler(this.Nori_negrii_pe_cerul_Romaniei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpitalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranseeImage)).EndInit();
            this.PanouInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitluBox;
        private System.Windows.Forms.PictureBox SpitalImage;
        private System.Windows.Forms.PictureBox TranseeImage;
        private System.Windows.Forms.Panel PanouInfo;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button CuprinsBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}