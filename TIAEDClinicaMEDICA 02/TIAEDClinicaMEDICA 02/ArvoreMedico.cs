using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIAEDClinicaMEDICA_02
{
    class ArvoreMedico
    {
        NodoMed raiz;

        public ArvoreMedico()
        {
            this.raiz = null;// inicializa a arvore?
        }

        public void Inserir(Medico med)
        {
            NodoMed novo = new NodoMed(med);

            this.raiz = insRec(novo, this.raiz);
        }

        private NodoMed insRec(NodoMed novo, NodoMed raiz)
        {
            if (raiz == null)
            {
                return novo;
            }
            if (novo.Medico.Crm.CompareTo(raiz.Medico.Crm) < 0)
                raiz.Esq = insRec(novo, raiz.Esq);
            else
                raiz.Dir = insRec(novo, raiz.Dir);

            return raiz;
        }

        public NodoMed buscar(int chavePront)
        {
            Medico dado = new Medico(chavePront);
            NodoMed busca = new NodoMed(dado);

            return buscaRec(busca, this.raiz);
        }

        private NodoMed buscaRec(NodoMed busca, NodoMed raiz)
        {
            if (raiz == null)
            {
                return null;
            }
            if (busca.Medico.Crm.CompareTo(raiz.Medico.Crm) == 0)
                return raiz;
            else if (busca.Medico.Crm.CompareTo(raiz.Medico.Crm) < 0)
                return buscaRec(busca, raiz.Esq);
            else
                return buscaRec(busca, raiz.Dir);
        }




        public override string ToString()
        {
            return emOrdem(this.raiz);
        }

        private string emOrdem(NodoMed raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux = emOrdem(raiz.Esq);
                aux += raiz.ToString();
                aux += emOrdem(raiz.Dir);
                return aux;
            }
            else return "";
        }

        private string preOrdem(NodoMed raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux += raiz.ToString();
                aux += preOrdem(raiz.Esq);
                aux += preOrdem(raiz.Dir);
                return aux;
            }
            else return "";
        }

        /*public Paciente retirar(int chvPront)
        {
            Paciente paciente = new Paciente(chvPront);
            Nodo retirada = new Nodo(paciente);
            Nodo aux = new Nodo(paciente);

            //retiradaRec(retirada, this.raiz, aux);
            return aux.Paciente;
        }*/

        /*public Nodo retiradaRec(Nodo quem, Nodo onde,  Nodo saida)
        {
            saida = new Nodo(null);
            if (onde == null)
            {                                    ////METODO DE RETIRADA NÃO FUNCIONA POIS NÃO CALCULEI O GRAU
                return null;
            }
            if (quem.Paciente.Prontuario.CompareTo(onde.Paciente.Prontuario) < 0)
                onde.Esq = retiradaRec(quem, onde.Esq, saida);
            else if (quem.Paciente.Prontuario.CompareTo(onde.Paciente.Prontuario) > 0)
                onde.Dir = retiradaRec(quem, onde.Dir, saida);
            else
            {           //ACHEI QUEM EU QUERIA
                saida = new Nodo(onde.Paciente);
                int grau = onde.grau;
                switch (grau)
                {
                    case 0:
                        return null;
                        break;
                    case -1:
                        return onde.Esq;
                        break;
                    case 1:
                        return onde.Dir;
                        break;
                    case 2:
                        Nodo antec = onde.antecessor();
                        onde.dado = antec.dado;
                        onde.Esq = retiradaRec(antec, onde.Esq);
                        break;
                }
            }
            return onde;
        }*/

    }
    class NodoMed
    {
        Medico medico;
        NodoMed dir;
        NodoMed esq;
       
        public NodoMed()
        {


        }
        public NodoMed(Medico med)
        {

            this.Medico = med;
        }



        public NodoMed(Medico medico, NodoMed dir, NodoMed esq)
        {
            this.medico = medico;
            this.dir = dir;
            this.esq = esq;
        }

        internal Medico Medico { get => medico; set => medico = value; }
        internal NodoMed Dir { get => dir; set => dir = value; }
        internal NodoMed Esq { get => esq; set => esq = value; }
        public override string ToString()
        {
            return Medico.ToString();
        }
    }
}
