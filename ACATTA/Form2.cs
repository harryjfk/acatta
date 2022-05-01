using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace ACATTA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
      


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pstart = new Point(50, 50);
            var pend = new Point(100, 50);
            var cant = 10;
            var pdist = new Point(Math.Abs(pstart.X - pend.X), Math.Abs(pstart.Y - pend.Y));
            var list = new List<Point>();
            if (pdist.Y / cant > 0 && pdist.X / cant > 0)
            {
                for (int i = 0; i < pdist.Y / cant; i++)
                {

                    for (int y = 0; y < pdist.X / cant; y++)
                    {

                    }
                }
            }
            else
            {
                var t = 0;
               t= pdist.X == 0 ?pdist.Y : pdist.X;
               for (int i =1; i <= t/cant; i++)
               {
                   var x = 0;
                   var y = 0;
                   x = pdist.X == 0 ? pstart.X : pstart.X + i * cant;
                   y = pdist.Y == 0 ? pstart.Y : pstart.Y + i * cant;
                   var n = new Point(x, y);
                   list.Add(n);
               }
            }


        }

        private void ucGraphDesigner1_Load(object sender, EventArgs e)
        {

        }

       

      
    }
    
    
}
