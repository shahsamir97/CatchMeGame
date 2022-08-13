namespace CatchMeGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstLife = new System.Windows.Forms.PictureBox();
            this.thirdLife = new System.Windows.Forms.PictureBox();
            this.secLife = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jerry = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secLife)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jerry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.firstLife);
            this.panel1.Controls.Add(this.thirdLife);
            this.panel1.Controls.Add(this.secLife);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SLabel);
            this.panel1.Location = new System.Drawing.Point(12, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 65);
            this.panel1.TabIndex = 1;
            // 
            // firstLife
            // 
            this.firstLife.Image = global::CatchMeGame.Properties.Resources._276105859011211;
            this.firstLife.Location = new System.Drawing.Point(608, 5);
            this.firstLife.Name = "firstLife";
            this.firstLife.Size = new System.Drawing.Size(51, 48);
            this.firstLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstLife.TabIndex = 8;
            this.firstLife.TabStop = false;
            // 
            // thirdLife
            // 
            this.thirdLife.Image = global::CatchMeGame.Properties.Resources._276105859011211;
            this.thirdLife.Location = new System.Drawing.Point(493, 5);
            this.thirdLife.Name = "thirdLife";
            this.thirdLife.Size = new System.Drawing.Size(51, 48);
            this.thirdLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdLife.TabIndex = 7;
            this.thirdLife.TabStop = false;
            // 
            // secLife
            // 
            this.secLife.Image = global::CatchMeGame.Properties.Resources._276105859011211;
            this.secLife.Location = new System.Drawing.Point(550, 5);
            this.secLife.Name = "secLife";
            this.secLife.Size = new System.Drawing.Size(52, 48);
            this.secLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secLife.TabIndex = 6;
            this.secLife.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(111, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(47, 32);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "00";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.SaddleBrown;
            this.time.Location = new System.Drawing.Point(523, 20);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // SLabel
            // 
            this.SLabel.AutoSize = true;
            this.SLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLabel.ForeColor = System.Drawing.Color.Black;
            this.SLabel.Location = new System.Drawing.Point(13, 13);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(108, 32);
            this.SLabel.TabIndex = 0;
            this.SLabel.Text = "Score :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.jerry);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 355);
            this.panel2.TabIndex = 5;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // jerry
            // 
            this.jerry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jerry.Image = global::CatchMeGame.Properties.Resources.jerry_logo;
            this.jerry.Location = new System.Drawing.Point(21, 14);
            this.jerry.Name = "jerry";
            this.jerry.Size = new System.Drawing.Size(86, 101);
            this.jerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jerry.TabIndex = 1;
            this.jerry.TabStop = false;
            this.jerry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.jerry_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(687, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Playing Catch Me";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secLife)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jerry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox jerry;
        private System.Windows.Forms.PictureBox secLife;
        private System.Windows.Forms.PictureBox firstLife;
        private System.Windows.Forms.PictureBox thirdLife;
    }
}

