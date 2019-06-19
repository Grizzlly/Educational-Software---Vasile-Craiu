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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelect));
            this.button1 = new System.Windows.Forms.Button();
            this.labelSpanzuratoare = new System.Windows.Forms.Label();
            this.labelPuzzle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anulare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelSpanzuratoare
            // 
            this.labelSpanzuratoare.AutoSize = true;
            this.labelSpanzuratoare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSpanzuratoare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpanzuratoare.Location = new System.Drawing.Point(8, 46);
            this.labelSpanzuratoare.Name = "labelSpanzuratoare";
            this.labelSpanzuratoare.Size = new System.Drawing.Size(152, 22);
            this.labelSpanzuratoare.TabIndex = 1;
            this.labelSpanzuratoare.Text = "• Spanzuratoarea";
            this.labelSpanzuratoare.Click += new System.EventHandler(this.LabelSpanzuratoare_Click);
            this.labelSpanzuratoare.MouseEnter += new System.EventHandler(this.LabelSpanzuratoare_MouseEnter);
            this.labelSpanzuratoare.MouseLeave += new System.EventHandler(this.LabelSpanzuratoare_MouseLeave);
            // 
            // labelPuzzle
            // 
            this.labelPuzzle.AutoSize = true;
            this.labelPuzzle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPuzzle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuzzle.Location = new System.Drawing.Point(8, 77);
            this.labelPuzzle.Name = "labelPuzzle";
            this.labelPuzzle.Size = new System.Drawing.Size(74, 22);
            this.labelPuzzle.TabIndex = 2;
            this.labelPuzzle.Text = "• Puzzle";
            this.labelPuzzle.Click += new System.EventHandler(this.LabelPuzzle_Click);
            this.labelPuzzle.MouseEnter += new System.EventHandler(this.LabelPuzzle_MouseEnter);
            this.labelPuzzle.MouseLeave += new System.EventHandler(this.LabelPuzzle_MouseLeave);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(260, 161);
            this.Controls.Add(this.labelPuzzle);
            this.Controls.Add(this.labelSpanzuratoare);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectare joc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSpanzuratoare;
        private System.Windows.Forms.Label labelPuzzle;
    }
}