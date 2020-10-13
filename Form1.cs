using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dadi
{
    public partial class Dadi : Form
    {
        public Dadi()
        {
            InitializeComponent();
            button1.Click += new EventHandler(this.buttonClicked);
        }

        void buttonClicked(object sender, EventArgs e)
        {
            sub sub = new sub();
            int repeat = Decimal.ToInt32 (numericUpDown1.Value);
            Object poolObj = comboBox1.SelectedItem;
            int pool = Convert.ToInt32(poolObj);

            //StringBuilder arrayStringhe = new StringBuilder();
            //arrayStringhe.Append(sub.roll(repeat, pool));

            String finale = string.Join(" ", sub.roll(repeat, pool));

            textBox1.AppendText("Pool: " + pool + " Repeat: "  + repeat +" || " + finale + "\r\n");
            textBox2.AppendText(sub.somma(repeat).ToString() + "\r\n");
        }
    }
}
