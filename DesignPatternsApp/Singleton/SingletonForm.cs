using DesignPatternsApp.Singleton.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsApp.Singleton
{
    public partial class SingletonForm : Form
    {
        public SingletonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in GetCityService.Instance)
            {
                richTextBox1.Text += $"{item.Name} \n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"";
        }
    }
}
