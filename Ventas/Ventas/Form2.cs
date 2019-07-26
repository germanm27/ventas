using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var clientesBL = new ClientesBL();
            listadeClientesBindingSource.DataSource =
                clientesBL.ListadeClientes;

            var ciudadBL = new CiudadBL();
            listadeClientesBindingSource.DataSource =
                ciudadBL.ListadeCiudad;
        }
    }
}