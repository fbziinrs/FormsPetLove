using FormsPetLove.PetLoveDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormsPetLove.PetLoveDataSet;

namespace FormsPetLove
{
    public partial class CadastroPet : Form
    {
        private Pet __pet;
        public CadastroPet()
        {
            InitializeComponent();
            atualizarLista();

        }
        private void atualizarLista()
        {
            lboDados.Items.Clear();
            PetsTableAdapter petsdados = new PetsTableAdapter();
            var dados = from linha in petsdados.GetData()
                        select linha;
            foreach (var linha in dados) lboDados.Items.Add(linha);
        }

        private void limparElementos()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtRaça.Text = "";
            txtTipo.Text = "";
        }

        public CadastroPet(Pet pet)
        {
            InitializeComponent();
            __pet = pet;
            txtNome.Text = pet.Nome;
            txtIdade.Text = pet.Idade.ToString();
            txtRaça.Text = pet.Raca;
            txtTipo.Text = pet.Tipo;

        }

        public Pet pet
        {
            get { return __pet; }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                txtIdade.Text = "0";
            }

            if (!txtIdade.Text.All(char.IsDigit))
            {
                MessageBox.Show("A idade deve conter apenas números!");
                return;
            }

            int idade = int.Parse(txtIdade.Text);

            string raca = txtRaça.Text;
            string tipo = txtTipo.Text;

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

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            lboDados.Items.Clear();
            try
            {
                var textLido = File.ReadAllText("Caminhoquedevecopiar");
                string[] linhas = textLido.Split('\n');
                PetsTableAdapter petsdados = new PetsTableAdapter();
                for (int i = 0; i < linhas.Length; i = i + 4)
                {
                    string nome = linhas[i];
                    int idade = int.Parse(linhas[i + 1]);
                    string raca = linhas[i + 2];
                    string tipo = linhas[i + 3];
                    if (i + 4 >= linhas.Length) break;

                }
                File.Delete("Caminhoquedevecopiar");
            }
            catch (Exception ex)
            {
                PetsTableAdapter dadosPets = new PetsTableAdapter();
                var dados = from linha in dadosPets.GetData()
                            select linha;
                foreach (var linha in dados) lboDados.Items.Add(linha);

            }
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboDados.SelectedItem == null) return;
            if (pets == null) return;
            PetsRow pets = lboDados.SelectedItem as PetsRow;
            btnAjuste.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
                txtNome.Text = pets.Nome;
                txtIdade.Text = pets.Idade.ToString();
                txtRaça.Text = pets.Raca;
                txtTipo.Text = pets.Tipo;




        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if(btnAcoes.Text == "Excluir")
            {
                if (lboDados.SelectedItems == null) return;
                PetsRow pets = lboDados.SelectedItem as PetsRow;
                if (pets == null) return;
                PetsTableAdapter petsAdapter = new PetsTableAdapter();
                pets.Delete(pets.PETID);
                atualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar Lista";
                btnAjuste.Text = "Cadastrar";
            }
            else
            {
                atualizarLista();
                
            }
            
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            if (btnAjuste.Text == "Cadastrar")
            {
                string nome = txtNome.Text;
                string idade = txtIdade.Text;
                string raca = txtRaça.Text;
                string tipo = txtTipo.Text;
                try
                {
                    int idadeInt = int.Parse(idade);
                    PetsTableAdapter
                }
            }
        }
    }
}

