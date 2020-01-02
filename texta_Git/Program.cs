using System;

namespace texta_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);

            if(agora.Hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if(agora.Hour < 19)
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
