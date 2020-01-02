using System;

namespace texta_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            DateTime agora = DateTime.Now;

            if(agora.Day < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if(agora.Day < 19)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            
        }
    }
}
