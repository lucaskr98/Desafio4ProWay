using Desafio4ProWay.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Desafio4ProWay.Test
{
   public class JogoTeste
    {
        [Fact]
        public void Placar_Deve_Retornar_Erro_Ao_Passar_Placar_Maior_Que_Mil()
        {
            Assert.Throws<ArgumentException>(() => new JogoBE(10000000));
        }

        [Fact]
        public void Placar_Nao_Deve_Retornar_Erro_Ao_Passar_Placar_Menor_Que_Mil()
        {
            int placar =  999;
            JogoBE jogo = new JogoBE(placar);
            Assert.Equal(placar, jogo.Placar);
        }
    }
}
