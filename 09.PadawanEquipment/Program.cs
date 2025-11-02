namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnsMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            double lightsabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int lightsabresCount = (int)Math.Ceiling(studentsCount * 1.1);

            int freeBelts = studentsCount / 6;

            double totalPrice =
                lightsabresPrice * lightsabresCount +
                robesPrice * studentsCount +
                beltsPrice * (studentsCount - freeBelts);

            if (totalPrice <= johnsMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - johnsMoney:F2}lv more.");
            }

        }
    }
}
