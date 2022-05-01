namespace ACATTA.Graficos
{
    partial class FrmImportGrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel5 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView5 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel6 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView6 = new DevExpress.XtraCharts.SplineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram3.AxisX.Range.Auto = false;
            xyDiagram3.AxisX.Range.MaxValueSerializable = "100";
            xyDiagram3.AxisX.Range.MinValueSerializable = "0";
            xyDiagram3.AxisX.Range.ScrollingRange.Auto = false;
            xyDiagram3.AxisX.Range.ScrollingRange.MaxValueSerializable = "100";
            xyDiagram3.AxisX.Range.ScrollingRange.MinValueSerializable = "0";
            xyDiagram3.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Range.Auto = false;
            xyDiagram3.AxisY.Range.MaxValueSerializable = "100";
            xyDiagram3.AxisY.Range.MinValueSerializable = "-100";
            xyDiagram3.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.EnableAxisXScrolling = true;
            xyDiagram3.EnableAxisXZooming = true;
            xyDiagram3.EnableAxisYScrolling = true;
            xyDiagram3.EnableAxisYZooming = true;
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel5.LineVisible = true;
            series3.Label = pointSeriesLabel5;
            series3.Name = "Series 1";
            series3.View = splineSeriesView5;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            pointSeriesLabel6.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel6;
            this.chartControl1.SeriesTemplate.View = splineSeriesView6;
            this.chartControl1.Size = new System.Drawing.Size(617, 400);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseClick);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 400);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(617, 30);
            this.ucPieFormulario1.StringAceptar = "Guardar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // FrmImportGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 430);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Name = "FrmImportGrafico";
            this.Text = "FrmImportGrafico";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
    }
}