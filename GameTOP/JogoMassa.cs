using GameTOP.Interface;

namespace GameTOP
{
    public class JogoMassa
    {
         private readonly IJogador _jogadorA;
         private readonly IJogador _jogadorB;

        public JogoMassa(IJogador jogador1, IJogador jogador2)
        { 
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Passe());

            System.Console.WriteLine($"\nPRÓXIMO JOGADOR");

            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}