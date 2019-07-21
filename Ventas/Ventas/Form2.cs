using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Tegucigalpa";

            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan Perez";
            cliente1.Telefono = "+504 9763-0913";
            cliente1.Direccion = "Barrio Guamilito";
            cliente1.Cuidad = ciudad1;

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Diego Lopez";
            cliente2.Telefono = "+504 8912-0921";
            cliente2.Direccion = "Barrio Medina";
            cliente2.Cuidad = ciudad1;

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Pedro Martinez";
            cliente3.Telefono = "+504 9238-7457";
            cliente3.Direccion = "Barrio Morazan";
            cliente3.Cuidad = ciudad2;

            var listadeclientes = new List<Cliente>();
            listadeclientes.Add(cliente1);
            listadeclientes.Add(cliente2);
            listadeclientes.Add(cliente3);

            foreach (var cliente in listadeclientes)
            {
                MessageBox.Show(cliente.Id + "\n" +cliente.Nombre+ "\n"+cliente.Telefono+"\n"+
                    cliente.Direccion+"\n"+cliente.Cuidad.Descripcion);
            }
        }
    }
}
