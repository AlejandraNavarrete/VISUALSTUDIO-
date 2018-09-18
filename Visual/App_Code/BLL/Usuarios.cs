using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuarios
{
    public Usuarios()
    {

    }
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        public static long InsertUsuario(UsuarioInfo info)
    {
        Usuarios usuario = new Usuarios();
        usuario.Nombre = usuario.Nombre;
        usuario.Apellido_Paterno = usuario.Apellido_Paterno;
        usuario.Apellido_Materno = usuario.Apellido_Materno;
        usuario.Contraseña = usuario.Contraseña;
        usuario.Correo_electronico = usuario.Correo_electronico;
    }
    public class UsuarioInfo
    {
        public long ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Contraseña { get; set; }
        public string Correo_Electronico { get; set; }
        public long ID_Videos { get; set; }
        public long ID_Comentarios { get; set; }
    }
}