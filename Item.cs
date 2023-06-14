using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONO
{
    public class Item
    {
        public String id;
        public String titulo;
        public String fecha_creacion;
        public String nivel;
        public String estado;
        public String contenido;
        public String fecha_modificacion;
        public String fecha_entrega;
        public String tipo;

        public Item(String tit, String id)
        {
            this.id = id;
            titulo = tit;
        }

        public Item()
        {
            id = "0";
        }
    }
}
