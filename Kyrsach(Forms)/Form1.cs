using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Kyrsach_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Поиск...";
            poisk_vklad.Text = "Поиск...";
            textBox1.ForeColor = Color.Black;
            openFileDialog1.Filter = "text files(*.txt)|*.txt";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public int Num = 0;
        public int Num_2 = 0;
        private void delete_click(object sender, EventArgs e)
        {
            Num--;
            //Num_2--;
            int number = dataGridView1.CurrentRow.Index;
            //int number_2 = dataGridView2.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            for (int i = number;i < dataGridView1.Rows.Count ; i++)
            {
                dataGridView1[0, i].Value = i + 1;
            }
            //for (int i = number_2; i < dataGridView2.Rows.Count; i++)
            //{
            //    dataGridView2[0, i].Value = i + 1;
            //}
        }
        private void delete_click_vklad(object sender, EventArgs e)
        {
            Num_2--;
            int number = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            for (int i = number; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2[0, i].Value = i + 1;
            }
        }
        
        Vklad vklad = new Vklad();
        private void copy_click_vklad(object sender, EventArgs e)
        {
            vklad.Name_vklad = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
            vklad.Date_open = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            vklad.Date_close = dataGridView2[3, dataGridView2.CurrentRow.Index].Value.ToString();
            vklad.sum = dataGridView2[4, dataGridView2.CurrentRow.Index].Value.ToString();

            vklad.Procent = dataGridView2[5, dataGridView2.CurrentRow.Index].Value.ToString();
            vklad.deposit_status = dataGridView2[6, dataGridView2.CurrentRow.Index].Value.ToString();
            vklad.Currency = dataGridView2[7, dataGridView2.CurrentRow.Index].Value.ToString();
        }
        private void paste_click_vklad(object sender, EventArgs e)
        {
            dataGridView2[0, dataGridView2.CurrentRow.Index].Value = dataGridView2.Rows.Count;
            dataGridView2[1, dataGridView2.CurrentRow.Index].Value = vklad.Name_vklad;
            dataGridView2[2, dataGridView2.CurrentRow.Index].Value = vklad.Date_open;
            dataGridView2[3, dataGridView2.CurrentRow.Index].Value = vklad.Date_close;

            dataGridView2[4, dataGridView2.CurrentRow.Index].Value = vklad.sum;
            dataGridView2[5, dataGridView2.CurrentRow.Index].Value = vklad.Procent;

            dataGridView2[6, dataGridView2.CurrentRow.Index].Value = vklad.deposit_status;


            dataGridView2[7, dataGridView2.CurrentRow.Index].Value = vklad.Currency;
        }

        static Client client = new Client();
        private void copy_click(object sender, EventArgs e)
        {
            

            client.Surname = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            client.Name = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            client.Patronomic = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            client.Telephone_number = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();

            client.Series = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            client.Number_pass = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();

            client.Date_Birth = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            

            client.Address = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
           

        }
        private void paste_click(object sender, EventArgs e)
        {
            dataGridView1[0, dataGridView1.CurrentRow.Index].Value = dataGridView1.Rows.Count;
            dataGridView1[1, dataGridView1.CurrentRow.Index].Value = client.Surname;
            dataGridView1[2, dataGridView1.CurrentRow.Index].Value = client.Name;
            dataGridView1[3, dataGridView1.CurrentRow.Index].Value = client.Patronomic;

            dataGridView1[4, dataGridView1.CurrentRow.Index].Value = client.Series;
            dataGridView1[5, dataGridView1.CurrentRow.Index].Value = client.Number_pass;

            dataGridView1[6, dataGridView1.CurrentRow.Index].Value = client.Date_Birth;
            

            dataGridView1[7, dataGridView1.CurrentRow.Index].Value = client.Address;
            
            dataGridView1[8, dataGridView1.CurrentRow.Index].Value = client.Telephone_number;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            AddClient ac = new AddClient();
            ac.Owner = this;
            ac.Show();
            //DataGridViewRow row = new DataGridViewRow();
            //dataGridView1.Rows.Add(row);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadToolStripMenuItem_Click(new object(), new EventArgs());
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ContextMenuStrip contextMenuStrip2 = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("Удалить строку");
            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Копировать строку");
            ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("Вставить строку");
            ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem("Удалить строку");
            ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem("Копировать строку");
            ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem("Вставить строку");
            contextMenuStrip1.Items.Add(toolStripMenuItem1);
            contextMenuStrip1.Items.Add(toolStripMenuItem2);
            contextMenuStrip1.Items.Add(toolStripMenuItem3);
            contextMenuStrip2.Items.Add(toolStripMenuItem4);
            contextMenuStrip2.Items.Add(toolStripMenuItem5);
            contextMenuStrip2.Items.Add(toolStripMenuItem6);
            toolStripMenuItem1.Click += delete_click;
            toolStripMenuItem2.Click += copy_click;
            toolStripMenuItem3.Click += paste_click;
            toolStripMenuItem4.Click += delete_click_vklad;
            toolStripMenuItem5.Click += copy_click_vklad;
            toolStripMenuItem6.Click += paste_click_vklad;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView2.ContextMenuStrip = contextMenuStrip2;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Поиск...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поиск...";
                textBox1.ForeColor = Color.Gray;
            }
        
        }
        private void SaveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            File.WriteAllText(saveFileDialog1.FileName, string.Empty);
            Client client = new Client();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
               
                client.Surname = dataGridView1[1, i].Value.ToString();
                client.Name = dataGridView1[2, i].Value.ToString();
                client.Patronomic = dataGridView1[3, i].Value.ToString();
                client.Series = dataGridView1[4, i].Value.ToString();
                client.Number_pass = dataGridView1[5, i].Value.ToString();
                client.Date_Birth = dataGridView1[6, i].Value.ToString();
                
                client.Address = dataGridView1[7, i].Value.ToString();
                
                client.Telephone_number = dataGridView1[8, i].Value.ToString();
                WriteDataClient(client);
            }
            MessageBox.Show("Файл сохранен");
        }
        private void WriteDataClient(Client client) 
        {
           StreamWriter fileWriter = new StreamWriter(saveFileDialog1.FileName, true);
           fileWriter.WriteLine(JsonSerializer.Serialize(client));
           fileWriter.Close();  
        }
        private void LoadClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Client client;
            int a = 0;
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            while (!reader.EndOfStream)
            {
                client = JsonSerializer.Deserialize<Client>(reader.ReadLine());
                DataGridViewRow row = new DataGridViewRow();
                dataGridView1.Rows.Add(row);
                dataGridView1[1, a].Value = client.Surname;
                dataGridView1[2, a].Value = client.Name;
                dataGridView1[3, a].Value = client.Patronomic;
                dataGridView1[4, a].Value = client.Series;
                dataGridView1[5, a].Value = client.Number_pass;
                dataGridView1[6, a].Value = client.Date_Birth;
               
                dataGridView1[7, a].Value = client.Address;
               
                dataGridView1[8, a].Value = client.Telephone_number;
                dataGridView1[0, a].Value = a + 1;
                a++;
            }
            reader.Close();
            MessageBox.Show("Файл открыт");
        }
        private void ExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
 
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = 0;
            dataGridView1.Rows.Clear();
        }

        private void Add_Vklad_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVklad aV = new AddVklad();
            aV.Owner = this;
            aV.Show();
            //DataGridViewRow row = new DataGridViewRow();
            //dataGridView2.Rows.Add(row);
        }

        private void Clear_2_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Num_2 = 0;
            dataGridView2.Rows.Clear();
        }

        private void poisk_vklad_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(poisk_vklad.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void poisk_vklad_Leave(object sender, EventArgs e)
        {
            if (poisk_vklad.Text == "")
            {
                poisk_vklad.Text = "Поиск...";
                poisk_vklad.ForeColor = Color.Gray;
            }
        }

        private void poisk_vklad_Enter(object sender, EventArgs e)
        {
            if (poisk_vklad.Text == "Поиск...")
            {
                poisk_vklad.Text = "";
                poisk_vklad.ForeColor = Color.Black;
            }
        }

        private void SaveToFileVkladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            File.WriteAllText(saveFileDialog1.FileName, string.Empty);
            Vklad vklad = new Vklad();
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {

                vklad.Name_vklad = dataGridView2[1, i].Value.ToString();
                vklad.Date_open = dataGridView2[2, i].Value.ToString();
                vklad.Date_close = dataGridView2[3, i].Value.ToString();
                vklad.deposit_status = dataGridView2[4, i].Value.ToString();
                vklad.Procent = dataGridView2[5, i].Value.ToString();
                vklad.sum = dataGridView2[6, i].Value.ToString();

                vklad.Currency = dataGridView2[7, i].Value.ToString();

                
                WriteDataVklad(vklad);
            }
            MessageBox.Show("Файл сохранен");
        }
        private void WriteDataVklad(Vklad vklad)
        {
            StreamWriter fileWriter = new StreamWriter(saveFileDialog1.FileName, true);
            fileWriter.WriteLine(JsonSerializer.Serialize(vklad));
            fileWriter.Close();
        }

        private void OpenVkladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Vklad vklad;
            int a = 0;
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            while (!reader.EndOfStream)
            {
                vklad = JsonSerializer.Deserialize<Vklad>(reader.ReadLine());
                DataGridViewRow row = new DataGridViewRow();
                dataGridView2.Rows.Add(row);
                dataGridView2[1, a].Value = vklad.Name_vklad;
                dataGridView2[2, a].Value = vklad.Date_open;
                dataGridView2[3, a].Value = vklad.Date_close;
                dataGridView2[4, a].Value = vklad.deposit_status;
                dataGridView2[5, a].Value = vklad.Procent;
                dataGridView2[6, a].Value = vklad.sum;

                dataGridView2[7, a].Value = vklad.Currency;
                dataGridView2[0, a].Value = a + 1;
                a++;
            }
            reader.Close();
            MessageBox.Show("Файл открыт");
        }

        private void ExcelToolVkladStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (dataGridView1.SelectedRows.Count > selectedRows.Count)
                {
                    selectedRows.Clear();
                    selectedRows.AddRange(dataGridView1.SelectedRows.Cast<DataGridViewRow>());
                }
                else
                {
                    foreach (var row in selectedRows)
                        row.Selected = true;
                }
            }
            else
            {
                selectedRows.Clear();
            }
        }
    }
}
