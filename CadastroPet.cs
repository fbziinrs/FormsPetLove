using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPetLove
{
    public partial class CadastroPet : Form
    {
        private Pet __pet;
        public CadastroPet()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
            btnAtualizar.Text = "Inserir";
        }
        
        public CadastroPet(Pet pet)
        {
            InitializeComponent();
            __pet = pet;
            txtNome.Text = pet.Nome;
            txtIdade.Text = pet.Idade.ToString();
            txtRaça.Text = pet.Raca;
            cboTipo.Text = pet.Tipo;
            btnAtualizar.Text = "Atualizar";
        }

        public Pet pet
        {
            get { return __pet; }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string raca = txtRaça.Text; 
            string tipo = cboTipo.Text;
            if (__pet == null)
            {
                __pet = new Pet(nome, idade, raca, tipo);
            }
            else
            {
                __pet.Atualizar(nome, idade, raca, tipo);
            }

            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            __pet = null;
            Close();
        }
    }
}
