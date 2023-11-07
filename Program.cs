namespace weather
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bemenet
            int dayCount;
            int raceDays;

            //kimenet
            bool conditionsOK;

            //ellenorzeshez
            string inputText;
            bool error;

            //belovasas
            do
            {
                Console.WriteLine("napok szama(nyilvan nincs negativ nap): ");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out dayCount) && dayCount < 0;
                if(error)
                {
                    Console.WriteLine("hogy mennyi, az szam es negativ szamu nap nincs. ujra");
                }
            } while (error);

            do
            {
                Console.WriteLine("versenynapok szama(nyilvan nincs negativ nap): ");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out raceDays) && raceDays < 0;
                if (error)
                {
                    Console.WriteLine("hogy mennyi, az szam es negativ szamu nap nincs. ujra");
                }
            } while (error);

            //tomb deklaralas

            Console.WriteLine("sebessegek(nyilvan nincs negativ): ");
            int[] windSpeeds = new int[dayCount + 1];
            for (int i = 1; i < dayCount + 1; i++)
            {
                do
                {
                    
                    inputText = Console.ReadLine();
                    error = !int.TryParse(inputText, out windSpeeds[i]) && windSpeeds[i] > 0;
                    if (error)
                    {
                        Console.WriteLine("hogy mennyi, az szam es negativ sebesseg nincs. ujra");
                    }
                } while (error);
            }

            //feldolgozas
            int suitableDays = 0;
            for (int i = 0;i <= dayCount; i++)
            {
                if (15 <= windSpeeds[i] && windSpeeds[i] <= 35)
                {
                    suitableDays++;
                }
            }

            conditionsOK = false;
            if (suitableDays >= raceDays)
            {
                conditionsOK = true;
            }

            //kiir
            if (conditionsOK)
            {
                Console.WriteLine("megrendezheto");
            }
            else
            {
                Console.WriteLine("nem rendezheto meg");
            }

        }
    }
}