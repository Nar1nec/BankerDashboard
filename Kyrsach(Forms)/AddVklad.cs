using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_Forms_
{
    public partial class AddVklad : Form
    {
        public AddVklad()
        {
            InitializeComponent();
            currency_box.Items.AddRange(new string[] { "$", "€", "₽" });
            currency_box.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            name_of_vklad_box.Items.AddRange(new string[] { "Сберегательный", "Накопительный", "К отпуску" });
            name_of_vklad_box.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = currency_box.SelectedItem.ToString();
        }

        private void Exit_vklad_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_vklad_button_Click(object sender, EventArgs e)
        {
            Form1 main_2 = this.Owner as Form1;
            main_2.Num_2++;
            DataGridViewRow row = new DataGridViewRow();
            main_2.dataGridView2.Rows.Add(row);
            main_2.dataGridView2[0, main_2.Num_2-1].Value = number_of_vklad_box.Text;
            main_2.dataGridView2[1, main_2.Num_2-1].Value = name_of_vklad_box.Text;
            main_2.dataGridView2[2, main_2.Num_2-1].Value = dateTimePicker1.Text;
            main_2.dataGridView2[3, main_2.Num_2-1].Value = dateTimePicker2.Text;
            main_2.dataGridView2[4, main_2.Num_2-1].Value = sum_box.Text;
            main_2.dataGridView2[5, main_2.Num_2-1].Value = procent_box.Text;
            main_2.dataGridView2[7, main_2.Num_2-1].Value = currency_box.Text;
            main_2.dataGridView2[6, main_2.Num_2 - 1].Value = (Convert.ToInt32(sum_box.Text) * (double.Parse(procent_box.Text, System.Globalization.CultureInfo.InvariantCulture) / 100)) + Convert.ToInt32(sum_box.Text);
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = name_of_vklad_box.SelectedItem.ToString();
        }

        private void procent_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,.\b]");
        }

        private void sum_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,.\b]");
        }

        private void sum_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddVklad_Load(object sender, EventArgs e)
        {
            Form1 main_2 = this.Owner as Form1;
            number_of_vklad_box.Text = Convert.ToString(main_2.dataGridView2.Rows.Count + 1);
        }
    }
}
