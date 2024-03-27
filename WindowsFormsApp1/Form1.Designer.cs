namespace WindowsFormsApp1
{
    partial class Form1
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
            this.grDatos = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.Estados = new System.Windows.Forms.ListBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.GpHorarios = new System.Windows.Forms.GroupBox();
            this.rBMatutino = new System.Windows.Forms.RadioButton();
            this.rBVespertino = new System.Windows.Forms.RadioButton();
            this.grDatos.SuspendLayout();
            this.GpHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDatos
            // 
            this.grDatos.Controls.Add(this.textDireccion);
            this.grDatos.Controls.Add(this.lbDireccion);
            this.grDatos.Controls.Add(this.textFecha);
            this.grDatos.Controls.Add(this.lbFecha);
            this.grDatos.Controls.Add(this.textNombre);
            this.grDatos.Controls.Add(this.lbNombre);
            this.grDatos.Location = new System.Drawing.Point(381, 12);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(368, 215);
            this.grDatos.TabIndex = 3;
            this.grDatos.TabStop = false;
            this.grDatos.Text = "Datos personales";
            this.grDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(115, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre completo";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(9, 38);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(302, 22);
            this.textNombre.TabIndex = 1;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(9, 67);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(132, 16);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha de nacimiento";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(12, 87);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(186, 22);
            this.textFecha.TabIndex = 3;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(12, 120);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(64, 16);
            this.lbDireccion.TabIndex = 4;
            this.lbDireccion.Text = "Direccion";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(15, 150);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(330, 22);
            this.textDireccion.TabIndex = 5;
            // 
            // Estados
            // 
            this.Estados.FormattingEnabled = true;
            this.Estados.ItemHeight = 16;
            this.Estados.Location = new System.Drawing.Point(382, 263);
            this.Estados.Name = "Estados";
            this.Estados.Size = new System.Drawing.Size(120, 84);
            this.Estados.TabIndex = 4;
            this.Estados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(646, 389);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // GpHorarios
            // 
            this.GpHorarios.Controls.Add(this.rBVespertino);
            this.GpHorarios.Controls.Add(this.rBMatutino);
            this.GpHorarios.Location = new System.Drawing.Point(29, 48);
            this.GpHorarios.Name = "GpHorarios";
            this.GpHorarios.Size = new System.Drawing.Size(200, 100);
            this.GpHorarios.TabIndex = 6;
            this.GpHorarios.TabStop = false;
            this.GpHorarios.Text = "Horarios";
            // 
            // rBMatutino
            // 
            this.rBMatutino.AutoSize = true;
            this.rBMatutino.Location = new System.Drawing.Point(7, 22);
            this.rBMatutino.Name = "rBMatutino";
            this.rBMatutino.Size = new System.Drawing.Size(78, 20);
            this.rBMatutino.TabIndex = 0;
            this.rBMatutino.TabStop = true;
            this.rBMatutino.Text = "Matutino";
            this.rBMatutino.UseVisualStyleBackColor = true;
            this.rBMatutino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBVespertino
            // 
            this.rBVespertino.AutoSize = true;
            this.rBVespertino.Location = new System.Drawing.Point(7, 49);
            this.rBVespertino.Name = "rBVespertino";
            this.rBVespertino.Size = new System.Drawing.Size(93, 20);
            this.rBVespertino.TabIndex = 1;
            this.rBVespertino.TabStop = true;
            this.rBVespertino.Text = "Vespertino";
            this.rBVespertino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GpHorarios);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Estados);
            this.Controls.Add(this.grDatos);
            this.Name = "Form1";
            this.Text = "Expediente de alumno";
            this.UseWaitCursor = true;
            this.grDatos.ResumeLayout(false);
            this.grDatos.PerformLayout();
            this.GpHorarios.ResumeLayout(false);
            this.GpHorarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grDatos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ListBox Estados;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox GpHorarios;
        private System.Windows.Forms.RadioButton rBMatutino;
        private System.Windows.Forms.RadioButton rBVespertino;
    }
}

