using MongoAceptadaPor.Models;
using MongoDB.Driver;

namespace MongoAceptadaPor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MongoAceptadaPor necesita la conexión a la BD de MongoDB y la lista de valores CSV ([IdLexnet], [UsuarioAceptacion])");

            var clien = new MongoClient("mongodb://localhost:27017");
            var eRegesDb = clien.GetDatabase("eReges");
            var notiTramColeccion = eRegesDb.GetCollection<NotificacionTramitada>("NotificacionTramitada");

            List<NotificacionTramitada> list = [];
            Console.WriteLine("Esto es una lista de registros generados por un bucle del tipo NotificacionTramitada");
            for (int i = 0; i < 50; i++)
            {
                var IdLexnet = $"20231014132400{i + 1}";
                var UsuarioAcepta = $"ERNESTO SANTOS TOSCA {(i + 1).ToString("00")}";
                NotificacionTramitada notificacionTramitada;
                //if (i % 2 == 0)
                //{
                //    notificacionTramitada = NotificacionTramitada.Create(IdLexnet, 3, UsuarioAcepta);
                //}
                //else
                //{
                //    notificacionTramitada = NotificacionTramitada.Create(IdLexnet, null, 3, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, UsuarioAcepta, null, null, null, null, null);
                //}
                notificacionTramitada = NotificacionTramitada.Create(IdLexnet, 3, UsuarioAcepta);
                list.Add(notificacionTramitada);
                // Console.WriteLine($"IdLexnet:{notificacionTramitada.Id} UsuarioAceptacion:{notificacionTramitada.UsuarioAceptacion}");
                // notiTramColeccion.InsertOne(notificacionTramitada);
            }

            //Console.WriteLine("Esto es una lista de registros leídos de la BD de MondoDB eReges de la colección NotificacionTramitada");
            //list = notiTramColeccion.Find(n => true).ToList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"IdLexnet:{item.Id} UsuarioAceptacion:{item.UsuarioAceptacion}");
            //}

            foreach (var item in list)
            {
                Console.WriteLine($"IdLexnet:{item.Id} UsuarioAceptacion:{item.UsuarioAceptacion}");
                notiTramColeccion.ReplaceOne(nt => nt.Id == item.Id, item);
            }

            Console.WriteLine("Pulse una tecla para terminar");
            Console.ReadLine();

        }
    }
}
