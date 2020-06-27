using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDaBiblioteca
{
    public class Emprestimos
    {
        int prazoEmp;
        DateTime dataEmp;
        DateTime dataDev;
        int contLoan;
        Livros livro;
       
        //constutor faz o emprestimo
        public Emprestimos(DateTime data_Emp,Livros livro_)
        {
            PrazoEmpGetESet = 7;
            LivroGetESet = livro_;
            DataEmpGetESet = data_Emp;
            LivroGetESet.ContEmpresGetESet += 1; ////Não deu tempo e no que eu tive não consegui fazer
            CalculaDataDev(dataEmp);

        }

        public int PrazoEmpGetESet { get => prazoEmp; set => prazoEmp = value; }
        public DateTime DataEmpGetESet { get => dataEmp; set => dataEmp = value; }
        public int ContLoanGetESet { get => contLoan; set => contLoan = value; }
        public Livros LivroGetESet { get => livro; set => livro = value; }
        public DateTime DataDevGetESet { get => dataDev; set => dataDev = value; }

        

        public string  CalculaDataDev(DateTime dataE)
        {
            DataDevGetESet = dataE.AddDays(PrazoEmpGetESet);
            return DataDevGetESet.ToLongDateString().ToString();
        }

        public bool ComparaDatEmEDatDev(DateTime dat_DeVAt)
        {
            if (DataDevGetESet.CompareTo(dat_DeVAt) == 0|| DataDevGetESet.CompareTo(dat_DeVAt) == 1)
                
                return true;           
              
            else return false ; 
        }
        //FAltou um metodo de claculo dos dias em atraso para gerar a suspensao do aluno ou dizendo ao professor que ele não pode 
        //pegar livros ou imprimir
       
    }
}
