using System;
using System.Reflection;

namespace ReflectionIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typeInfoOnString = typeof(string);

            Assembly stringAssembly = typeInfoOnString.Assembly;
            AssemblyName stringAssemblyName = stringAssembly.GetName();

            Console.WriteLine($"Assembly name: {stringAssemblyName.Name}");
            Console.WriteLine($"Assembly version: {stringAssemblyName.Version}");
        }
    }
}