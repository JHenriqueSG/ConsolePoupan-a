using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoupança
{

    class ContaPoupança
    {
        static double taxaDeJuroAnual = 0.04;
        double saldoPoupança;


        public ContaPoupança() { }
      
        public ContaPoupança(double saldoPoupança)
        {
            this.saldoPoupança = saldoPoupança;


        }
        public double calcularJuroMensal()
        {
            this.saldoPoupança = (((taxaDeJuroAnual * saldoPoupança) / 12) + saldoPoupança);
            return this.saldoPoupança;
        }

        public static void alterarTaxaDeJuros(double taxaDeJuros)
        {
            ContaPoupança.taxaDeJuroAnual = taxaDeJuros;
        }
    }











}

