using System;

namespace Adivinhar_n
{
    public class Program
    {
        Random random = new Random();
        public int numSecreto;
        public int erros;

        public Program() 
        {
            numSecreto = random.Next(101);
        }
        static void Main(string[] args)
        {
            Program jogo = new Program();
            int chute;
            bool chuteValido = false;
            bool acertou = false;
            

            while (!chuteValido || !acertou)
            {
                Console.WriteLine("Chute um valor:");
                string input = Console.ReadLine();
                chute = int.Parse(input);
                if (int.TryParse(input, out chute))
                {
                    chuteValido = true;
                    jogo.Dicas(jogo.numSecreto, chute, ref acertou);
                }
            }

        }

        public void Dicas(int numSecreto, int chute, ref bool acertou)
        {
            if (chute != numSecreto){
                erros += 1; 
                if (chute > numSecreto && erros < 5){
                    Console.WriteLine("* O chute é MAIOR que o numero secreto");
                }
                else{
                    Console.WriteLine("* O chute é MENOR que o numero secreto");
                }
            } else {
                Console.WriteLine("Parabéns você acertou! O numero secreto era {0}", numSecreto);
                acertou = true;
                erros += 1;
            }

            switch(erros){
                case 1:
                    if (Primo(numSecreto))
                    {
                        Console.WriteLine("* O numero secreto é primo.");
                    }
                    else
                    {
                        Console.WriteLine("* O numero secreto NAO é primo.");
                    }
                    break;
                case 2:
                    if ((numSecreto % 2) == 0){
                        Console.WriteLine("* O numero secreto é multiplo de dois");
                    } else{
                        Console.WriteLine("* O numero secreto NAO é multiplo de dois");
                    }
                    break;
                case 3:
                    if ((numSecreto % 3) == 0)
                    {
                        Console.WriteLine("* O numero secreto é multiplo de tres");
                    }
                    else
                    {
                        Console.WriteLine("* O numero secreto NAO é multiplo de tres");
                    }
                break;
                case 4:
                        var multiplicacao = chute * numSecreto;
                        Console.WriteLine("* ATENCAO ESTA E SUA ULTIMA CHANCE");
                        Console.WriteLine("* O seu chute multiplicado pelo numero secreto equivale a: {0}", multiplicacao);
                    break;
                default:
                        Console.WriteLine("Voce perdeu, o numero secreto era {0}", numSecreto);
                    acertou = true;
                break;
            } 
            
            
        }

        public static bool Primo(int numSecreto)
        {
            if (numSecreto <= 1) return false;
            if (numSecreto == 2) return true;
            if (numSecreto % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numSecreto); i += 2)
            {
                if (numSecreto % i == 0) return false;
            }

            return true;
        }


    }
}
