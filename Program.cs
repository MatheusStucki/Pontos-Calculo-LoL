using System;

namespace Pontos_Calculo_LoL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = -1;
            int Pontos = 0;
            int backup = 0;
            int pontostotal = 0;
            int resvit = 0;
            int resdef = 0;
            while (escolha != 0)
            {
                Console.Clear();
                Console.WriteLine($"Pontos Ganhos: {pontostotal}\nPontos antes de resetar: {backup}" +
                    $"\n1- Pontos necessarios para nivel X" +
                    $"\n2- Pontos ganhos por tempo de jogo" +
                    $"\n3- Quanto tempo para X ponto" +
                    $"\n4- Restar Pontos" +
                    $"\n5- Diminuir pontos" +
                    $"\n6- Aumentar pontos" +
                    $"\n0- Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        CalculoPontos pontos = new CalculoPontos();

                        Console.Write("Entre quantos niveis vc precisa: ");
                        pontos.Niveis = int.Parse(Console.ReadLine());

                        // Passagem por parametro para as classes
                        pontos.CalcTempoMin(pontos.Niveis);
                        pontos.CalcTempoMax(pontos.Niveis);
                        pontos.CalcPontos(pontos.Niveis);

                        // Imprime o override string
                        Console.Clear();
                        Console.WriteLine(pontos);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        PontoTempo tempo = new PontoTempo();

                        Console.WriteLine("Voce (1) ganhou ou (2) perdeu: ");
                        int WinLoss = int.Parse(Console.ReadLine());
                        if (WinLoss == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Escreva os 2 primeiros numeros do tempo de jogo.");
                            Console.Write("Quanto tempo de jogo teve: ");
                            tempo.Tempo = int.Parse(Console.ReadLine());

                            Pontos = tempo.CalcTempoWi(tempo.Tempo);
                            pontostotal = Pontos + pontostotal;

                            Console.Clear();
                            Console.WriteLine($"Voce ganhou {Pontos} com sua vitoria");
                            Console.ReadLine();
                            break;

                        }if (WinLoss == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Escreva os 2 primeiros numeros do tempo de jogo.");
                            Console.Write("Quanto tempo de jogo teve: ");
                            tempo.Tempo = int.Parse(Console.ReadLine());

                            Pontos = tempo.CalcTempoLose(tempo.Tempo);
                            pontostotal = Pontos + pontostotal;

                            Console.Clear();
                            Console.WriteLine($"Voce ganhou {Pontos} com sua Derrota");
                            Console.ReadLine();
                            break;
                        }
                        else { 
                            break;
                        }
                    case 3:
                        Console.Clear();
                        Console.Write("Quantos Pontos voce precisa: ");
                        int neces = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resvit = neces / 6;
                        Console.WriteLine("se ganhar o resultado é " + resvit + " min");
                        resdef = neces / 4;
                        Console.WriteLine("se perder o resultado é " + resdef + " min");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        backup = pontostotal;
                        Console.WriteLine("Pontos resetados");
                        Console.ReadLine();
                        pontostotal = 0;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine($"Arrumar os erros {pontostotal}");
                        int fix = int.Parse(Console.ReadLine());

                        pontostotal -= fix;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"Arrumar os erros {pontostotal}");
                        int fixmais = int.Parse(Console.ReadLine());

                        pontostotal += fixmais;
                        break;
                    default:
                        Console.WriteLine("Numero invalido");
                        break;
                }
                Console.WriteLine("Adeus");
            }
        }
    }
}
