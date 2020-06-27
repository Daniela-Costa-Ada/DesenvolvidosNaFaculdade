using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    public abstract class Livros
    {
        string nome;
        int pagina;
        string tema;
        //Autor autor;
        int codigo;
        int contEmpres;

        public Livros(string nome, int pagina, string tema, int codigo)
        {
           NomeGetESet        = nome;
           PaginaGetESet      = pagina;
           TemaGetESet       = tema;
           CodigoGetESet     = codigo;
          
        }

        public string NomeGetESet       { get => nome; set => nome = value; }
        public int    PaginaGetESet     { get => pagina; set => pagina = value; }
        public string TemaGetESet       { get => tema; set => tema = value; }
        public int    CodigoGetESet     { get => codigo; set => codigo = value; }
        public int    ContEmpresGetESet { get => contEmpres; set => contEmpres = value; }

        public abstract int CalculaQuantEmprest();
        //Metodo para contador de emprestimo
        //Metodo para ordenar o contador
    }
}
