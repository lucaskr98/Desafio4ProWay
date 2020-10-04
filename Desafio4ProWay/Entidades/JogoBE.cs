using System;

namespace Desafio4ProWay.Entidades
{
    public  class JogoBE
    {
        public JogoBE()
        {

        }

        public JogoBE(int placar)
        {
            if(placar > 1000)
            {
                throw new ArgumentException("O placar não deve ser maior que 1000.");
            }

            Placar = placar;
        }

        public int Codigo { get; set; }
        public int Placar { get; set; }
        public int MinimoTemporada { get; set; }
        public int MaximoTemporada { get; set; }
        public int QuebraRecordeMinimo { get; set; }
        public int QuebraRecordeMaximo { get; set; }

        public int Soma(int n1, int n2 )
        {
            return n1 - n2;
        }
    }
}
