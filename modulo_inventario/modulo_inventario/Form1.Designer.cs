
namespace modulo_inventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonLocations = new System.Windows.Forms.Button();
            this.buttonMoves = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProducts
            // 
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(0, 34);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(173, 90);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "Productos";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonLocations
            // 
            this.buttonLocations.FlatAppearance.BorderSize = 0;
            this.buttonLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocations.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLocations.Image = ((System.Drawing.Image)(resources.GetObject("buttonLocations.Image")));
            this.buttonLocations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLocations.Location = new System.Drawing.Point(0, 147);
            this.buttonLocations.Name = "buttonLocations";
            this.buttonLocations.Size = new System.Drawing.Size(173, 98);
            this.buttonLocations.TabIndex = 1;
            this.buttonLocations.Text = "Locations";
            this.buttonLocations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLocations.UseVisualStyleBackColor = true;
            this.buttonLocations.Click += new System.EventHandler(this.buttonLocations_Click);
            // 
            // buttonMoves
            // 
            this.buttonMoves.FlatAppearance.BorderSize = 0;
            this.buttonMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoves.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMoves.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoves.Image")));
            this.buttonMoves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoves.Location = new System.Drawing.Point(0, 267);
            this.buttonMoves.Name = "buttonMoves";
            this.buttonMoves.Size = new System.Drawing.Size(191, 98);
            this.buttonMoves.TabIndex = 2;
            this.buttonMoves.Text = "Movimientos";
            this.buttonMoves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMoves.UseVisualStyleBackColor = true;
            this.buttonMoves.Click += new System.EventHandler(this.buttonMoves_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.buttonMoves);
            this.panel1.Controls.Add(this.buttonLocations);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 445);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonLocations;
        private System.Windows.Forms.Button buttonMoves;
        private System.Windows.Forms.Panel panel1;
    }
}

