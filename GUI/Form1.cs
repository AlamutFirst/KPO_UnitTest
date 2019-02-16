using KPO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KPO.Math izračuni = new KPO.Math();
            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Napačne vrednosti!");
                return;
            }
            var result = izračuni.SumOfN(Convert.ToInt32(textBox1.Text));
            label2.Text = "Vrednost je " + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KPO.Math izračuni = new KPO.Math();
            try
            {
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Napačne vrednosti!");
                return;
            }
            int[] items = new int[3];
            items[0] = Convert.ToInt32(textBox2.Text);
            items[1] = Convert.ToInt32(textBox3.Text);
            items[2] = Convert.ToInt32(textBox4.Text);
            var result = izračuni.SumOfAvgArray(items);
            label4.Text = "Vrednost je " + result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            KPO.Math izračuni = new KPO.Math();
            {

                try
                {
                    a = Convert.ToDouble(textBox5.Text);
                    b = Convert.ToDouble(textBox6.Text);
                    c = Convert.ToDouble(textBox7.Text);
                }
                catch
                {
                    MessageBox.Show("Napačne vrednosti!");
                    return;
                }
            }
            var result = izračuni.QuadraticEquation(a, b, c);

            if (result == null)
            {
                MessageBox.Show("Enačba je linearna!");
                return;
            }
            double d1 = b * b - 4 * a * c;

            if (d1 < 0.0)
            {
                label13.Visible = true;
                label13.Text = "Rešitev je imaginarna!";
                label13.ForeColor = Color.Red;
            }
            else
            {
                label13.Visible = false;
            }

            label11.Text = result[0].ToString();
            label12.Text = result[1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ime = textBox8.Text;
            var naslov = textBox9.Text;
            listBox1.Items.Clear();
            var users = new Users(new TableData());

            if (string.IsNullOrEmpty(ime) && string.IsNullOrEmpty(naslov))
            {
                var result = users.GetAll();
                foreach (var item in result)
                {
                    listBox1.Items.Add(item.ime + " " + item.priimek + " " + item.naslov);
                }

            }
            else if (string.IsNullOrEmpty(ime))
            {
                var result = users.GetUserByAddres(naslov);
                if (result == null)
                    listBox1.Items.Add("Ni zadetkov");
                else
                    listBox1.Items.Add(result.ime + " " + result.priimek + " " + result.naslov);

            }
            else if (string.IsNullOrEmpty(naslov))
            {
                var result = users.GetUserByName(ime);
                if (result == null)
                    listBox1.Items.Add("Ni zadetkov");

                else
                    listBox1.Items.Add(result.ime + " " + result.priimek + " " + result.naslov);

            }
            else
            {
                var result = users.GetUserByAddresAndName(naslov, ime);
                if (result == null)
                    listBox1.Items.Add("Ni zadetkov");

                else
                    listBox1.Items.Add(result.ime + " " + result.priimek + " " + result.naslov);

            }
        }
    }
}
