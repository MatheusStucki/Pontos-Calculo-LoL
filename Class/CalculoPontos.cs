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
            //level * a quantidade de ponto pra 1 / pelos pontos ganhos
            TempoMin = (niveis * 400) / 6;
            TempoMin = TempoMin / 60;
        }

        public void CalcTempoMax(int niveis)
        {
            //level * a quantidade de ponto pra 1 / pelos pontos ganhos
            TempoMax = (niveis * 400)/ 4;
            TempoMax = TempoMax / 60;
        }
        public void CalcPontos(int niveis)
        {
            //400 pontos pra 1 nivel sem mt segredo
            Pontos = niveis * 400;
        }
        public override string ToString()
        {
            return $"O tempo minimo sera: {TempoMin.ToString("F1")}h\nO Tempo Maximo sera {TempoMax.ToString("F1")}h\nVoce precisa de {Pontos} Pontos para o nivel {Niveis}";
        }
    }
}
