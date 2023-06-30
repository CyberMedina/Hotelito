using BancoSangre.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSangre.Vista
{

    public partial class ListadoDeClientes : Form
    {
        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        Recibo recibo = new Recibo();
        List<Datosenviar> datosenviars = new List<Datosenviar>();
        private int filaSeleccionada = -1;

        public ListadoDeClientes()
        {
            InitializeComponent();
            AddDetail();
        }

        private void AddDetail()
        {
            var existe = Directory.Exists(recibo.path);

            if (existe)
            {
                Print();
            }
            else
            {
                MessageBox.Show("No hay reservaciones agendadas.");
            }
        }

        public void Print()
        {
            List<string> input = File.ReadAllLines(Path.Combine(recibo.path, recibo.Consulta)).ToList();

            foreach (var linea in input)
            {
                string[] registro = linea.Split('°');
                Datosenviar Eje = new Datosenviar();

                Eje.Nombres = registro[0];
                Eje.Apellidos = registro[1];
                Eje.Cedula = registro[2];
                Eje.Acompañantes = registro[3];
                Eje.Nacionalidad = registro[4];
                Eje.Sexo = registro[5];
                Eje.CorreoElectronico = registro[6];
                Eje.NoTelefono = registro[7];
                Eje.FechaIngreso = registro[8];
                Eje.FechaEgreso = registro[9];
                Eje.Habitacion = registro[10];
                Eje.TotalDolares = registro[11];
                Eje.TotalCordobas = registro[12];
                Datosenviar.NombredelLogin = registro[13];
                Eje.fechayhora = registro[14];

                datosenviars.Add(Eje);

                int row = Listado.Rows.Add();
                Listado.Rows[row].Cells[0].Value = Eje.Nombres;
                Listado.Rows[row].Cells[1].Value = Eje.Apellidos;
                Listado.Rows[row].Cells[2].Value = Eje.Cedula;
                Listado.Rows[row].Cells[3].Value = Eje.Acompañantes;
                Listado.Rows[row].Cells[4].Value = Eje.Nacionalidad;
                Listado.Rows[row].Cells[5].Value = Eje.Sexo;
                Listado.Rows[row].Cells[6].Value = Eje.CorreoElectronico;
                Listado.Rows[row].Cells[7].Value = Eje.NoTelefono;
                Listado.Rows[row].Cells[8].Value = Eje.FechaIngreso;
                Listado.Rows[row].Cells[9].Value = Eje.FechaEgreso;
                Listado.Rows[row].Cells[10].Value = Eje.Habitacion;
                Listado.Rows[row].Cells[11].Value = Eje.TotalDolares;
                Listado.Rows[row].Cells[12].Value = Eje.TotalCordobas;
                Listado.Rows[row].Cells[13].Value = Datosenviar.NombredelLogin;
                Listado.Rows[row].Cells[14].Value = Eje.fechayhora;
            }
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0 && filaSeleccionada < datosenviars.Count)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar la reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el registro de la lista
                    datosenviars.RemoveAt(filaSeleccionada);

                    // Eliminar la fila seleccionada del DataGridView
                    Listado.Rows.RemoveAt(filaSeleccionada);

                    // Reiniciar el valor de filaSeleccionada
                    filaSeleccionada = -1;

                    // Guardar los datos actualizados en el archivo
                    ReescribirArchivo();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila válida.");
            }
        }


        private void ReescribirArchivo()
        {
            List<string> lines = new List<string>();

            // Convertir los datos actualizados en líneas de texto
            foreach (Datosenviar datos in datosenviars)
            {
                string line = $"{datos.Nombres}°{datos.Apellidos}°{datos.Cedula}°{datos.Acompañantes}°{datos.Nacionalidad}°{datos.Sexo}°{datos.CorreoElectronico}°{datos.NoTelefono}°{datos.FechaIngreso}°{datos.FechaEgreso}°{datos.Habitacion}°{datos.TotalDolares}°{datos.TotalCordobas}°{Datosenviar.NombredelLogin}°{datos.fechayhora}";
                lines.Add(line);
            }

            // Sobrescribir el archivo con los datos actualizados
            File.WriteAllLines(Path.Combine(path, Consulta), lines);
        }



        private void Listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == -1)
            {
                // Establecer el color de la nueva fila seleccionada
                filaSeleccionada = e.RowIndex;
            }
        }


        private void LabelClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
