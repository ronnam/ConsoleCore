using System;

namespace GameTOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jogo = new JogoMassa(
                new Jogador1("Ronnam"),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }    
}
