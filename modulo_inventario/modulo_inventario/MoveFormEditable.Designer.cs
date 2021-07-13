
namespace modulo_inventario
{
    partial class MoveFormEditable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveFormEditable));
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(13, 15);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(116, 57);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(148, 15);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 57);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(847, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 109);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 18);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(11, 170);
            this.labelContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(69, 18);
            this.labelContact.TabIndex = 4;
            this.labelContact.Text = "Contacto";
            this.labelContact.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(11, 231);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(71, 18);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(288, 109);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(37, 18);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(271, 174);
            this.labelOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(52, 18);
            this.labelOrigen.TabIndex = 7;
            this.labelOrigen.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(266, 225);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(59, 18);
            this.labelDestino.TabIndex = 8;
            this.labelDestino.Text = "Destino";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(595, 164);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(49, 18);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBoxID.Location = new System.Drawing.Point(116, 105);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxID.Size = new System.Drawing.Size(127, 24);
            this.textBoxID.TabIndex = 10;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBoxContacto.Location = new System.Drawing.Point(116, 166);
            this.textBoxContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(127, 24);
            this.textBoxContacto.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBoxDireccion.Location = new System.Drawing.Point(116, 219);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(127, 24);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBoxFecha.Location = new System.Drawing.Point(652, 160);
            this.textBoxFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(162, 24);
            this.textBoxFecha.TabIndex = 16;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(342, 109);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(211, 26);
            this.comboBoxType.TabIndex = 17;
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(342, 169);
            this.comboBoxSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(211, 26);
            this.comboBoxSource.TabIndex = 18;
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(342, 222);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(211, 26);
            this.comboBoxDestination.TabIndex = 19;
            // 
            // comboBoxState
            // 
            this.comboBoxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(652, 109);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(162, 26);
            this.comboBoxState.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "State";
            // 
            // MoveFormEditable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(876, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoveFormEditable";
            this.Text = "Editar Movimiento de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label1;
    }
}