namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();

            var classInstance = Activator.CreateInstance(typeof(BlackBoxInteger), true);

            Type type = Type.GetType("P02_BlackBoxInteger.BlackBoxInteger");

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Static);

            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split('_');

                var num = int.Parse(tokens[1]);

                methods.FirstOrDefault(m => m.Name == tokens[0])
                       .Invoke(classInstance, new object[] { num });

                foreach (var field in fields)
                {
                    sb.AppendLine(field.GetValue(classInstance).ToString());
                }
            }

            Console.WriteLine(sb.ToString().Trim());

        }
    }
}
