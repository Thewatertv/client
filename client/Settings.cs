using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace client
{
    public partial class Form_settings : Form
    {
        public Form_settings()
        {
            InitializeComponent();
        }

        private void Form_settings_Load(object sender, EventArgs e)
        {
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_ip.Text != "" && textBox_ip.Text != " " && textBox_port.Text != "" && textBox_port.Text != " ")
            {
                try
                {

                    var sw = new StreamWriter("D:\\месенджер на c++\\se\\seData_info.txt");
                    sw.WriteLine(textBox_ip.Text + ":" + textBox_port.Text);
                    sw.Close();

                    this.Hide();

                    Application.Restart();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
        }
    }
}
