namespace Proyecto1
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.TituloTx = new System.Windows.Forms.Label();
            this.NombreTx = new System.Windows.Forms.TextBox();
            this.ApellidoTx = new System.Windows.Forms.TextBox();
            this.CedulaTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresarBut = new System.Windows.Forms.Button();
            this.ventanaL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloTx
            // 
            this.TituloTx.BackColor = System.Drawing.Color.Transparent;
            this.TituloTx.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTx.Location = new System.Drawing.Point(344, 20);
            this.TituloTx.Name = "TituloTx";
            this.TituloTx.Size = new System.Drawing.Size(247, 54);
            this.TituloTx.TabIndex = 0;
            this.TituloTx.Text = "Registro de datos";
            this.TituloTx.Click += new System.EventHandler(this.TituloTx_Click);
            // 
            // NombreTx
            // 
            this.NombreTx.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTx.Location = new System.Drawing.Point(384, 219);
            this.NombreTx.Multiline = true;
            this.NombreTx.Name = "NombreTx";
            this.NombreTx.Size = new System.Drawing.Size(183, 32);
            this.NombreTx.TabIndex = 1;
            this.NombreTx.TextChanged += new System.EventHandler(this.NombreTx_TextChanged);
            // 
            // ApellidoTx
            // 
            this.ApellidoTx.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTx.Location = new System.Drawing.Point(384, 301);
            this.ApellidoTx.Multiline = true;
            this.ApellidoTx.Name = "ApellidoTx";
            this.ApellidoTx.Size = new System.Drawing.Size(183, 32);
            this.ApellidoTx.TabIndex = 2;
            this.ApellidoTx.TextChanged += new System.EventHandler(this.ApellidoTx_TextChanged);
            // 
            // CedulaTx
            // 
            this.CedulaTx.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaTx.Location = new System.Drawing.Point(384, 386);
            this.CedulaTx.Multiline = true;
            this.CedulaTx.Name = "CedulaTx";
            this.CedulaTx.Size = new System.Drawing.Size(183, 32);
            this.CedulaTx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cédula";
            // 
            // IngresarBut
            // 
            this.IngresarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IngresarBut.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarBut.Location = new System.Drawing.Point(418, 463);
            this.IngresarBut.Name = "IngresarBut";
            this.IngresarBut.Size = new System.Drawing.Size(108, 38);
            this.IngresarBut.TabIndex = 7;
            this.IngresarBut.Text = "Ingresar";
            this.IngresarBut.UseVisualStyleBackColor = true;
            this.IngresarBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventanaL
            // 
            this.ventanaL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventanaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventanaL.Location = new System.Drawing.Point(806, 491);
            this.ventanaL.Name = "ventanaL";
            this.ventanaL.Size = new System.Drawing.Size(117, 32);
            this.ventanaL.TabIndex = 9;
            this.ventanaL.Text = "Ver Ingresos";
            this.ventanaL.UseVisualStyleBackColor = true;
            this.ventanaL.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 533);
            this.Controls.Add(this.ventanaL);
            this.Controls.Add(this.IngresarBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CedulaTx);
            this.Controls.Add(this.ApellidoTx);
            this.Controls.Add(this.NombreTx);
            this.Controls.Add(this.TituloTx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Registro de visitantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloTx;
        private System.Windows.Forms.TextBox NombreTx;
        private System.Windows.Forms.TextBox ApellidoTx;
        private System.Windows.Forms.TextBox CedulaTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IngresarBut;
        private System.Windows.Forms.Button ventanaL;
    }
}

