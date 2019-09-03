namespace Taller3._1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnedad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(170, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(443, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Programa para Solicitud de la Edad";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(50, 131);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(168, 24);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "Ingrese su Edad:";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(243, 132);
            this.txtedad.Multiline = true;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(105, 23);
            this.txtedad.TabIndex = 2;
            // 
            // btnedad
            // 
            this.btnedad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedad.Location = new System.Drawing.Point(421, 123);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(113, 40);
            this.btnedad.TabIndex = 3;
            this.btnedad.Text = "Presiona";
            this.btnedad.UseVisualStyleBackColor = true;
            this.btnedad.Click += new System.EventHandler(this.btnedad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedad);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnedad;
    }
}

