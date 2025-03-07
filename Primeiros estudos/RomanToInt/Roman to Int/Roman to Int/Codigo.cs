using System;

namespace RomanToIntConsole
{
    public class Program
    {
        static void Main(string valorRomano)
        {
            Program program = new Program();
            string[] romanos = { "I", "V", "X", "L", "C", "D", "M" };
            int[] numerosConvertidos = { 1, 5, 10, 50, 100, 500, 1000 };
            Console.WriteLine("Digite um valor em numeros romanos");
            
            do
            {
                valorRomano = Console.ReadLine().ToUpper();
            } while (string.IsNullOrEmpty(valorRomano) || valorRomano.Length > 15 || Validar(valorRomano, romanos) == false);

            int resultado = program.RomanToInt(valorRomano, romanos, numerosConvertidos);
            Console.WriteLine(resultado);
        }

        public static bool Validar(string valor, string[] romanos)
        {
            foreach (char c in valor)
            {
                if (Array.IndexOf(romanos, c.ToString()) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int RomanToInt(string valorRomano, string[] romanos, int[] numerosConvertidos)
        {
            int valor = 0;
            for (int i = 0; i < valorRomano.Length; i++)
            {
                char letraAtual = valorRomano[i];
                int indexLetraAtual = Array.IndexOf(romanos, letraAtual.ToString());
                if (i < valorRomano.Length - 1)
                {
                    char proxLetra = valorRomano[i + 1];
                    int indexProxLetra = Array.IndexOf(romanos, proxLetra.ToString());
                    if (indexLetraAtual < indexProxLetra)
                    {
                        valor -= numerosConvertidos[indexLetraAtual];
                    }
                    else
                    {
                        valor += numerosConvertidos[indexLetraAtual];
                    }
                }
                else
                {
                    valor += numerosConvertidos[indexLetraAtual];
                }
            }
            return valor;
        }
    }
}