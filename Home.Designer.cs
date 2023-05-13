namespace MantenimientoDeClientes
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR NUEVO CLIENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "LISTADO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "HERRAMIENTAS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            this.bntSalir.Location = new System.Drawing.Point(621, 24);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(167, 87);
            this.bntSalir.TabIndex = 3;
            this.bntSalir.Text = "SALIR ";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MantenimientoDeClientes.Properties.Resources.Screenshot_2023_05_12_at_20_04_39_Diseño_sin_título;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Menu Mantenimiento de Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bntSalir;
    }
}