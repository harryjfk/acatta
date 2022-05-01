using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACATTA;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_PredictSeriesTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_PredictSeriesTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_PredictSeriesTest
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
        ///Una prueba de Constructor PredictSeries
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_PredictSeriesConstructorTest()
        {
            PreditionAlgorithm.PredictSeries target = new PreditionAlgorithm.PredictSeries();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de FromGraphObject
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void FromGraphObjectTest()
        {
            GraphicObject graphobject = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries actual;
            actual = PreditionAlgorithm_Accessor.PredictSeries.FromGraphObject(graphobject);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de MinTempTranf
        ///</summary>
        [TestMethod()]
        public void MinTempTranfTest()
        {
            PreditionAlgorithm.PredictSeries target = new PreditionAlgorithm.PredictSeries(); // TODO: Inicializar en un valor adecuado
            Nullable<double> expected = new Nullable<double>(); // TODO: Inicializar en un valor adecuado
            Nullable<double> actual;
            actual = target.MinTempTranf();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de SerieByName
        ///</summary>
        [TestMethod()]
        public void SerieByNameTest()
        {
            PreditionAlgorithm.PredictSeries target = new PreditionAlgorithm.PredictSeries(); // TODO: Inicializar en un valor adecuado
            string name = string.Empty; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.SerieByName(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
