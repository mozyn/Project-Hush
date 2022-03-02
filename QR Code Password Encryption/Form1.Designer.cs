namespace QR_Code_Password_Encryption
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BirthMonthSelect = new System.Windows.Forms.NumericUpDown();
            this.BirthDaySelect = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthMonthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDaySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 31);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(87, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save QR";
            this.toolTip1.SetToolTip(this.button3, "Make sure your birth month and day are correct!");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Decrypt QR";
            this.toolTip1.SetToolTip(this.button4, "Make sure your birth month and day are correct!\r\n");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BirthMonthSelect
            // 
            this.BirthMonthSelect.AllowDrop = true;
            this.BirthMonthSelect.Location = new System.Drawing.Point(105, 134);
            this.BirthMonthSelect.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.BirthMonthSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BirthMonthSelect.Name = "BirthMonthSelect";
            this.BirthMonthSelect.Size = new System.Drawing.Size(35, 20);
            this.BirthMonthSelect.TabIndex = 6;
            this.BirthMonthSelect.Tag = "";
            this.toolTip1.SetToolTip(this.BirthMonthSelect, "Please enter your birth month.\r\n");
            this.BirthMonthSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BirthDaySelect
            // 
            this.BirthDaySelect.Location = new System.Drawing.Point(162, 134);
            this.BirthDaySelect.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.BirthDaySelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BirthDaySelect.Name = "BirthDaySelect";
            this.BirthDaySelect.Size = new System.Drawing.Size(35, 20);
            this.BirthDaySelect.TabIndex = 7;
            this.toolTip2.SetToolTip(this.BirthDaySelect, "Please enter your birth day.\r\n");
            this.BirthDaySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 250;
            this.toolTip2.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 138);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDaySelect);
            this.Controls.Add(this.BirthMonthSelect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Hush";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthMonthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDaySelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown BirthMonthSelect;
        private System.Windows.Forms.NumericUpDown BirthDaySelect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
    }
}

