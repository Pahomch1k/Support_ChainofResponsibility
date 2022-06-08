using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14_TexPodderjka_ChainofResponsibility
{
    class TechPeopleHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "1") return $"TechPeople try to restardet if no send 2 and go to TechMaster.\n"; 
            else return base.Handle(request); 
        }
    }
}
