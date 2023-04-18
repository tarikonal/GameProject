using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)) { 
            Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt silindi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt silme başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt güncellendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt güncelleme başarısız");
            }
        }
    }
}
