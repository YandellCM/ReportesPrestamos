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
            this.btnCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(209, 244);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(156, 59);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Yellow;
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrestamo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPrestamo.Location = new System.Drawing.Point(416, 244);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(149, 59);
            this.btnPrestamo.TabIndex = 2;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnAmortizacion
            // 
            this.btnAmortizacion.BackColor = System.Drawing.Color.Yellow;
            this.btnAmortizacion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAmortizacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAmortizacion.Location = new System.Drawing.Point(624, 244);
            this.btnAmortizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmortizacion.Name = "btnAmortizacion";
            this.btnAmortizacion.Size = new System.Drawing.Size(149, 59);
            this.btnAmortizacion.TabIndex = 3;
            this.btnAmortizacion.Text = "Amortizacion";
            this.btnAmortizacion.UseVisualStyleBackColor = false;
            this.btnAmortizacion.Click += new System.EventHandler(this.btnAmortizacion_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAmortizacion);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
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