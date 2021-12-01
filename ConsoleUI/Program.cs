using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ApartmentManager apartmentManager = new ApartmentManager(new EfApartmentDal());
            foreach (var apartment in apartmentManager.GetAll())
            {
                Console.WriteLine(apartment.BlokNo);
            }
        }
    }
}
