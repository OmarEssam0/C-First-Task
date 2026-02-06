namespace WEEK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carpet Cleaning Service

            int smallCarpet = 25;
            int largeCarpet = 35;
            int tax = 6;

            Console.WriteLine("Enter Number Of Small Carpets:");
            int smallCarpetCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of Large Carpets:");
            int largeCarpetCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Price of small carpet :{smallCarpet}$");
            Console.WriteLine($"Price of large carpet :{largeCarpet}$");

            int cost = (smallCarpet * smallCarpetCount) + (largeCarpet * largeCarpetCount);
            Console.WriteLine($"Cost :{cost}$");

            double totalTaxPerRequest = Convert.ToDouble(cost) * tax / 100;
            Console.WriteLine($"tax : {totalTaxPerRequest}$");

            Console.WriteLine("=====================================");
            Console.WriteLine($"total estimate: {cost + totalTaxPerRequest}$");
            Console.WriteLine($"this estiamte is valid for 30 days");





        }
    }
}
