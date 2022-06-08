using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14_TexPodderjka_ChainofResponsibility
{
    class TechMasterHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "2") return $"TechMaster ok now poreshaem.\n"; 
            else  return base.Handle(request); 
        }
    }
}
