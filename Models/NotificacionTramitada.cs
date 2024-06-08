using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoAceptadaPor.Models
{
    [Serializable]
    public class NotificacionTramitada
    {
        public static NotificacionTramitada Create(string id, int idTipoMensaje, string usuarioTramitacion)
        {
            return new NotificacionTramitada
            {
                Id = id,
                IdTipoMensaje = idTipoMensaje,
                UsuarioAceptacion = usuarioTramitacion
            };

        }

        public static NotificacionTramitada Create(string id, string tipoMensaje, int idTipoMensaje, string origen, string destino,
            string asunto, string tipoProcedimiento, string numeroProcedimiento, string numeroPieza, string nig,
            string tipoProcedimientoOrigen, string numeroProcedimientoOrigen, string numeroPiezaOrigen, string nigOrigen,
            string estado, string motivo, DateTime? fechaEnvio, DateTime? fechaAceptacion, string usuarioAceptacion,
            string usuarioTramitacion, string idUsuarioAceptacion, string idUsuarioTramitacion, string adjuntoPrincipal,
            List<string?> adjuntosSecundarios)
        {
            return new NotificacionTramitada
            {
                Id = id,
                TipoMensaje = tipoMensaje,
                IdTipoMensaje = idTipoMensaje,
                Origen = origen,
                Destino = destino,
                Asunto = asunto,
                TipoProcedimiento = tipoProcedimiento,
                NumeroProcedimiento = numeroProcedimiento,
                NumeroPieza = numeroPieza,
                Nig = nig,
                NumeroProcedimientoOrigen = numeroProcedimientoOrigen,
                NumeroPiezaOrigen = numeroPiezaOrigen,
                NigOrigen = nigOrigen,
                TipoProcedimientoOrigen = tipoProcedimientoOrigen,
                Estado = estado,
                Motivo = motivo,
                FechaEnvio = fechaEnvio,
                FechaAceptacion = fechaAceptacion,
                UsuarioAceptacion = usuarioAceptacion,
                IdUsuarioAceptacion = idUsuarioAceptacion,
                UsuarioTramitacion = usuarioTramitacion,
                IdUsuarioTramitacion = idUsuarioTramitacion,
                AdjuntoPrincipal = adjuntoPrincipal,
                AdjuntosSecundarios = adjuntosSecundarios
            };
        }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string? Id { get; private set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("tipoMensaje")]
        public string? TipoMensaje { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        [BsonElement("idTipoMensaje")]
        public int? IdTipoMensaje { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public string? Asunto { get; set; }
        public string? TipoProcedimiento { get; set; }
        public string? NumeroProcedimiento { get; set; }
        public string? NumeroPieza { get; set; }
        public string? Nig { get; set; }
        public string? TipoProcedimientoOrigen { get; set; }
        public string? NumeroProcedimientoOrigen { get; set; }
        public string? NumeroPiezaOrigen { get; set; }
        public string? NigOrigen { get; set; }
        public string? Estado { get; set; }
        public string? Motivo { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaAceptacion { get; set; }
        public string? FechaEnvioTxt { get; set; }
        public string? FechaAceptacionTxt { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("usuarioAceptacion")]
        public string? UsuarioAceptacion { get; set; }
        public string? IdUsuarioAceptacion { get; set; }
        public string? UsuarioTramitacion { get; set; }
        public string? IdUsuarioTramitacion { get; set; }
        public string? NombreCompletoUsuarioAceptacion { get; set; }
        public string? AdjuntoPrincipal { get; set; }
        public List<string?>? AdjuntosSecundarios { get; set; }
    }
}
