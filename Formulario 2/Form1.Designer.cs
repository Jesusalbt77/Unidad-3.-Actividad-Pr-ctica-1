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
            this.components = new System.ComponentModel.Container();
            this.cbminutos = new System.Windows.Forms.ComboBox();
            this.cbsegundos = new System.Windows.Forms.ComboBox();
            this.lbtiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbminutos
            // 
            this.cbminutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbminutos.FormattingEnabled = true;
            this.cbminutos.Location = new System.Drawing.Point(191, 84);
            this.cbminutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbminutos.Name = "cbminutos";
            this.cbminutos.Size = new System.Drawing.Size(150, 26);
            this.cbminutos.TabIndex = 0;
            // 
            // cbsegundos
            // 
            this.cbsegundos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsegundos.FormattingEnabled = true;
            this.cbsegundos.Location = new System.Drawing.Point(441, 84);
            this.cbsegundos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbsegundos.Name = "cbsegundos";
            this.cbsegundos.Size = new System.Drawing.Size(150, 26);
            this.cbsegundos.TabIndex = 1;
            // 
            // lbtiempo
            // 
            this.lbtiempo.AutoSize = true;
            this.lbtiempo.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtiempo.Location = new System.Drawing.Point(308, 147);
            this.lbtiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtiempo.Name = "lbtiempo";
            this.lbtiempo.Size = new System.Drawing.Size(145, 55);
            this.lbtiempo.TabIndex = 2;
            this.lbtiempo.Text = "00:00";
            this.lbtiempo.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundos:";
            // 
            // btniniciar
            // 
            this.btniniciar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(191, 253);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(150, 45);
            this.btniniciar.TabIndex = 5;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btndetener
            // 
            this.btndetener.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetener.Location = new System.Drawing.Point(441, 253);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(150, 45);
            this.btndetener.TabIndex = 6;
            this.btndetener.Text = "Detener";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 478);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtiempo);
            this.Controls.Add(this.cbsegundos);
            this.Controls.Add(this.cbminutos);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.timer1_Tick_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbminutos;
        private System.Windows.Forms.ComboBox cbsegundos;
        private System.Windows.Forms.Label lbtiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Timer timer1;
    }
}

