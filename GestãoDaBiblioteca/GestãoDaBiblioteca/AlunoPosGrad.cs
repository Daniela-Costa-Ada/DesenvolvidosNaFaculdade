using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    class AlunoPosGrad : Perfil
    {
        bool situacao;
        public AlunoPosGrad(string nome, string dataNasc, int cpf, Emprestimos emprest)
            : base(nome, dataNasc, cpf, emprest)
        {
            SituacaoGeSAlPG = SituaçãoGetESet;
        }

        public bool SituacaoGeSAlPG { get => situacao; set => situacao = value; }
        

        public override bool VerificarSituação() { return SituacaoGeSAlPG; }
    }
}
