using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee myCoffee = new Coffee(100, 200, 300);
            myCoffee.ShowComposition();
        }
    }

    public class Coffee
    {
        public Coffee(int pureCoffeeVolume, int milkVolume, int waterVolume)
        {
            PureCoffeeVolume = pureCoffeeVolume;
            MilkVolume = milkVolume;
            WaterVolume = waterVolume;
        }
        public int PureCoffeeVolume { get; set; }
        public int MilkVolume { get; set; }
        public int WaterVolume { get; set; }

        public void ShowComposition()
        {
            int overallVolume = PureCoffeeVolume + MilkVolume + WaterVolume;
            string message1 = $"Overall volume of coffee: {Convert.ToString(overallVolume)}\n";
            string message2 = $"Pure Coffee volume: {Convert.ToString(PureCoffeeVolume)}\n";
            string message3 = $"Milk volume: {Convert.ToString(MilkVolume)}\n";
            string message4 = $"Water volume: {Convert.ToString(WaterVolume)}\n";
            string message = message1 + message2 + message3 + message4;
            Console.WriteLine(message);
        }

        public void ChangeCoffeeComposition(int newPureCoffeeVolume, int newMilkVolume, int newWaterVolume)
        {
            PureCoffeeVolume = newPureCoffeeVolume;
            MilkVolume = newPureCoffeeVolume;
            WaterVolume = newWaterVolume;
            ShowComposition();
        }

    }
}
