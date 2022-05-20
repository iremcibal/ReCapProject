using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach(var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

            //carTest();

            //brandTest();

            //colorTest();
        }

        private static void colorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void brandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void carTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
          
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " -- " + car.CarName + " -- " + car.ColorName + " -- " + car.DailyPrice);
            }
        }
    }
}
