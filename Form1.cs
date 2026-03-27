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

namespace FormsPetLove
{
    public partial class Form1 : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog(); // Abrir um arquivo externo 
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        protected Pet pet = null;
        public Form1()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            btnSalvarComo.Enabled = false;
            btnInserir.Enabled = false;
        }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            // Alterar para ativar o botao
            btnSalvar.Enabled = true;
            btnSalvarComo.Enabled = true;
            btnInserir.Enabled = true;
            //limpar nossa lista
            lboDados.Items.Clear();
            leitura.Filter = "Arquivo TXT|*.txt"; // pipeline
            leitura.Title = "Selecione o arquivo  que contem os  dados";
            // verificar se seu tudo certo ao clicar em ok , apos selecionar o dado
            // se ao obter o caminho , o cmainho deu certo , continua , caso contrario encerra
            if (leitura.ShowDialog() != DialogResult.OK) return;
            // obtendo o caminho do arquivo
            caminho = leitura.FileName;
            // tente executar o trecho do codigo

            try
            {
                var textoLido = File.ReadAllText(caminho);
                MessageBox.Show(textoLido.GetType().ToString());
                string[] Linhas = textoLido.Split('\n');

                for (int i = 0; i < Linhas.Length; i = i + 4)
                {
                    string nome = Linhas[i];
                    int idade = int.Parse(Linhas[i + 1].ToString());
                    string raca = Linhas[i + 2].ToString();
                    string tipo = Linhas[i + 3].ToString();
                    Pet novopet = new Pet(nome, idade, raca, tipo);
                    lboDados.Items.Add(novopet);
                }
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pet antigopet = lboDados.SelectedItem as Pet;
            if (antigopet == null) return;

            Pet novopet;

            using (CadastroPet cadastropet = new CadastroPet(antigopet))
            {
                cadastropet.ShowDialog();
                novopet = cadastropet.pet;
            }

            if (novopet == null)
            {
                lboDados.Items.Remove(antigopet);
            }
            else
            {
                int index = lboDados.Items.IndexOf(antigopet);
                lboDados.Items[index] = novopet;
            }

            lboDados.Update();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pet novopet;
            using (CadastroPet cadastropet = new CadastroPet())
            {
                cadastropet.ShowDialog();
                novopet = cadastropet.pet;
            }
            if (novopet == null)
                return;
            lboDados.Items.Add(novopet);
            lboDados.Update();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (caminho == null) return;    
            StreamWriter salvandoArquivo = new StreamWriter(caminho);
            string texto = "";
            foreach (Pet pet in lboDados.Items)
            {
                texto += pet.Nome + "\n";
                texto += pet.Idade + "\n";
                texto += pet.Raca + "\n";
                texto += pet.Tipo + "\n";
            }
            salvandoArquivo.WriteLine(texto);
            salvandoArquivo.Close();
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            if (lboDados.Items.Count == 0) return;
            salvamento.Filter = "Arquivo TXT|*.txt";
            salvamento.FileName = "Salvar o arquivo";
            if (salvamento.ShowDialog() != DialogResult.OK && salvamento.FileName == null) return;
            FileStream abrirArquivo = salvamento.OpenFile() as FileStream;
            StreamWriter salvandoArquivo = new StreamWriter(abrirArquivo);
            string texto = "";
            foreach (Pet pet in lboDados.Items)
            {
                texto += pet.Nome + "\n";
                texto += pet.Idade + "\n";
                texto += pet.Raca + "\n";
                texto += pet.Tipo + "\n";
            }
            salvandoArquivo.WriteLine(texto);
            salvandoArquivo.Close();
            abrirArquivo.Close();
        }
    }
}
