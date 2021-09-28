using dominio;
using dominio.Enums;
using Estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {   Model em;
        public Form1()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            decimal valor;
            DateTime fecha;
            
            decimal valorecidual;

            int codigo = (int)numCodigo.Value;

            valorecidual = numericUpDown1.Value;
            nombre = txtNom.Text;
            descripcion = txtDesc.Text;
            valor = numValor.Value;
            fecha = dateTimePicker1.Value.Date;
            decimal depreciacion; if (cmbTipo.SelectedIndex == 0) {
                depreciacion = (decimal)numericUpDown2.Value;

                decimal valordepreciadoL = em.CalcularDepreciacion(valor, valorecidual, depreciacion);
                AtributosProducto emp = new AtributosProducto()
                {
                    ID = ++this.id,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Codigo = codigo,
                    ValorActivo = valor,
                    ValorRecidual = valorecidual,
                    VidaUtil = depreciacion,
                    FechaDeAdquicision = fecha,
                    Activo = (TipoActivo)cmbTipo.SelectedIndex,



                };

                MessageBox.Show($"   id = {emp.ID}{Environment.CommandLine}" +
                                                         $" nombre = {emp.Nombre}{Environment.CommandLine}");

 
                

            };
        }
    }
}
