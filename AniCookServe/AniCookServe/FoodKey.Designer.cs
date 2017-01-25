namespace AniCookServe
{
    partial class FoodKey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.foodKeyBackground = new System.Windows.Forms.PictureBox();
            this.foodKeyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodKeyBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientLabel.Location = new System.Drawing.Point(63, 20);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(151, 16);
            this.ingredientLabel.TabIndex = 1;
            this.ingredientLabel.Text = "INGREDIENT GOES HERE";
            // 
            // foodKeyBackground
            // 
            this.foodKeyBackground.BackgroundImage = global::AniCookServe.Properties.Resources.foodKeyBackground;
            this.foodKeyBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodKeyBackground.Location = new System.Drawing.Point(0, 0);
            this.foodKeyBackground.Name = "foodKeyBackground";
            this.foodKeyBackground.Size = new System.Drawing.Size(57, 58);
            this.foodKeyBackground.TabIndex = 2;
            this.foodKeyBackground.TabStop = false;
            // 
            // foodKeyLabel
            // 
            this.foodKeyLabel.AutoSize = true;
            this.foodKeyLabel.BackColor = System.Drawing.Color.Tomato;
            this.foodKeyLabel.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodKeyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.foodKeyLabel.Location = new System.Drawing.Point(15, 18);
            this.foodKeyLabel.Name = "foodKeyLabel";
            this.foodKeyLabel.Size = new System.Drawing.Size(0, 27);
            this.foodKeyLabel.TabIndex = 3;
            // 
            // FoodKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.foodKeyLabel);
            this.Controls.Add(this.foodKeyBackground);
            this.Controls.Add(this.ingredientLabel);
            this.Name = "FoodKey";
            this.Size = new System.Drawing.Size(222, 58);
            ((System.ComponentModel.ISupportInitialize)(this.foodKeyBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ingredientLabel;
        private System.Windows.Forms.PictureBox foodKeyBackground;
        private System.Windows.Forms.Label foodKeyLabel;
    }
}
