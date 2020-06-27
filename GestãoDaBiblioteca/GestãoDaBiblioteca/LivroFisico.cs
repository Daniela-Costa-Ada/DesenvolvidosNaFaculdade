using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    class LivroFisico : Livros
    {
        public LivroFisico(string nome, int pagina, string tema, int codigo) : base(nome, pagina, tema, codigo) { }
        public override int CalculaQuantEmprest()
        {
            return
                1; } //Não deu tempo e no que eu tive não consegui fazer
    }
}
