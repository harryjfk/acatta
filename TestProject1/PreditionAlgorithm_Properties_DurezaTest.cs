using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_Properties_DurezaTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_Properties_DurezaTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_Properties_DurezaTest
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
        ///Una prueba de Constructor Dureza
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_Properties_DurezaConstructorTest()
        {
            PreditionAlgorithm.Properties.Dureza target = new PreditionAlgorithm.Properties.Dureza();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Bainita
        ///</summary>
        [TestMethod()]
        public void BainitaTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Dureza.Bainita(DB, Vle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Ferrita_Perlita
        ///</summary>
        [TestMethod()]
        public void Ferrita_PerlitaTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Dureza.Ferrita_Perlita(DB, Vle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Final
        ///</summary>
        [TestMethod()]
        public void FinalTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Dureza.Final(DB, Vle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Martensita
        ///</summary>
        [TestMethod()]
        public void MartensitaTest()
        {
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Dureza.Martensita(DB, Vle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de RokwellC
        ///</summary>
        [TestMethod()]
        public void RokwellCTest()
        {
            double Hv = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Dureza.RokwellC(Hv);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
