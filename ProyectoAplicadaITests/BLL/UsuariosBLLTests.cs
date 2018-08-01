using BLL;
using ENTIDADES;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuarios = new Usuarios();
            bool paso;
            usuarios.UsuariosId = 0;
            usuarios.Nombre = "Eudy Cabral";
            usuarios.Usuario = "Eudy02";
            usuarios.Contraseña = "122017";
            usuarios.Tipodeusuario = "Admin";
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso,true);
        }

      
        [TestMethod()]
        public void EditarTest()
        {
            Usuarios usuarios = new Usuarios();
            bool paso;
            usuarios.UsuariosId = 1;
            usuarios.Nombre = "Eudes Cabral";
            usuarios.Usuario = "Eudes02";
            usuarios.Contraseña = "122017";
            usuarios.Tipodeusuario = "Admin";
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Usuarios usuarios = new Usuarios();
            usuarios = UsuariosBLL.Buscar(id);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = UsuariosBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = UsuariosBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }

    }
}