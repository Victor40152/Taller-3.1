using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(txtedad.Text);
            if (edad >= 18)

            {
                MessageBox.Show("Es Mayor de Edad");

            }
            else
            {
                {
                    MessageBox.Show("Es menor de Edad");
                }


            }
        }

    }
}