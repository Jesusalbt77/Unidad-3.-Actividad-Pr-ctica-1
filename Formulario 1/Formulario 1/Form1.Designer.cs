namespace Unidad_3.Actividad_Práctica_1
{
    partial class Form1
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
            this.btngenerar = new System.Windows.Forms.Button();
            this.lbtabla = new System.Windows.Forms.ListBox();
            this.tbnumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btngenerar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Location = new System.Drawing.Point(184, 91);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(101, 45);
            this.btngenerar.TabIndex = 0;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // lbtabla
            // 
            this.lbtabla.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtabla.FormattingEnabled = true;
            this.lbtabla.ItemHeight = 19;
            this.lbtabla.Location = new System.Drawing.Point(343, 172);
            this.lbtabla.Name = "lbtabla";
            this.lbtabla.Size = new System.Drawing.Size(130, 213);
            this.lbtabla.TabIndex = 1;
            // 
            // tbnumeros
            // 
            this.tbnumeros.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumeros.Location = new System.Drawing.Point(343, 91);
            this.tbnumeros.Name = "tbnumeros";
            this.tbnumeros.Size = new System.Drawing.Size(130, 27);
            this.tbnumeros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbnumeros);
            this.Controls.Add(this.lbtabla);
            this.Controls.Add(this.btngenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.ListBox lbtabla;
        private System.Windows.Forms.TextBox tbnumeros;
    }
}

