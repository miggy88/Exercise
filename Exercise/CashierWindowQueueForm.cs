using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class CashierWindowQueueForm : Form
    {
        public ListBox ListCashierQueue { get; private set; } // Changed type to ListBox

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            ListCashierQueue = new ListBox(); // Initialize ListBox
            Controls.Add(ListCashierQueue); // Add ListBox to the form
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(System.Collections.IEnumerable CashierList)
        {
            ListCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                ListCashierQueue.Items.Add(obj.ToString()); 
            }
        }
    }
       
        }
    

