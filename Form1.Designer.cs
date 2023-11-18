namespace czytnik_kart_magnetycznych
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
            this.buttonGetPin = new System.Windows.Forms.Button();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGetCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetPin
            // 
            this.buttonGetPin.Location = new System.Drawing.Point(46, 239);
            this.buttonGetPin.Name = "buttonGetPin";
            this.buttonGetPin.Size = new System.Drawing.Size(109, 62);
            this.buttonGetPin.TabIndex = 0;
            this.buttonGetPin.Text = "Pin";
            this.buttonGetPin.UseVisualStyleBackColor = true;
            this.buttonGetPin.Click += new System.EventHandler(this.buttonGetPin_Click);
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.Location = new System.Drawing.Point(46, 330);
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(599, 22);
            this.textBoxReceived.TabIndex = 2;
            // 
            // buttonGreen
            // 
            this.buttonGreen.Location = new System.Drawing.Point(46, 121);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(109, 62);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.Text = "Zielona dioda";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Location = new System.Drawing.Point(232, 121);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(107, 61);
            this.buttonYellow.TabIndex = 4;
            this.buttonYellow.Text = "Żółta dioda";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(417, 121);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(107, 61);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.Text = "Czerwona dioda";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGetCard
            // 
            this.buttonGetCard.Location = new System.Drawing.Point(232, 239);
            this.buttonGetCard.Name = "buttonGetCard";
            this.buttonGetCard.Size = new System.Drawing.Size(106, 61);
            this.buttonGetCard.TabIndex = 6;
            this.buttonGetCard.Text = "Karta";
            this.buttonGetCard.UseVisualStyleBackColor = true;
            this.buttonGetCard.Click += new System.EventHandler(this.buttonGetCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 547);
            this.Controls.Add(this.buttonGetCard);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.buttonGetPin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetPin;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGetCard;
    }
}

