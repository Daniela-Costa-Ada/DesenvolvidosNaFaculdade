﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinômioDeNewtonDaniela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                             CALCULANDO O BINÔMIO DE NEWTON!\n\nTrabalho Interdisciplinar ATP, Laboratório\ne Introdução aos Fundamentos de Matemática para a Computação.\n\nAluna: Daniela Pereira Costa mat.: 609606.\n");
            PerguntaCliente();
            Console.WriteLine("Trabalho Interdisciplinar ATP, Laboratório\ne Introdução aos Fundamentos de Matemática para a Computação.\n\nAluna: Daniela Pereira Costa mat.: 609606\n\nTenha um Bom Dia Soraia :) ");
            Console.ReadKey();
        }
        //Um método void em forma de função recursiva para exibir o Binômio e perguntar ao cliente se ele deseja sair ou fazer um novo calculo.
        public static void PerguntaCliente ()
        {
            Console.WriteLine("*******************************************\nCalcular o Binômio de Newton? \nDigite 1 para Sim, 0 para Não.\n******************************************* ");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.Clear();
                double BinomioNewton = Somatorio();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("                                    n                     ");
                Console.WriteLine("O valor do Binômio de Newton (a + b)  é: " + BinomioNewton + "\n");
                Console.WriteLine("**********************************************************");
                Console.WriteLine();
                PerguntaCliente();
                Console.Clear();
            }
           
            else if (resposta == 0)
            {              
                Console.Clear();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
                PerguntaCliente();
                Console.Clear();              
               
            }
        }
        //Método para o calculo de todo o somatorio.
        public static double Somatorio ()
        {
            double A, B;
            Console.WriteLine("                                             CALCULANDO O BINÔMIO DE NEWTON!\n");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                   n");
            Console.Write("Na fórmula  (a + b) ,  digite o fator a:  ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite também o fator b:  ");
            B = double.Parse(Console.ReadLine());

            int N;
            Console.Write("E por último digite o número n, o qual a fómula está elevada:  ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************************************************");

            int P = 0;            
            double Somat = 0;
           
            for (P= 0; P <= N; P++)
            {        
              Somat = Somat + ((Combinação(N, P)) * Math.Pow(A, (N - P)) * Math.Pow(B, P));                
            }
            return Somat;
        }       
       //Método para o calculo do coeficiente binomial
        public static int Combinação (int N2, int P2)
        {
            int Comb = (Fatorial(N2)) / ((Fatorial(P2)) * (Fatorial((N2 - P2))));
            //Console.WriteLine(Comb);

            return Comb;
        }
        // Método para calcular o fatorial.
        public static int Fatorial(int F)
        {
            int cont = 1, fat = 1;
            while (cont <= F)
            {
               fat = fat * cont;
               cont++;
            }
            return fat;
        }
    }
}

