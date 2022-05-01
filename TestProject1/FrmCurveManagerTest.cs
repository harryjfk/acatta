using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmCurveManagerTest y se pretende que
    ///contenga todas las pruebas unitarias FrmCurveManagerTest.
    ///</summary>
    [TestClass()]
    public class FrmCurveManagerTest
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
        ///Una prueba de Constructor FrmCurveManager
        ///</summary>
        [TestMethod()]
        public void FrmCurveManagerConstructorTest()
        {
            FrmCurveManager target = new FrmCurveManager();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de FrmCurveManager_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void FrmCurveManager_LoadTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.FrmCurveManager_Load(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void InitializeComponentTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            target.InitializeComponent();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de gridView1_InitNewRow
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void gridView1_InitNewRowTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            InitNewRowEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.gridView1_InitNewRow(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de gridView1_RowUpdated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void gridView1_RowUpdatedTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            RowObjectEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.gridView1_RowUpdated(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de repositoryItemButtonEdit1_ButtonPressed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void repositoryItemButtonEdit1_ButtonPressedTest()
        {
            FrmCurveManager_Accessor target = new FrmCurveManager_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            ButtonPressedEventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.repositoryItemButtonEdit1_ButtonPressed(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }
    }
}
