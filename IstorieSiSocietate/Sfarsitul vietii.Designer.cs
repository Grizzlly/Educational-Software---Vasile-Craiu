namespace IstorieSiSocietate
{
    partial class Sfarsitul_vietii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sfarsitul_vietii));
            this.TitluBox = new System.Windows.Forms.Label();
            this.AvionImage = new System.Windows.Forms.PictureBox();
            this.InmormantareImage = new System.Windows.Forms.PictureBox();
            this.PanouInfo = new System.Windows.Forms.Panel();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.CuprinsBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InmormantareImage)).BeginInit();
            this.PanouInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitluBox
            // 
            this.TitluBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitluBox.AutoSize = true;
            this.TitluBox.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluBox.Location = new System.Drawing.Point(327, 9);
            this.TitluBox.Name = "TitluBox";
            this.TitluBox.Size = new System.Drawing.Size(153, 28);
            this.TitluBox.TabIndex = 0;
            this.TitluBox.Text = "Sfârșitul vieții";
            // 
            // AvionImage
            // 
            this.AvionImage.Image = ((System.Drawing.Image)(resources.GetObject("AvionImage.Image")));
            this.AvionImage.Location = new System.Drawing.Point(13, 51);
            this.AvionImage.Name = "AvionImage";
            this.AvionImage.Size = new System.Drawing.Size(233, 387);
            this.AvionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvionImage.TabIndex = 1;
            this.AvionImage.TabStop = false;
            // 
            // InmormantareImage
            // 
            this.InmormantareImage.Image = ((System.Drawing.Image)(resources.GetObject("InmormantareImage.Image")));
            this.InmormantareImage.Location = new System.Drawing.Point(560, 51);
            this.InmormantareImage.Name = "InmormantareImage";
            this.InmormantareImage.Size = new System.Drawing.Size(228, 387);
            this.InmormantareImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InmormantareImage.TabIndex = 2;
            this.InmormantareImage.TabStop = false;
            // 
            // PanouInfo
            // 
            this.PanouInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanouInfo.Controls.Add(this.InfoBox);
            this.PanouInfo.Location = new System.Drawing.Point(252, 51);
            this.PanouInfo.Name = "PanouInfo";
            this.PanouInfo.Size = new System.Drawing.Size(302, 358);
            this.PanouInfo.TabIndex = 3;
            // 
            // InfoBox
            // 
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.Location = new System.Drawing.Point(4, 4);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.InfoBox.Size = new System.Drawing.Size(293, 349);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = resources.GetString("InfoBox.Text");
            // 
            // CuprinsBtn
            // 
            this.CuprinsBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CuprinsBtn.Location = new System.Drawing.Point(252, 415);
            this.CuprinsBtn.Name = "CuprinsBtn";
            this.CuprinsBtn.Size = new System.Drawing.Size(140, 23);
            this.CuprinsBtn.TabIndex = 5;
            this.CuprinsBtn.Text = "Cuprins";
            this.CuprinsBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BackBtn.Location = new System.Drawing.Point(398, 415);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(156, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "<-- Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // Sfarsitul_vietii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CuprinsBtn);
            this.Controls.Add(this.PanouInfo);
            this.Controls.Add(this.InmormantareImage);
            this.Controls.Add(this.AvionImage);
            this.Controls.Add(this.TitluBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sfarsitul_vietii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sfarsitul vietii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sfarsitul_vietii_FormClosing);
            this.Load += new System.EventHandler(this.Sfarsitul_vietii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InmormantareImage)).EndInit();
            this.PanouInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitluBox;
        private System.Windows.Forms.PictureBox AvionImage;
        private System.Windows.Forms.PictureBox InmormantareImage;
        private System.Windows.Forms.Panel PanouInfo;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button CuprinsBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}