namespace Formulario_3
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.cmbde = new System.Windows.Forms.ComboBox();
            this.cmba = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(130, 361);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(152, 26);
            this.txtvalor.TabIndex = 0;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(475, 361);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(152, 26);
            this.txtresultado.TabIndex = 1;
            // 
            // btnconvertir
            // 
            this.btnconvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnconvertir.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertir.Location = new System.Drawing.Point(339, 361);
            this.btnconvertir.Margin = new System.Windows.Forms.Padding(4);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(85, 27);
            this.btnconvertir.TabIndex = 2;
            this.btnconvertir.Text = "Convertir ";
            this.btnconvertir.UseVisualStyleBackColor = false;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // cmbde
            // 
            this.cmbde.FormattingEnabled = true;
            this.cmbde.Items.AddRange(new object[] {
            "Metro",
            "Centimetro",
            "Pulgada"});
            this.cmbde.Location = new System.Drawing.Point(130, 165);
            this.cmbde.Name = "cmbde";
            this.cmbde.Size = new System.Drawing.Size(152, 27);
            this.cmbde.TabIndex = 3;
            this.cmbde.SelectedIndexChanged += new System.EventHandler(this.cmbde_SelectedIndexChanged);
            // 
            // cmba
            // 
            this.cmba.FormattingEnabled = true;
            this.cmba.Items.AddRange(new object[] {
            "Metro",
            "Centimetro",
            "Pulgada"});
            this.cmba.Location = new System.Drawing.Point(475, 165);
            this.cmba.Name = "cmba";
            this.cmba.Size = new System.Drawing.Size(152, 27);
            this.cmba.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor a Calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(270, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidades de Longitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "De:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmba);
            this.Controls.Add(this.cmbde);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtvalor);
            this.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.ComboBox cmbde;
        private System.Windows.Forms.ComboBox cmba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

