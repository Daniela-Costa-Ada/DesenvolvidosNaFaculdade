using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIAEDClinicaMEDICA_02
{
    class Lista
    {
        Elemento prim = null;
        Elemento ult;

        public bool vazia()
        {
            return (this.prim == this.ult);
        }
        public void inserir(Consulta cons)
        {
            Elemento novo = new Elemento(cons);

            this.ult.Prox = novo;
            this.ult = novo;
        }

        public Consulta localizar(int posBusca)
        {
            int posAux = 0;
            Elemento aux = this.prim;

            while ((aux != null) && (posAux < posBusca))
            {
                aux = aux.Prox;
                posAux++;
            }

            if (aux == null) return null;
            else return aux.MeuDado;

        }

        public Consulta retirar(Consulta consulta)
        {
            if (this.vazia()) return null;

            Elemento aux = this.prim;
            while ((aux.Prox != null)&& (!aux.Prox.MeuDado.Equals(consulta)));
        
            aux = aux.Prox;

            if (aux.Prox == null) return null;
            else
            {
                Elemento auxRet = aux.Prox;
                aux.Prox = auxRet.Prox;
                if (auxRet == this.ult)
                    this.ult = aux;
                else
                    auxRet.Prox = null;

                return auxRet.MeuDado;
            }
        }

        public void concatenar(Lista outra)
        {

            if (outra.vazia()) return;

            this.ult.Prox = outra.prim.Prox;
            this.ult = outra.ult;
            outra = new Lista();



        }
    }
     class Elemento
    {

        Consulta meuDado;
        Elemento prox;

        internal Consulta MeuDado { get => meuDado; set => meuDado = value; }
        internal Elemento Prox { get => prox; set => prox = value; }
        public Elemento(Consulta meuDado)
        {
            this.MeuDado = meuDado;
            
        }

        public Elemento(Consulta meuDado, Elemento prox)
        {
            this.MeuDado = meuDado;
            this.Prox = prox;
        }
        
    }
}
