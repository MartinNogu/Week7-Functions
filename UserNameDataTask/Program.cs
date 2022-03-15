using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm palub kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja sisestab '3', siis kuvataks kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    GetNameData1(userName);
                    break;
                case '2':
                    GetNameData2(userName);
                    break;
                case '3':
                    GetNameData3(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }
        public static void GetNameData1(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
        }

        public static void GetNameData2(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}.");
        }

        public static void GetNameData3(string userName)
        {
            Console.WriteLine($"Sinu eesnimi on {userName.Length} sümbolit pikk.");
        }
    }
}
