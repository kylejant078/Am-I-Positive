
namespace Am_I_Positive
{
    partial class amIPositive
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.divisible = new System.Windows.Forms.Label();
            this.positiveNegative = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(59, 79);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(171, 37);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input an integer";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // divisible
            // 
            this.divisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisible.Location = new System.Drawing.Point(61, 275);
            this.divisible.Name = "divisible";
            this.divisible.Size = new System.Drawing.Size(307, 34);
            this.divisible.TabIndex = 1;
            this.divisible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // positiveNegative
            // 
            this.positiveNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveNegative.Location = new System.Drawing.Point(61, 229);
            this.positiveNegative.Name = "positiveNegative";
            this.positiveNegative.Size = new System.Drawing.Size(307, 37);
            this.positiveNegative.TabIndex = 2;
            this.positiveNegative.Tag = "";
            this.positiveNegative.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // integerInput
            // 
            this.integerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerInput.Location = new System.Drawing.Point(268, 85);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 31);
            this.integerInput.TabIndex = 3;
            // 
            // enter
            // 
            this.enter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(268, 142);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 56);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // amIPositive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 365);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.positiveNegative);
            this.Controls.Add(this.divisible);
            this.Controls.Add(this.inputLabel);
            this.Name = "amIPositive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Am I Positive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label divisible;
        private System.Windows.Forms.Label positiveNegative;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button enter;
    }
}

