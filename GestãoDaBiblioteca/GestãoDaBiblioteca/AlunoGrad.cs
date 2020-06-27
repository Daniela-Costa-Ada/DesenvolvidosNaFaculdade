using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    class AlunoGrad : Perfil
    {
        bool situacao;
        public AlunoGrad(string nome, string dataNasc, int cpf, Emprestimos emprest)
            : base(nome, dataNasc, cpf, emprest)
        {
            SituacaoGeSAlG = SituaçãoGetESet;
        }

        public bool SituacaoGeSAlG { get => situacao; set => situacao = value; }

        public override bool VerificarSituação() { return SituacaoGeSAlG; }
    }
}
