namespace IstorieSiSocietate
{
    partial class Bibliografie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bibliografie));
            this.TitluBox = new System.Windows.Forms.Label();
            this.Mat1 = new System.Windows.Forms.Label();
            this.Mat2 = new System.Windows.Forms.Label();
            this.Mat3 = new System.Windows.Forms.Label();
            this.Mat4 = new System.Windows.Forms.Label();
            this.CuprinsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitluBox
            // 
            this.TitluBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitluBox.AutoSize = true;
            this.TitluBox.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluBox.Location = new System.Drawing.Point(311, 9);
            this.TitluBox.Name = "TitluBox";
            this.TitluBox.Size = new System.Drawing.Size(132, 28);
            this.TitluBox.TabIndex = 0;
            this.TitluBox.Text = "Bibliografie";
            // 
            // Mat1
            // 
            this.Mat1.AutoSize = true;
            this.Mat1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat1.Location = new System.Drawing.Point(12, 97);
            this.Mat1.Name = "Mat1";
            this.Mat1.Size = new System.Drawing.Size(766, 22);
            this.Mat1.TabIndex = 1;
            this.Mat1.Text = "- Dan ANTONIU, \"Căpitan aviator CRAIU VASILE\", Editura MĂIASTRA, Târgu Jiu, 2018";
            // 
            // Mat2
            // 
            this.Mat2.AutoSize = true;
            this.Mat2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat2.Location = new System.Drawing.Point(12, 151);
            this.Mat2.Name = "Mat2";
            this.Mat2.Size = new System.Drawing.Size(686, 22);
            this.Mat2.TabIndex = 2;
            this.Mat2.Text = "- Catalog Aeromfila 2018 In memoriam Vasile Craiu, Târgu Jiu, 24-30 august 2018";
            // 
            // Mat3
            // 
            this.Mat3.AutoSize = true;
            this.Mat3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat3.Location = new System.Drawing.Point(12, 200);
            this.Mat3.Name = "Mat3";
            this.Mat3.Size = new System.Drawing.Size(287, 22);
            this.Mat3.TabIndex = 3;
            this.Mat3.Text = "- \"Gorjeanul\", 14 noiembrie 1927";
            // 
            // Mat4
            // 
            this.Mat4.AutoSize = true;
            this.Mat4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat4.Location = new System.Drawing.Point(13, 251);
            this.Mat4.Name = "Mat4";
            this.Mat4.Size = new System.Drawing.Size(84, 22);
            this.Mat4.TabIndex = 4;
            this.Mat4.Text = "- TVR.ro";
            // 
            // CuprinsBtn
            // 
            this.CuprinsBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CuprinsBtn.Location = new System.Drawing.Point(316, 415);
            this.CuprinsBtn.Name = "CuprinsBtn";
            this.CuprinsBtn.Size = new System.Drawing.Size(127, 23);
            this.CuprinsBtn.TabIndex = 5;
            this.CuprinsBtn.Text = "Cuprins";
            this.CuprinsBtn.UseVisualStyleBackColor = true;
            // 
            // Bibliografie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CuprinsBtn);
            this.Controls.Add(this.Mat4);
            this.Controls.Add(this.Mat3);
            this.Controls.Add(this.Mat2);
            this.Controls.Add(this.Mat1);
            this.Controls.Add(this.TitluBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bibliografie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliografie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitluBox;
        private System.Windows.Forms.Label Mat1;
        private System.Windows.Forms.Label Mat2;
        private System.Windows.Forms.Label Mat3;
        private System.Windows.Forms.Label Mat4;
        private System.Windows.Forms.Button CuprinsBtn;
    }
}