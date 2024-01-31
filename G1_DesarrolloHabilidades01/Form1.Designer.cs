namespace Analisis_Desarrollo
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
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.cbGerente = new System.Windows.Forms.RadioButton();
            this.cbSubgerente = new System.Windows.Forms.RadioButton();
            this.cbSecretaria = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbSalarioBruto = new System.Windows.Forms.TextBox();
            this.tbMontoDescuento = new System.Windows.Forms.TextBox();
            this.tbSalarioNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(324, 30);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(79, 16);
            this.lblDescuentos.TabIndex = 0;
            this.lblDescuentos.Text = "Descuentos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(456, 103);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 16);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(164, 209);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(83, 16);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salario bruto";
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Location = new System.Drawing.Point(137, 264);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(110, 16);
            this.lblMontoDescuento.TabIndex = 4;
            this.lblMontoDescuento.Text = "Monto descuento";
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Location = new System.Drawing.Point(168, 325);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(79, 16);
            this.lblSalarioNeto.TabIndex = 5;
            this.lblSalarioNeto.Text = "Salario neto";
            // 
            // cbGerente
            // 
            this.cbGerente.AutoSize = true;
            this.cbGerente.Location = new System.Drawing.Point(532, 207);
            this.cbGerente.Name = "cbGerente";
            this.cbGerente.Size = new System.Drawing.Size(76, 20);
            this.cbGerente.TabIndex = 6;
            this.cbGerente.TabStop = true;
            this.cbGerente.Text = "Gerente";
            this.cbGerente.UseVisualStyleBackColor = true;
            // 
            // cbSubgerente
            // 
            this.cbSubgerente.AutoSize = true;
            this.cbSubgerente.Location = new System.Drawing.Point(532, 262);
            this.cbSubgerente.Name = "cbSubgerente";
            this.cbSubgerente.Size = new System.Drawing.Size(98, 20);
            this.cbSubgerente.TabIndex = 7;
            this.cbSubgerente.TabStop = true;
            this.cbSubgerente.Text = "Subgerente";
            this.cbSubgerente.UseVisualStyleBackColor = true;
            // 
            // cbSecretaria
            // 
            this.cbSecretaria.AutoSize = true;
            this.cbSecretaria.Location = new System.Drawing.Point(532, 323);
            this.cbSecretaria.Name = "cbSecretaria";
            this.cbSecretaria.Size = new System.Drawing.Size(90, 20);
            this.cbSecretaria.TabIndex = 8;
            this.cbSecretaria.TabStop = true;
            this.cbSecretaria.Text = "Secretaria";
            this.cbSecretaria.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(357, 389);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(211, 100);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 15;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(598, 100);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 22);
            this.tbApellido.TabIndex = 16;
            // 
            // tbSalarioBruto
            // 
            this.tbSalarioBruto.Location = new System.Drawing.Point(271, 209);
            this.tbSalarioBruto.Name = "tbSalarioBruto";
            this.tbSalarioBruto.Size = new System.Drawing.Size(100, 22);
            this.tbSalarioBruto.TabIndex = 17;
            // 
            // tbMontoDescuento
            // 
            this.tbMontoDescuento.Enabled = false;
            this.tbMontoDescuento.Location = new System.Drawing.Point(271, 264);
            this.tbMontoDescuento.Name = "tbMontoDescuento";
            this.tbMontoDescuento.Size = new System.Drawing.Size(100, 22);
            this.tbMontoDescuento.TabIndex = 18;
            // 
            // tbSalarioNeto
            // 
            this.tbSalarioNeto.Enabled = false;
            this.tbSalarioNeto.Location = new System.Drawing.Point(271, 325);
            this.tbSalarioNeto.Name = "tbSalarioNeto";
            this.tbSalarioNeto.Size = new System.Drawing.Size(100, 22);
            this.tbSalarioNeto.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSalarioNeto);
            this.Controls.Add(this.tbMontoDescuento);
            this.Controls.Add(this.tbSalarioBruto);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbSecretaria);
            this.Controls.Add(this.cbSubgerente);
            this.Controls.Add(this.cbGerente);
            this.Controls.Add(this.lblSalarioNeto);
            this.Controls.Add(this.lblMontoDescuento);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescuentos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desarrollo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblMontoDescuento;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.RadioButton cbGerente;
        private System.Windows.Forms.RadioButton cbSubgerente;
        private System.Windows.Forms.RadioButton cbSecretaria;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbSalarioBruto;
        private System.Windows.Forms.TextBox tbMontoDescuento;
        private System.Windows.Forms.TextBox tbSalarioNeto;
    }
}

