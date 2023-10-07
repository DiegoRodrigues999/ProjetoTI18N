using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
     class control
    {
        Calculadora calc;//conectando a variavel calc a class Calculadora
        public control() 
        {
            calc = new Calculadora();//instanciando, calc é um objeto de calculadora

        }//fim do construtor

        //coletar 
        public int ColetarNum1() 
        {
            Console.WriteLine("informe um numero: ");
            Calc.ConsultarNum1 = Convert.ToDouble (Console.ReadLine()); 
        }// Fim do metodo coletar num1

        public void ColetarNum2() 
        {
            Console.WriteLine("informe outro numero: ");
            calc.ConsultarNum2= Convert.ToDouble (Console.ReadLine()); 

        }
        public void menu() 
        {
            Console.WriteLine("------menu------" +
                                "\n0. Sair" +
                                "\n1. somar" +
                                "\n2. subtrair" +
                                "\n3. multiplicar" +
                                "\n4. dividir" +
                                "\n\n. escolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine()); 
        }//fim do metodo menu

        // metodo que faça operação
           
        public void operacao ()
        {
            menu();
            switch (consultarOpcao) 
            {
                case 0:
                    Console.WriteLine("obrigado!");
                    break;
                case 1:
                    ColetarNum1();
                    ColetarNum2();
                    Console.WriteLine("A Somar dos números digitado é: " + calc.somar());
                    break;
                case 2:
                    ColetarNum1();
                    ColetarNum2();
                    
                       Console.WriteLine("A Subtração dos números digitado é: " + calc.Subtrair());
                    break;

                case 3:
                    ColetarNum1();
                    ColetarNum2();
                    Console.WriteLine("A Multiplicação dos números digitado é: " + calc.Multiplicar());
                    break;
                case 4:
                    ColetarNum1();
                    ColetarNum2();
                    Console.WriteLine("A Divisão dos números digitado é: " + calc.Dividir());
                    break;
                default :
                    Console.WriteLine("opcao escolhida não é valida");
                    break;
            }
    }// fim do projeto
} // fim da class
