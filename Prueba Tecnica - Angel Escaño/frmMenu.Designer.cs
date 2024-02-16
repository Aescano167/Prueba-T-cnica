
namespace Prueba_Tecnica___Angel_Escaño
{
    using System.Data.SqlClient;
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            btnMantenimientoU = new ToolStripMenuItem();
            btnMantenimientoP = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnMantenimientoU, btnMantenimientoP });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(50, 20);
            menúToolStripMenuItem.Text = "Menú";
            // 
            // btnMantenimientoU
            // 
            btnMantenimientoU.Name = "btnMantenimientoU";
            btnMantenimientoU.Size = new Size(206, 22);
            btnMantenimientoU.Text = "Mantenimiento Usuario";
            btnMantenimientoU.Click += btnMantenimientoU_Click;
            // 
            // btnMantenimientoP
            // 
            btnMantenimientoP.Name = "btnMantenimientoP";
            btnMantenimientoP.Size = new Size(206, 22);
            btnMantenimientoP.Text = "Mantenimiento Proyecto";
            btnMantenimientoP.Click += btnMantenimientoP_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Prueba Tecnica ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnMantenimientoP_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmMantenimientoUsuario
            frmMantenimientoProyecto mantenimientoProyecto = new frmMantenimientoProyecto();

            // Mostrar el formulario
            mantenimientoProyecto.Show();

        }

        private void btnMantenimientoU_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmMantenimientoUsuario
            frmMantenimientoUsuario mantenimientoUsuarioForm = new frmMantenimientoUsuario();

            // Mostrar el formulario
            mantenimientoUsuarioForm.Show();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem btnMantenimientoU;
        private ToolStripMenuItem btnMantenimientoP;
    }
}
