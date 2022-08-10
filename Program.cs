namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            


            string filepath = "C:\\Users\\mani1\\source\\repos\\JSONInventoryManagement\\StockAccountManagement\\Data.json";

            
            
            StockPortFolio port = new StockPortFolio();
            port.DisplayStockDetails(filepath);
        }


    }
}
