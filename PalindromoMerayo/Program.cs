using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromoMerayo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione el metodo a utilizar:");
                Console.WriteLine("En caso de querer checkear palindromo escriba 1");
                Console.WriteLine("En caso de querer transformar texto a CamelCase escriba 2");
                Console.WriteLine("Para salir escriba 3");
                string seleccion;
                seleccion = Console.ReadLine();
                switch (seleccion)
                {
                    case "1":
                        Console.WriteLine("introduzca una palabra:");

                        string palabra;
                        palabra = Console.ReadLine();
                        Console.WriteLine("La palabra es " + palabra + "!");
                        if (EsPalindromo(palabra))
                            Console.WriteLine("Es palindromo");
                        else
                            Console.WriteLine("No es palindromo");
                        break;
                    case "2":
                        Console.WriteLine("introduzca el texto a transformar en CamelCase: ");
                        string textoACamelCase;
                        textoACamelCase = Console.ReadLine();
                        CamelCase(textoACamelCase);
                        break;
                    case "3":
                        return;
                }
            }

            Console.ReadKey();
        }
        public static bool EsPalindromo(string palabra)
        {
            palabra = palabra.ToLower();
            palabra = palabra.Replace(" ", "");

            int i = 0;
            int j = palabra.Length - 1;

            while (i < j)
            {
                if (palabra[i] == palabra[j])
                {
                    --j;
                    ++i;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static void CamelCase(string textoACamelCase)
        {
            string result = "";
            for (int i = 0; i < textoACamelCase.Length; i++)
            {


                if (textoACamelCase[i] == ' ')
                    result += textoACamelCase[i++ + 1].ToString().ToUpper();
                else if (Char.IsLower(textoACamelCase[i]))
                    result += textoACamelCase[i];


            }


            // result = textoACamelCase.Replace(" ", "");

            Console.WriteLine(result);
        }
    }
}

       