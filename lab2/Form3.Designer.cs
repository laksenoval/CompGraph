using System.ComponentModel;

namespace lab2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(208, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 212);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(780, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 212);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(493, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab2.Properties.Resources.testPicture;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(208, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Открыть изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "NTSC RGB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 58);
            this.button3.TabIndex = 22;
            this.button3.Text = "sRGB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(208, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Исходная картинка";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(493, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "NTSC RGB";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(780, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "sRGB";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(208, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "Разность";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(494, 293);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(280, 212);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(780, 293);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(280, 212);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(780, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "sRGB";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(493, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 34);
            this.label6.TabIndex = 29;
            this.label6.Text = "NTSC RGB";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 58);
            this.button4.TabIndex = 31;
            this.button4.Text = "Разность";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Task 1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        

        #endregion
    }
}

