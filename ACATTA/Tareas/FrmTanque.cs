using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ACATTA.Reportes;
using DevExpress.XtraEditors;

namespace ACATTA.Tareas
{
    public partial class FrmTanque : DevExpress.XtraEditors.XtraForm
    {
        public FrmTanque()
        {
            InitializeComponent();
        }

        private void FrmTanque_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.t_TipoMaterialTableAdapter.Fill(this.dSDatos.T_TipoMaterial);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_MedioEnfriamiento' Puede moverla o quitarla según sea necesario.
            this.t_MedioEnfriamientoTableAdapter.Fill(this.dSDatos.T_MedioEnfriamiento);
            t_CapacidadCalorificaTableAdapter1.Fill(dSDatos.T_CapacidadCalorifica);
            t_CapacidadDeslozeTableAdapter1.Fill(dSDatos.T_CapacidadDesloze);
            for (int i = 20; i <= 80; i++)
            {
                if (i <= 40)
                    inicialliquidoedit.Properties.Items.Add(i);
                finalliquidoedit.Properties.Items.Add(i);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var calculateweight = new FrmCalculateWeight();
            if (calculateweight.ShowDialog(this) == DialogResult.OK)
                pesoedit.EditValue = calculateweight.Weight;
        }

        public DSDatos.T_TipoMaterialRow Material { get
        {
            return /*dSDatos.T_TipoMaterial.FindByidtipomaterial(int.Parse(tipomatedit.EditValue.ToString())); */
                dSDatos.T_TipoMaterial[0];
        } }
        public DSDatos.T_MedioEnfriamientoRow MedioEnfriamiento { get
        {
            return /*dSDatos.T_MedioEnfriamiento.FindByidmedioenf(int.Parse(medioenfedit.EditValue.ToString()));*/
                dSDatos.T_MedioEnfriamiento[0];
        } }
       

        private void ucPieFormulario1_Aceptar(object sender)
        {
          
            if (dxValidationProvider1
                .Validate())
            {
               var res = DSDatos.T_Tanque.CalculateCircular(Material, MedioEnfriamiento,
                                                         int.Parse(inicialmetaledit.EditValue.ToString()),
                                                         int.Parse(finmetaledit.EditValue.ToString()),
                                                         int.Parse(inicialliquidoedit.EditValue.ToString()),
                                                         int.Parse(finalliquidoedit.EditValue.ToString()),
                                                         float.Parse(cantpiezasedit.EditValue.ToString()),
                                                         float.Parse(pesoedit.EditValue.ToString()),
                                                         float.Parse(dimensionedit.EditValue.ToString()));
              //  var
              //  res = DSDatos.T_Tanque.CalculateCircular(Material, MedioEnfriamiento, 825, 30, 40, 30, 6, (float) 15.2, 367);



            //    var pi = new MemoryStream();
            //    pictureBox1.Image.Save(pi, ImageFormat.Bmp);
            //    res.Add("img", pi.ToArray());
                var frmreport = new FrmReporte();
                frmreport.Text = "Reporte de calculo de tanque";
                frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\EvalTanque.repx", res);
                frmreport.ShowDialog(this);
            }
        }
    }
}