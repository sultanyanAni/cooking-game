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
            this.foodKeyLabel = new System.Windows.Forms.Button();
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodKeyLabel
            // 
            this.foodKeyLabel.Location = new System.Drawing.Point(3, 3);
            this.foodKeyLabel.Name = "foodKeyLabel";
            this.foodKeyLabel.Size = new System.Drawing.Size(75, 67);
            this.foodKeyLabel.TabIndex = 0;
            this.foodKeyLabel.Text = "KEY";
            this.foodKeyLabel.UseVisualStyleBackColor = true;
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Location = new System.Drawing.Point(85, 29);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(140, 13);
            this.ingredientLabel.TabIndex = 1;
            this.ingredientLabel.Text = "INGREDIENT GOES HERE";
            // 
            // FoodKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ingredientLabel);
            this.Controls.Add(this.foodKeyLabel);
            this.Name = "FoodKey";
            this.Size = new System.Drawing.Size(359, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foodKeyLabel;
        private System.Windows.Forms.Label ingredientLabel;
    }
}
