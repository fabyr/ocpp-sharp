using System;

namespace OcppSharp.Protocol
{
    public static class ConfigKey<T> where T : struct, System.Enum
    {
        private static readonly Dictionary<CiString, T> NameToEnum = new Dictionary<CiString, T>();

        private static readonly Type Enum = typeof(T);

        static ConfigKey()
        {
            T[] values = System.Enum.GetValues<T>();
            foreach(T val in values)
            {
                NameToEnum.Add(val.ToString(), val);
            }
        }

        public static string? GetUnit(T v)
        {
            return v.GetAttributeOfType<ValueUnitAttribute>()?.Unit;
        }

        public static Type? GetValidType(T v)
        {
            return v.GetAttributeOfType<ValidValuesAttribute>()?.ValidType;
        }

        public static bool IsList(T v)
        {
            return v.GetAttributeOfType<ValueListAttribute>() != null;
        }

        public static bool IsIndexedList(T v)
        {
            return v.GetAttributeOfType<ValueIndexedAttribute>() != null;
        }

        public static bool IsRangeLimited(T v, out long min, out long max)
        {
            ValueRangeAttribute? vattr = v.GetAttributeOfType<ValueRangeAttribute>();
            
            if(vattr != null)
            {
                min = vattr.Min; max = vattr.Max;
                return true;
            }
            else
            {
                min = 0; max = 0;
                return false;
            }
        }

        public static TypeEditInfo GetEditInfo(T v)
        {
            TypeEditInfo info = new TypeEditInfo()
            {
                Arbitrary = false,
                IsList = IsList(v),
                IsIndexedList = IsIndexedList(v),
                ValidType = GetValidType(v),
                Unit = GetUnit(v) ?? string.Empty,
            };
            long min, max;
            if(IsRangeLimited(v, out min, out max))
            {
                info.IsRangeLimited = true;
                info.RangeMin = min;
                info.RangeMax = max;
            }
            return info;
        }

        public static TypeEditInfo GetEditInfo(CiString key)
        {
            if(IsCoreProfileValue(key))
            {
                return GetEditInfo(GetEnumValue(key));
            }
            return new TypeEditInfo() { Arbitrary = true };
        }

        public static bool IsCoreProfileValue(CiString key)
        {
            return NameToEnum.ContainsKey(key);
        }

        public static T GetEnumValue(CiString key)
        {
            return NameToEnum[key];
        }
    }
}