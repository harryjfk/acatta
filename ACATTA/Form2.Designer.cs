namespace ACATTA
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucGraphDesigner1 = new ACATTA.UCGraphDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGraphDesigner1
            // 
            this.ucGraphDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGraphDesigner1.Location = new System.Drawing.Point(0, 0);
            this.ucGraphDesigner1.Name = "ucGraphDesigner1";
            this.ucGraphDesigner1.Size = new System.Drawing.Size(648, 449);
            this.ucGraphDesigner1.TabIndex = 0;
            this.ucGraphDesigner1.Load += new System.EventHandler(this.ucGraphDesigner1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 449);
            this.Controls.Add(this.ucGraphDesigner1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UCGraphDesigner ucGraphDesigner1;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}