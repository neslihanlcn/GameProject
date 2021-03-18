using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "AYŞE",
                LastName = "GÜNDÜZ",
                IdentityNumber = 12345
            });

            KampanyaManager kampanyaManager = new KampanyaManager ();
            kampanyaManager.Add(kampanyaManager );

            kampanyaManager.Delete();
            kampanyaManager.Update();
                
            
            
           
        }
    }
}
