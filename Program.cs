    namespace DrinksInfo
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                UserInput input = new UserInput();
                input.GetInputCategories().Wait();
            }
        }
    }