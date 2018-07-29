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
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulos = new Articulos();
            articulos.ArticuloId = 0;
            articulos.Nombre = "Plancha";
            articulos.Inventario = 0;
            paso = BLL.ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso,true);
        }

   

        [TestMethod()]
        public void EditarTest()
        {
            bool paso;
            Articulos articulos = new Articulos();
            articulos.ArticuloId = 1;
            articulos.Nombre = "tanque";
            articulos.Inventario = 0;
            paso = BLL.ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Articulos articulos = new Articulos();
            articulos = BLL.ArticulosBLL.Buscar(id);

            Assert.IsNotNull(articulos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var LISTAR = BLL.ArticulosBLL.GetList(X=>true );
            Assert.IsNotNull(LISTAR);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 2;
            paso = BLL.ArticulosBLL.Eliminar(id);

            Assert.AreEqual(paso, true);
        }
    }
}