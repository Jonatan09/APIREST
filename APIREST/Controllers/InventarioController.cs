using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {

        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Aca estaria la coexion a la base de datos
            return id switch
            {
                1 => "Producto",
                2 => "Computadora ASUS",
                _ => throw new NotSupportedException("El id no es valido")
            };

        }

        public string Post(Producto producto )
        {
            //Aca guardamos el producto en la base de datos

            return producto.nombreProducto;
        }

        public class Producto
        {
            public string nombreProducto { get; set; }
        }
    }
}
