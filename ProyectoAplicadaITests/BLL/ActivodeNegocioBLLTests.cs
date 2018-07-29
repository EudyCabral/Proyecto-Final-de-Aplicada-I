using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.DAL;
using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class ActivodeNegocioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            ActivodeNegocio activo = new ActivodeNegocio();
            activo.ActivodeNegocioId = 0;
            activo.Nombre = "Capital";
            activo.Activo = 85000;
            paso = BLL.ActivodeNegocioBLL.Guardar(activo);

            Assert.AreEqual(paso,true);
        }

       

        [TestMethod()]
        public void EditarTest()
        {
            bool paso;
            ActivodeNegocio activo = new ActivodeNegocio();
            activo.ActivodeNegocioId = 1;
            activo.Nombre = "Capital2";
            activo.Activo = 58536;
            paso = BLL.ActivodeNegocioBLL.Editar(activo);

            Assert.AreEqual(paso, true);
        }

      
        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            ActivodeNegocio negocio = new ActivodeNegocio();
            negocio = BLL.ActivodeNegocioBLL.Buscar(id);
            Assert.IsNotNull(negocio);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = BLL.ActivodeNegocioBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 2;
            paso = BLL.ActivodeNegocioBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

    }
}