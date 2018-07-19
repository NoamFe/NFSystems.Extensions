using System; 

namespace NFSystems.Extensions
{
    public class EnumExtensions
    {
        
        public static T Random<T>()
        {
            Array values = Enum.GetValues(typeof(T));

            return (T)values.GetValue(Common.GetRandomNumber(0, values.Length));
        }
    }
}
