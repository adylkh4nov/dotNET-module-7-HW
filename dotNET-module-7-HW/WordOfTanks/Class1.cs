using System;

namespace WorldOfTanks
{
    public class Tank
    {
        private string Name;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;
        private static Random random = new Random();

        public Tank(string name)
        {
            Name = name;
            ammunitionLevel = random.Next(0, 101);
            armorLevel = random.Next(0, 101);
            maneuverabilityLevel = random.Next(0, 101);
        }

        public string TankName { get { return Name; } }
        public int AmmunitionLevel { get { return ammunitionLevel; } }
        public int ArmorLevel { get { return armorLevel; } }
        public int ManeuverabilityLevel { get { return maneuverabilityLevel; } }

        public static bool operator ^(Tank t34, Tank pantera)
        {
            int t34Wins = 0;
            int panteraWins = 0;

            if (t34.AmmunitionLevel > pantera.AmmunitionLevel)
                t34Wins++;
            else
                panteraWins++;

            if (t34.ArmorLevel > pantera.ArmorLevel)
                t34Wins++;
            else
                panteraWins++;

            if (t34.ManeuverabilityLevel > pantera.ManeuverabilityLevel)
                t34Wins++;
            else
                panteraWins++;

            return (t34Wins > panteraWins);
        }

        public string GetTankParameters()
        {
            return $"{Name}: Ammo={ammunitionLevel}%, Armor={armorLevel}%, Maneuverability={maneuverabilityLevel}%";
        }
    }
}
