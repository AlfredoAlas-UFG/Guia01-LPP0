namespace G1_Ejemplo02
{
    partial class frmVentana
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.cmbop = new System.Windows.Forms.ComboBox();
            this.listadvance = new System.Windows.Forms.ListBox();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(200, 46);
            this.txtnum1.Multiline = true;
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(138, 42);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(200, 194);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(138, 42);
            this.txtnum2.TabIndex = 3;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(389, 46);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(77, 20);
            this.rbt1.TabIndex = 4;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Básicas";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // cmbop
            // 
            this.cmbop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbop.FormattingEnabled = true;
            this.cmbop.Location = new System.Drawing.Point(389, 72);
            this.cmbop.Name = "cmbop";
            this.cmbop.Size = new System.Drawing.Size(184, 24);
            this.cmbop.TabIndex = 5;
            // 
            // listadvance
            // 
            this.listadvance.FormattingEnabled = true;
            this.listadvance.ItemHeight = 16;
            this.listadvance.Location = new System.Drawing.Point(651, 72);
            this.listadvance.Name = "listadvance";
            this.listadvance.Size = new System.Drawing.Size(175, 84);
            this.listadvance.TabIndex = 6;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(651, 46);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(96, 20);
            this.rbtn2.TabIndex = 7;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Avanzadas";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(389, 271);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(233, 71);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.listadvance);
            this.Controls.Add(this.cmbop);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVentana";
            this.Text = "Este es un ejemplo";
            this.Load += new System.EventHandler(this.frmVentana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.ComboBox cmbop;
        private System.Windows.Forms.ListBox listadvance;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Button btncalcular;
    }
}

