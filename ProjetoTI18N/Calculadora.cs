using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
     class Calculadora
    {   //variáveis globais
        private double num1;
        private double num2;
        //metodo construtor -> instância as variaveis na memoria do computador
        public Calculadora() 
        { 
            ConsultarNum1= 0;
            ConsultarNum2 = 0;

        }//fim do metodo contrutor

        //método modificadores = GET e SET
        public double ConsultarNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//Fim do método consultoNum1
        public double ConsultarNum2
        { get { return this.num2; }
          set { this.num2 = value; }
        }//fim Do Consultor

        //metodo
            public double somar()
        {
            return ConsultarNum1+ ConsultarNum2;
        }//fim da somar

    }//fim da classe

    public double Subtrair() 
    {
        return ConsultarNum1- ConsultarNum2;
    }// fim da subtração

    public double Multiplicar()
        return ConsultarNum1* ConsultadorNum2;
    // fim da Multiplicação

    public double Dividir()
        return ConsultarNum1/ ConsultarNum2;
    // fim da divisão



}//fim do projeto
