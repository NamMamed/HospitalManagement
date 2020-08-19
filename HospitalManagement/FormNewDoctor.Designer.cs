namespace HospitalManagement
{
    partial class FormNewDoctor
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
            this.button1 = new System.Windows.Forms.Button();
            this.specific_ = new System.Windows.Forms.TextBox();
            this.fio_doctor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // specific_
            // 
            this.specific_.Location = new System.Drawing.Point(12, 80);
            this.specific_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.specific_.Name = "specific_";
            this.specific_.Size = new System.Drawing.Size(731, 23);
            this.specific_.TabIndex = 12;
            // 
            // fio_doctor
            // 
            this.fio_doctor.Location = new System.Drawing.Point(12, 31);
            this.fio_doctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fio_doctor.Name = "fio_doctor";
            this.fio_doctor.Size = new System.Drawing.Size(734, 23);
            this.fio_doctor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Спецификация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия Имя Отчество";
            // 
            // FormNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specific_);
            this.Controls.Add(this.fio_doctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNewDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДОБАВЛЕНИЕ/РЕДАКТИРВОАНИЕ ДОКТОРА";
            this.Load += new System.EventHandler(this.FormNewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox specific_;
        private System.Windows.Forms.TextBox fio_doctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}