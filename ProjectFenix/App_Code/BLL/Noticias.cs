using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Noticias
/// </summary>

namespace BLL
{
    public class Noticias
    {
        public Noticias()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        public static long InsertNoticia(NoticiaInfo info)
        {
            Noticia Noticia = new Noticia();

            Noticia.IDNoticia = info.IDNoticia;

            Noticia.Fecha = DateTime.Now;

            Noticia.Titulo = info.Titulo;
            Noticia.Contenido = info.Contenido;
            Noticia.Foto = info.Foto;
            Noticia.IDSeccion = info.IDSeccion;
            Noticia.IDUsuario = info.IDUsuario;

            DataClassesDataContext dc = new DataClassesDataContext();

            dc.Noticia.InsertOnSubmit(Noticia);
            dc.SubmitChanges();

            return Noticia.IDNoticia;
        }
    }
    public class NoticiaInfo
    {
        public long IDNoticia { get; set; }
        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Foto { get; set; }
        public long IDSeccion { get; set; }
        public long IDUsuario { get; set; }

    }
}