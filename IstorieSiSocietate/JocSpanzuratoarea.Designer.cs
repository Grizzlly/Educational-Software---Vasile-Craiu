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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocSpanzuratoarea));
            this.PicBoxHang = new System.Windows.Forms.PictureBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.groupChars = new System.Windows.Forms.GroupBox();
            this.FlowPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGLeft = new System.Windows.Forms.Label();
            this.textGLeft = new System.Windows.Forms.TextBox();
            this.textTryLeft = new System.Windows.Forms.TextBox();
            this.labelTryLeft = new System.Windows.Forms.Label();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.labelChState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHang)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxHang
            // 
            this.PicBoxHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBoxHang.Location = new System.Drawing.Point(531, 148);
            this.PicBoxHang.Name = "PicBoxHang";
            this.PicBoxHang.Size = new System.Drawing.Size(257, 290);
            this.PicBoxHang.TabIndex = 0;
            this.PicBoxHang.TabStop = false;
            this.PicBoxHang.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxHang_Paint);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(331, 34);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(63, 22);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "<hint>";
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
            this.FlowPanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowPanelButtons.Location = new System.Drawing.Point(12, 210);
            this.FlowPanelButtons.Name = "FlowPanelButtons";
            this.FlowPanelButtons.Size = new System.Drawing.Size(513, 169);
            this.FlowPanelButtons.TabIndex = 3;
            // 
            // labelGLeft
            // 
            this.labelGLeft.AutoSize = true;
            this.labelGLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGLeft.Location = new System.Drawing.Point(8, 165);
            this.labelGLeft.Name = "labelGLeft";
            this.labelGLeft.Size = new System.Drawing.Size(173, 22);
            this.labelGLeft.TabIndex = 4;
            this.labelGLeft.Text = "Caracatere rămase:";
            // 
            // textGLeft
            // 
            this.textGLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGLeft.Enabled = false;
            this.textGLeft.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGLeft.Location = new System.Drawing.Point(187, 171);
            this.textGLeft.Name = "textGLeft";
            this.textGLeft.ReadOnly = true;
            this.textGLeft.Size = new System.Drawing.Size(30, 13);
            this.textGLeft.TabIndex = 5;
            this.textGLeft.Text = "<int>";
            // 
            // textTryLeft
            // 
            this.textTryLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTryLeft.Enabled = false;
            this.textTryLeft.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTryLeft.Location = new System.Drawing.Point(495, 171);
            this.textTryLeft.Name = "textTryLeft";
            this.textTryLeft.ReadOnly = true;
            this.textTryLeft.Size = new System.Drawing.Size(30, 13);
            this.textTryLeft.TabIndex = 7;
            this.textTryLeft.Text = "<int>";
            // 
            // labelTryLeft
            // 
            this.labelTryLeft.AutoSize = true;
            this.labelTryLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTryLeft.Location = new System.Drawing.Point(334, 165);
            this.labelTryLeft.Name = "labelTryLeft";
            this.labelTryLeft.Size = new System.Drawing.Size(155, 22);
            this.labelTryLeft.TabIndex = 6;
            this.labelTryLeft.Text = "Încercări rămase:";
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(187, 385);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(207, 53);
            this.btnGameStart.TabIndex = 8;
            this.btnGameStart.Text = "Începe jocul!";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.BtnGameStart_Click);
            // 
            // labelChState
            // 
            this.labelChState.AutoSize = true;
            this.labelChState.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChState.Location = new System.Drawing.Point(240, 165);
            this.labelChState.Name = "labelChState";
            this.labelChState.Size = new System.Drawing.Size(67, 22);
            this.labelChState.TabIndex = 9;
            this.labelChState.Text = "<state>";
            // 
            // JocSpanzuratoarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChState);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.textTryLeft);
            this.Controls.Add(this.labelTryLeft);
            this.Controls.Add(this.textGLeft);
            this.Controls.Add(this.labelGLeft);
            this.Controls.Add(this.FlowPanelButtons);
            this.Controls.Add(this.groupChars);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.PicBoxHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.GroupBox groupChars;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelButtons;
        private System.Windows.Forms.Label labelGLeft;
        private System.Windows.Forms.TextBox textGLeft;
        private System.Windows.Forms.TextBox textTryLeft;
        private System.Windows.Forms.Label labelTryLeft;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Label labelChState;
    }
}