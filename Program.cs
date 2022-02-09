namespace UsoWhile
{
    class Program
    {
        static void Main()
        {
            int intentos = 0, nRandom, userNum;

            Random n = new Random();
            nRandom = n.Next(0, 100);
            Console.WriteLine("ingresa el numero");
            userNum = int.Parse(Console.ReadLine());
            while (nRandom != userNum)
            {
                intentos++;
                userNum = int.Parse((Console.ReadLine()));
                if (nRandom == userNum) Console.WriteLine("FELICIDADES");
                if (intentos == 2)
                {
                    Console.WriteLine($"PERDISTE \nnumero: {nRandom}");
                    break;
                }
            }
        }
    }
}