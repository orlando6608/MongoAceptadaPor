using MongoAceptadaPor.Models;

namespace MongoAceptadaPor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<NotificacionTramitada> list = [];

            for (int i = 0; i < 50; i++)
            {
                var IdLexnet = $"20231014132400{i+1}";
                var UsuarioAcepta = $"Orlando Santos Tosca {(i+1).ToString("00")}" ;
                NotificacionTramitada notificacionTramitada;
                if (i % 2 == 0)
                {
                    notificacionTramitada = NotificacionTramitada.Create(IdLexnet, 3, UsuarioAcepta);
                }
                else {
                    notificacionTramitada = NotificacionTramitada.Create(IdLexnet, null, 3, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, UsuarioAcepta, null, null, null, null, null);
                }

                list.Add(notificacionTramitada);
                Console.WriteLine($"IdLexnet:{notificacionTramitada.Id} UsuarioAceptacion:{notificacionTramitada.UsuarioAceptacion}");
            }
        }
    }
}
