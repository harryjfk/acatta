using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevExpress.XtraCharts;
using ACATTA;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmPredecirTest y se pretende que
    ///contenga todas las pruebas unitarias FrmPredecirTest.
    ///</summary>
    [TestClass()]
    public class FrmPredecirTest
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
        ///Una prueba de Constructor FrmPredecir
        ///</summary>
        [TestMethod()]
        public void FrmPredecirConstructorTest()
        {
            FrmPredecir target = new FrmPredecir();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de FillChartControl
        ///</summary>
        [TestMethod()]
        public void FillChartControlTest()
        {
            ChartControl chart = null; // TODO: Inicializar en un valor adecuado
            PreditionAlgorithm.PredictSeries serie = null; // TODO: Inicializar en un valor adecuado
            FrmPredecir.FillChartControl(chart, serie);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de FrmPredecir_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void FrmPredecir_LoadTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.FrmPredecir_Load(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de GetValor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetValorTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            DSDatos.T_AceroPuntoRow[] ptos = null; // TODO: Inicializar en un valor adecuado
            string s = string.Empty; // TODO: Inicializar en un valor adecuado
            string expected = string.Empty; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = target.GetValor(ptos, s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GetindexList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void GetindexListTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            string s = string.Empty; // TODO: Inicializar en un valor adecuado
            int expected = 0; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = target.GetindexList(s);
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
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            target.InitializeComponent();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de IsValid
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void IsValidTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.IsValid();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Test
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void TestTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            target.Test();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de aceroPredecBindingSource_ListChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void aceroPredecBindingSource_ListChangedTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            ListChangedEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.aceroPredecBindingSource_ListChanged(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de button1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void button1_ClickTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.button1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de buttonEdit1_ButtonClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void buttonEdit1_ButtonClickTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            ButtonPressedEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.buttonEdit1_ButtonClick(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de chartControl1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void chartControl1_ClickTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.chartControl1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de checkEdit1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void checkEdit1_ClickTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.checkEdit1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de checkEdit1_Properties_CheckStateChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void checkEdit1_Properties_CheckStateChangedTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.checkEdit1_Properties_CheckStateChanged(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de gridLookUpEdit1_Properties_EditValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void gridLookUpEdit1_Properties_EditValueChangedTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.gridLookUpEdit1_Properties_EditValueChanged(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de gridView1_RowUpdated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void gridView1_RowUpdatedTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            RowObjectEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.gridView1_RowUpdated(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton1_ClickTest()
        {
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
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
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
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
            FrmPredecir_Accessor target = new FrmPredecir_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton3_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Acero
        ///</summary>
        [TestMethod()]
        public void AceroTest()
        {
            FrmPredecir target = new FrmPredecir(); // TODO: Inicializar en un valor adecuado
            DSDatos.T_AceroRow actual;
            actual = target.Acero;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Norma
        ///</summary>
        [TestMethod()]
        public void NormaTest()
        {
            FrmPredecir target = new FrmPredecir(); // TODO: Inicializar en un valor adecuado
            DSDatos.T_NormaRow actual;
            actual = target.Norma;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
