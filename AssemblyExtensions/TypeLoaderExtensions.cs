using System;
using System.Collections.Generic;
using System.Linq;

namespace AssemblyExtensions
{
    /// <summary>
    /// Provides methods to get types which implement a specific Interface
    /// </summary>
    public static class TypeLoaderExtensions
    {

        /// <summary>
        /// Get all types which implement an interface
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetImplementingTypesGeneral(this Type sender)
            => AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.GetInterfaces().Contains(sender));

        /// <summary>
        /// Get all types which implement an interface with a constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetImplementingTypesWithConstructor(this Type sender)
            => AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.GetInterfaces().Contains(sender) && type.GetConstructor(Type.EmptyTypes) != null);


    }
}
