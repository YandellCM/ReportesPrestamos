namespace ReportePrestamos
{
    partial class Amortizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amortizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumPago = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtTipoAmortizacion = new System.Windows.Forms.TextBox();
            this.txtAmortizacion = new System.Windows.Forms.TextBox();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.txtPagoTotal = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.btnRegistrarAmortizacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label2.Location = new System.Drawing.Point(688, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha del Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label3.Location = new System.Drawing.Point(305, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label4.Location = new System.Drawing.Point(688, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intereses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label5.Location = new System.Drawing.Point(305, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amortizacion de Capital";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label6.Location = new System.Drawing.Point(305, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saldo Pendiente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label7.Location = new System.Drawing.Point(688, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tasa de Interes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 10.8F);
            this.label8.Location = new System.Drawing.Point(688, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo de Amortizacion";
            // 
            // txtNumPago
            // 
            this.txtNumPago.Location = new System.Drawing.Point(480, 198);
            this.txtNumPago.Name = "txtNumPago";
            this.txtNumPago.Size = new System.Drawing.Size(136, 22);
            this.txtNumPago.TabIndex = 8;
            this.txtNumPago.TextChanged += new System.EventHandler(this.txtNumPago_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(480, 328);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(135, 22);
            this.txtSaldo.TabIndex = 9;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(841, 325);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(135, 22);
            this.txtTasaInteres.TabIndex = 10;
            // 
            // txtTipoAmortizacion
            // 
            this.txtTipoAmortizacion.Location = new System.Drawing.Point(869, 385);
            this.txtTipoAmortizacion.Name = "txtTipoAmortizacion";
            this.txtTipoAmortizacion.Size = new System.Drawing.Size(173, 22);
            this.txtTipoAmortizacion.TabIndex = 11;
            // 
            // txtAmortizacion
            // 
            this.txtAmortizacion.Location = new System.Drawing.Point(491, 387);
            this.txtAmortizacion.Name = "txtAmortizacion";
            this.txtAmortizacion.Size = new System.Drawing.Size(125, 22);
            this.txtAmortizacion.TabIndex = 12;
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(801, 258);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(175, 22);
            this.txtIntereses.TabIndex = 13;
            this.txtIntereses.TextChanged += new System.EventHandler(this.txtIntereses_TextChanged);
            // 
            // txtPagoTotal
            // 
            this.txtPagoTotal.Location = new System.Drawing.Point(438, 262);
            this.txtPagoTotal.Name = "txtPagoTotal";
            this.txtPagoTotal.Size = new System.Drawing.Size(178, 22);
            this.txtPagoTotal.TabIndex = 14;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(841, 200);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(135, 22);
            this.txtFechaPago.TabIndex = 15;
            // 
            // btnRegistrarAmortizacion
            // 
            this.btnRegistrarAmortizacion.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrarAmortizacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAmortizacion.Location = new System.Drawing.Point(309, 446);
            this.btnRegistrarAmortizacion.Name = "btnRegistrarAmortizacion";
            this.btnRegistrarAmortizacion.Size = new System.Drawing.Size(265, 50);
            this.btnRegistrarAmortizacion.TabIndex = 16;
            this.btnRegistrarAmortizacion.Text = "Registrar Amortizacion";
            this.btnRegistrarAmortizacion.UseVisualStyleBackColor = false;
            this.btnRegistrarAmortizacion.Click += new System.EventHandler(this.btnRegistrarAmortizacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 56);
            this.label9.TabIndex = 17;
            this.label9.Text = "Amortizacion";
            // 
            // Amortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrarAmortizacion);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.txtPagoTotal);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.txtAmortizacion);
            this.Controls.Add(this.txtTipoAmortizacion);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNumPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Name = "Amortizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.Amortizacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumPago;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtTipoAmortizacion;
        private System.Windows.Forms.TextBox txtAmortizacion;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.TextBox txtPagoTotal;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Button btnRegistrarAmortizacion;
        private System.Windows.Forms.Label label9;
    }
}