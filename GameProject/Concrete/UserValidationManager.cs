using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN" && gamer.LastName == "DEMİROĞ" && gamer.BirthYear == 123444 && gamer.Id==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
