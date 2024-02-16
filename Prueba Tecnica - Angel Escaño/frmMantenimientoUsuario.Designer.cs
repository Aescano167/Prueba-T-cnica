namespace Prueba_Tecnica___Angel_Escaño
{
    using System.Data.SqlClient;
    partial class frmMantenimientoUsuario
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            txtIdUsuario = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            btnAgregarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnModificarUsuario = new Button();
            label5 = new Label();
            txtIdProyecto = new TextBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 64);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Id Usuario:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(121, 60);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(60, 23);
            txtIdUsuario.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 192, 0);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(183, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(137, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(121, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(137, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 9);
            label4.Name = "label4";
            label4.Size = new Size(255, 30);
            label4.TabIndex = 8;
            label4.Text = "Mantenimiento Usuarios";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarUsuario.ForeColor = Color.White;
            btnAgregarUsuario.Location = new Point(66, 193);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(75, 26);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.FromArgb(0, 192, 0);
            btnEliminarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.Location = new Point(164, 193);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 26);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.BackColor = Color.FromArgb(0, 192, 0);
            btnModificarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarUsuario.ForeColor = Color.White;
            btnModificarUsuario.Location = new Point(265, 193);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(75, 26);
            btnModificarUsuario.TabIndex = 11;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 142);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 12;
            label5.Text = "Proyecto Asignado:";
            // 
            // txtIdProyecto
            // 
            txtIdProyecto.Location = new Point(121, 137);
            txtIdProyecto.Name = "txtIdProyecto";
            txtIdProyecto.Size = new Size(60, 23);
            txtIdProyecto.TabIndex = 13;
            // 
            // frmMantenimientoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(414, 303);
            Controls.Add(txtIdProyecto);
            Controls.Add(label5);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label1);
            Name = "frmMantenimientoUsuario";
            Text = "Usuarios";
            Load += frmMantenimientoUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private TextBox txtIdUsuario;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label4;
        private Button btnAgregarUsuario;
        private Button btnEliminarUsuario;
        private Button btnModificarUsuario;
        private Label label5;
        private TextBox txtIdProyecto;
    }
}