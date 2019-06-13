namespace IstorieSiSocietate
{
    partial class JocSpanzuratoarea
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
            this.PicBoxHang = new System.Windows.Forms.PictureBox();
            this.LabelHint = new System.Windows.Forms.Label();
            this.groupChars = new System.Windows.Forms.GroupBox();
            this.FlowPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHang)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxHang
            // 
            this.PicBoxHang.Location = new System.Drawing.Point(531, 148);
            this.PicBoxHang.Name = "PicBoxHang";
            this.PicBoxHang.Size = new System.Drawing.Size(257, 290);
            this.PicBoxHang.TabIndex = 0;
            this.PicBoxHang.TabStop = false;
            this.PicBoxHang.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxHang_Paint);
            // 
            // LabelHint
            // 
            this.LabelHint.AutoSize = true;
            this.LabelHint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHint.Location = new System.Drawing.Point(331, 34);
            this.LabelHint.Name = "LabelHint";
            this.LabelHint.Size = new System.Drawing.Size(63, 22);
            this.LabelHint.TabIndex = 1;
            this.LabelHint.Text = "<hint>";
            // 
            // groupChars
            // 
            this.groupChars.Location = new System.Drawing.Point(12, 59);
            this.groupChars.Name = "groupChars";
            this.groupChars.Size = new System.Drawing.Size(776, 83);
            this.groupChars.TabIndex = 2;
            this.groupChars.TabStop = false;
            // 
            // FlowPanelButtons
            // 
            this.FlowPanelButtons.Location = new System.Drawing.Point(12, 210);
            this.FlowPanelButtons.Name = "FlowPanelButtons";
            this.FlowPanelButtons.Size = new System.Drawing.Size(513, 189);
            this.FlowPanelButtons.TabIndex = 3;
            // 
            // JocSpanzuratoarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlowPanelButtons);
            this.Controls.Add(this.groupChars);
            this.Controls.Add(this.LabelHint);
            this.Controls.Add(this.PicBoxHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JocSpanzuratoarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spanzuratoarea";
            this.Load += new System.EventHandler(this.JocSpanzuratoarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxHang;
        private System.Windows.Forms.Label LabelHint;
        private System.Windows.Forms.GroupBox groupChars;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelButtons;
    }
}