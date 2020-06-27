using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    class LivroVirtual : Livros
    {
        double custoPg;
        //Construtor
        public LivroVirtual(double custoPg, string nome, int pagina, string tema, int codigo, int contEmpres) 
            : base(nome, pagina, tema, codigo) 
        {
            CustoPgGetESet = custoPg;
        }
        //Metodos acessores e modificadores
        public double CustoPgGetESet { get => custoPg; set => custoPg = value; }

        public override int CalculaQuantEmprest() { return 1; } //Metodo para contador de emprestimo
        //Metodo para ordenar o contador
        public double CalculoImpressao(int quantPg)
        {
            return CustoPgGetESet * quantPg; ;
        }
    }
}
