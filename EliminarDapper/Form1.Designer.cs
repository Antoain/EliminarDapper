namespace EliminarDapper
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
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBBuscarID = new System.Windows.Forms.TextBox();
            this.btnCargarTods = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.txtBCategoryName = new System.Windows.Forms.TextBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Location = new System.Drawing.Point(2, 28);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.RowHeadersWidth = 51;
            this.DgvCategorias.RowTemplate.Height = 24;
            this.DgvCategorias.Size = new System.Drawing.Size(776, 197);
            this.DgvCategorias.TabIndex = 0;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(230, 375);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 1;
            this.btnBuscarID.Text = "BuscarID";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtBBuscarID
            // 
            this.txtBBuscarID.Location = new System.Drawing.Point(219, 337);
            this.txtBBuscarID.Name = "txtBBuscarID";
            this.txtBBuscarID.Size = new System.Drawing.Size(100, 22);
            this.txtBBuscarID.TabIndex = 3;
            // 
            // btnCargarTods
            // 
            this.btnCargarTods.Location = new System.Drawing.Point(230, 277);
            this.btnCargarTods.Name = "btnCargarTods";
            this.btnCargarTods.Size = new System.Drawing.Size(75, 23);
            this.btnCargarTods.TabIndex = 4;
            this.btnCargarTods.Text = "Cargar Todas";
            this.btnCargarTods.UseVisualStyleBackColor = true;
            this.btnCargarTods.Click += new System.EventHandler(this.btnCargarTods_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(464, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Categoria";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(464, 266);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(100, 22);
            this.txtCategoriaID.TabIndex = 6;
            // 
            // txtBCategoryName
            // 
            this.txtBCategoryName.Location = new System.Drawing.Point(464, 295);
            this.txtBCategoryName.Name = "txtBCategoryName";
            this.txtBCategoryName.Size = new System.Drawing.Size(100, 22);
            this.txtBCategoryName.TabIndex = 7;
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(464, 323);
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtBDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "CatName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBDescripcion);
            this.Controls.Add(this.txtBCategoryName);
            this.Controls.Add(this.txtCategoriaID);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargarTods);
            this.Controls.Add(this.txtBBuscarID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.DgvCategorias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBBuscarID;
        private System.Windows.Forms.Button btnCargarTods;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.TextBox txtBCategoryName;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

