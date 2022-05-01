using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para PreditionAlgorithm_CalculatedPointListTest y se pretende que
    ///contenga todas las pruebas unitarias PreditionAlgorithm_CalculatedPointListTest.
    ///</summary>
    [TestClass()]
    public class PreditionAlgorithm_CalculatedPointListTest
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
        ///Una prueba de Constructor CalculatedPointList
        ///</summary>
        [TestMethod()]
        public void PreditionAlgorithm_CalculatedPointListConstructorTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de GetByTemp
        ///</summary>
        [TestMethod()]
        public void GetByTempTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList(); // TODO: Inicializar en un valor adecuado
            double Temp = 0F; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = target.GetByTemp(Temp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de ItemByRange
        ///</summary>
        [TestMethod()]
        public void ItemByRangeTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList(); // TODO: Inicializar en un valor adecuado
            double Temp = 0F; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPoint expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPoint actual;
            actual = target.ItemByRange(Temp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de ItemByTemp
        ///</summary>
        [TestMethod()]
        public void ItemByTempTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList(); // TODO: Inicializar en un valor adecuado
            double Temp = 0F; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPoint expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPoint actual;
            actual = target.ItemByTemp(Temp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Order
        ///</summary>
        [TestMethod()]
        public void OrderTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList(); // TODO: Inicializar en un valor adecuado
            target.Order();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            PreditionAlgorithm.CalculatedPointList target = new PreditionAlgorithm.CalculatedPointList(); // TODO: Inicializar en un valor adecuado
            string expected = string.Empty; // TODO: Inicializar en un valor adecuado
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
