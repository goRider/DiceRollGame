namespace CrapsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.pbDice3 = new System.Windows.Forms.PictureBox();
            this.pbDice4 = new System.Windows.Forms.PictureBox();
            this.pbDice5 = new System.Windows.Forms.PictureBox();
            this.pbDice6 = new System.Windows.Forms.PictureBox();
            this.pbDiceShow1 = new System.Windows.Forms.PictureBox();
            this.pbDiceShow2 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice1
            // 
            this.pbDice1.Image = ((System.Drawing.Image)(resources.GetObject("pbDice1.Image")));
            this.pbDice1.Location = new System.Drawing.Point(43, 28);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(100, 100);
            this.pbDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice1.TabIndex = 0;
            this.pbDice1.TabStop = false;
            // 
            // pbDice2
            // 
            this.pbDice2.Image = ((System.Drawing.Image)(resources.GetObject("pbDice2.Image")));
            this.pbDice2.Location = new System.Drawing.Point(149, 28);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(100, 100);
            this.pbDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice2.TabIndex = 0;
            this.pbDice2.TabStop = false;
            // 
            // pbDice3
            // 
            this.pbDice3.Image = ((System.Drawing.Image)(resources.GetObject("pbDice3.Image")));
            this.pbDice3.Location = new System.Drawing.Point(255, 28);
            this.pbDice3.Name = "pbDice3";
            this.pbDice3.Size = new System.Drawing.Size(100, 100);
            this.pbDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice3.TabIndex = 0;
            this.pbDice3.TabStop = false;
            // 
            // pbDice4
            // 
            this.pbDice4.Image = ((System.Drawing.Image)(resources.GetObject("pbDice4.Image")));
            this.pbDice4.Location = new System.Drawing.Point(361, 28);
            this.pbDice4.Name = "pbDice4";
            this.pbDice4.Size = new System.Drawing.Size(100, 100);
            this.pbDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice4.TabIndex = 0;
            this.pbDice4.TabStop = false;
            // 
            // pbDice5
            // 
            this.pbDice5.Image = ((System.Drawing.Image)(resources.GetObject("pbDice5.Image")));
            this.pbDice5.Location = new System.Drawing.Point(467, 28);
            this.pbDice5.Name = "pbDice5";
            this.pbDice5.Size = new System.Drawing.Size(100, 100);
            this.pbDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice5.TabIndex = 0;
            this.pbDice5.TabStop = false;
            // 
            // pbDice6
            // 
            this.pbDice6.Image = ((System.Drawing.Image)(resources.GetObject("pbDice6.Image")));
            this.pbDice6.Location = new System.Drawing.Point(573, 28);
            this.pbDice6.Name = "pbDice6";
            this.pbDice6.Size = new System.Drawing.Size(100, 100);
            this.pbDice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice6.TabIndex = 0;
            this.pbDice6.TabStop = false;
            // 
            // pbDiceShow1
            // 
            this.pbDiceShow1.Location = new System.Drawing.Point(43, 146);
            this.pbDiceShow1.Name = "pbDiceShow1";
            this.pbDiceShow1.Size = new System.Drawing.Size(312, 312);
            this.pbDiceShow1.TabIndex = 1;
            this.pbDiceShow1.TabStop = false;
            // 
            // pbDiceShow2
            // 
            this.pbDiceShow2.Location = new System.Drawing.Point(361, 146);
            this.pbDiceShow2.Name = "pbDiceShow2";
            this.pbDiceShow2.Size = new System.Drawing.Size(312, 312);
            this.pbDiceShow2.TabIndex = 1;
            this.pbDiceShow2.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(825, 28);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(151, 57);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Roll";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(825, 146);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 47);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 498);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pbDiceShow2);
            this.Controls.Add(this.pbDiceShow1);
            this.Controls.Add(this.pbDice6);
            this.Controls.Add(this.pbDice5);
            this.Controls.Add(this.pbDice4);
            this.Controls.Add(this.pbDice3);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.pbDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.PictureBox pbDice3;
        private System.Windows.Forms.PictureBox pbDice4;
        private System.Windows.Forms.PictureBox pbDice5;
        private System.Windows.Forms.PictureBox pbDice6;
        private System.Windows.Forms.PictureBox pbDiceShow1;
        private System.Windows.Forms.PictureBox pbDiceShow2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button Exit;
    }
}

