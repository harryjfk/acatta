using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.IO;

namespace ACATTA.Graficos
{
    public partial class FrmGraficos : DevExpress.XtraEditors.XtraForm
    {
        public FrmGraficos()
        {
            InitializeComponent();
        }

        private void t_AceroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_AceroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_CurvaValor' Puede moverla o quitarla según sea necesario.
     
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoCurva' Puede moverla o quitarla según sea necesario.
            this.t_TipoCurvaTableAdapter.Fill(this.dSDatos.T_TipoCurva);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Curva' Puede moverla o quitarla según sea necesario.
            this.t_CurvaTableAdapter.Fill(this.dSDatos.T_Curva);
            this.t_CurvaValorTableAdapter.Fill(this.dSDatos.T_CurvaValor);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.)
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
        }

        private DSDatos.T_AceroRow Acero
        {
            get
            {
                if (t_AceroBindingSource.Current != null)
                    return (DSDatos.T_AceroRow) ((DataRowView) t_AceroBindingSource.Current).Row;
                return null;

            }
        }
        private void t_AceroBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            t_CurvaBindingSource.Filter = "idacero = " + Acero.idacero.ToString();
   
  
            if (t_CurvaBindingSource.Current == null)
            {
              //  var curva = dSDatos.T_Curva.NewT_CurvaRow();
     
              //dSDatos.T_Curva.AddT_CurvaRow(curva);

              // dSDatos.T_Curva.DefaultView.RowFilter = "idcurva = " + curva.idcurva.ToString();

              //  t_CurvaBindingSource.Add(dSDatos.T_Curva.DefaultView[0]);
              //  dSDatos.T_Curva.DefaultView.RowFilter = "";
                // curva.AcceptChanges();
             //var   s = 0;
           var curva=  (DSDatos.T_CurvaRow) ((DataRowView)    t_CurvaBindingSource.AddNew()).Row;
                      curva.idacero = Acero.idacero;
                curva.idtipocurva = 1;
                curva.inicio = true;
                t_CurvaBindingSource.EndEdit();

            }
            else
            {
                t_CurvaBindingSource.EndEdit();
                   //   dSDatos.AcceptChanges();
            }
        //    t_CurvaBindingSource.Filter = "idacero = " + Acero.idacero.ToString();
      
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
      
        }

        private void FrmGraficos_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_CurvaBindingSource.EndEdit();
    
            t_CurvaValorBindingSource.EndEdit();
            t_CurvaTableAdapter.Update(dSDatos.T_Curva);
       
             t_CurvaValorTableAdapter.Update(dSDatos.T_CurvaValor);
        }
        private void LoadFromCSV(string filename)
        {
            var reader = System.IO.File.OpenText(filename);
            var i = 0;
            var list = new List<PointF>();
            while (!reader.EndOfStream)
            {
               var s = reader.ReadLine();
               if (i != 0 && s.Trim()!="")
               { 
                var x =   s.Substring(0,s.IndexOf(","));
                   var y =s.Substring(s.IndexOf(",")+1,s.Length-s.IndexOf(",")-1);

                   list.Add(new PointF(float.Parse(x.Replace('.', ',')), float.Parse(y.Replace('.', ','))));
               }
                i++;
            }
            SetValorList(list);
            
        }
        private void SetFilter()
        {
            if (Acero != null && idtipocurvaSpinEdit.EditValue is int && inicioCheckEdit.EditValue is bool)
            {
                var t = (int)idtipocurvaSpinEdit.EditValue;
                var t1 = (bool)inicioCheckEdit.EditValue;
                t_CurvaBindingSource.Filter = " idacero = " + Acero.idacero + " and  idtipocurva = " +t + " and inicio = " + t1;
                if (t_CurvaBindingSource.Current == null)
                {
                    t_CurvaBindingSource.AddNew();
                    t_CurvaBindingSource.MoveLast();
                    var valor = ((DSDatos.T_CurvaRow)((DataRowView)t_CurvaBindingSource.Current).Row);
                    valor.idacero = Acero.idacero;
                    valor.idtipocurva = t;
                    valor.inicio = t1;
                    t_CurvaBindingSource.EndEdit();
                }
            }
        }

        private void SetValorList(List<PointF> list)
        {
            while (t_CurvaValorBindingSource.Current != null)
                t_CurvaValorBindingSource.RemoveCurrent();
            foreach (PointF values in list)
            {
                t_CurvaValorBindingSource.AddNew();
                t_CurvaValorBindingSource.MoveLast();
                var valor = ((DSDatos.T_CurvaValorRow)((DataRowView)t_CurvaValorBindingSource.Current).Row);
      
                valor.valorx = values.X;
                valor.valory = values.Y;
                t_CurvaValorBindingSource.EndEdit();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var frmimport = new FrmImportGrafico();
            if (frmimport.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var list = new List<PointF>();
                foreach (SeriesPoint values in frmimport.Points)
                    list.Add(new PointF(float.Parse(values.Values[0].ToString()),float.Parse(values.NumericalArgument.ToString())));
  
            }
        }

        private void idtipocurvaSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void inicioCheckEdit_EditValueChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void idtipocurvaSpinEdit_Properties_QueryCloseUp(object sender, CancelEventArgs e)
        {
            SetFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                LoadFromCSV(openFileDialog1.FileName);
            }
        }
    }
}