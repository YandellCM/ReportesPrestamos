﻿namespace ReportePrestamos
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnAmortizacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Yellow;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(243, 305);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(168, 74);
          
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Yellow;
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Location = new System.Drawing.Point(468, 305);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(168, 74);

            this.btnPrestamo.TabIndex = 2;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnAmortizacion
            // 
            this.btnAmortizacion.BackColor = System.Drawing.Color.Yellow;
            this.btnAmortizacion.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.btnAmortizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmortizacion.Location = new System.Drawing.Point(702, 305);
            this.btnAmortizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAmortizacion.Name = "btnAmortizacion";
            this.btnAmortizacion.Size = new System.Drawing.Size(168, 74);

            this.btnAmortizacion.TabIndex = 3;
            this.btnAmortizacion.Text = "Amortizacion";
            this.btnAmortizacion.UseVisualStyleBackColor = false;
            this.btnAmortizacion.Click += new System.EventHandler(this.btnAmortizacion_Click);
            // 
            // RegisterForm
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAmortizacion);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnAmortizacion;
    }
}