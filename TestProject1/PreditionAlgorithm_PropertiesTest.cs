using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_PropertiesTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_PropertiesTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_PropertiesTest
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
        ///Una prueba de Constructor Properties
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_PropertiesConstructorTest()
        {
            PreditionAlgorithm.Properties target = new PreditionAlgorithm.Properties();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Di
        ///</summary>
        [TestMethod()]
        public void DiTest()
        {
            double fi = 0F; // TODO: Inicializar en un valor adecuado
            double b = 0F; // TODO: Inicializar en un valor adecuado
            double n = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.Di(fi, b, n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de F_Martensita
        ///</summary>
        [TestMethod()]
        public void F_MartensitaTest()
        {
            Dictionary<string, double> Percents = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double T = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.F_Martensita(Percents, DB, T);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de F_Transformada
        ///</summary>
        [TestMethod()]
        public void F_TransformadaTest()
        {
            Dictionary<string, double> tiempos = null; // TODO: Inicializar en un valor adecuado
            double dt = 0F; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Percents = null; // TODO: Inicializar en un valor adecuado
            string valor = string.Empty; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = PreditionAlgorithm.Properties.F_Transformada(tiempos, dt, Percents, valor);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Ferritico
        ///</summary>
        [TestMethod()]
        public void FerriticoTest()
        {
            PreditionAlgorithm.PredictSeries series = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double te = 0F; // TODO: Inicializar en un valor adecuado
            double dt = 0F; // TODO: Inicializar en un valor adecuado
            double mf = 0F; // TODO: Inicializar en un valor adecuado
            double To = 0F; // TODO: Inicializar en un valor adecuado
            double retTiempo = 0F; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList ser = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList serExpected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = PreditionAlgorithm.Properties.Ferritico(series, DB, te, dt, mf, To, retTiempo, Vle, out ser);
            Assert.AreEqual(serExpected, ser);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GetTemp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetTempTest()
        {
            PreditionAlgorithm.CalculatedPointList s = null; // TODO: Inicializar en un valor adecuado
            double T = 0F; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = PreditionAlgorithm_Accessor.Properties.GetTemp(s, T);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Normalize
        ///</summary>
        [TestMethod()]
        public void NormalizeTest()
        {
            Dictionary<string, double> res = null; // TODO: Inicializar en un valor adecuado
            int i = 0; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.Properties.Normalize(res, i, DB);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Predict
        ///</summary>
        [TestMethod()]
        public void PredictTest()
        {
            PreditionAlgorithm.PredictSeries series = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double te = 0F; // TODO: Inicializar en un valor adecuado
            double dt = 0F; // TODO: Inicializar en un valor adecuado
            double mf = 0F; // TODO: Inicializar en un valor adecuado
            double To = 0F; // TODO: Inicializar en un valor adecuado
            double retTiempo = 0F; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList ser = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList serExpected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = PreditionAlgorithm.Properties.Predict(series, DB, te, dt, mf, To, retTiempo, Vle, out ser);
            Assert.AreEqual(serExpected, ser);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de PredictionFraccion
        ///</summary>
        [TestMethod()]
        public void PredictionFraccionTest()
        {
            PreditionAlgorithm.PredictSeries series = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            double te = 0F; // TODO: Inicializar en un valor adecuado
            double dt = 0F; // TODO: Inicializar en un valor adecuado
            double mf = 0F; // TODO: Inicializar en un valor adecuado
            double To = 0F; // TODO: Inicializar en un valor adecuado
            double retTiempo = 0F; // TODO: Inicializar en un valor adecuado
            double Vle = 0F; // TODO: Inicializar en un valor adecuado
            bool check = false; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.Properties.PropertiesCalculated expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.Properties.PropertiesCalculated actual;
            actual = PreditionAlgorithm.Properties.PredictionFraccion(series, DB, te, dt, mf, To, retTiempo, Vle, check);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de UpdateDictionary
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void UpdateDictionaryTest()
        {
            string name = string.Empty; // TODO: Inicializar en un valor adecuado
            double valor = 0F; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> DB = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm_Accessor.Properties.UpdateDictionary(name, valor, DB);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de VerificaMicroestructura
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void VerificaMicroestructuraTest()
        {
            PreditionAlgorithm.PredictSeries series = null; // TODO: Inicializar en un valor adecuado
            double Temp = 0F; // TODO: Inicializar en un valor adecuado
            string microestruct = string.Empty; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = PreditionAlgorithm_Accessor.Properties.VerificaMicroestructura(series, Temp, microestruct);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
