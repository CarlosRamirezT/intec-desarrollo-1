
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
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonLocations = new System.Windows.Forms.Button();
            this.buttonMoves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(114, 166);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(136, 101);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "Productos";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonLocations
            // 
            this.buttonLocations.Location = new System.Drawing.Point(296, 166);
            this.buttonLocations.Name = "buttonLocations";
            this.buttonLocations.Size = new System.Drawing.Size(140, 101);
            this.buttonLocations.TabIndex = 1;
            this.buttonLocations.Text = "Locations";
            this.buttonLocations.UseVisualStyleBackColor = true;
            this.buttonLocations.Click += new System.EventHandler(this.buttonLocations_Click);
            // 
            // buttonMoves
            // 
            this.buttonMoves.Location = new System.Drawing.Point(479, 168);
            this.buttonMoves.Name = "buttonMoves";
            this.buttonMoves.Size = new System.Drawing.Size(136, 99);
            this.buttonMoves.TabIndex = 2;
            this.buttonMoves.Text = "Movimientos de Inventario";
            this.buttonMoves.UseVisualStyleBackColor = true;
            this.buttonMoves.Click += new System.EventHandler(this.buttonMoves_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMoves);
            this.Controls.Add(this.buttonLocations);
            this.Controls.Add(this.buttonProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonLocations;
        private System.Windows.Forms.Button buttonMoves;
    }
}

