using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgrammingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            int result = 0;
            //result = Calculate();

            Task<int> task = new Task<int>(Calculate);

            task.Start();
            
            result = await task;

            MessageBox.Show($"Result : {result}");

        }

        private int Calculate()
        {
            int total = 40;
            System.Threading.Thread.Sleep(3000);
            return total;
        }
    }
}
