using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmViewPredecirTest y se pretende que
    ///contenga todas las pruebas unitarias FrmViewPredecirTest.
    ///</summary>
    [TestClass()]
    public class FrmViewPredecirTest
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
        ///Una prueba de Constructor FrmViewPredecir
        ///</summary>
        [TestMethod()]
        public void FrmViewPredecirConstructorTest()
        {
            FrmViewPredecir target = new FrmViewPredecir();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmViewPredecir_Accessor target = new FrmViewPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de FillChart
        ///</summary>
        [TestMethod()]
        public void FillChartTest()
        {
            FrmViewPredecir target = new FrmViewPredecir(); // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries series = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.Properties.PropertiesCalculated calculated = null; // TODO: Inicializar en un valor adecuado
            target.FillChart(series, calculated);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void InitializeComponentTest()
        {
            FrmViewPredecir_Accessor target = new FrmViewPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            target.InitializeComponent();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton1_ClickTest()
        {
            FrmViewPredecir_Accessor target = new FrmViewPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de ParentPredecir
        ///</summary>
        [TestMethod()]
        public void ParentPredecirTest()
        {
            FrmViewPredecir target = new FrmViewPredecir(); // TODO: Inicializar en un valor adecuado
            FrmPredictPropiedades expected = null; // TODO: Inicializar en un valor adecuado
            FrmPredictPropiedades actual;
            target.ParentPredecir = expected;
            actual = target.ParentPredecir;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
