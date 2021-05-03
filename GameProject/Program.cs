
using GameProject.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Concrete.GamerManager gamerManager = new Concrete.GamerManager(new UserValidationManager());
            gamerManager.Add(new Entities.Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", NationalityId = 123444 });
          

        }
    }
}
