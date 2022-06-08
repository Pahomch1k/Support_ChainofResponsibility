using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_14_TexPodderjka_ChainofResponsibility
{
    class TechBotHandler : AbstractHandler
    {
        public override object Handle(object request)
        {  
            if ((request as string) == "call") return $"TechBot send 1 and go to TechPeople.\n"; 
            else return base.Handle(request); 
        }
    }
}
