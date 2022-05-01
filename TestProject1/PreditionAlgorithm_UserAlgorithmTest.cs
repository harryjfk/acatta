using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_UserAlgorithmTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_UserAlgorithmTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_UserAlgorithmTest
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
        ///Una prueba de Constructor UserAlgorithm
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_UserAlgorithmConstructorTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de CalculateBainita
        ///</summary>
        [TestMethod()]
        public void CalculateBainitaTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            int pasotemp = 0; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.CalculateBainita(DB, pasotemp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de CalculateFerrita
        ///</summary>
        [TestMethod()]
        public void CalculateFerritaTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            bool first = false; // TODO: Inicializar en un valor adecuado
            int pasotemp = 0; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.CalculateFerrita(DB, first, pasotemp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de CalculatePerlita
        ///</summary>
        [TestMethod()]
        public void CalculatePerlitaTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            int pasotemp = 0; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.CalculatePerlita(DB, pasotemp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GetNouseBainita
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetNouseBainitaTest()
        {
            PreditionAlgorithm_Accessor.UserAlgorithm target = new PreditionAlgorithm_Accessor.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            int pasotemp = 0; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.GetNouseBainita(DB, pasotemp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de TB
        ///</summary>
        [TestMethod()]
        public void TBTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Xf = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.TB(DB, Xf);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de TF
        ///</summary>
        [TestMethod()]
        public void TFTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Xf = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.TF(DB, Xf);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de TP
        ///</summary>
        [TestMethod()]
        public void TPTest()
        {
            PreditionAlgorithm.UserAlgorithm target = new PreditionAlgorithm.UserAlgorithm(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Xf = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.TP(DB, Xf);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
