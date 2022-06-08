using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_14_TexPodderjka_ChainofResponsibility
{
    class Client
    { 
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var choise in new List<string> { "call", "1", "2" })
            {
                WriteLine($"Client chooses {choise}");

                var result = handler.Handle(choise);

                if (result != null) Write($"   {result}"); 
                else  WriteLine($"   {choise} was left untouched."); 
            }
        }
    }
}
