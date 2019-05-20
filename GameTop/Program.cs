﻿using GameTop.Lib;
using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador1("Gustavo"), new Jogador2());

            jogo.IniciarJogo();
        }   
    }
}
