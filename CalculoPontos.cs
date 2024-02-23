using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontos_Calculo_LoL
{
    internal class CalculoPontos
    {
        public int Niveis;
        public double TempoMin;
        public double TempoMax;
        public int Pontos;

        public void CalcTempoMin(int niveis)
        {
            //leva 33 min para 1 level se ganhar ele da 198 pontos mas eu considerei com 200 msm
            TempoMin = niveis * 33;
            TempoMin = TempoMin / 60;
        }

        public void CalcTempoMax(int niveis)
        {
            //leva 50min para 1 levo se perder
            TempoMax = niveis * 50;
            TempoMax = TempoMax / 60;
        }
        public void CalcPontos(int niveis)
        {
            //200 pontos pra 1 nivel sem mt segredo
            Pontos = niveis * 200;
        }
        public override string ToString()
        {
            return $"O tempo minimo sera: {TempoMin.ToString("F1")}h\nO Tempo Maximo sera {TempoMax.ToString("F1")}h\nVoce precisa de {Pontos} Pontos para o nivel {Niveis}";
        }
    }
}
