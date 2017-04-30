using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernateTutorial.Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace NHibernateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNHibernateCfg();

            /* CRUD */
            CharacterRepository repo = new CharacterRepository();

            //CREATE!
            var nuevo= new Character { Nombre = "Jorge", Apellido = "Nañez", Edad = 22, Profesion = "Estudiante" };
            repo.Add(nuevo);
            Console.WriteLine(" \n");
            var nuevo2 = new Character { Nombre = "Luis", Apellido = "Ocampo", Edad = 23, Profesion = "Estudiante" };
            repo.Add(nuevo2);
            Console.WriteLine(" \n");
            //READ!
            Character jorge = repo.GetCharacterByName("Jorge");
            Console.WriteLine(" \n");
           Character luis= repo.GetCharacterByName("Luis");
           
            Console.ReadKey();
        }

        public static void LoadNHibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Character).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

    }
}
