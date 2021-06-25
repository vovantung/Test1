using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Factory factory = new Factory();
        Service1 service1;
        Service2 service2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            service1 = new Service1(factory);
            service2 = new Service2(factory);
            factory.data.str = "Initailize";

            textBox1.Text = factory.data.str;

            service1.Action();
            textBox2.Text = factory.data.str;

            service2.Action();
            textBox3.Text = factory.data.str;
        }
    }
}
