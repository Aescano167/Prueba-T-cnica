namespace Prueba_Tecnica___Angel_Escaño
{
    using System.Data.SqlClient;
    partial class frmMantenimientoProyecto
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
            label4 = new Label();
            txtIdProyecto = new TextBox();
            label1 = new Label();
            btnModificarProyecto = new Button();
            btnEliminarProyecto = new Button();
            btnAgregarProyecto = new Button();
            label2 = new Label();
            txtNombreProyecto = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtIdUsuario = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 11);
            label4.Name = "label4";
            label4.Size = new Size(297, 30);
            label4.TabIndex = 9;
            label4.Text = "Mantenimiento de Proyectos";
            // 
            // txtIdProyecto
            // 
            txtIdProyecto.Location = new Point(134, 70);
            txtIdProyecto.Name = "txtIdProyecto";
            txtIdProyecto.Size = new Size(68, 23);
            txtIdProyecto.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 74);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 10;
            label1.Text = "Id Proyecto:";
            // 
            // btnModificarProyecto
            // 
            btnModificarProyecto.BackColor = Color.FromArgb(0, 192, 0);
            btnModificarProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarProyecto.ForeColor = Color.White;
            btnModificarProyecto.Location = new Point(276, 227);
            btnModificarProyecto.Name = "btnModificarProyecto";
            btnModificarProyecto.Size = new Size(75, 26);
            btnModificarProyecto.TabIndex = 14;
            btnModificarProyecto.Text = "Modificar";
            btnModificarProyecto.UseVisualStyleBackColor = false;
            btnModificarProyecto.Click += btnModificarProyecto_Click;
            // 
            // btnEliminarProyecto
            // 
            btnEliminarProyecto.BackColor = Color.FromArgb(0, 192, 0);
            btnEliminarProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProyecto.ForeColor = Color.White;
            btnEliminarProyecto.Location = new Point(173, 227);
            btnEliminarProyecto.Name = "btnEliminarProyecto";
            btnEliminarProyecto.Size = new Size(75, 26);
            btnEliminarProyecto.TabIndex = 13;
            btnEliminarProyecto.Text = "Eliminar";
            btnEliminarProyecto.UseVisualStyleBackColor = false;
            btnEliminarProyecto.Click += btnEliminarProyecto_Click;
            // 
            // btnAgregarProyecto
            // 
            btnAgregarProyecto.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProyecto.ForeColor = Color.White;
            btnAgregarProyecto.Location = new Point(70, 227);
            btnAgregarProyecto.Name = "btnAgregarProyecto";
            btnAgregarProyecto.Size = new Size(75, 26);
            btnAgregarProyecto.TabIndex = 12;
            btnAgregarProyecto.Text = "Agregar";
            btnAgregarProyecto.UseVisualStyleBackColor = false;
            btnAgregarProyecto.Click += btnAgregarProyecto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre del Proyecto:";
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Location = new Point(134, 96);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(141, 23);
            txtNombreProyecto.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 126);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 17;
            label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(134, 122);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(141, 23);
            txtDescripcion.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 153);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 19;
            label5.Text = "Usuario a cargo:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(134, 148);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(68, 23);
            txtIdUsuario.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 192, 0);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(203, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 23);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmMantenimientoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(398, 291);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombreProyecto);
            Controls.Add(label2);
            Controls.Add(btnModificarProyecto);
            Controls.Add(btnEliminarProyecto);
            Controls.Add(btnAgregarProyecto);
            Controls.Add(txtIdProyecto);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "frmMantenimientoProyecto";
            Text = "Proyectos";
            Load += frmMantenimientoProyecto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtIdProyecto;
        private Label label1;
        private Button btnModificarProyecto;
        private Button btnEliminarProyecto;
        private Button btnAgregarProyecto;
        private Label label2;
        private TextBox txtNombreProyecto;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtIdUsuario;
        private Button btnBuscar;
    }
}