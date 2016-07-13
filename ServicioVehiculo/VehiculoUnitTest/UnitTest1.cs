using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using MVC1.ServiceV;

namespace VehiculoUnitTest
{  
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {           
            ServiceReference1.VehiculoServiceClient target = new ServiceReference1.VehiculoServiceClient();
            string respuesta = target.PostConfiguracion(10,10);
            NUnit.Framework.Assert.AreEqual(respuesta, "Ok");
        }

        [Test]
        public void TestMethod2()
        {
            ServiceReference1.VehiculoServiceClient target = new ServiceReference1.VehiculoServiceClient();
            VehiculoRespuesta modelRespuesta = new VehiculoRespuesta();
            modelRespuesta = target.PostValidarComando("2,N;3,S", 10, 10, "1,2");
            NUnit.Framework.Assert.IsNotNull(modelRespuesta);
            NUnit.Framework.Assert.AreEqual(modelRespuesta.Mensaje, "Error en formato de comando");
        }

        [Test]
        public void TestMethod3()
        {
            ServiceReference1.VehiculoServiceClient target = new ServiceReference1.VehiculoServiceClient();
            string posicion = target.GetPosicion();
            NUnit.Framework.Assert.IsNotNull(posicion);            
        }

    }
}
