﻿namespace ReportePrestamos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreLogin = new System.Windows.Forms.TextBox();
            this.txtContraseniaLogin = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbl_RegistroUsuarios = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(167, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtNombreLogin
            // 
            this.txtNombreLogin.Location = new System.Drawing.Point(159, 117);
            this.txtNombreLogin.Name = "txtNombreLogin";
            this.txtNombreLogin.Size = new System.Drawing.Size(195, 26);
            this.txtNombreLogin.TabIndex = 2;
            // 
            // txtContraseniaLogin
            // 
            this.txtContraseniaLogin.Location = new System.Drawing.Point(159, 236);
            this.txtContraseniaLogin.Name = "txtContraseniaLogin";
            this.txtContraseniaLogin.Size = new System.Drawing.Size(195, 26);
            this.txtContraseniaLogin.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(182, 317);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(140, 51);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lbl_RegistroUsuarios
            // 
            this.lbl_RegistroUsuarios.AutoSize = true;
            this.lbl_RegistroUsuarios.Location = new System.Drawing.Point(181, 277);
            this.lbl_RegistroUsuarios.Name = "lbl_RegistroUsuarios";
            this.lbl_RegistroUsuarios.Size = new System.Drawing.Size(141, 20);
            this.lbl_RegistroUsuarios.TabIndex = 5;
            this.lbl_RegistroUsuarios.TabStop = true;
            this.lbl_RegistroUsuarios.Text = "Registrar Usuarios";
            this.lbl_RegistroUsuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_RegistroUsuarios_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 413);
            this.Controls.Add(this.lbl_RegistroUsuarios);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContraseniaLogin);
            this.Controls.Add(this.txtNombreLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreLogin;
        private System.Windows.Forms.TextBox txtContraseniaLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lbl_RegistroUsuarios;
    }
}

