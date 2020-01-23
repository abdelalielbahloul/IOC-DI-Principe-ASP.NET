using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IOC_DI_Principe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // injection par instanciation statique
            //CreateHostBuilder(args).Build().Run();
            //DaoIpml dao = new DaoIpml();
            //MetierImpl metier = new MetierImpl(dao);
            //ou methode 2 via le ctroc par default
            //metier.dao = dao;
            //Console.WriteLine(metier.calcul());
            //Console.ReadKey();

            //injection par instanciation dynamique
            string path = "config.txt";
            string[] data = File.ReadAllLines(path);
            string daoClassName = data[0];
            string metierClassName = data[1];

            IDao dao = (IDao)Activator.CreateInstance(Type.GetType(daoClassName));

            IMetier metier = (IMetier)Activator.CreateInstance(Type.GetType(metierClassName), dao); // c'est l'équivalent de [ MetierImpl metier = new MetierImpl(dao); ]
            Console.WriteLine(metier.calcul());


            Console.WriteLine(daoClassName);
            Console.WriteLine(metierClassName);
            Console.ReadKey();

        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
