using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontos_Calculo_LoL
{
    internal class PontoTempo
    {
        public int Tempo;
        public int Pontos;
        public int PontoLoss;
        public int CalcTempoWi(int time)
        {
            //tempo de jogo(min) x 6
            Pontos = time * 6;
            return Pontos;
        }
        public int CalcTempoLose(int time)
        {
            //tempo de jogo(min) x 4
            PontoLoss = time * 4;
            return PontoLoss;
        }
    }
}
