using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONO
{
    interface Comunicacion
    {

        void vernota(Item item);
        void vertarea(Item item);
        void nuevanota();
        void nuevatarea();

    }
}
