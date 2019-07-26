using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "SPS");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var cliente1 = new Cliente(1, "Juan Perez", "+504 9321-7482", "Bo. Guamilito", ciudad1);
            var cliente2 = new Cliente(2, "Diego Lopez", "+504 9131-0921", "Bo. Medina", ciudad1);
            var cliente3 = new Cliente(3, "Pedro Ruiz", "+504 8321-8730", "Bo. Morazan", ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
