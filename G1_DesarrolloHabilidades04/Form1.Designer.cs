namespace Analisis4
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
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.ingreseValorlbl = new System.Windows.Forms.Label();
            this.valorTxb = new System.Windows.Forms.TextBox();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mayorPositivotxb = new System.Windows.Forms.TextBox();
            this.promedioImparestxb = new System.Windows.Forms.TextBox();
            this.porcentajeCerostxb = new System.Windows.Forms.TextBox();
            this.mayorNegativotxb = new System.Windows.Forms.TextBox();
            this.mayorParPositivolbl = new System.Windows.Forms.Label();
            this.promedioImpareslbl = new System.Windows.Forms.Label();
            this.porcentajeCeroslbl = new System.Windows.Forms.Label();
            this.mayorNegativolbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNumbers
            // 
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.Location = new System.Drawing.Point(32, 93);
            this.listNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(143, 290);
            this.listNumbers.TabIndex = 0;
            // 
            // ingreseValorlbl
            // 
            this.ingreseValorlbl.AutoSize = true;
            this.ingreseValorlbl.Location = new System.Drawing.Point(32, 43);
            this.ingreseValorlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingreseValorlbl.Name = "ingreseValorlbl";
            this.ingreseValorlbl.Size = new System.Drawing.Size(129, 13);
            this.ingreseValorlbl.TabIndex = 1;
            this.ingreseValorlbl.Text = "Ingrese un valor al arreglo";
            // 
            // valorTxb
            // 
            this.valorTxb.Location = new System.Drawing.Point(172, 41);
            this.valorTxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valorTxb.Name = "valorTxb";
            this.valorTxb.Size = new System.Drawing.Size(76, 20);
            this.valorTxb.TabIndex = 2;
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Location = new System.Drawing.Point(288, 41);
            this.ingresarbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(56, 19);
            this.ingresarbtn.TabIndex = 3;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            this.ingresarbtn.Click += new System.EventHandler(this.ingresarbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.mayorPositivotxb);
            this.groupBox1.Controls.Add(this.promedioImparestxb);
            this.groupBox1.Controls.Add(this.porcentajeCerostxb);
            this.groupBox1.Controls.Add(this.mayorNegativotxb);
            this.groupBox1.Controls.Add(this.mayorParPositivolbl);
            this.groupBox1.Controls.Add(this.promedioImpareslbl);
            this.groupBox1.Controls.Add(this.porcentajeCeroslbl);
            this.groupBox1.Controls.Add(this.mayorNegativolbl);
            this.groupBox1.Location = new System.Drawing.Point(214, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con arreglo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(152, 237);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mayorPositivotxb
            // 
            this.mayorPositivotxb.Enabled = false;
            this.mayorPositivotxb.Location = new System.Drawing.Point(208, 187);
            this.mayorPositivotxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mayorPositivotxb.Name = "mayorPositivotxb";
            this.mayorPositivotxb.Size = new System.Drawing.Size(76, 20);
            this.mayorPositivotxb.TabIndex = 7;
            // 
            // promedioImparestxb
            // 
            this.promedioImparestxb.Enabled = false;
            this.promedioImparestxb.Location = new System.Drawing.Point(208, 141);
            this.promedioImparestxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.promedioImparestxb.Name = "promedioImparestxb";
            this.promedioImparestxb.Size = new System.Drawing.Size(76, 20);
            this.promedioImparestxb.TabIndex = 6;
            // 
            // porcentajeCerostxb
            // 
            this.porcentajeCerostxb.Enabled = false;
            this.porcentajeCerostxb.Location = new System.Drawing.Point(208, 96);
            this.porcentajeCerostxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.porcentajeCerostxb.Name = "porcentajeCerostxb";
            this.porcentajeCerostxb.Size = new System.Drawing.Size(76, 20);
            this.porcentajeCerostxb.TabIndex = 5;
            // 
            // mayorNegativotxb
            // 
            this.mayorNegativotxb.Enabled = false;
            this.mayorNegativotxb.Location = new System.Drawing.Point(208, 45);
            this.mayorNegativotxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mayorNegativotxb.Name = "mayorNegativotxb";
            this.mayorNegativotxb.Size = new System.Drawing.Size(76, 20);
            this.mayorNegativotxb.TabIndex = 4;
            // 
            // mayorParPositivolbl
            // 
            this.mayorParPositivolbl.AutoSize = true;
            this.mayorParPositivolbl.Location = new System.Drawing.Point(28, 187);
            this.mayorParPositivolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mayorParPositivolbl.Name = "mayorParPositivolbl";
            this.mayorParPositivolbl.Size = new System.Drawing.Size(140, 13);
            this.mayorParPositivolbl.TabIndex = 3;
            this.mayorParPositivolbl.Text = "Mayor de los pares positivos";
            // 
            // promedioImpareslbl
            // 
            this.promedioImpareslbl.AutoSize = true;
            this.promedioImpareslbl.Location = new System.Drawing.Point(28, 141);
            this.promedioImpareslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.promedioImpareslbl.Name = "promedioImpareslbl";
            this.promedioImpareslbl.Size = new System.Drawing.Size(149, 13);
            this.promedioImpareslbl.TabIndex = 2;
            this.promedioImpareslbl.Text = "Promedio de impares positivos";
            // 
            // porcentajeCeroslbl
            // 
            this.porcentajeCeroslbl.AutoSize = true;
            this.porcentajeCeroslbl.Location = new System.Drawing.Point(28, 96);
            this.porcentajeCeroslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.porcentajeCeroslbl.Name = "porcentajeCeroslbl";
            this.porcentajeCeroslbl.Size = new System.Drawing.Size(163, 13);
            this.porcentajeCeroslbl.TabIndex = 1;
            this.porcentajeCeroslbl.Text = "Porcentaje de ceros en el arreglo";
            // 
            // mayorNegativolbl
            // 
            this.mayorNegativolbl.AutoSize = true;
            this.mayorNegativolbl.Location = new System.Drawing.Point(28, 50);
            this.mayorNegativolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mayorNegativolbl.Name = "mayorNegativolbl";
            this.mayorNegativolbl.Size = new System.Drawing.Size(168, 13);
            this.mayorNegativolbl.TabIndex = 0;
            this.mayorNegativolbl.Text = "Número mayor de pares negativos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingresarbtn);
            this.Controls.Add(this.valorTxb);
            this.Controls.Add(this.ingreseValorlbl);
            this.Controls.Add(this.listNumbers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.Label ingreseValorlbl;
        private System.Windows.Forms.TextBox valorTxb;
        private System.Windows.Forms.Button ingresarbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox mayorPositivotxb;
        private System.Windows.Forms.TextBox promedioImparestxb;
        private System.Windows.Forms.TextBox porcentajeCerostxb;
        private System.Windows.Forms.TextBox mayorNegativotxb;
        private System.Windows.Forms.Label mayorParPositivolbl;
        private System.Windows.Forms.Label promedioImpareslbl;
        private System.Windows.Forms.Label porcentajeCeroslbl;
        private System.Windows.Forms.Label mayorNegativolbl;
    }
}

