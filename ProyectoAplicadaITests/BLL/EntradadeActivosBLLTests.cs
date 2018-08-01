using BLL;
using ENTIDADES;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class EntradadeActivosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            EntradadeActivos activos = new EntradadeActivos();
            bool paso;
            activos.EntradadeActivosId = 0;
            activos.ActivodeNegocioId = 1;
            activos.Fecha = DateTime.Now;
            activos.Motivo = "Inicio";
            activos.Suma = 5000;
            paso = EntradadeActivosBLL.Guardar(activos);
            Assert.AreEqual(paso,true);
        }

        

        [TestMethod()]
        public void EditarTest()
        {
            EntradadeActivos activos = new EntradadeActivos();
            bool paso;
            activos.EntradadeActivosId = 1;
            activos.ActivodeNegocioId = 1;
            activos.Fecha = DateTime.Now;
            activos.Motivo = "Inicio";
            activos.Suma = 2500;
            paso = EntradadeActivosBLL.Editar(activos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            EntradadeActivos activos = new EntradadeActivos();
            activos = EntradadeActivosBLL.Buscar(id);
            Assert.IsNotNull(activos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var activos = EntradadeActivosBLL.GetList(x => true);
            Assert.IsNotNull(activos);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;
            paso = EntradadeActivosBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }

    }
}