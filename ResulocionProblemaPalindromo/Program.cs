using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("introduce la palabra a verificar ");
        string texto = Console.ReadLine();

        bool resultado = esPalindromo(texto);

        //Console.WriteLine($" ¡Es palindromo ? {resultado}");

        if (resultado = true)
        {
            Console.WriteLine($"¡La palabra es un palíndromo! {resultado}");

        }
        else
        {
            Console.WriteLine($"¡La palabra no es un palíndromo! {resultado}");
        }
     }
    public static bool esPalindromo(string texto)
    {

        string textoLimpio = texto.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");


        char[] caracteres = textoLimpio.ToCharArray();
        Array.Reverse(caracteres);
        string textoReverso = new string(caracteres);

        return textoLimpio == textoReverso;


    }
}