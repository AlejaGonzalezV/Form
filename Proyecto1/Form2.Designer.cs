using System;

namespace Proyecto1
{
    partial class VentanaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLista));
            this.ListaIngresos = new System.Windows.Forms.ListBox();
            this.TituloIngresos = new System.Windows.Forms.Label();
            this.ExaminarBut = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.OpenFileDialog();
            this.CerrarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaIngresos
            // 
            this.ListaIngresos.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaIngresos.FormattingEnabled = true;
            this.ListaIngresos.ItemHeight = 20;
            this.ListaIngresos.Location = new System.Drawing.Point(206, 248);
            this.ListaIngresos.Name = "ListaIngresos";
            this.ListaIngresos.Size = new System.Drawing.Size(488, 244);
            this.ListaIngresos.TabIndex = 0;
            this.ListaIngresos.SelectedIndexChanged += new System.EventHandler(this.ListaIngresos_SelectedIndexChanged);
            // 
            // TituloIngresos
            // 
            this.TituloIngresos.AutoSize = true;
            this.TituloIngresos.BackColor = System.Drawing.Color.Transparent;
            this.TituloIngresos.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloIngresos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TituloIngresos.Location = new System.Drawing.Point(308, 70);
            this.TituloIngresos.Name = "TituloIngresos";
            this.TituloIngresos.Size = new System.Drawing.Size(279, 35);
            this.TituloIngresos.TabIndex = 1;
            this.TituloIngresos.Text = "Registro de ingresos";
            // 
            // ExaminarBut
            // 
            this.ExaminarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExaminarBut.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExaminarBut.Location = new System.Drawing.Point(395, 172);
            this.ExaminarBut.Name = "ExaminarBut";
            this.ExaminarBut.Size = new System.Drawing.Size(100, 33);
            this.ExaminarBut.TabIndex = 2;
            this.ExaminarBut.Text = "Examinar";
            this.ExaminarBut.UseVisualStyleBackColor = true;
            this.ExaminarBut.Click += new System.EventHandler(this.ExaminarBut_Click_1);
            // 
            // File
            // 
            this.File.FileName = "+";
            this.File.FileOk += new System.ComponentModel.CancelEventHandler(this.File_FileOk);
            // 
            // CerrarBoton
            // 
            this.CerrarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarBoton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarBoton.Location = new System.Drawing.Point(791, 482);
            this.CerrarBoton.Name = "CerrarBoton";
            this.CerrarBoton.Size = new System.Drawing.Size(89, 32);
            this.CerrarBoton.TabIndex = 3;
            this.CerrarBoton.Text = "Cerrar";
            this.CerrarBoton.UseMnemonic = false;
            this.CerrarBoton.UseVisualStyleBackColor = true;
            this.CerrarBoton.Click += new System.EventHandler(this.CerrarBoton_Click);
            // 
            // VentanaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 526);
            this.Controls.Add(this.CerrarBoton);
            this.Controls.Add(this.ExaminarBut);
            this.Controls.Add(this.TituloIngresos);
            this.Controls.Add(this.ListaIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaLista";
            this.Text = "Lista de ingresos";
            this.Load += new System.EventHandler(this.VentanaLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ListBox ListaIngresos;
        private System.Windows.Forms.Label TituloIngresos;
        private System.Windows.Forms.Button ExaminarBut;
        private System.Windows.Forms.OpenFileDialog File;
        private System.Windows.Forms.Button CerrarBoton;
    }
}