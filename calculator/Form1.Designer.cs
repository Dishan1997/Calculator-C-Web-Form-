namespace calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.onopPerf = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(358, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.White;
            this.n1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(16, 361);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(85, 62);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.White;
            this.n4.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(16, 293);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(85, 62);
            this.n4.TabIndex = 2;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n1_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.White;
            this.n3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(198, 361);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(85, 62);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.White;
            this.n2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(107, 361);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(85, 62);
            this.n2.TabIndex = 4;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n1_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.White;
            this.n8.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(107, 225);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(85, 62);
            this.n8.TabIndex = 5;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n1_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.White;
            this.n6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(198, 293);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(85, 62);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n1_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.White;
            this.n5.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(107, 293);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(85, 62);
            this.n5.TabIndex = 7;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n1_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.White;
            this.n9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(198, 225);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(85, 62);
            this.n9.TabIndex = 8;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n1_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.White;
            this.n7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(16, 225);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(85, 62);
            this.n7.TabIndex = 9;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n1_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.White;
            this.n0.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(107, 429);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(85, 62);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n1_Click);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.Color.White;
            this.bdot.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdot.Location = new System.Drawing.Point(198, 429);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(85, 62);
            this.bdot.TabIndex = 11;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.n1_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bc.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc.Location = new System.Drawing.Point(198, 157);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(85, 62);
            this.bc.TabIndex = 12;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bad.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad.Location = new System.Drawing.Point(289, 361);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(85, 62);
            this.bad.TabIndex = 13;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = false;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bsub.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.Location = new System.Drawing.Point(289, 293);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(85, 62);
            this.bsub.TabIndex = 14;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bad_Click);
            // 
            // bmul
            // 
            this.bmul.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bmul.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmul.Location = new System.Drawing.Point(289, 225);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(85, 62);
            this.bmul.TabIndex = 15;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = false;
            this.bmul.Click += new System.EventHandler(this.bad_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bdiv.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.Location = new System.Drawing.Point(289, 157);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(85, 62);
            this.bdiv.TabIndex = 16;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bad_Click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bequal.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequal.Location = new System.Drawing.Point(289, 429);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(85, 62);
            this.bequal.TabIndex = 17;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 62);
            this.button2.TabIndex = 19;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bad_Click);
            // 
            // onopPerf
            // 
            this.onopPerf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onopPerf.AutoSize = true;
            this.onopPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onopPerf.Location = new System.Drawing.Point(282, 49);
            this.onopPerf.Name = "onopPerf";
            this.onopPerf.Size = new System.Drawing.Size(0, 33);
            this.onopPerf.TabIndex = 22;
            this.onopPerf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 62);
            this.button3.TabIndex = 23;
            this.button3.Text = "+/-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(391, 503);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.onopPerf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label onopPerf;
        private System.Windows.Forms.Button button3;
    }
}

