//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int id_sexo { get; set; }
        public Nullable<int> edad { get; set; }
    
        public virtual sexo sexo { get; set; }

        public override string ToString()
        {
            return $"{apellidos}, {nombre}. Edad {edad}, sexo {sexo}";
        }
    }
}
