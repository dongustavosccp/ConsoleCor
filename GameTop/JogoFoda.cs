using GameTop.Interface;

namespace GameTop
{
    class JogoFoda
    {
        public readonly IJogador _jogador1;
        public readonly IJogador _jogador2;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Correr());
            System.Console.WriteLine(_jogador1.Passar());
            System.Console.WriteLine(_jogador1.Chutar());

            System.Console.WriteLine(_jogador2.Correr());
            System.Console.WriteLine(_jogador2.Passar());
            System.Console.WriteLine(_jogador2.Chutar());
        }
    }
}