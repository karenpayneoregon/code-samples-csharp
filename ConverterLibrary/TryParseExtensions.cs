using System;

namespace ConverterLibrary
{
    public static class TryParseExtensions
    {

        public static int TryParseInt32(this string value)
        {
            return TryParse<int>(value, int.TryParse);
        }

        public static Int16 TryParseInt16(this string value)
        {
            return TryParse<Int16>(value, Int16.TryParse);
        }

        public static Int64 TryParseInt64(this string value)
        {
            return TryParse<Int64>(value, Int64.TryParse);
        }

        public static byte TryParseByte(this string value)
        {
            return TryParse<byte>(value, byte.TryParse);
        }

        public static bool TryParseBoolean(this string value)
        {
            return TryParse<bool>(value, bool.TryParse);
        }

        public static float TryParseSingle(this string value)
        {
            return TryParse<Single>(value, Single.TryParse);
        }

        public static double TryParseDoube(this string value)
        {
            return TryParse<Double>(value, Double.TryParse);
        }

        public static decimal TryParseDecimal(this string value)
        {
            return TryParse<Decimal>(value, Decimal.TryParse);
        }

        public static DateTime TryParseDateTime(this string value)
        {
            return TryParse<DateTime>(value, DateTime.TryParse);
        }

        #region Private Members

        private delegate bool ParseDelegate<T>(string s, out T result);

        private static T TryParse<T>(this string value, ParseDelegate<T> parse) where T : struct
        {
            T result;
            parse(value, out result);
            return result;
        }

        #endregion

    }
}