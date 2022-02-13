using System;

namespace LadisEndpointBLL.Util.Validators.Console
{
    public class ConsoleValidators
    {
        static public void CallOptAtributes<T>()
        {
            foreach (int i in Enum.GetValues(typeof(T)))
                System.Console.WriteLine($" {i} -> {Enum.GetName(typeof(T), i)}");
        }
        static public bool ValidateOptAtributes<T>(int val)
        {
            if (Enum.IsDefined(typeof(T), val))
                return false;
            else
            {
                System.Console.WriteLine($"Value {val} wrong for option {nameof(T)}");
                return true;
            }

        }
        static public (bool, int) ValidateNumberOpt(string opt)
        {
            if (int.TryParse(opt, out int line))
                return (false, line);
            else
            {
                System.Console.WriteLine("Please, insert a Integer number. eg: 1, 2, 3");
                return (true, 0);
            }
        }

        static public (bool, int) ValidateNumberOptWithEnum<T>(string opt)
        {
            var validation = ValidateNumberOpt(opt);
            return !validation.Item1 ? (ValidateOptAtributes<T>(validation.Item2), validation.Item2) : (true, 0);           
        }
    }
}
