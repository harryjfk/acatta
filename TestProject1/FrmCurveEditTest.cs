using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmCurveEditTest y se pretende que
    ///contenga todas las pruebas unitarias FrmCurveEditTest.
    ///</summary>
    [TestClass()]
    public class FrmCurveEditTest
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
        ///Una prueba de Constructor FrmCurveEdit
        ///</summary>
        [TestMethod()]
        public void FrmCurveEditConstructorTest()
        {
            FrmCurveEdit target = new FrmCurveEdit();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmCurveEdit_Accessor target = new FrmCurveEdit_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void InitializeComponentTest()
        {
            FrmCurveEdit_Accessor target = new FrmCurveEdit_Accessor(); // TODO: Inicializar en un valor adecuado
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
            FrmCurveEdit_Accessor target = new FrmCurveEdit_Accessor(); // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.IsValid();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de ucPieFormulario1_Aceptar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void ucPieFormulario1_AceptarTest()
        {
            FrmCurveEdit_Accessor target = new FrmCurveEdit_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            target.ucPieFormulario1_Aceptar(sender);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de data
        ///</summary>
        [TestMethod()]
        public void dataTest()
        {
            FrmCurveEdit target = new FrmCurveEdit(); // TODO: Inicializar en un valor adecuado
            byte[] expected = null; // TODO: Inicializar en un valor adecuado
            byte[] actual;
            target.data = expected;
            actual = target.data;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
