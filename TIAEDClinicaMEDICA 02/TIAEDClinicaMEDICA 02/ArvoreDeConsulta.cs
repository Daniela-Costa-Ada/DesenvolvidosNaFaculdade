using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIAEDClinicaMEDICA_02
{
    class ArvoreDeConsulta
    {
        NodoC raiz;

        public ArvoreDeConsulta()
        {
            this.raiz = null;// inicializa a arvore?
        }

        public void Inserir(Consulta pac)
        {
            NodoC novo = new NodoC(pac);

            this.raiz = insRec(novo, this.raiz);
        }

        private NodoC insRec(NodoC novo, NodoC raiz)
        {
            if (raiz == null)
            {
                return novo;
            }
            if (novo.Consulta.ProntuarioPac.CompareTo(raiz.Consulta.ProntuarioPac) < 0)
                raiz.Esq1 = insRec(novo, raiz.Esq1);
            else
                raiz.Dir1 = insRec(novo, raiz.Dir1);

            return raiz;
        }

        public NodoC buscar(int chavePront)
        {
           Consulta dado = new Consulta(chavePront);
            NodoC busca = new NodoC(dado);

            return buscaRec(busca, this.raiz);
        }

        private NodoC buscaRec(NodoC busca, NodoC raiz)
        {
            if (raiz == null)
            {
                return null;
            }
            if (busca.Consulta.ProntuarioPac.CompareTo(raiz.Consulta.ProntuarioPac) == 0)
                return raiz;
            else if (busca.Consulta.ProntuarioPac.CompareTo(raiz.Consulta.ProntuarioPac) < 0)
                return buscaRec(busca, raiz.Esq1);
            else
                return buscaRec(busca, raiz.Dir1);
        }




        public override string ToString()
        {
            return emOrdem(this.raiz);
        }

        private string emOrdem(NodoC raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux = emOrdem(raiz.Esq1);
                aux += raiz.ToString();
                aux += emOrdem(raiz.Dir1);
                return aux;
            }
            else return "";
        }

        private string preOrdem(NodoC raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux += raiz.ToString();
                aux += preOrdem(raiz.Esq1);
                aux += preOrdem(raiz.Dir1);
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
    class NodoC
    {
        Consulta consulta;
        NodoC dir;
        NodoC esq;
        public NodoC(Consulta consulta)
        {
            this.Consulta = consulta;

        }
        public NodoC()
        {


        }

        public NodoC(Consulta consulta, NodoC dir, NodoC esq)
        {
            this.Consulta = consulta;
            this.Dir1 = dir;
            this.Esq1 = esq;
        }

        
        internal Consulta Consulta { get => consulta; set => consulta = value; }
        internal NodoC Dir1 { get => dir; set => dir = value; }
        internal NodoC Esq1 { get => esq; set => esq = value; }

        public override string ToString()
        {
            return Consulta.ToString();
        }
    }
    class Consulta
    {
        int especialidade;
        int prioridade;
        int prontuarioPac;
        DateTime data = new DateTime();
        double valor; //depende do tipo e e especialidade da consulta
        public Consulta(int prontuario)
        {

            ProntuarioPac = prontuario;

        }

        public Consulta(int espec, int prioridade, int prontuario, string data)
        {
            this.Especialidade = espec;
            this.prioridade = prioridade;
            ProntuarioPac = prontuario;
            this.data = DateTime.Parse(data);
            this.valor = 1;//depende do tipo e e especialidade da consulta
        }

        public int Prioridade { get => prioridade; set => prioridade = value; }
        public DateTime Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Especialidade { get => especialidade; set => especialidade = value; }
        public int ProntuarioPac { get => prontuarioPac; set => prontuarioPac = value; }


        public override string ToString()
        {
            return "especialidade: " + Especialidade + " Prontuario: " + prontuarioPac + " data:  " + Data;
        }
    }

}
    