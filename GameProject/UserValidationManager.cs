﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear ==1999 && gamer.FirstName =="AYŞE"
                && gamer.LastName =="GÜNDÜZ"&& gamer.IdentityNumber == 12345)

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
