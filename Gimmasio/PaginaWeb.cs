using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmasio
{
    class PaginaWeb
    {
        //Atributos
        String nombre_cliente;
        String dominio;
        DateTime fecha_inicio;
        DateTime fecha_entrega;
        Double precio;

        //Metodos Constructor
        public PaginaWeb(String nombre_cliente, String dominio, DateTime fecha_inicio, DateTime fecha_entrega, double precio)
        {
            this.nombre_cliente = nombre_cliente;
            this.dominio = dominio; 
            this.fecha_inicio = fecha_inicio;
            this.fecha_entrega = fecha_entrega;
            this.precio = precio;
        }
        public String datos()
        {
            String result;
            result =
                "nombre: " + nombre_cliente + "\r\n" +
                "Dominio:  " + dominio + "\r\n" +
                "Fecha Inicio: " + fecha_inicio + "\r\n" +
                "Fecha Entrega" + fecha_entrega + "\r\n" +
               "Precio" + precio + "\r\n"+
               " ";

            return result;
        }

    }
}
