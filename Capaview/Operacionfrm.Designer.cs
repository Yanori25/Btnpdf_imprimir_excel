
namespace BtnPrinterExcel.Capaview
{
    partial class Operacionfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dgvroles = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilnombre = new System.Windows.Forms.TextBox();
            this.grpopciones = new System.Windows.Forms.GroupBox();
            this.btnimprime = new System.Windows.Forms.Button();
            this.btnpdf = new System.Windows.Forms.Button();
            this.cmbindicador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(82, 19);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(251, 20);
            this.txtdescripcion.TabIndex = 1;
            // 
            // dgvroles
            // 
            this.dgvroles.BackgroundColor = System.Drawing.Color.White;
            this.dgvroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroles.Location = new System.Drawing.Point(25, 86);
            this.dgvroles.Name = "dgvroles";
            this.dgvroles.Size = new System.Drawing.Size(530, 177);
            this.dgvroles.TabIndex = 2;
            this.dgvroles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroles_CellClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(283, 54);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 27);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseCompatibleTextRendering = true;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(82, 54);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(108, 27);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseCompatibleTextRendering = true;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpdf);
            this.groupBox1.Controls.Add(this.btnimprime);
            this.groupBox1.Controls.Add(this.btnexcel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfilnombre);
            this.groupBox1.Controls.Add(this.dgvroles);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Operaciones";
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(61, 53);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(108, 27);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Exportar a excel";
            this.btnexcel.UseCompatibleTextRendering = true;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtfilnombre
            // 
            this.txtfilnombre.Location = new System.Drawing.Point(105, 19);
            this.txtfilnombre.Name = "txtfilnombre";
            this.txtfilnombre.Size = new System.Drawing.Size(251, 20);
            this.txtfilnombre.TabIndex = 3;
            // 
            // grpopciones
            // 
            this.grpopciones.Controls.Add(this.label3);
            this.grpopciones.Controls.Add(this.cmbindicador);
            this.grpopciones.Controls.Add(this.label1);
            this.grpopciones.Controls.Add(this.txtdescripcion);
            this.grpopciones.Controls.Add(this.btneliminar);
            this.grpopciones.Controls.Add(this.btnagregar);
            this.grpopciones.Location = new System.Drawing.Point(12, 21);
            this.grpopciones.Name = "grpopciones";
            this.grpopciones.Size = new System.Drawing.Size(649, 119);
            this.grpopciones.TabIndex = 18;
            this.grpopciones.TabStop = false;
            this.grpopciones.Text = "opciones";
            // 
            // btnimprime
            // 
            this.btnimprime.Location = new System.Drawing.Point(306, 53);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(108, 27);
            this.btnimprime.TabIndex = 13;
            this.btnimprime.Text = "imprimir";
            this.btnimprime.UseCompatibleTextRendering = true;
            this.btnimprime.UseVisualStyleBackColor = true;
            this.btnimprime.Click += new System.EventHandler(this.btnimprime_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(175, 53);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(108, 27);
            this.btnpdf.TabIndex = 14;
            this.btnpdf.Text = "Exportar a pdf";
            this.btnpdf.UseCompatibleTextRendering = true;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // cmbindicador
            // 
            this.cmbindicador.FormattingEnabled = true;
            this.cmbindicador.Items.AddRange(new object[] {
            "SUMA",
            "RESTA"});
            this.cmbindicador.Location = new System.Drawing.Point(413, 19);
            this.cmbindicador.Name = "cmbindicador";
            this.cmbindicador.Size = new System.Drawing.Size(182, 21);
            this.cmbindicador.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Indicador";
            // 
            // Operacionfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpopciones);
            this.Name = "Operacionfrm";
            this.Text = "Operacionfrm";
            this.Load += new System.EventHandler(this.Operacionfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpopciones.ResumeLayout(false);
            this.grpopciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DataGridView dgvroles;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilnombre;
        private System.Windows.Forms.GroupBox grpopciones;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnimprime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbindicador;
    }
}