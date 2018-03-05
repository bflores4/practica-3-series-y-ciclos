namespace Practica_3_series_y_ciclos
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
            this.lblX = new System.Windows.Forms.Label();
            this.btnLogaritmo = new System.Windows.Forms.Button();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.txtNumRepeticiones = new System.Windows.Forms.TextBox();
            this.lblNumRepeticiones = new System.Windows.Forms.Label();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 24);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(92, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Valor de X:";
            this.lblX.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogaritmo
            // 
            this.btnLogaritmo.Location = new System.Drawing.Point(75, 139);
            this.btnLogaritmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogaritmo.Name = "btnLogaritmo";
            this.btnLogaritmo.Size = new System.Drawing.Size(177, 35);
            this.btnLogaritmo.TabIndex = 1;
            this.btnLogaritmo.Text = "Logaritmo natural";
            this.btnLogaritmo.UseVisualStyleBackColor = true;
            this.btnLogaritmo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(105, 18);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(100, 26);
            this.txtValorX.TabIndex = 2;
            // 
            // txtNumRepeticiones
            // 
            this.txtNumRepeticiones.Location = new System.Drawing.Point(207, 58);
            this.txtNumRepeticiones.Name = "txtNumRepeticiones";
            this.txtNumRepeticiones.Size = new System.Drawing.Size(100, 26);
            this.txtNumRepeticiones.TabIndex = 4;
            // 
            // lblNumRepeticiones
            // 
            this.lblNumRepeticiones.AutoSize = true;
            this.lblNumRepeticiones.Location = new System.Drawing.Point(13, 61);
            this.lblNumRepeticiones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRepeticiones.Name = "lblNumRepeticiones";
            this.lblNumRepeticiones.Size = new System.Drawing.Size(192, 20);
            this.lblNumRepeticiones.TabIndex = 3;
            this.lblNumRepeticiones.Text = "Numero de repeticiones:";
            // 
            // btnCoseno
            // 
            this.btnCoseno.Location = new System.Drawing.Point(75, 229);
            this.btnCoseno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(177, 35);
            this.btnCoseno.TabIndex = 5;
            this.btnCoseno.Text = "Coseno";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(75, 184);
            this.btnSeno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(177, 35);
            this.btnSeno.TabIndex = 6;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Location = new System.Drawing.Point(117, 101);
            this.lblCalcular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(88, 20);
            this.lblCalcular.TabIndex = 7;
            this.lblCalcular.Text = "Calcular ...";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(45, 286);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(84, 20);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(139, 283);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(142, 26);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 333);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.txtNumRepeticiones);
            this.Controls.Add(this.lblNumRepeticiones);
            this.Controls.Add(this.txtValorX);
            this.Controls.Add(this.btnLogaritmo);
            this.Controls.Add(this.lblX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnLogaritmo;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.TextBox txtNumRepeticiones;
        private System.Windows.Forms.Label lblNumRepeticiones;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

