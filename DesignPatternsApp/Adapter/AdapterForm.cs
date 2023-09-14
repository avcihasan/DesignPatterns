using DesignPatternsApp.Adapter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsApp.Adapter
{
    public partial class AdapterForm : Form
    {
        readonly IUserService _userService;
        readonly IUserService _userService2;
        public AdapterForm()
        {

            InitializeComponent();
            _userService = new UserService();
            _userService2 = new XUserServiceAdapter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userService.CreateUser(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;

            UserDb.Users.ForEach(x =>
            {
                richTextBox1.Text += $"Name : {x.Name} - Surname : {x.Surname} - Age : {x.Age} \n";
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _userService2.CreateUser(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
