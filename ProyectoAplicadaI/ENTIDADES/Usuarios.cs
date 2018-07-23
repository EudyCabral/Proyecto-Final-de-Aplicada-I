using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class Usuarios
    {
        [Key]

        public int UsuariosId { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Tipodeusuario { get; set; }

        public Usuarios()
        {
            UsuariosId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            Tipodeusuario = string.Empty;
        }
    }
}
