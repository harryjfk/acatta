using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_CalculatedPointTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_CalculatedPointTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_CalculatedPointTest
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
        ///Una prueba de Constructor CalculatedPoint
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_CalculatedPointConstructorTest()
        {
            PreditionAlgorithm.CalculatedPoint target = new PreditionAlgorithm.CalculatedPoint();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Final
        ///</summary>
        [TestMethod()]
        public void FinalTest()
        {
            PreditionAlgorithm.CalculatedPoint target = new PreditionAlgorithm.CalculatedPoint(); // TODO: Inicializar en un valor adecuado
            double expected =15F; // TODO: Inicializar en un valor adecuado
            double actual;
            target.Final = expected;
            actual = target.Final;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Inicial
        ///</summary>
        [TestMethod()]
        public void InicialTest()
        {
            PreditionAlgorithm.CalculatedPoint target = new PreditionAlgorithm.CalculatedPoint(); // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            target.Inicial = expected;
            actual = target.Inicial;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Temp
        ///</summary>
        [TestMethod()]
        public void TempTest()
        {
            PreditionAlgorithm.CalculatedPoint target = new PreditionAlgorithm.CalculatedPoint(); // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            target.Temp = expected;
            actual = target.Temp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
