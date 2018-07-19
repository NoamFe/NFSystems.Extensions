using System; 

namespace NFSystems.Extensions
{
    public class Common
    {
        private static readonly Random Random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (Random)
            {
                return Random.Next(min, max);
            }
        }
    }
}
