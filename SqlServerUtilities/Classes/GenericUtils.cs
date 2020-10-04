using System;

namespace SqlServerUtilities.Classes
{
    public static class GenericUtils
    {
        public static T EnumParser<T>(string value) => (T)Enum.Parse(typeof(T), value, true);
    }
}
