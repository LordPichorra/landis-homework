using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointBLL.Util.Validators
{
    public class ConsoleValidators
    {
        static public void CallOptAtributes<T>()
        {
            foreach (int i in Enum.GetValues(typeof(T)))
                Console.WriteLine(" {0} -> {1}", i, Enum.GetName(typeof(T), i));
        }
        static public bool ValidateOptAtributes<T>(int val)
        {
            if (Enum.IsDefined(typeof(T), val))
                return false;
            else
            {
                Console.WriteLine("Value {0} wrong for option {1}", val, nameof(T));
                return true;
            }

        }
        static public (bool, int) ValidateNumberOpt(string opt)
        {
            if (int.TryParse(opt, out int line))
                return (false, line);
            else
            {
                Console.WriteLine("Please, insert a Integer number. eg: 1, 2, 3");
                return (true, 0);
            }
        }

        static public (bool, int) ValidateNumberOptWithEnum<T>(string opt)
        {
            var validation = ValidateNumberOpt(opt);
            if (!validation.Item1)
                return (ValidateOptAtributes<T>(validation.Item2), validation.Item2);
            else
                return (true, 0);
        }
    }
}
