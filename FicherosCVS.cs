using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MongoAceptadaPor.Models;
using CsvHelper;
using DnsClient.Protocol;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MongoAceptadaPor
{
    public static class FicherosCVS
    {
        public record InfoModificada(string? Id, string? UsuarioAcepta);

        public static void GuardarListaModificadosCSV(List<NotificacionTramitada> listaModificados)
        {
            // string path = @"C:\dev\MongoAceptadaPor\listaModificados.csv";
            string path = @"..\listaModificados.csv";

            List<InfoModificada> lista = [];
            foreach (var item in listaModificados)
            {
                var infM = new InfoModificada(item.Id, item.UsuarioAceptacion ?? "null");
                lista.Add(infM);
            }

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(lista);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static void LeerListaTramitadosCSV()
        {
            string path = @"C:\dev\MongoAceptadaPor\listaTramitados.csv";

            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("No existe el archivo");
                    throw new Exception();
                }

                using (var reader = new StreamReader(path))

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<NotificacionTramitada>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

    }
}
