﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaABC.ViewModel.Exibicao
{
    public partial class FrmPecas : Form
    {
        public FrmPecas()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadPecas cadPecas = new FrmCadPecas();
            cadPecas.Show();

        }

        private void FrmPecas_Load(object sender, EventArgs e)
        {

        }
    }
}
