namespace HospitalManagement
{
    partial class FormNewClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.blood_type = new System.Windows.Forms.TextBox();
            this.place_of_work = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия Имя Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа крови";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Место работы";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(11, 43);
            this.fio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(734, 23);
            this.fio.TabIndex = 3;
            // 
            // blood_type
            // 
            this.blood_type.Location = new System.Drawing.Point(11, 92);
            this.blood_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blood_type.Name = "blood_type";
            this.blood_type.Size = new System.Drawing.Size(100, 23);
            this.blood_type.TabIndex = 4;
            // 
            // place_of_work
            // 
            this.place_of_work.Location = new System.Drawing.Point(11, 141);
            this.place_of_work.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.place_of_work.Name = "place_of_work";
            this.place_of_work.Size = new System.Drawing.Size(734, 23);
            this.place_of_work.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // date_of_birth
            // 
            this.date_of_birth.Location = new System.Drawing.Point(11, 190);
            this.date_of_birth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(147, 23);
            this.date_of_birth.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.place_of_work);
            this.Controls.Add(this.blood_type);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДОБАВЛЕНИЕ/РЕДАКТИРОВАНИЕ КЛИЕНТА";
            this.Load += new System.EventHandler(this.FormNewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox blood_type;
        private System.Windows.Forms.TextBox place_of_work;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_of_birth;
        private System.Windows.Forms.Button button1;
    }
}