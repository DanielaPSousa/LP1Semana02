using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere a altura do cilindro");
            float al= float.Parse(altura);

            Console.Write("Insere o raio do cilindro");
            float ra= float.Parse(raio);

            float volume= MathF.PI * MathF.Pow (ra, 2) * al;
            float superficie= 2*MathF.PI * ra (ra + al);

            Console.WriteLine($"O volume do cilindro é {volume}");
            Console.WriteLine($"A área da superficie é{superficie}");
        }
    }
}
