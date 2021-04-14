using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIAEDClinicaMEDICA_02
{
    class Medico
    {
        int crm;
        string nome;
        int espec;
        public Medico(int crm)
        {
            this.Crm = crm;
            
        }

        public Medico(int crm, string nome, int especialidade)
        {
            this.Crm = crm;
            this.Nome = nome;
            this.Espec = especialidade;
        }

        public int Crm { get => crm; set => crm = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Espec { get => espec; set => espec = value; }

        public override string ToString()
        {
            return "CRM: " + Crm + " Nome: " + Nome + " Especialidade: " + Espec; 
        }
    }
}
