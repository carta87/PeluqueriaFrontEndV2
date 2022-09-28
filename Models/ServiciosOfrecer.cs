using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueiaStar.Models
{
    public class ServiciosOfrecer
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public string Descripcion { get; set; }  = string.Empty;
        public int ValorServicio { get; set; }
        public int ValorAplicarDescuento { get; set; }
        public int ValorTotalServicio { get; set; }
        public string Comentario { get; set; }  = string.Empty;
    }
}