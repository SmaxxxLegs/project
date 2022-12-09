using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Clients
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public int Acc_num { get; set; }
        public int Amount_of_money { get; set; }

        public Clients(string name, string city, string status, int acc_num,int amount_of_money)
        {
            Name = name;
            City = city;
            Status = status;
            Acc_num = acc_num;
            Amount_of_money = amount_of_money;
        }
    }
}
