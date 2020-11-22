using System;

namespace Infrastructure.Methods
{
    public static class EnumsMethods
    {
        /// <summary>
        /// Возвращает русское имя перечисления
        /// </summary>
        /// <param name="Target">Перечисление</param>
        /// <param name="Index">индекс</param>
        /// <returns>Длинное_имя => Длинное имя</returns>
        public static string GetRusEnumName(Type Target, int Index)
        {
            string result = Enum.GetName(Target, Index);
            while (result.Contains("_"))
                result = result.Replace('_', ' ');
            return result;
        }
    }
}
