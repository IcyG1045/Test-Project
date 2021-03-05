
namespace Final_Project
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
            this.passfail = new System.Windows.Forms.Label();
            this.numbermissed = new System.Windows.Forms.Label();
            this.incorrectbox = new System.Windows.Forms.Label();
            this.correctbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passfail
            // 
            this.passfail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passfail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passfail.Location = new System.Drawing.Point(419, 106);
            this.passfail.Name = "passfail";
            this.passfail.Size = new System.Drawing.Size(149, 35);
            this.passfail.TabIndex = 0;
            // 
            // numbermissed
            // 
            this.numbermissed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbermissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbermissed.Location = new System.Drawing.Point(419, 252);
            this.numbermissed.Name = "numbermissed";
            this.numbermissed.Size = new System.Drawing.Size(149, 35);
            this.numbermissed.TabIndex = 1;
            // 
            // incorrectbox
            // 
            this.incorrectbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incorrectbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectbox.Location = new System.Drawing.Point(419, 204);
            this.incorrectbox.Name = "incorrectbox";
            this.incorrectbox.Size = new System.Drawing.Size(149, 35);
            this.incorrectbox.TabIndex = 2;
            // 
            // correctbox
            // 
            this.correctbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctbox.Location = new System.Drawing.Point(419, 155);
            this.correctbox.Name = "correctbox";
            this.correctbox.Size = new System.Drawing.Size(149, 35);
            this.correctbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pass or Failed:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of questions missed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of incorect answers:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Number of correct answers:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(306, 326);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(150, 62);
            this.grade.TabIndex = 8;
            this.grade.Text = "Grade";
            this.grade.UseVisualStyleBackColor = true;
            this.grade.Click += new System.EventHandler(this.grade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correctbox);
            this.Controls.Add(this.incorrectbox);
            this.Controls.Add(this.numbermissed);
            this.Controls.Add(this.passfail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passfail;
        private System.Windows.Forms.Label numbermissed;
        private System.Windows.Forms.Label incorrectbox;
        private System.Windows.Forms.Label correctbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button grade;
    }
}

