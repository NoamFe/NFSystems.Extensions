using System;

namespace UnitTestHelper
{
    public class EnumExtensions
    {
        private static readonly Random random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (random)
            {
                return random.Next(min, max);
            }
        }
        public static T Random<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(GetRandomNumber(0, values.Length));
        }
    }
}
