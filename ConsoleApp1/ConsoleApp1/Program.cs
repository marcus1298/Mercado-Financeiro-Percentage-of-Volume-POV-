/*
15 30 05 12
10 17 28
03 11
80
1, 2, 3, 2, 5, 1, 4
*/
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Collections.Generic;
using System.Security;
using System.Data.Common;

namespace ConsoleApp1
{
    internal class Class
    {
        static void Main()
        {
           Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 90));
           Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 100));
           Console.WriteLine(funcaoRetornaQuantitadePOV(0.2M, 70));
        }

        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            decimal resultado = (totalNegociado * porcentagem)/((1 - porcentagem)) ;
            return (int)resultado;
        }
    }
}


