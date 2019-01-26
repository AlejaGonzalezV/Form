namespace Proyecto1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ListaIngresos = new System.Windows.Forms.ListBox();
            this.TituloIngresos = new System.Windows.Forms.Label();
            this.ExaminarBut = new System.Windows.Forms.Button();
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
            this.ExaminarBut.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExaminarBut.Location = new System.Drawing.Point(395, 172);
            this.ExaminarBut.Name = "ExaminarBut";
            this.ExaminarBut.Size = new System.Drawing.Size(100, 33);
            this.ExaminarBut.TabIndex = 2;
            this.ExaminarBut.Text = "Examinar";
            this.ExaminarBut.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 526);
            this.Controls.Add(this.ExaminarBut);
            this.Controls.Add(this.TituloIngresos);
            this.Controls.Add(this.ListaIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaIngresos;
        private System.Windows.Forms.Label TituloIngresos;
        private System.Windows.Forms.Button ExaminarBut;
    }
}