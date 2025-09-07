using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class QueuingForm: Form
    {
        private CashierClass cashier;
        private Timer timer;


        public QueuingForm()
        {
            InitializeComponent();

            cashier = new CashierClass();

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
