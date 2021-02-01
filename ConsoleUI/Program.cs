using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("ID\t" + "Brand ID\t" + "Color ID\t" + "Model Year\t" + "Daily Price\t" + "   Desciption");
            Console.WriteLine("--\t" + "--------\t" + "--------\t" + "----------\t" + "-----------\t" + "   ----------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id}\t    {car.BrandId}\t\t    {car.ColorId}\t\t  {car.ModelYear}\t\t  {car.DailyPrice} \t{car.Description}");
            }

            Console.ReadKey();
        }
    }
}
