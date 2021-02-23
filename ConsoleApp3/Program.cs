using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(EjemploPersonasEntities db = new EjemploPersonasEntities())
            {
                //Listar todas las presonas
                var listaPersonas = db.persona.ToList();
                Console.WriteLine("          PERSONAS");
                Console.WriteLine("---------------------------------------");
                foreach (var p in listaPersonas)
                {
                    Console.WriteLine($" > {p.ToString()}");
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------");

                //Listar hombres
                var listaHombres = db.persona.Where(x => x.sexo.descrip.Equals("Hombre"));
                Console.WriteLine("          HOMBRES");
                Console.WriteLine("---------------------------------------");
                foreach (var p in listaHombres)
                {
                    Console.WriteLine($" > {p.ToString()}");
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------");

                //Listar mujeres
                var listaMujeres = db.persona.Where(x => x.sexo.descrip.Equals("Mujer"));
                Console.WriteLine("          MUJERES");
                Console.WriteLine("---------------------------------------");
                foreach (var p in listaMujeres)
                {
                    Console.WriteLine($" > {p.ToString()}");
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------");

                //Listar menores
                var listaMenores = db.persona.Where(x => x.edad < 18);
                Console.WriteLine("          MENORES");
                Console.WriteLine("---------------------------------------");
                foreach (var p in listaMenores)
                {
                    Console.WriteLine($" > {p.ToString()}");
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------");

                //Insertar persona
                var search = db.persona.Where(x=> x.nombre.Equals("Xoel")).First();
                if (search == null){
                 persona per = new persona();
                 per.nombre = "Xoel";
                 per.apellidos = "Martinez";
                 per.edad = 8;
                 per.id_sexo = 1;

                 db.persona.Add(per);

                 db.Entry(per).State = System.Data.Entity.EntityState.Added;

                    db.SaveChanges();
                }

                //Editar
                persona cambiar = db.persona.Where(x => x.nombre == "Jorge").First();
                cambiar.edad = 40;

                db.Entry(cambiar).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                //Eliminar
                persona borrar = db.persona.Find(10);
                db.persona.Remove(borrar);

                db.Entry(borrar).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();




            }



        }
    }
}
