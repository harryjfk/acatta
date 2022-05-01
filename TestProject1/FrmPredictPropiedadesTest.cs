using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmPredictPropiedadesTest y se pretende que
    ///contenga todas las pruebas unitarias FrmPredictPropiedadesTest.
    ///</summary>
    [TestClass()]
    public class FrmPredictPropiedadesTest
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
        ///Una prueba de Constructor FrmPredictPropiedades
        ///</summary>
        [TestMethod()]
        public void FrmPredictPropiedadesConstructorTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de CompareDinosByLength
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void CompareDinosByLengthTest()
        {
            PreditionAlgorithm.CalculatedPoint x = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPoint y = null; // TODO: Inicializar en un valor adecuado
            int expected = 0; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = FrmPredictPropiedades_Accessor.CompareDinosByLength(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de CreateSerieResult
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void CreateSerieResultTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            target.CreateSerieResult();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de GenerateCurvesCTT
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GenerateCurvesCTTTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            target.GenerateCurvesCTT();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de GetSerieInitialPoint
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetSerieInitialPointTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            string name = string.Empty; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.CalculatedPointList actual;
            actual = target.GetSerieInitialPoint(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GetSeriesOrdered
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetSeriesOrderedTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            List<PreditionAlgorithm.CalculatedPointList> expected = null; // TODO: Inicializar en un valor adecuado
            List<PreditionAlgorithm.CalculatedPointList> actual;
            actual = target.GetSeriesOrdered();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void InitializeComponentTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            target.InitializeComponent();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de chartControl1_ObjectSelected
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void chartControl1_ObjectSelectedTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            HotTrackEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.chartControl1_ObjectSelected(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de checkEdit1_CheckedChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void checkEdit1_CheckedChangedTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.checkEdit1_CheckedChanged(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de checkEdit1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void checkEdit1_ClickTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.checkEdit1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton1_ClickTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton2_ClickTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton2_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton3_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton3_ClickTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton3_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton4_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton4_ClickTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton4_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de ucPieFormulario1_Aceptar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void ucPieFormulario1_AceptarTest()
        {
            FrmPredictPropiedades_Accessor target = new FrmPredictPropiedades_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            target.ucPieFormulario1_Aceptar(sender);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de ParentPredecir
        ///</summary>
        [TestMethod()]
        public void ParentPredecirTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            FrmPredecir expected = null; // TODO: Inicializar en un valor adecuado
            FrmPredecir actual;
            target.ParentPredecir = expected;
            actual = target.ParentPredecir;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de ResultDB
        ///</summary>
        [TestMethod()]
        public void ResultDBTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            target.ResultDB = expected;
            actual = target.ResultDB;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Serie
        ///</summary>
        [TestMethod()]
        public void SerieTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries expected = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries actual;
            target.Serie = expected;
            actual = target.Serie;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de To
        ///</summary>
        [TestMethod()]
        public void ToTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.To;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Vle
        ///</summary>
        [TestMethod()]
        public void VleTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.Vle;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de dt
        ///</summary>
        [TestMethod()]
        public void dtTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.dt;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de mf
        ///</summary>
        [TestMethod()]
        public void mfTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.mf;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de retTiempo
        ///</summary>
        [TestMethod()]
        public void retTiempoTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.retTiempo;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de te
        ///</summary>
        [TestMethod()]
        public void teTest()
        {
            FrmPredictPropiedades target = new FrmPredictPropiedades(); // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.te;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
