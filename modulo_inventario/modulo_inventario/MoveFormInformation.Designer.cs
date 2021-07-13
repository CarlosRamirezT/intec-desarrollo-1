
namespace modulo_inventario
{
    partial class MoveFormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveFormInformation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreContent = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelContactoContent = new System.Windows.Forms.Label();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.labelDireccionContent = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelTipoContent = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelOrigenContent = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelDestinoContent = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelFechaContent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(892, 14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 59);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(13, 14);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 59);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(37, 88);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(22, 18);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "ID";
            // 
            // labelNombreContent
            // 
            this.labelNombreContent.AutoSize = true;
            this.labelNombreContent.Location = new System.Drawing.Point(180, 86);
            this.labelNombreContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreContent.Name = "labelNombreContent";
            this.labelNombreContent.Size = new System.Drawing.Size(16, 18);
            this.labelNombreContent.TabIndex = 5;
            this.labelNombreContent.Text = "0";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(37, 144);
            this.labelContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(69, 18);
            this.labelContacto.TabIndex = 6;
            this.labelContacto.Text = "Contacto";
            // 
            // labelContactoContent
            // 
            this.labelContactoContent.AutoSize = true;
            this.labelContactoContent.Location = new System.Drawing.Point(180, 144);
            this.labelContactoContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactoContent.Name = "labelContactoContent";
            this.labelContactoContent.Size = new System.Drawing.Size(46, 18);
            this.labelContactoContent.TabIndex = 7;
            this.labelContactoContent.Text = "label4";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Location = new System.Drawing.Point(36, 203);
            this.LabelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(71, 18);
            this.LabelDireccion.TabIndex = 8;
            this.LabelDireccion.Text = "Dirección";
            // 
            // labelDireccionContent
            // 
            this.labelDireccionContent.AutoSize = true;
            this.labelDireccionContent.Location = new System.Drawing.Point(180, 203);
            this.labelDireccionContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccionContent.Name = "labelDireccionContent";
            this.labelDireccionContent.Size = new System.Drawing.Size(46, 18);
            this.labelDireccionContent.TabIndex = 9;
            this.labelDireccionContent.Text = "label2";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(431, 86);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(37, 18);
            this.labelTipo.TabIndex = 10;
            this.labelTipo.Text = "Tipo";
            // 
            // labelTipoContent
            // 
            this.labelTipoContent.AutoSize = true;
            this.labelTipoContent.Location = new System.Drawing.Point(613, 85);
            this.labelTipoContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoContent.Name = "labelTipoContent";
            this.labelTipoContent.Size = new System.Drawing.Size(46, 18);
            this.labelTipoContent.TabIndex = 11;
            this.labelTipoContent.Text = "label4";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(431, 144);
            this.labelOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(52, 18);
            this.labelOrigen.TabIndex = 12;
            this.labelOrigen.Text = "Origen";
            // 
            // labelOrigenContent
            // 
            this.labelOrigenContent.AutoSize = true;
            this.labelOrigenContent.Location = new System.Drawing.Point(613, 144);
            this.labelOrigenContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigenContent.Name = "labelOrigenContent";
            this.labelOrigenContent.Size = new System.Drawing.Size(46, 18);
            this.labelOrigenContent.TabIndex = 13;
            this.labelOrigenContent.Text = "label2";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(431, 203);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(59, 18);
            this.labelDestino.TabIndex = 14;
            this.labelDestino.Text = "Destino";
            // 
            // labelDestinoContent
            // 
            this.labelDestinoContent.AutoSize = true;
            this.labelDestinoContent.Location = new System.Drawing.Point(613, 203);
            this.labelDestinoContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestinoContent.Name = "labelDestinoContent";
            this.labelDestinoContent.Size = new System.Drawing.Size(46, 18);
            this.labelDestinoContent.TabIndex = 15;
            this.labelDestinoContent.Text = "label4";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(766, 122);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(49, 18);
            this.labelFecha.TabIndex = 16;
            this.labelFecha.Text = "Fecha";
            // 
            // labelFechaContent
            // 
            this.labelFechaContent.AutoSize = true;
            this.labelFechaContent.Location = new System.Drawing.Point(870, 122);
            this.labelFechaContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaContent.Name = "labelFechaContent";
            this.labelFechaContent.Size = new System.Drawing.Size(46, 18);
            this.labelFechaContent.TabIndex = 17;
            this.labelFechaContent.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(840, 88);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 18);
            this.labelStatus.TabIndex = 19;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(130, 14);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 59);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MoveFormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFechaContent);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDestinoContent);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigenContent);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.labelTipoContent);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelDireccionContent);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.labelContactoContent);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.labelNombreContent);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoveFormInformation";
            this.Text = "MoveFormInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreContent;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelContactoContent;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.Label labelDireccionContent;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelTipoContent;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelOrigenContent;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelDestinoContent;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelFechaContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonDelete;
    }
}