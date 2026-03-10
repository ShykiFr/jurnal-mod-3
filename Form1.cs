using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal_mod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nilaiPertama = 0;
            double nilaiKedua = 0;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Pilih Satuan terlebih dahulu!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
            }

            if (comboBox1.Text == "Celcius" && comboBox2.Text == "Fahrenheit")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama * 9 / 5) + 32;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Celcius" && comboBox2.Text == "Kelvin")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = nilaiPertama + 273.15;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Celcius" && comboBox2.Text == "Reamur")
            {
                nilaiPertama += Convert.ToDouble(textBox1.Text);
                nilaiKedua = nilaiPertama * 4 / 5;
                textBox2.Text = nilaiKedua.ToString();
            }

            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celcius")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama - 32) * 5 / 9;
                textBox2.Text = nilaiKedua.ToString();

            }
            else if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Kelvin")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama - 32) * 5 / 9 + 273.15;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Reamur")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama - 32) * 4 / 9;
                textBox2.Text = nilaiKedua.ToString();
            }

            if ((comboBox1.Text == "Kelvin" && comboBox2.Text == "Celcius"))
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = nilaiPertama - 273.15;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Fahrenheit")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama - 273.15) * 9 / 5 + 32;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Reamur")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama - 273.15) * 4 / 5;
                textBox2.Text = nilaiKedua.ToString();
            }

            if (comboBox1.Text == "Reamur" && comboBox2.Text == "Celcius")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = nilaiPertama * 5 / 4;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Reamur" && comboBox2.Text == "Fahrenheit")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama * 9 / 4) + 32;
                textBox2.Text = nilaiKedua.ToString();
            }
            else if (comboBox1.Text == "Reamur" && comboBox2.Text == "Kelvin")
            {
                nilaiPertama = Convert.ToDouble(textBox1.Text);
                nilaiKedua = (nilaiPertama * 5 / 4) + 273.15;
                textBox2.Text = nilaiKedua.ToString();
            }
        }
    }
}
