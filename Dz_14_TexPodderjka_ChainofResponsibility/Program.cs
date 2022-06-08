using System;

namespace Dz_14_TexPodderjka_ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        { 
            var TechBot = new TechBotHandler();
            var TechPeople = new TechPeopleHandler();
            var TechMaster = new TechMasterHandler();
             
            TechBot.SetNext(TechPeople).SetNext(TechMaster);
             
            Console.WriteLine("Chain: TechBot > TechPeople > Master\n");
            Client.ClientCode(TechBot);
            Console.WriteLine(); 
        }
    }
}
