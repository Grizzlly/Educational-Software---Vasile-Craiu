namespace IstorieSiSocietate
{
    partial class GameSelect
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
            this.button1 = new System.Windows.Forms.Button();
            this.LabelSpanzuratoare = new System.Windows.Forms.Label();
            this.LabelPuzzle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anulare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LabelSpanzuratoare
            // 
            this.LabelSpanzuratoare.AutoSize = true;
            this.LabelSpanzuratoare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpanzuratoare.Location = new System.Drawing.Point(8, 46);
            this.LabelSpanzuratoare.Name = "LabelSpanzuratoare";
            this.LabelSpanzuratoare.Size = new System.Drawing.Size(152, 22);
            this.LabelSpanzuratoare.TabIndex = 1;
            this.LabelSpanzuratoare.Text = "• Spanzuratoarea";
            this.LabelSpanzuratoare.Click += new System.EventHandler(this.LabelSpanzuratoare_Click);
            // 
            // LabelPuzzle
            // 
            this.LabelPuzzle.AutoSize = true;
            this.LabelPuzzle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuzzle.Location = new System.Drawing.Point(8, 68);
            this.LabelPuzzle.Name = "LabelPuzzle";
            this.LabelPuzzle.Size = new System.Drawing.Size(74, 22);
            this.LabelPuzzle.TabIndex = 2;
            this.LabelPuzzle.Text = "• Puzzle";
            this.LabelPuzzle.Click += new System.EventHandler(this.LabelPuzzle_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 161);
            this.Controls.Add(this.LabelPuzzle);
            this.Controls.Add(this.LabelSpanzuratoare);
            this.Controls.Add(this.button1);
            this.Name = "GameSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectare joc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelSpanzuratoare;
        private System.Windows.Forms.Label LabelPuzzle;
    }
}