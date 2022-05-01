﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ACATTA.Prediccion
{
    public partial class FrmCurveEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmCurveEdit()
        {
            InitializeComponent();
        }

        private byte[] _data;
        public byte[] data
        {
            get { return _data; }
            set { _data = value;
                if(_data==null)
                    return;
                var mem = new MemoryStream(_data);
                ucGraphDesigner1.LoadFromStream(mem);
            }
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(IsValid())
            {
                DialogResult = DialogResult.OK;
                var Mem = new MemoryStream();
                ucGraphDesigner1.SaveToStream(Mem);
                _data = Mem.ToArray();
                Close();
            }
            else
            {
                MessageBox.Show("aaa");
            }
        }

        private bool IsValid()
        {

            return true;
        }
    }
}