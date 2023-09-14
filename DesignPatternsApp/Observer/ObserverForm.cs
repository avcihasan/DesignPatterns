using DesignPatternsApp.Observer.Observers;
using DesignPatternsApp.Observer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsApp.Observer
{
    public partial class ObserverForm : Form
    {
        readonly IUdemyService _udemyService;
        public ObserverForm()
        {
            InitializeComponent();
            _udemyService = new UdemyService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _udemyService.AddObserver(new StudentObserver() { Name = textBox1.Text });
            textBox1.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _udemyService.AddObserver(new StudentObserver() { Name = textBox2.Text });
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _udemyService.CreateCourse(textBox3.Text);
            textBox3.Text = string.Empty;

        }
    }
}
