using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class ClienteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Clientes clientes = new Clientes();
            clientes.ClienteId = 0;
            clientes.Nombre = "Eudy Cabral Burgos";
            clientes.Cedula = "402-7896542-1";
            clientes.Direccion = "Urb. Turin";
            clientes.Telefono = "809-712-4606";
            paso = BLL.ClienteBLL.Guardar(clientes);
            Assert.AreEqual(paso,true);
        }



        [TestMethod()]
        public void EditarTest()
        {
            bool paso;
            Clientes clientes = new Clientes();
            clientes.ClienteId = 1;
            clientes.Nombre = "Eudes Rafael Cabral de la Cruz Dr";
            clientes.Cedula = "402-7896542-1";
            clientes.Direccion = "Urb. Turin";
            clientes.Telefono = "809-712-4606";
            paso = BLL.ClienteBLL.Editar(clientes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Clientes clientes = new Clientes();
            clientes = BLL.ClienteBLL.Buscar(id);
            Assert.IsNotNull(clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = BLL.ClienteBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = BLL.ClienteBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

    }
}