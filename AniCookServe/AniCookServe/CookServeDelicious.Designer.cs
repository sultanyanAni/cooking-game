namespace AniCookServe
{
    partial class CookServeDelicious
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.keyGuideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(12, 476);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(266, 42);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "ORDER GOES HERE";
            // 
            // keyGuideLabel
            // 
            this.keyGuideLabel.AutoSize = true;
            this.keyGuideLabel.Location = new System.Drawing.Point(942, 13);
            this.keyGuideLabel.Name = "keyGuideLabel";
            this.keyGuideLabel.Size = new System.Drawing.Size(144, 13);
            this.keyGuideLabel.TabIndex = 4;
            this.keyGuideLabel.Text = "KEYS TO PRESS GO HERE";
            // 
            // CookServeDelicious
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 593);
            this.Controls.Add(this.keyGuideLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Name = "CookServeDelicious";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label keyGuideLabel;
    }
}

