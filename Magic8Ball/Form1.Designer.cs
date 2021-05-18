
namespace Magic8Ball
{
    partial class eightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eightBall));
            this.titleLabel = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 34);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Think of a Question";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.ForeColor = System.Drawing.Color.Transparent;
            this.button.Location = new System.Drawing.Point(90, 95);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(253, 214);
            this.button.TabIndex = 1;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 387);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(412, 37);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magic8Ball.Properties.Resources.clickBall1;
            this.ClientSize = new System.Drawing.Size(436, 433);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eightBall";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label answerLabel;
    }
}

