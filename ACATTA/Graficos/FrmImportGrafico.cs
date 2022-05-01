using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace ACATTA.Graficos
{
    public partial class FrmImportGrafico : DevExpress.XtraEditors.XtraForm
    {
        public FrmImportGrafico()
        {
            InitializeComponent();
        }

        public SeriesPointCollection Points { get { return chartControl1.Series[0].Points; } }
        private void chartControl1_MouseClick(object sender, MouseEventArgs e)
        {
           //chartControl1.
           var s = ((XYDiagram)chartControl1.Diagram).PointToDiagram(e.Location);
            
            chartControl1.Series[0].Points.Add(new SeriesPoint(s.NumericalArgument, s.NumericalValue));
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}