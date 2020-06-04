using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            long res = await TaskLoop();
            btn.Text = res.ToString();
        }

        public async static Task<long> TaskLoop()
        {
            long result = 0;
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1099900000; i++)
                {
                    result += i;
                }
            });
            await task;
            return result;
        }
    }
}
