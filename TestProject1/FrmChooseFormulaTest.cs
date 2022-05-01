using ACATTA.Prediccion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ACATTA;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FrmChooseFormulaTest y se pretende que
    ///contenga todas las pruebas unitarias FrmChooseFormulaTest.
    ///</summary>
    [TestClass()]
    public class FrmChooseFormulaTest
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
        ///Una prueba de Constructor FrmChooseFormula
        ///</summary>
        [TestMethod()]
        public void FrmChooseFormulaConstructorTest()
        {
            FrmChooseFormula target = new FrmChooseFormula();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void DisposeTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            bool disposing = false; // TODO: Inicializar en un valor adecuado
            target.Dispose(disposing);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de FrmChooseFormula_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void FrmChooseFormula_LoadTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.FrmChooseFormula_Load(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void InitializeComponentTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            target.InitializeComponent();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de gridLookUpEdit1_Properties_EditValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void gridLookUpEdit1_Properties_EditValueChangedTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.gridLookUpEdit1_Properties_EditValueChanged(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de simpleButton1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void simpleButton1_ClickTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.simpleButton1_Click(sender, e);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de ucPieFormulario1_Aceptar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void ucPieFormulario1_AceptarTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            target.ucPieFormulario1_Aceptar(sender);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de DB
        ///</summary>
        [TestMethod()]
        public void DBTest()
        {
            FrmChooseFormula target = new FrmChooseFormula(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            target.DB = expected;
            actual = target.DB;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Formula
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ACATTA.exe")]
        public void FormulaTest()
        {
            FrmChooseFormula_Accessor target = new FrmChooseFormula_Accessor(); // TODO: Inicializar en un valor adecuado
            DSDatos.T_FormulaRow actual;
            actual = target.Formula;
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Pto
        ///</summary>
        [TestMethod()]
        public void PtoTest()
        {
            FrmChooseFormula target = new FrmChooseFormula(); // TODO: Inicializar en un valor adecuado
            string expected = string.Empty; // TODO: Inicializar en un valor adecuado
            string actual;
            target.Pto = expected;
            actual = target.Pto;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            FrmChooseFormula target = new FrmChooseFormula(); // TODO: Inicializar en un valor adecuado
            Nullable<double> expected = new Nullable<double>(); // TODO: Inicializar en un valor adecuado
            Nullable<double> actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
