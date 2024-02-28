using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte:{byte.MinValue} ; {byte.MaxValue}");
            Console.WriteLine($"int:{int.MinValue} ; {int.MaxValue}");
            Console.WriteLine($"short:{short.MinValue} ; {long.MaxValue}");
            Console.WriteLine($"long:{long.MinValue} ; {long.MaxValue}");
            Console.WriteLine($"ulong:{ulong.MinValue} ; {ulong.MaxValue}");
            Console.WriteLine($"ushort:{ushort.MinValue} ; {ushort.MaxValue}");
            Console.WriteLine($"uint:{uint.MinValue} ; {uint.MaxValue}");
            Console.WriteLine($"float:{float.MinValue} ; {float.MaxValue}");
            Console.WriteLine($"byte:{decimal.MinValue} ; {decimal.MaxValue}");
            Console.WriteLine($"double:{byte.MinValue} ; {double.MaxValue}");

            Console WriteLine($"Mais infinito:{double.PositiveInfinity}");
            Console WriteLine($"Menos infinito:{double.NegativeInfinity}");
            Console WriteLine($"NaN:{double.NaN}");
            Console WriteLine($"Mais infinito:{float.PositiveInfinity}");
            Console WriteLine($"Menos infinito:{float.NegativeInfinity}");
            Console WriteLine($"NaN:{float.NaN}");

        }
    }
}
