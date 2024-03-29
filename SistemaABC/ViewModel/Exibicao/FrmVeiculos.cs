﻿using SistemaABCBusiness.Models;
using SistemaABCBusiness.ValueObjects;
using System;
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
    public partial class FrmVeiculos : Form
    {
        public FrmVeiculos()
        {
            InitializeComponent();
        }

        private void btnCadVeiculos_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos frmCad = new FrmCadVeiculos();
            frmCad.Show();
        }

        private void FrmVeiculos_Load(object sender, EventArgs e)
        {
            TblVeiculoModel veiculoModel = new TblVeiculoModel();
            dgvUsers.DataSource = veiculoModel.GetAll();
        }
    }
}
