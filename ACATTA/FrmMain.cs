using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACATTA.Codificadores;
using ACATTA.Prediccion;
using ACATTA.Tareas;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;


namespace ACATTA
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }


        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private Form CreateForm(Form form, bool dialog=false)
        {
            //if(!dialog)
            //form.MdiParent = this;
            form.Show(this); 
            return form;


        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmTanque());
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCalculoTT());
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmDeterminarTT());
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmHornos(), true);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Norma' Puede moverla o quitarla según sea necesario.
            this.t_NormaTableAdapter.Fill(this.dSDatos.T_Norma);
            barEditItem1.EditValue = Properties.Settings.Default.Norma;
            ACINOX.Functions.Skins.FillSkins(ribbonGalleryBarItem1);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
 Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Norma = Int32.Parse(barEditItem1.EditValue.ToString());
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEvalHorno());
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMaterial(), true);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmAcero(),true);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmHornos(), true);
        }

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmFormula(), true);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmPredecir());
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCurveManager());
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

    }
}