﻿namespace DrinksInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DrinksService drinkService = new DrinksService();
            Console.WriteLine(DrinksService.GetCategoriesAsync());
        }
    }
}