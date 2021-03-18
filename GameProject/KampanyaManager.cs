using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager:Gamer
    {
        

        public void Add(KampanyaManager kampanyaManager)
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("kampanya silindi");
        }

        public void Update( )
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
