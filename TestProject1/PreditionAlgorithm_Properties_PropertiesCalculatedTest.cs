using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_Properties_PropertiesCalculatedTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_Properties_PropertiesCalculatedTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_Properties_PropertiesCalculatedTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Constructor PropertiesCalculated
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_Properties_PropertiesCalculatedConstructorTest()
        {
            PreditionAlgorithm.Properties.PropertiesCalculated target = new PreditionAlgorithm.Properties.PropertiesCalculated();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Percents
        ///</summary>
        [TestMethod()]
        public void PercentsTest()
        {
            PreditionAlgorithm.Properties.PropertiesCalculated target = new PreditionAlgorithm.Properties.PropertiesCalculated(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = target.Percents;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Points
        ///</summary>
        [TestMethod()]
        public void PointsTest()
        {
            PreditionAlgorithm.Properties.PropertiesCalculated target = new PreditionAlgorithm.Properties.PropertiesCalculated(); // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.Points;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de PtoInicio
        ///</summary>
        [TestMethod()]
        public void PtoInicioTest()
        {
            PreditionAlgorithm.Properties.PropertiesCalculated target = new PreditionAlgorithm.Properties.PropertiesCalculated(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, PreditionAlgorithm.CalculatedPoint> actual;
            actual = target.PtoInicio;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de VelocidadExtraction
        ///</summary>
        [TestMethod()]
        public void VelocidadExtractionTest()
        {
            PreditionAlgorithm.Properties.PropertiesCalculated target = new PreditionAlgorithm.Properties.PropertiesCalculated(); // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            target.VelocidadExtraction = expected;
            actual = target.VelocidadExtraction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
