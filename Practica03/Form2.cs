﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica03
{
    public partial class Form2 : Form
    {
        Calculadora objeto1 = new Calculadora(5, 6);
        public Form2()
        {
            InitializeComponent();
        }

        private void accionarBott_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objeto1.suma().ToString());
            MessageBox.Show(objeto1.resta().ToString());
            MessageBox.Show(objeto1.multiplicacion().ToString());
            MessageBox.Show(objeto1.division().ToString());
        }
    }
}
