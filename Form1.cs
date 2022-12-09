using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.IO;

namespace Project
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Account = new List<Clients>
            {
                new Clients("Белова Анна", "Київ","Активний",777777,999999),
                new Clients("Вася Пупкiн", "Харкiв","Неактивний",454758,5000),
                new Clients("Iван Iванов", "Днiпро","Неактивний",230940,66000),
                new Clients("Сергiй Cергiйович", "Київ","Активний",324345,0),
                new Clients("Петро Петрович", "Львiв","Неактивний",356985,0),
                new Clients("Роман Романович", "Вiнниця","Активний",938457,10000),
            };
            clientsBindingSource.DataSource = Account;
        }
        public List<Clients> Account { get; set; }
        public static class Helper
        {
            public static Timer timer;
            public static void serialize(string path, List<Clients> Account)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string serialized = JsonSerializer.Serialize(Account, options);
                File.WriteAllText(path, serialized);
                
            }
            public static List<Clients> deserialize(string path)
            {
                string deserialized = File.ReadAllText(path);
                var acc = JsonSerializer.Deserialize<List<Clients>>(deserialized);
                return acc;
            }
            public static async void Saver(string path, List<Clients> Account)
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    await JsonSerializer.SerializeAsync(fs, Account);
                }

            }
            public static async void Loader(string path)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {   
                    var acc = await JsonSerializer.DeserializeAsync<List<Clients>>(fs);
                    foreach (var account in acc)
                    {
                        Console.WriteLine($"{account.Name} - {account.City} - {account.Status} - {account.Acc_num} - {account.Amount_of_money}");
                    }
                }
            }
        }
        
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var active = Account.Where(x => x.Status.Equals("Активний")).Select(x => x).ToList();
                clientsBindingSource.DataSource = active;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                var nonactive = Account.Where(x => x.Status.Equals("Неактивний")).Select(x => x).ToList();
                clientsBindingSource.DataSource = nonactive;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var max = Account.OrderBy(x => x.Amount_of_money).Last();
                clientsBindingSource.DataSource = max;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                var zero = Account.Where(x => x.Amount_of_money.Equals(0)).Select(x => x).ToList();
                clientsBindingSource.DataSource = zero;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientsBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Виберiть аккаунт для видалення");
            }
        }

        private void Block_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.CurrentRow.Cells[2].Value = "Заблокований";
            }
            else
            {
                MessageBox.Show("Виберiть аккаунт для блокування");
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            Helper.serialize("account.json", Account);
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = Helper.deserialize("account.json");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Helper.Saver("E:\\uni projects\\visual studio\\JSON.json",Account);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Helper.Loader("E:\\uni projects\\visual studio\\JSON.json");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var addclient = new _Add();
            if (addclient.ShowDialog() == DialogResult.OK)
            {
                clientsBindingSource.Add(addclient.Addclass);
            }
            
        }

        


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}

