﻿namespace ReportePrestamos
{
    partial class RegistPrestCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistPrestCliente));
            this.txtMesesCliente = new System.Windows.Forms.TextBox();
            this.txtInteresCliente = new System.Windows.Forms.TextBox();
            this.txtClientePrestamo = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarPrestamoC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesesCliente
            // 
            this.txtMesesCliente.Location = new System.Drawing.Point(191, 256);
            this.txtMesesCliente.Name = "txtMesesCliente";
            this.txtMesesCliente.Size = new System.Drawing.Size(198, 20);
            this.txtMesesCliente.TabIndex = 21;
            // 
            // txtInteresCliente
            // 
            this.txtInteresCliente.Location = new System.Drawing.Point(412, 256);
            this.txtInteresCliente.Name = "txtInteresCliente";
            this.txtInteresCliente.Size = new System.Drawing.Size(119, 20);
            this.txtInteresCliente.TabIndex = 20;
            // 
            // txtClientePrestamo
            // 
            this.txtClientePrestamo.Location = new System.Drawing.Point(191, 170);
            this.txtClientePrestamo.Name = "txtClientePrestamo";
            this.txtClientePrestamo.Size = new System.Drawing.Size(198, 20);
            this.txtClientePrestamo.TabIndex = 19;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(412, 170);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(188, 20);
            this.txtMontoPrestamo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label4.Location = new System.Drawing.Point(409, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Interes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label2.Location = new System.Drawing.Point(188, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Meses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Monto Del Prestamo";
            // 
            // btnRegistrarPrestamoC
            // 
            this.btnRegistrarPrestamoC.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrarPrestamoC.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.btnRegistrarPrestamoC.Location = new System.Drawing.Point(191, 325);
            this.btnRegistrarPrestamoC.Name = "btnRegistrarPrestamoC";
            this.btnRegistrarPrestamoC.Size = new System.Drawing.Size(183, 23);
            this.btnRegistrarPrestamoC.TabIndex = 22;
            this.btnRegistrarPrestamoC.Text = "Registrar Prestamo Cliente";
            this.btnRegistrarPrestamoC.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamoC.Click += new System.EventHandler(this.btnRegistrarPrestamoC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 33);
            this.label6.TabIndex = 26;
            this.label6.Text = "Registro Prestamo Cliente";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Yellow;
            this.btnCalcular.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.btnCalcular.Location = new System.Drawing.Point(551, 253);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 23);
            this.btnCalcular.TabIndex = 27;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // RegistPrestCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrarPrestamoC);
            this.Controls.Add(this.txtMesesCliente);
            this.Controls.Add(this.txtInteresCliente);
            this.Controls.Add(this.txtClientePrestamo);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistPrestCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistPrestCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMesesCliente;
        private System.Windows.Forms.TextBox txtInteresCliente;
        private System.Windows.Forms.TextBox txtClientePrestamo;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarPrestamoC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
    }
}