using System;
namespace RomanToIntCodigoLeetCode { 
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Solution program = new Solution();
            string[] romanos = { "I", "V", "X", "L", "C", "D", "M" };
            int[] numerosConvertidos = { 1, 5, 10, 50, 100, 500, 1000 };

            int valor = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char letraAtual = s[i];
                int indexLetraAtual = Array.IndexOf(romanos, letraAtual.ToString());
                if (i < s.Length - 1)
                {
                    char proxLetra = s[i + 1];
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