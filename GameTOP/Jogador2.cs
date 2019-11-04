using GameTOP.Interface;

namespace GameTOP
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return $"Maradona está pateando.\n";
        }

        public string Corre()
        {
            return $"Maradona está corriendo.\n";
        }

        public string Passe()
        {
            return $"Maradona está pasando.\n";
        }
    }
}