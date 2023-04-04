using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmasio
{
    class Cliente
    {
        //Atributos
        String nombre;
        String apellidos;
        int dni;
        String telefono;
        String direccion;
        String correo;
        String instagram;
        String negocio;
        double precio;

        //Metodos Constructor
        public Cliente(String nombre, String apellidos, int dni, String telefono, 
            String direccion, String correo, String instagram, String negocio, double precio)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.instagram = instagram;
            this.negocio = negocio;
            this.precio = precio;

        }

        public String datos()
        {
            String result;
            result = 
                "nombre" + nombre + "\r\n" +
                "Apellido" + apellidos + "\r\n" +
                "dni" + dni + "\r\n" +
                "Telefono" + telefono + "\r\n" +
               "Direccion" + direccion + "\r\n" +
                 "Correo" + correo + "\r\n" +
                 "Instagram" + instagram + "\r\n" +
                 "Negocio" + negocio + "\r\n" +
                 "Precio" + precio + "\r\n"+
                 "             ";

            return result;
        }

    }
}
