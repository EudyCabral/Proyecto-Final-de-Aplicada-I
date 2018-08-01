using BLL;
using ENTIDADES;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            paso = ClienteBLL.Guardar(clientes);
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
            paso = ClienteBLL.Editar(clientes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Clientes clientes = new Clientes();
            clientes = ClienteBLL.Buscar(id);
            Assert.IsNotNull(clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = ClienteBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = ClienteBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

    }
}