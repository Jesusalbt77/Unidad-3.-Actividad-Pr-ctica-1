using Formulario_Lab04.Controllers;
using Formulario_Lab04.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Lab04
{
    public partial class Form1 : Form
    {
        // Llamar al controlador 
        private AlumnoController alumnoController = new AlumnoController();

        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public double Promedio { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        //Mostrar
        private void MostrarAlumnos(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos de entrada
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el alumno
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };

            {
                // Registrar alumno en el arreglo
                alumnoController.Registrar(alumno);

                // Mostrar los alumnos
                MostrarAlumnos(alumnoController.ListarTodo());

                limpiarCampos();
                {
                }
            }
        }
        public void limpiarCampos()
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           // Validación de seleccion de fila
            if(dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro para eliminar");
                return;
            }

            // Obtener el código
            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminar la fila seleccionafa
            alumnoController.Eliminar(codigo);

            // Mostrar
            MostrarAlumnos(alumnoController.ListarTodo());

        }

        private void btnOrdernar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoController.Ordenar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar campo
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el código a buscar");
                return;
            }
            // Obtener el código
            String codigo = tbBuscar.Text;
            // Mostrar
            MostrarAlumnos(alumnoController.BuscarPorCodigo(codigo));
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoController.Ordenar());
        }
    }
}         
        
    

          

