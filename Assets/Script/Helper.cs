using System;
using System.Reflection;

namespace Bloonz
{
    public class Helper
    {
        public static Type GetType(string typeName)
        {
            Type type = Type.GetType(typeName);
            if (type != null) return type;
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = a.GetType(typeName);
                if (type != null)
                    return type;
            }
            return null;
        }
    }
}