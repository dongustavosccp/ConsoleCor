using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public Jogador1(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get ; set ; }

      public string Chutar()
        {
            return $"{Nome} está chutando";
        }

        public string Correr()
        {
            return $"{Nome} está correndo";
        }

        public string Passar()
        {
            return $"{Nome} está passando";
        }
    }
}