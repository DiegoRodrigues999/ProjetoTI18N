using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conecta o console com  A control
            control controle = new control();
            controle.operacao();


            Console.ReadLine();//Leia - uso para manter o prompt
        }//Fim do método main 
    }//fim da classe program
}//fim do projeto
