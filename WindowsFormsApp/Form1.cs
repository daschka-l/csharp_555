using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelInputError.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Zlist numbers = new Zlist(textBoxArrItems.Text);
                // label_hint.Text = numbers.PrintNumbers();
                numbers.BubbleSort();
                labelResult.Text = numbers.PrintNumbers();
                labelResultCount.Text = Convert.ToString(numbers.SwapCount);
            }
            catch (Exception error)
            {
                // labelInputError.Text = error.Message;
                MessageBox.Show(error.Message);
            }
        }
    }
}
