namespace EconomyTracker
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
            this.fondTextbox = new System.Windows.Forms.TextBox();
            this.enkelTextbox = new System.Windows.Forms.TextBox();
            this.spekulasjonTextbox = new System.Windows.Forms.TextBox();
            this.fondLabel = new System.Windows.Forms.Label();
            this.enkelLabel = new System.Windows.Forms.Label();
            this.spekulasjonLabel = new System.Windows.Forms.Label();
            this.cryptoLabel = new System.Windows.Forms.Label();
            this.cryptoTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fondTextbox
            // 
            this.fondTextbox.Location = new System.Drawing.Point(22, 47);
            this.fondTextbox.Name = "fondTextbox";
            this.fondTextbox.Size = new System.Drawing.Size(100, 20);
            this.fondTextbox.TabIndex = 0;
            // 
            // enkelTextbox
            // 
            this.enkelTextbox.Location = new System.Drawing.Point(22, 101);
            this.enkelTextbox.Name = "enkelTextbox";
            this.enkelTextbox.Size = new System.Drawing.Size(100, 20);
            this.enkelTextbox.TabIndex = 1;
            // 
            // spekulasjonTextbox
            // 
            this.spekulasjonTextbox.Location = new System.Drawing.Point(22, 160);
            this.spekulasjonTextbox.Name = "spekulasjonTextbox";
            this.spekulasjonTextbox.Size = new System.Drawing.Size(100, 20);
            this.spekulasjonTextbox.TabIndex = 2;
            // 
            // fondLabel
            // 
            this.fondLabel.AutoSize = true;
            this.fondLabel.Location = new System.Drawing.Point(19, 31);
            this.fondLabel.Name = "fondLabel";
            this.fondLabel.Size = new System.Drawing.Size(54, 13);
            this.fondLabel.TabIndex = 3;
            this.fondLabel.Text = "Aksjefond";
            // 
            // enkelLabel
            // 
            this.enkelLabel.AutoSize = true;
            this.enkelLabel.Location = new System.Drawing.Point(22, 85);
            this.enkelLabel.Name = "enkelLabel";
            this.enkelLabel.Size = new System.Drawing.Size(65, 13);
            this.enkelLabel.TabIndex = 4;
            this.enkelLabel.Text = "Enkeltaksjer";
            // 
            // spekulasjonLabel
            // 
            this.spekulasjonLabel.AutoSize = true;
            this.spekulasjonLabel.Location = new System.Drawing.Point(22, 144);
            this.spekulasjonLabel.Name = "spekulasjonLabel";
            this.spekulasjonLabel.Size = new System.Drawing.Size(65, 13);
            this.spekulasjonLabel.TabIndex = 5;
            this.spekulasjonLabel.Text = "Spekulasjon";
            // 
            // cryptoLabel
            // 
            this.cryptoLabel.AutoSize = true;
            this.cryptoLabel.Location = new System.Drawing.Point(22, 199);
            this.cryptoLabel.Name = "cryptoLabel";
            this.cryptoLabel.Size = new System.Drawing.Size(37, 13);
            this.cryptoLabel.TabIndex = 6;
            this.cryptoLabel.Text = "Crypto";
            // 
            // cryptoTextbox
            // 
            this.cryptoTextbox.Location = new System.Drawing.Point(22, 215);
            this.cryptoTextbox.Name = "cryptoTextbox";
            this.cryptoTextbox.Size = new System.Drawing.Size(100, 20);
            this.cryptoTextbox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(22, 262);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Kalkuler";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 430);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cryptoTextbox);
            this.Controls.Add(this.cryptoLabel);
            this.Controls.Add(this.spekulasjonLabel);
            this.Controls.Add(this.enkelLabel);
            this.Controls.Add(this.fondLabel);
            this.Controls.Add(this.spekulasjonTextbox);
            this.Controls.Add(this.enkelTextbox);
            this.Controls.Add(this.fondTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fondTextbox;
        private System.Windows.Forms.TextBox enkelTextbox;
        private System.Windows.Forms.TextBox spekulasjonTextbox;
        private System.Windows.Forms.Label fondLabel;
        private System.Windows.Forms.Label enkelLabel;
        private System.Windows.Forms.Label spekulasjonLabel;
        private System.Windows.Forms.Label cryptoLabel;
        private System.Windows.Forms.TextBox cryptoTextbox;
        private System.Windows.Forms.Button calculateButton;
    }
}

