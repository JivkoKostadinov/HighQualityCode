using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Identifiers
{
    class _01
    {

        const int MAX_COUNT = 6;

        class Converter
        {
            public void BoolToString(bool value)
            {
                string valueAsString = value.ToString();
                Console.WriteLine(valueAsString);
            }
        }

        public static void EntryPoint()
        {
            Converter converter = new Converter();
            converter.BoolToString(true);
        }


    }
}
