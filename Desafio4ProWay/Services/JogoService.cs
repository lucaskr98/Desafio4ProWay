using Desafio4ProWay.Entidades;
using Desafio4ProWay.Repository;
using System.Collections.Generic;

namespace Desafio4ProWay.Services
{
    public class JogoService
    {
        public void CadastrarNovoJogo(JogoBE jogo)
        {
            JogoRepository repository = new JogoRepository();
            repository.CadastrarNovoJogo(jogo);
        }

        public List<JogoBE> ObterJogosCadastrados()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterJogosCadastrados();
        }

        public int ObterPlacarMinimo()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterPlacarMinimo();
        }

        public int ObterPlacarMaximo()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterPlacarMaximo();
        }

        public int ObterRecordeMinimo()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterRecordeMinimo();
        }

        public int ObterRecordeMaximo()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterRecordeMaximo();
        }

        public void DeletarDados()
        {
            JogoRepository repository = new JogoRepository();
            repository.DeletarDados();
        }
    }
}
