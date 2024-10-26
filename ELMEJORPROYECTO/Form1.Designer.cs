namespace ELMEJORPROYECTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txinicio = new System.Windows.Forms.TextBox();
            this.txregis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btinicio = new System.Windows.Forms.Button();
            this.btregis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su usuario";
            // 
            // txinicio
            // 
            this.txinicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txinicio.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txinicio.Location = new System.Drawing.Point(110, 82);
            this.txinicio.Name = "txinicio";
            this.txinicio.Size = new System.Drawing.Size(118, 22);
            this.txinicio.TabIndex = 1;
            // 
            // txregis
            // 
            this.txregis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txregis.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txregis.Location = new System.Drawing.Point(110, 138);
            this.txregis.Name = "txregis";
            this.txregis.Size = new System.Drawing.Size(118, 22);
            this.txregis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su contraseña";
            // 
            // btinicio
            // 
            this.btinicio.BackColor = System.Drawing.Color.Lime;
            this.btinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btinicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btinicio.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinicio.Location = new System.Drawing.Point(119, 166);
            this.btinicio.Name = "btinicio";
            this.btinicio.Size = new System.Drawing.Size(100, 31);
            this.btinicio.TabIndex = 4;
            this.btinicio.Text = "Iniciar Sesion";
            this.btinicio.UseVisualStyleBackColor = false;
            this.btinicio.Click += new System.EventHandler(this.btinicio_Click);
            // 
            // btregis
            // 
            this.btregis.BackColor = System.Drawing.Color.Lime;
            this.btregis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btregis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btregis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btregis.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregis.Location = new System.Drawing.Point(243, 207);
            this.btregis.Name = "btregis";
            this.btregis.Size = new System.Drawing.Size(97, 31);
            this.btregis.TabIndex = 5;
            this.btregis.Text = "Registrarse";
            this.btregis.UseVisualStyleBackColor = false;
            this.btregis.Click += new System.EventHandler(this.btregis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ELMEJORPROYECTO.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 55);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btregis);
            this.Controls.Add(this.btinicio);
            this.Controls.Add(this.txregis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txinicio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txinicio;
        private System.Windows.Forms.TextBox txregis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btinicio;
        private System.Windows.Forms.Button btregis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

