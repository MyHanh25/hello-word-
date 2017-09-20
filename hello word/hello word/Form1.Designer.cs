namespace hello_word
{
    partial class frmhelloword
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
            this.lblHelloWord = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWord
            // 
            this.lblHelloWord.AutoSize = true;
            this.lblHelloWord.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWord.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWord.Location = new System.Drawing.Point(12, 95);
            this.lblHelloWord.Name = "lblHelloWord";
            this.lblHelloWord.Size = new System.Drawing.Size(0, 80);
            this.lblHelloWord.TabIndex = 0;
            this.lblHelloWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(77, 235);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(201, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "ShowHelloWord";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmhelloword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHelloWord);
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmhelloword";
            this.Text = "hello word";
            this.Load += new System.EventHandler(this.frmhelloword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWord;
        private System.Windows.Forms.Button btnShow;

    }
}

