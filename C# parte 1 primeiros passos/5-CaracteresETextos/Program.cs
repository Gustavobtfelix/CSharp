using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            // uma string é declarada com aspas duplas " e pode ter zero ou mais caracteres. Um char é declarado com aspas simples ' e pode usar apenas um caractere!


            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao =
@" - .NET
 - Java
 - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
           
             
            Console.ReadLine();
        }
    }
}
