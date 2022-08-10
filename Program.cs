namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To OOPS Problems");

            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();


            string filepath = "D:\\BridgelabzPracticeProblems\\OopsProblem\\OopsProblem\\InventoryManagement\\InventoryManagement\\Data.json";

            Rice data = fetchInventoryDetails.Read(filepath);

            Console.WriteLine("Types of Rice :");
            for (int i = 0; i < data.typesofRice.Count; i++)
            {

                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine(data.typesofRice[i].weight);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Pulses :");
            for (int i = 0; i < data.typesofPulses.Count; i++)
            {

                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].price);
                Console.WriteLine(data.typesofPulses[i].weight);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Wheat :");
            for (int i = 0; i < data.typesofPulses.Count; i++)
            {

                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].price);
                Console.WriteLine(data.typesofWheat[i].weight);

                Console.WriteLine("--------------");
            }

        }
    }
}