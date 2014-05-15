namespace ColorSort
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
            this.Draw_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.redCheck = new System.Windows.Forms.CheckBox();
            this.greenCheck = new System.Windows.Forms.CheckBox();
            this.blueCheck = new System.Windows.Forms.CheckBox();
            this.ranRedCheck = new System.Windows.Forms.CheckBox();
            this.ranGreenCheck = new System.Windows.Forms.CheckBox();
            this.ranBlueCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Draw_button
            // 
            this.Draw_button.Location = new System.Drawing.Point(474, 12);
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.Size = new System.Drawing.Size(75, 23);
            this.Draw_button.TabIndex = 0;
            this.Draw_button.Text = "Draw";
            this.Draw_button.UseVisualStyleBackColor = true;
            this.Draw_button.Click += new System.EventHandler(this.Draw_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // redCheck
            // 
            this.redCheck.AutoSize = true;
            this.redCheck.Location = new System.Drawing.Point(474, 68);
            this.redCheck.Name = "redCheck";
            this.redCheck.Size = new System.Drawing.Size(46, 17);
            this.redCheck.TabIndex = 2;
            this.redCheck.Text = "Red";
            this.redCheck.UseVisualStyleBackColor = true;
            this.redCheck.CheckedChanged += new System.EventHandler(this.redCheck_CheckedChanged);
            // 
            // greenCheck
            // 
            this.greenCheck.AutoSize = true;
            this.greenCheck.Location = new System.Drawing.Point(474, 91);
            this.greenCheck.Name = "greenCheck";
            this.greenCheck.Size = new System.Drawing.Size(55, 17);
            this.greenCheck.TabIndex = 3;
            this.greenCheck.Text = "Green";
            this.greenCheck.UseVisualStyleBackColor = true;
            this.greenCheck.CheckedChanged += new System.EventHandler(this.greenCheck_CheckedChanged);
            // 
            // blueCheck
            // 
            this.blueCheck.AutoSize = true;
            this.blueCheck.Location = new System.Drawing.Point(474, 114);
            this.blueCheck.Name = "blueCheck";
            this.blueCheck.Size = new System.Drawing.Size(47, 17);
            this.blueCheck.TabIndex = 4;
            this.blueCheck.Text = "Blue";
            this.blueCheck.UseVisualStyleBackColor = true;
            this.blueCheck.CheckedChanged += new System.EventHandler(this.blueCheck_CheckedChanged);
            // 
            // ranRedCheck
            // 
            this.ranRedCheck.AutoSize = true;
            this.ranRedCheck.Location = new System.Drawing.Point(526, 67);
            this.ranRedCheck.Name = "ranRedCheck";
            this.ranRedCheck.Size = new System.Drawing.Size(66, 17);
            this.ranRedCheck.TabIndex = 5;
            this.ranRedCheck.Text = "Random";
            this.ranRedCheck.UseVisualStyleBackColor = true;
            this.ranRedCheck.CheckedChanged += new System.EventHandler(this.ranCheck_CheckedChanged);
            // 
            // ranGreenCheck
            // 
            this.ranGreenCheck.AutoSize = true;
            this.ranGreenCheck.Location = new System.Drawing.Point(526, 91);
            this.ranGreenCheck.Name = "ranGreenCheck";
            this.ranGreenCheck.Size = new System.Drawing.Size(66, 17);
            this.ranGreenCheck.TabIndex = 6;
            this.ranGreenCheck.Text = "Random";
            this.ranGreenCheck.UseVisualStyleBackColor = true;
            // 
            // ranBlueCheck
            // 
            this.ranBlueCheck.AutoSize = true;
            this.ranBlueCheck.Location = new System.Drawing.Point(526, 114);
            this.ranBlueCheck.Name = "ranBlueCheck";
            this.ranBlueCheck.Size = new System.Drawing.Size(66, 17);
            this.ranBlueCheck.TabIndex = 7;
            this.ranBlueCheck.Text = "Random";
            this.ranBlueCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 257);
            this.Controls.Add(this.ranBlueCheck);
            this.Controls.Add(this.ranGreenCheck);
            this.Controls.Add(this.ranRedCheck);
            this.Controls.Add(this.blueCheck);
            this.Controls.Add(this.greenCheck);
            this.Controls.Add(this.redCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Draw_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox redCheck;
        private System.Windows.Forms.CheckBox greenCheck;
        private System.Windows.Forms.CheckBox blueCheck;
        private System.Windows.Forms.CheckBox ranRedCheck;
        private System.Windows.Forms.CheckBox ranGreenCheck;
        private System.Windows.Forms.CheckBox ranBlueCheck;
    }
}

