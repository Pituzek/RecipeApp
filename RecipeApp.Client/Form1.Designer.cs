
namespace RecipeApp.Client
{
    partial class RecipeApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SiUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.CookingUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceRichTextBox
            // 
            this.SourceRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.SourceRichTextBox.Name = "SourceRichTextBox";
            this.SourceRichTextBox.Size = new System.Drawing.Size(210, 284);
            this.SourceRichTextBox.TabIndex = 0;
            this.SourceRichTextBox.Text = "";
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultRichTextBox.Location = new System.Drawing.Point(340, 12);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(208, 284);
            this.ResultRichTextBox.TabIndex = 1;
            this.ResultRichTextBox.Text = "";
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(228, 115);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Location = new System.Drawing.Point(228, 145);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(106, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CookingUnitsRadioButton);
            this.groupBox1.Controls.Add(this.SiUnitsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(221, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SiUnitsRadioButton
            // 
            this.SiUnitsRadioButton.AutoSize = true;
            this.SiUnitsRadioButton.Checked = true;
            this.SiUnitsRadioButton.Location = new System.Drawing.Point(8, 13);
            this.SiUnitsRadioButton.Name = "SiUnitsRadioButton";
            this.SiUnitsRadioButton.Size = new System.Drawing.Size(64, 19);
            this.SiUnitsRadioButton.TabIndex = 0;
            this.SiUnitsRadioButton.TabStop = true;
            this.SiUnitsRadioButton.Text = "SI Units";
            this.SiUnitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // CookingUnitsRadioButton
            // 
            this.CookingUnitsRadioButton.AutoSize = true;
            this.CookingUnitsRadioButton.Location = new System.Drawing.Point(8, 38);
            this.CookingUnitsRadioButton.Name = "CookingUnitsRadioButton";
            this.CookingUnitsRadioButton.Size = new System.Drawing.Size(100, 19);
            this.CookingUnitsRadioButton.TabIndex = 1;
            this.CookingUnitsRadioButton.Text = "Cooking Units";
            this.CookingUnitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecipeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.SourceRichTextBox);
            this.MinimumSize = new System.Drawing.Size(576, 389);
            this.Name = "RecipeApp";
            this.Text = "RecipeApp v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SourceRichTextBox;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CookingUnitsRadioButton;
        private System.Windows.Forms.RadioButton SiUnitsRadioButton;
    }
}

