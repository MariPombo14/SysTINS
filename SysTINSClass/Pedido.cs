using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Usuario { get; set; }
        public int Cliente { get; set; }

    }
}
//id int(4) AI PK 
//usuario_id int(4) 
//cliente_id int(4) 
//data timestamp 
//status char(1) 
//desconto decimal(10,2)
