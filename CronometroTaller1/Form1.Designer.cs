namespace CronometroTaller1
{
    partial class Cronometro
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
            this.txtPantalla = new System.Windows.Forms.Label();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnDarkWhiteMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.AutoSize = true;
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(34, 31);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(220, 55);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.Text = "00:00:00";
            // 
            // btnPausar
            // 
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Image = global::CronometroTaller1.Properties.Resources.pausar;
            this.btnPausar.Location = new System.Drawing.Point(183, 251);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(60, 60);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Image = global::CronometroTaller1.Properties.Resources.iniciar;
            this.btnIniciar.Location = new System.Drawing.Point(44, 251);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(60, 60);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Image = global::CronometroTaller1.Properties.Resources.reiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(114, 177);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(60, 60);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnDarkWhiteMode
            // 
            this.btnDarkWhiteMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkWhiteMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkWhiteMode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkWhiteMode.ForeColor = System.Drawing.Color.Black;
            this.btnDarkWhiteMode.Location = new System.Drawing.Point(165, 420);
            this.btnDarkWhiteMode.Name = "btnDarkWhiteMode";
            this.btnDarkWhiteMode.Size = new System.Drawing.Size(89, 29);
            this.btnDarkWhiteMode.TabIndex = 4;
            this.btnDarkWhiteMode.Text = "Dark Mode";
            this.btnDarkWhiteMode.UseVisualStyleBackColor = true;
            this.btnDarkWhiteMode.Click += new System.EventHandler(this.btnDarkWhiteMode_Click);
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.btnDarkWhiteMode);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.txtPantalla);
            this.Name = "Cronometro";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPantalla;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnDarkWhiteMode;
    }
}

