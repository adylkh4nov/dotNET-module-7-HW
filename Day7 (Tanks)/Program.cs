using System;
using WorldOfTanks;
namespace TankBattleSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tank[] t34Tanks = new Tank[5];
            Tank[] panteraTanks = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tank("T-34");
                panteraTanks[i] = new Tank("Pantera");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Битва {i + 1}:");
                Console.WriteLine($"{t34Tanks[i].TankName} vs. {panteraTanks[i].TankName}");

                if (t34Tanks[i] ^ panteraTanks[i])
                    Console.WriteLine($"{t34Tanks[i].TankName} Победил!");
                else
                    Console.WriteLine($"{panteraTanks[i].TankName} Победил!");

                Console.WriteLine(t34Tanks[i].GetTankParameters());
                Console.WriteLine(panteraTanks[i].GetTankParameters());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
