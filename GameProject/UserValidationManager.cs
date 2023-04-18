using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            bool flag=false;

            if(gamer.BirthYear==1980 && 
                gamer.FirstName=="Tarık" && 
                gamer.LastName=="Önal" && 
                gamer.IdentityNumber == 12345)
            {
               flag = true;
            }
           
            return flag;
        }
    }
}
