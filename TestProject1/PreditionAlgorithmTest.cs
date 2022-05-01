using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithmTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithmTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithmTest
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
        ///Una prueba de Constructor PreditionAlgorithm
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithmConstructorTest()
        {
            PreditionAlgorithm target = new PreditionAlgorithm();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Calculate
        ///</summary>
        [TestMethod()]
        public void CalculateTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            bool method = false; // TODO: Inicializar en un valor adecuado
            int pasotemp = 0; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries actual;
            actual = PreditionAlgorithm.Calculate(DB, method, pasotemp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de IntegralK
        ///</summary>
        [TestMethod()]
        public void IntegralKTest()
        {
            double K = 0F; // TODO: Inicializar en un valor adecuado
            double X0 = 0F; // TODO: Inicializar en un valor adecuado
            double Xn = 0F; // TODO: Inicializar en un valor adecuado
            bool first = false; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.IntegralK(K, X0, Xn, first);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de IsValidDB
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void IsValidDBTest()
        {
            Dictionary<string, double> Db = null; // TODO: Inicializar en un valor adecuado
            bool method = false; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = PreditionAlgorithm_Accessor.IsValidDB(Db, method);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de IsValidTemp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void IsValidTempTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = PreditionAlgorithm_Accessor.IsValidTemp(DB);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de MaxValue
        ///</summary>
        [TestMethod()]
        public void MaxValueTest()
        {
            List<PreditionAlgorithm.CalculatedPoint> ferr = null; // TODO: Inicializar en un valor adecuado
            List<PreditionAlgorithm.CalculatedPoint> bai = null; // TODO: Inicializar en un valor adecuado
            List<PreditionAlgorithm.CalculatedPoint> perl = null; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.MaxValue(ferr, bai, perl);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
