﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //CarTestAll(carManager);
            //CarTestByColor(carManager);
            //CarTestByBrand(carManager);
            //CarTestAdding(carManager);

            CarDetailTest(carManager);

        }

        private static void CarDetailTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                if (car.CarName == carManager.GetCarDetails()[0].CarName)
                {
                    Console.WriteLine($"Listed {carManager.GetCarDetails().Count} car(s)");
                    Console.WriteLine("ID".PadRight(13) + "Brand".PadRight(14) + "Color".PadRight(11) + "Daily Price");
                    Console.WriteLine("--".PadRight(10) + "-----------".PadRight(15) + "---------".PadRight(13) + "-----------");
                }
                Console.WriteLine(car.CarName.PadRight(10) + car.BrandName.PadRight(16) + car.ColorName.PadRight(15) + car.DailyPrice);
            }
        }

        private static void CarTestAdding(CarManager carManager)
        {
            Console.WriteLine("\n\t\t******Adding Car******");
            carManager.Delete(new Car() { Id = 51, BrandId = 4, ColorId = 3, DailyPrice = 0, ModelYear = 2014, Description = "No İnformation" });
            carManager.Add(new Car() { Id = 51, BrandId = 4, ColorId = 3, DailyPrice = 0, ModelYear = 2014, Description = "No İnformation" });
            carManager.Add(new Car() { Id = 51, BrandId = 4, ColorId = 3, DailyPrice = 140, ModelYear = 2014, Description = "No İnformation" });
            foreach (var car in carManager.GetAll())
            {
                if (car.Id == carManager.GetAll()[0].Id)
                {
                    Console.WriteLine($"Listed {carManager.GetAll().Count} car(s)");
                    Console.WriteLine("ID\t" + "Brand ID\t" + "Color ID\t" + "Model Year\t" + "Daily Price\t" + "    Desciption");
                    Console.WriteLine("--\t" + "--------\t" + "--------\t" + "----------\t" + "-----------\t" + "    ----------");
                }
                Console.WriteLine($"{car.Id}\t    {car.BrandId}\t\t    {car.ColorId}\t\t  {car.ModelYear}\t\t    {car.DailyPrice}\t\t{car.Description}");
            }
        }

        private static void CarTestByBrand(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                if (car.Id == carManager.GetCarsByBrandId(4)[0].Id)
                {
                    Console.WriteLine($"\nCar informations of BrandId={car.BrandId}. Listed {carManager.GetCarsByBrandId(4).Count} car(s)");
                    Console.WriteLine("ID\t" + "Color ID\t" + "Model Year\t" + "Daily Price\t" + "    Desciption");
                    Console.WriteLine("--\t" + "--------\t" + "----------\t" + "-----------\t" + "    ----------");
                }
                Console.WriteLine($"{car.Id}\t   {car.ColorId}\t\t  {car.ModelYear}\t\t    {car.DailyPrice}\t\t{car.Description}");
            }
        }

        private static void CarTestByColor(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                if (car.Id == carManager.GetCarsByColorId(2)[0].Id)
                {
                    Console.WriteLine($"\nCar informations of ColorId={car.ColorId}. Listed {carManager.GetCarsByColorId(2).Count} car(s). ");
                    Console.WriteLine("ID\t" + "Brand ID\t" + "Model Year\t" + "Daily Price\t" + "    Desciption");
                    Console.WriteLine("--\t" + "--------\t" + "----------\t" + "-----------\t" + "    ----------");
                }

                Console.WriteLine($"{car.Id}\t   {car.BrandId}\t\t   {car.ModelYear}\t\t    {car.DailyPrice}\t\t{car.Description}");
            }
        }

        private static void CarTestAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                if (car.Id == carManager.GetAll()[0].Id)
                {
                    Console.WriteLine($"Listed {carManager.GetAll().Count} car(s)");
                    Console.WriteLine("ID\t" + "Brand ID\t" + "Color ID\t" + "Model Year\t" + "Daily Price\t" + "    Desciption");
                    Console.WriteLine("--\t" + "--------\t" + "--------\t" + "----------\t" + "-----------\t" + "    ----------");
                }
                Console.WriteLine($"{car.Id}\t    {car.BrandId}\t\t    {car.ColorId}\t\t  {car.ModelYear}\t\t    {car.DailyPrice}\t\t{car.Description}");
            }
        }
    }
}
