using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimmasio
{
    public partial class home : Form
    {
        //atributos del Cliente
        String nombre;
        String apellidos;
        int dni;
        String telefono;
        String direccion;
        String correo;
        String instagram;
        String negocio;
        double precio;

        //atributos del Cliente
        String nombre_cliente;
        String dominio;
        DateTime fecha_inicio;
        DateTime fecha_entrega;
        Double precio_pagina;

        //Obejto  Cliente
        Cliente[] arrayClientes = new Cliente[1];

        //Objeto Pagina web
        PaginaWeb[] arrayPaginas = new PaginaWeb[1];

        //contador
        int i = 0;
        int k = 0;
        public home()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            dni = Convert.ToInt32(txtdni.Text);
            telefono = txttelefono.Text.ToString();
            direccion = txtDireccion.Text.ToString();  
            correo = txtCorreo.Text.ToString();
            instagram = txtInstagram.Text.ToString();
            negocio = txtNegocio.Text.ToString();
            precio = Convert.ToDouble(txtPrecio.Text);

            arrayClientes[i] = new Cliente(nombre, apellidos, dni, telefono, direccion, correo, instagram, negocio, precio);
            i++;

            //limpiar campos
            txtNombre.Clear();
            txtApellidos.Clear();
            txtdni.Clear();
            txttelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtInstagram.Clear();
            txtNegocio.Clear();
            txtPrecio.Clear();


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String v = "";

            for (int j = 0; j < arrayClientes.Length; j++)
            { 
                v = v +"Cliente " +(j+1)+"\r\n"+ arrayClientes[j].datos(); 

            }
            

            txtMostrarClientes.Text = v;
        }

        private void btnGuardarPagina_Click(object sender, EventArgs e)
        {
            nombre_cliente = txtNombreCliente.Text.ToString();
            dominio = txtDominio.Text.ToString();
            fecha_inicio = dtpInicio.Value;
            fecha_entrega = dtpFin.Value;
            precio_pagina = Convert.ToDouble(txtPrecioPaginaWeb.Text);
            arrayPaginas[k] = new PaginaWeb(nombre_cliente, dominio, fecha_inicio, fecha_entrega, precio_pagina);
            k++;

            txtNombreCliente.Clear();
            txtDominio.Clear();
            txtPrecioPaginaWeb.Clear();
        }

        private void btnMostrarPaginas_Click(object sender, EventArgs e)
        {
            String v = "";

            for (int j = 0; j < arrayPaginas.Length; j++)
            {
                v = v + "Pagina Web " + (j + 1) + "\r\n" + arrayPaginas[j].datos();

            }


            txtMostrarDatos.Text = v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
