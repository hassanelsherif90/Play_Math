namespace Play_Math
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nu_NumberQuestion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBQuize_Level = new System.Windows.Forms.ComboBox();
            this.CBOperation_Type = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStartQuize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nu_NumberQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Questions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nu_NumberQuestion
            // 
            this.Nu_NumberQuestion.AutoSize = true;
            this.Nu_NumberQuestion.BackColor = System.Drawing.Color.White;
            this.Nu_NumberQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nu_NumberQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nu_NumberQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nu_NumberQuestion.Location = new System.Drawing.Point(453, 102);
            this.Nu_NumberQuestion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Nu_NumberQuestion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nu_NumberQuestion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nu_NumberQuestion.Name = "Nu_NumberQuestion";
            this.Nu_NumberQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Nu_NumberQuestion.Size = new System.Drawing.Size(105, 45);
            this.Nu_NumberQuestion.TabIndex = 1;
            this.Nu_NumberQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nu_NumberQuestion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nu_NumberQuestion.ValueChanged += new System.EventHandler(this.Nu_NumberQuestion_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quize Level";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operation Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number Of Nummbers In Questions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBQuize_Level
            // 
            this.CBQuize_Level.BackColor = System.Drawing.Color.White;
            this.CBQuize_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBQuize_Level.FormattingEnabled = true;
            this.CBQuize_Level.Location = new System.Drawing.Point(274, 183);
            this.CBQuize_Level.Name = "CBQuize_Level";
            this.CBQuize_Level.Size = new System.Drawing.Size(285, 33);
            this.CBQuize_Level.TabIndex = 5;
            this.CBQuize_Level.SelectedIndexChanged += new System.EventHandler(this.CBQuize_Level_SelectedIndexChanged);
            // 
            // CBOperation_Type
            // 
            this.CBOperation_Type.BackColor = System.Drawing.Color.White;
            this.CBOperation_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOperation_Type.FormattingEnabled = true;
            this.CBOperation_Type.Location = new System.Drawing.Point(274, 247);
            this.CBOperation_Type.Name = "CBOperation_Type";
            this.CBOperation_Type.Size = new System.Drawing.Size(285, 33);
            this.CBOperation_Type.TabIndex = 6;
            this.CBOperation_Type.SelectedIndexChanged += new System.EventHandler(this.CBOperation_Type_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(453, 318);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(105, 45);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStartQuize
            // 
            this.btnStartQuize.BackColor = System.Drawing.Color.White;
            this.btnStartQuize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuize.Location = new System.Drawing.Point(364, 457);
            this.btnStartQuize.Name = "btnStartQuize";
            this.btnStartQuize.Size = new System.Drawing.Size(228, 78);
            this.btnStartQuize.TabIndex = 8;
            this.btnStartQuize.Text = "StartQuize";
            this.btnStartQuize.UseVisualStyleBackColor = false;
            this.btnStartQuize.Click += new System.EventHandler(this.btnStartQuize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Play_Math.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 576);
            this.Controls.Add(this.btnStartQuize);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CBOperation_Type);
            this.Controls.Add(this.CBQuize_Level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nu_NumberQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nu_NumberQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nu_NumberQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBQuize_Level;
        private System.Windows.Forms.ComboBox CBOperation_Type;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStartQuize;
    }
}

