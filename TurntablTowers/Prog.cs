using System;
namespace TurntablTowers
{
    public class Prog
    {
        public static void Main(string[] args)
        {
            TurnTablTower AchimotaTurntabl = new TurnTablTower(12,6);
            AchimotaTurntabl.TakeTheRegister();
            Console.WriteLine();
            AchimotaTurntabl.RingAllBells();
        }
    }
}
