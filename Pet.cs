using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPetLove
{
   public class Pet
    {
        private string __nome;
        private int __Idade;
        private string __Raca;
        private string __Tipo;
       
        public string   Nome
        {
            get { return __nome; }
            
        }
        public int Idade
        {
            get { return __Idade; }

        }
        public string Raca
        {
            get { return __Raca; }
        }
        public string Tipo
        {
            get { return __Tipo; }bbbb
        }

        public Pet(string nome, int idade, string raca, string tipo)
        {
            this.__nome = nome;
            __Idade = idade;
            __Raca = raca;
            __Tipo = tipo;
        }
        public void Atualizar(string nome, int idade, string raca, string tipo)
        {
            __nome = nome;
            __Idade = idade;
            __Raca = raca;
            __Tipo = tipo;
        }
        public override string ToString()
        {
            return __nome;
        }
    }
}
