namespace ShapesDemoGUI
{
    partial class Form1
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
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.shapeTextBox = new System.Windows.Forms.TextBox();
            this.newShapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Rectangle",
            "Square",
            "Triangle"});
            this.shapeComboBox.Location = new System.Drawing.Point(13, 13);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeComboBox.TabIndex = 0;
            this.shapeComboBox.Text = "Choose a shape:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(13, 41);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(60, 38);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(74, 20);
            this.heightTextBox.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(13, 66);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(60, 63);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(74, 20);
            this.widthTextBox.TabIndex = 4;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(26, 89);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(84, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create Shape";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // shapeTextBox
            // 
            this.shapeTextBox.Location = new System.Drawing.Point(152, 13);
            this.shapeTextBox.Multiline = true;
            this.shapeTextBox.Name = "shapeTextBox";
            this.shapeTextBox.Size = new System.Drawing.Size(120, 128);
            this.shapeTextBox.TabIndex = 6;
            // 
            // newShapeButton
            // 
            this.newShapeButton.Enabled = false;
            this.newShapeButton.Location = new System.Drawing.Point(26, 118);
            this.newShapeButton.Name = "newShapeButton";
            this.newShapeButton.Size = new System.Drawing.Size(84, 23);
            this.newShapeButton.TabIndex = 7;
            this.newShapeButton.Text = "New Shape";
            this.newShapeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.newShapeButton);
            this.Controls.Add(this.shapeTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.shapeComboBox);
            this.Name = "Form1";
            this.Text = "Shapes Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox shapeTextBox;
        private System.Windows.Forms.Button newShapeButton;
    }
}

