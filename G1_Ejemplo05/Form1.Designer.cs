namespace Ejemplo_5
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
            this.mayorNegativolbl = new System.Windows.Forms.Label();
            this.porcentajeCeroslbl = new System.Windows.Forms.Label();
            this.promedioImpareslbl = new System.Windows.Forms.Label();
            this.mayorParPositivolbl = new System.Windows.Forms.Label();
            this.mayorNegativotxb = new System.Windows.Forms.TextBox();
            this.porcentajeCerostxb = new System.Windows.Forms.TextBox();
            this.promedioImparestxb = new System.Windows.Forms.TextBox();
            this.mayorPositivotxb = new System.Windows.Forms.TextBox();
            this.mostrar1 = new System.Windows.Forms.Button();
            this.mostrar2 = new System.Windows.Forms.Button();
            this.mostrar3 = new System.Windows.Forms.Button();
            this.mostrar4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNumbers
            // 
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.ItemHeight = 16;
            this.listNumbers.Location = new System.Drawing.Point(43, 114);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(189, 292);
            this.listNumbers.TabIndex = 0;
            // 
            // ingreseValorlbl
            // 
            this.ingreseValorlbl.AutoSize = true;
            this.ingreseValorlbl.Location = new System.Drawing.Point(43, 53);
            this.ingreseValorlbl.Name = "ingreseValorlbl";
            this.ingreseValorlbl.Size = new System.Drawing.Size(162, 16);
            this.ingreseValorlbl.TabIndex = 1;
            this.ingreseValorlbl.Text = "Ingrese un valor al arreglo";
            // 
            // valorTxb
            // 
            this.valorTxb.Location = new System.Drawing.Point(229, 50);
            this.valorTxb.Name = "valorTxb";
            this.valorTxb.Size = new System.Drawing.Size(100, 22);
            this.valorTxb.TabIndex = 2;
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Location = new System.Drawing.Point(384, 50);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(75, 23);
            this.ingresarbtn.TabIndex = 3;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            this.ingresarbtn.Click += new System.EventHandler(this.ingresarbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostrar4);
            this.groupBox1.Controls.Add(this.mostrar3);
            this.groupBox1.Controls.Add(this.mostrar2);
            this.groupBox1.Controls.Add(this.mostrar1);
            this.groupBox1.Controls.Add(this.mayorPositivotxb);
            this.groupBox1.Controls.Add(this.promedioImparestxb);
            this.groupBox1.Controls.Add(this.porcentajeCerostxb);
            this.groupBox1.Controls.Add(this.mayorNegativotxb);
            this.groupBox1.Controls.Add(this.mayorParPositivolbl);
            this.groupBox1.Controls.Add(this.promedioImpareslbl);
            this.groupBox1.Controls.Add(this.porcentajeCeroslbl);
            this.groupBox1.Controls.Add(this.mayorNegativolbl);
            this.groupBox1.Location = new System.Drawing.Point(285, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 292);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con arreglo";
            // 
            // mayorNegativolbl
            // 
            this.mayorNegativolbl.AutoSize = true;
            this.mayorNegativolbl.Location = new System.Drawing.Point(37, 62);
            this.mayorNegativolbl.Name = "mayorNegativolbl";
            this.mayorNegativolbl.Size = new System.Drawing.Size(215, 16);
            this.mayorNegativolbl.TabIndex = 0;
            this.mayorNegativolbl.Text = "Número mayor de pares negativos";
            // 
            // porcentajeCeroslbl
            // 
            this.porcentajeCeroslbl.AutoSize = true;
            this.porcentajeCeroslbl.Location = new System.Drawing.Point(37, 118);
            this.porcentajeCeroslbl.Name = "porcentajeCeroslbl";
            this.porcentajeCeroslbl.Size = new System.Drawing.Size(206, 16);
            this.porcentajeCeroslbl.TabIndex = 1;
            this.porcentajeCeroslbl.Text = "Porcentaje de ceros en el arreglo";
            // 
            // promedioImpareslbl
            // 
            this.promedioImpareslbl.AutoSize = true;
            this.promedioImpareslbl.Location = new System.Drawing.Point(37, 174);
            this.promedioImpareslbl.Name = "promedioImpareslbl";
            this.promedioImpareslbl.Size = new System.Drawing.Size(194, 16);
            this.promedioImpareslbl.TabIndex = 2;
            this.promedioImpareslbl.Text = "Promedio de impares positivos";
            // 
            // mayorParPositivolbl
            // 
            this.mayorParPositivolbl.AutoSize = true;
            this.mayorParPositivolbl.Location = new System.Drawing.Point(37, 230);
            this.mayorParPositivolbl.Name = "mayorParPositivolbl";
            this.mayorParPositivolbl.Size = new System.Drawing.Size(180, 16);
            this.mayorParPositivolbl.TabIndex = 3;
            this.mayorParPositivolbl.Text = "Mayor de los pares positivos";
            // 
            // mayorNegativotxb
            // 
            this.mayorNegativotxb.Enabled = false;
            this.mayorNegativotxb.Location = new System.Drawing.Point(277, 55);
            this.mayorNegativotxb.Name = "mayorNegativotxb";
            this.mayorNegativotxb.Size = new System.Drawing.Size(100, 22);
            this.mayorNegativotxb.TabIndex = 4;
            // 
            // porcentajeCerostxb
            // 
            this.porcentajeCerostxb.Enabled = false;
            this.porcentajeCerostxb.Location = new System.Drawing.Point(277, 118);
            this.porcentajeCerostxb.Name = "porcentajeCerostxb";
            this.porcentajeCerostxb.Size = new System.Drawing.Size(100, 22);
            this.porcentajeCerostxb.TabIndex = 5;
            // 
            // promedioImparestxb
            // 
            this.promedioImparestxb.Enabled = false;
            this.promedioImparestxb.Location = new System.Drawing.Point(277, 174);
            this.promedioImparestxb.Name = "promedioImparestxb";
            this.promedioImparestxb.Size = new System.Drawing.Size(100, 22);
            this.promedioImparestxb.TabIndex = 6;
            // 
            // mayorPositivotxb
            // 
            this.mayorPositivotxb.Enabled = false;
            this.mayorPositivotxb.Location = new System.Drawing.Point(277, 230);
            this.mayorPositivotxb.Name = "mayorPositivotxb";
            this.mayorPositivotxb.Size = new System.Drawing.Size(100, 22);
            this.mayorPositivotxb.TabIndex = 7;
            // 
            // mostrar1
            // 
            this.mostrar1.Location = new System.Drawing.Point(393, 55);
            this.mostrar1.Name = "mostrar1";
            this.mostrar1.Size = new System.Drawing.Size(75, 23);
            this.mostrar1.TabIndex = 8;
            this.mostrar1.Text = "Mostrar";
            this.mostrar1.UseVisualStyleBackColor = true;
            this.mostrar1.Click += new System.EventHandler(this.mostrar1_Click);
            // 
            // mostrar2
            // 
            this.mostrar2.Location = new System.Drawing.Point(393, 116);
            this.mostrar2.Name = "mostrar2";
            this.mostrar2.Size = new System.Drawing.Size(75, 23);
            this.mostrar2.TabIndex = 9;
            this.mostrar2.Text = "Mostrar";
            this.mostrar2.UseVisualStyleBackColor = true;
            this.mostrar2.Click += new System.EventHandler(this.mostrar2_Click);
            // 
            // mostrar3
            // 
            this.mostrar3.Location = new System.Drawing.Point(393, 172);
            this.mostrar3.Name = "mostrar3";
            this.mostrar3.Size = new System.Drawing.Size(75, 23);
            this.mostrar3.TabIndex = 10;
            this.mostrar3.Text = "Mostrar";
            this.mostrar3.UseVisualStyleBackColor = true;
            // 
            // mostrar4
            // 
            this.mostrar4.Location = new System.Drawing.Point(393, 228);
            this.mostrar4.Name = "mostrar4";
            this.mostrar4.Size = new System.Drawing.Size(75, 23);
            this.mostrar4.TabIndex = 11;
            this.mostrar4.Text = "Mostrar";
            this.mostrar4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingresarbtn);
            this.Controls.Add(this.valorTxb);
            this.Controls.Add(this.ingreseValorlbl);
            this.Controls.Add(this.listNumbers);
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
        private System.Windows.Forms.Button mostrar4;
        private System.Windows.Forms.Button mostrar3;
        private System.Windows.Forms.Button mostrar2;
        private System.Windows.Forms.Button mostrar1;
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

