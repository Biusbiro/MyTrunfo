using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrunfo.Enums
{
    public static class EnumsToString
    {
        public static String ToString(ECategory category)
        {
            switch (category)
            {
                case ECategory.Consumption: 
                    return "Consumo";
                case ECategory.Displacements:
                    return "Cilindradas";
                case ECategory.HorsePower:
                    return "Potência";
                case ECategory.Length:
                    return "Comprimento";
                case ECategory.MaxSpeed:
                    return "Velocidade Máxima";
                default:
                    return String.Empty;
            }
        }

        public static String ToString(EPlayer player)
        {
            switch (player)
            {
                case EPlayer.Player1:
                    return "Jogador 1";
                case EPlayer.Player2:
                    return "Jogador 2";
                default:
                    return String.Empty;
            }
        }
    }
}
