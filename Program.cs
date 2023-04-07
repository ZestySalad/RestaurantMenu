namespace BaileysRestaurant
{
    public class Program
    {
        private List<Apps> appetizers;
        private List<Entree> entrees;
        private List<Dessert> desserts;
        private bool _flag;

        public Program()
        {
            appetizers = new List<Apps>();
            entrees = new List<Entree>();
            desserts = new List<Dessert>();
            _flag = false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.additems();
            program.Display();
        }
        static void DisplayItems<T>(List<T> items) where T : Items
        {
            Console.WriteLine("Items:");
            foreach (T item in items)
            {
                Console.WriteLine($"{item.Itemname} - {item.Description} - {item.Price:C}");
            }
            Console.WriteLine();
        }

        public void Display()
        {
            while (true)
            {
                Console.WriteLine("Select a category:");
                Console.WriteLine("1. Appetizers");
                Console.WriteLine("2. Entrees");
                Console.WriteLine("3. Desserts");
                Console.WriteLine("4. Exit");
              

                string input = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(input, out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            DisplayItems(appetizers);
                            break;
                        case 2:
                            DisplayItems(entrees);
                            break;
                        case 3:
                            DisplayItems(desserts);
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                       
                            return;
                        default:
                            Console.WriteLine("NO SOUP FOR YOU!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("NO SOUP FOR YOU!!");
                }
            }
        }

        static void DisplayItems(List<Items> items)
        {
            Console.WriteLine("Items:");
            foreach (Items item in items)
            {
                Console.WriteLine($"{item.Itemname} - {item.Description} - {item.Price:C}");
            }
            Console.WriteLine();
        }

        public void additems()
        {
            appetizers.Add(new Apps("Garlic Bread", "Toasted bread with garlic butter", 5.99m));
            appetizers.Add(new Apps("Bruschetta", "Toasted bread with tomatoes and basil", 6.99m));
            entrees.Add(new Entree("Mom's Spaghetti", "Pasta with tomato sauce and meatballs", 12.99m));
            entrees.Add(new Entree("Creamy Chicken Ranch", "shreaded chicken with cream cheese, ranch, and rice topped with chedder cheese.", 15.99m));
            desserts.Add(new Dessert("Tiramisu", "Tasty italian cake dish with chocolate and coffe", 7.99m));
            desserts.Add(new Dessert("Cheesecake", "Creamy dessert with graham cracker crust", 6.99m));
        }
        public void AdminPanel()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Admin Panel");
                Console.WriteLine("Select a category to add a new item to:");
                Console.WriteLine("1. Appetizers");
                Console.WriteLine("2. Entrees");
                Console.WriteLine("3. Desserts");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Enter the name of the new appetizer:");
                            string appName = Console.ReadLine();
                            Console.WriteLine("Enter the description of the new appetizer:");
                            string appDesc = Console.ReadLine();
                            Console.WriteLine("Enter the price of the new appetizer:");
                            decimal appPrice;
                            if (decimal.TryParse(Console.ReadLine(), out appPrice))
                            {
                                appetizers.Add(new Apps(appName, appDesc + " (new)", appPrice));
                                Console.WriteLine($"{appName} added to appetizers as new.");
                            }
                            else
                            {
                                Console.WriteLine("NO DISCOUNTS!!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the name of the new entree:");
                            string entreeName = Console.ReadLine();
                            Console.WriteLine("Enter the description of the new entree:");
                            string entreeDesc = Console.ReadLine();
                            Console.WriteLine("Enter the price of the new entree:");
                            decimal entreePrice;
                            if (decimal.TryParse(Console.ReadLine(), out entreePrice))
                            {
                                entrees.Add(new Entree(entreeName, entreeDesc + " (new)", entreePrice));
                                Console.WriteLine($"{entreeName} added to entrees as new.");
                            }
                            else
                            {
                                Console.WriteLine("NO DISCOUNTS!!");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the name of the new dessert:");
                            string dessertName = Console.ReadLine();
                            Console.WriteLine("Enter the description of the new dessert:");
                            string dessertDesc = Console.ReadLine();
                            Console.WriteLine("Enter the price of the new dessert:");
                            decimal dessertPrice;
                            if (decimal.TryParse(Console.ReadLine(), out dessertPrice))
                            {
                                desserts.Add(new Dessert(dessertName, dessertDesc + " (new)", dessertPrice));
                                Console.WriteLine($"{dessertName} added to desserts as new.");
                            }
                            else
                            {
                                Console.WriteLine("NO DISCOUNTS!!");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        case 5:
                            Display();
                            return;
                        default:
                            Console.WriteLine("NO SOUP FOR YOU!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("NO SOUP FOR YOU!!");
                }
            }
        }
    }
}