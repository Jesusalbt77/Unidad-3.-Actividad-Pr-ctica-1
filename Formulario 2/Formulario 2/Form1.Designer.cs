namespace Formulario_2
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
            this.tbxLongitud = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tbLongitud = new System.Windows.Forms.TextBox();
            this.tbGenerada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLongitud
            // 
            this.tbxLongitud.AutoSize = true;
            this.tbxLongitud.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLongitud.Location = new System.Drawing.Point(128, 107);
            this.tbxLongitud.Name = "tbxLongitud";
            this.tbxLongitud.Size = new System.Drawing.Size(79, 19);
            this.tbxLongitud.TabIndex = 0;
            this.tbxLongitud.Text = "Longitud";
            this.tbxLongitud.Click += new System.EventHandler(this.tbxLongitud_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Tomato;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(106, 178);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(117, 34);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tbLongitud
            // 
            this.tbLongitud.Location = new System.Drawing.Point(254, 104);
            this.tbLongitud.Name = "tbLongitud";
            this.tbLongitud.Size = new System.Drawing.Size(152, 22);
            this.tbLongitud.TabIndex = 2;
            // 
            // tbGenerada
            // 
            this.tbGenerada.Location = new System.Drawing.Point(254, 185);
            this.tbGenerada.Name = "tbGenerada";
            this.tbGenerada.Size = new System.Drawing.Size(152, 22);
            this.tbGenerada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generador de Contraseñas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGenerada);
            this.Controls.Add(this.tbLongitud);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tbxLongitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbxLongitud;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tbLongitud;
        private System.Windows.Forms.TextBox tbGenerada;
        private System.Windows.Forms.Label label1;
    }
}

