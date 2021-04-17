
namespace Lab
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.Maroon;
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCargar.Location = new System.Drawing.Point(29, 59);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(109, 40);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(207, 28);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(430, 138);
            this.textBoxResultado.TabIndex = 2;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(207, 230);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(430, 160);
            this.listBoxResultado.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.BackColor = System.Drawing.Color.Maroon;
            this.buttonNombres.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNombres.Location = new System.Drawing.Point(29, 126);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(109, 40);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Generar Promedios";
            this.buttonNombres.UseVisualStyleBackColor = false;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonNombres;
    }
}

