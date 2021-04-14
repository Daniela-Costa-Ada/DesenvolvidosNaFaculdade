using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIAEDClinicaMEDICA_02
{
   
        public class Especialidade
        {
            string nome;
            int tipo;

            public Especialidade(int tipo)
            {

                this.Tipo = tipo;
                switch (tipo)
                {
                    case 1:
                        Nome = "Ortopedia";
                        break;
                    case 2:
                        Nome = "Otorrinolaringologia";
                        break;
                    case 3:
                        Nome = "Traumatologia";
                        break;
                    case 4:
                        Nome = "Clinica Geral";
                        break;
                    default:
                        break;
                }

            }
            public Especialidade()
            {

            }
            public Especialidade(string nome, int tipo)
            {
                this.nome = nome;
                this.tipo = tipo;
            }

            public string Nome { get => nome; set => nome = value; }
            public int Tipo { get => tipo; set => tipo = value; }

            public override string ToString()
            {
                return "Especialidade: " + Nome + " tipo: " + Tipo.ToString() + "\n";
            }
        
    }
}
