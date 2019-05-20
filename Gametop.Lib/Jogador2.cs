using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Nome { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string Chutar()
        {
            return "Maradona estas pateando";
        }

        public string Correr()
        {
            return "Maradona estas coriendo";
        }

        public string Passar()
        {
            return "Maradona estas pasando";
        }
    }
}