
namespace Kyrsach_Forms_
{
    partial class AddVklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVklad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.number_of_vklad_box = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.sum_box = new System.Windows.Forms.TextBox();
            this.procent_box = new System.Windows.Forms.TextBox();
            this.currency_box = new System.Windows.Forms.ComboBox();
            this.Exit_vklad_button = new System.Windows.Forms.Button();
            this.Add_vklad_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name_of_vklad = new System.Windows.Forms.Label();
            this.name_of_vklad_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер вклада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата открытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата закрытия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма вклада";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Процентная ставка";
            // 
            // number_of_vklad_box
            // 
            this.number_of_vklad_box.Location = new System.Drawing.Point(231, 49);
            this.number_of_vklad_box.Name = "number_of_vklad_box";
            this.number_of_vklad_box.ReadOnly = true;
            this.number_of_vklad_box.Size = new System.Drawing.Size(32, 31);
            this.number_of_vklad_box.TabIndex = 6;
            this.number_of_vklad_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procent_box_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Валюта";
            // 
            // sum_box
            // 
            this.sum_box.Location = new System.Drawing.Point(231, 251);
            this.sum_box.Name = "sum_box";
            this.sum_box.Size = new System.Drawing.Size(129, 31);
            this.sum_box.TabIndex = 10;
            this.sum_box.TextChanged += new System.EventHandler(this.sum_box_TextChanged);
            this.sum_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sum_box_KeyPress);
            // 
            // procent_box
            // 
            this.procent_box.Location = new System.Drawing.Point(231, 303);
            this.procent_box.Name = "procent_box";
            this.procent_box.Size = new System.Drawing.Size(46, 31);
            this.procent_box.TabIndex = 11;
            this.procent_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procent_box_KeyPress);
            // 
            // currency_box
            // 
            this.currency_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency_box.FormattingEnabled = true;
            this.currency_box.Location = new System.Drawing.Point(231, 351);
            this.currency_box.Name = "currency_box";
            this.currency_box.Size = new System.Drawing.Size(67, 33);
            this.currency_box.TabIndex = 14;
            this.currency_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Exit_vklad_button
            // 
            this.Exit_vklad_button.Location = new System.Drawing.Point(29, 416);
            this.Exit_vklad_button.Name = "Exit_vklad_button";
            this.Exit_vklad_button.Size = new System.Drawing.Size(131, 46);
            this.Exit_vklad_button.TabIndex = 15;
            this.Exit_vklad_button.Text = "Выход";
            this.Exit_vklad_button.UseVisualStyleBackColor = true;
            this.Exit_vklad_button.Click += new System.EventHandler(this.Exit_vklad_button_Click);
            // 
            // Add_vklad_button
            // 
            this.Add_vklad_button.Location = new System.Drawing.Point(296, 416);
            this.Add_vklad_button.Name = "Add_vklad_button";
            this.Add_vklad_button.Size = new System.Drawing.Size(135, 46);
            this.Add_vklad_button.TabIndex = 16;
            this.Add_vklad_button.Text = "Добавить";
            this.Add_vklad_button.UseVisualStyleBackColor = true;
            this.Add_vklad_button.Click += new System.EventHandler(this.Add_vklad_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "%";
            // 
            // name_of_vklad
            // 
            this.name_of_vklad.AutoSize = true;
            this.name_of_vklad.Location = new System.Drawing.Point(29, 101);
            this.name_of_vklad.Name = "name_of_vklad";
            this.name_of_vklad.Size = new System.Drawing.Size(196, 25);
            this.name_of_vklad.TabIndex = 18;
            this.name_of_vklad.Text = "Наименование вклада";
            // 
            // name_of_vklad_box
            // 
            this.name_of_vklad_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_of_vklad_box.FormattingEnabled = true;
            this.name_of_vklad_box.Location = new System.Drawing.Point(231, 101);
            this.name_of_vklad_box.Name = "name_of_vklad_box";
            this.name_of_vklad_box.Size = new System.Drawing.Size(182, 33);
            this.name_of_vklad_box.TabIndex = 19;
            this.name_of_vklad_box.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AddVklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 518);
            this.Controls.Add(this.name_of_vklad_box);
            this.Controls.Add(this.name_of_vklad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add_vklad_button);
            this.Controls.Add(this.Exit_vklad_button);
            this.Controls.Add(this.currency_box);
            this.Controls.Add(this.procent_box);
            this.Controls.Add(this.sum_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.number_of_vklad_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddVklad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый вклад";
            this.Load += new System.EventHandler(this.AddVklad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox number_of_vklad_box;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sum_box;
        private System.Windows.Forms.TextBox procent_box;
        private System.Windows.Forms.ComboBox currency_box;
        private System.Windows.Forms.Button Exit_vklad_button;
        private System.Windows.Forms.Button Add_vklad_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name_of_vklad;
        private System.Windows.Forms.ComboBox name_of_vklad_box;
    }
}