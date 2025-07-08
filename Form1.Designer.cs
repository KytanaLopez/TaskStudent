namespace Clase4GUI
{
    partial class frmPrincipal
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
            lstIdArea = new Label();
            txtIdAreaEmpresa = new TextBox();
            lblNombreAreaEmpresa = new Label();
            txtNombreAreaEmpresa = new TextBox();
            lblTitulo = new Label();
            lblResponsableAreaEmpresa = new Label();
            txtNombreResponsableArea = new TextBox();
            btnCreateAreasEmpresas = new Button();
            btnReadAreasEmpresas = new Button();
            btnUpdateAreasEmpresas = new Button();
            btnDeleteAreasEmpresas = new Button();
            btnGestionarPersonas = new Button();
            tabControl1 = new TabControl();
            tabPageAreasEmpresas = new TabPage();
            grdAreasEmpresas = new DataGridView();
            tabPageInventario = new TabPage();
            tabPageProduccion = new TabPage();
            tabPageMercadeo = new TabPage();
            tabPageFinanzas = new TabPage();
            btnGestionarInventario = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageAreasEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAreasEmpresas).BeginInit();
            tabPageInventario.SuspendLayout();
            SuspendLayout();
            // 
            // lstIdArea
            // 
            lstIdArea.AutoSize = true;
            lstIdArea.Location = new Point(67, 36);
            lstIdArea.Name = "lstIdArea";
            lstIdArea.Size = new Size(93, 15);
            lstIdArea.TabIndex = 0;
            lstIdArea.Text = "ID Área Empresa";
            // 
            // txtIdAreaEmpresa
            // 
            txtIdAreaEmpresa.Enabled = false;
            txtIdAreaEmpresa.Location = new Point(250, 33);
            txtIdAreaEmpresa.Name = "txtIdAreaEmpresa";
            txtIdAreaEmpresa.Size = new Size(110, 23);
            txtIdAreaEmpresa.TabIndex = 1;
            // 
            // lblNombreAreaEmpresa
            // 
            lblNombreAreaEmpresa.AutoSize = true;
            lblNombreAreaEmpresa.Location = new Point(67, 73);
            lblNombreAreaEmpresa.Name = "lblNombreAreaEmpresa";
            lblNombreAreaEmpresa.Size = new Size(126, 15);
            lblNombreAreaEmpresa.TabIndex = 2;
            lblNombreAreaEmpresa.Text = "Nombre Área Empresa";
            // 
            // txtNombreAreaEmpresa
            // 
            txtNombreAreaEmpresa.Location = new Point(250, 73);
            txtNombreAreaEmpresa.Name = "txtNombreAreaEmpresa";
            txtNombreAreaEmpresa.Size = new Size(227, 23);
            txtNombreAreaEmpresa.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(155, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Gestión Áreas de la Empresa";
            // 
            // lblResponsableAreaEmpresa
            // 
            lblResponsableAreaEmpresa.AutoSize = true;
            lblResponsableAreaEmpresa.Location = new Point(70, 114);
            lblResponsableAreaEmpresa.Name = "lblResponsableAreaEmpresa";
            lblResponsableAreaEmpresa.Size = new Size(147, 15);
            lblResponsableAreaEmpresa.TabIndex = 5;
            lblResponsableAreaEmpresa.Text = "Nombre Responsable Área";
            // 
            // txtNombreResponsableArea
            // 
            txtNombreResponsableArea.Location = new Point(251, 114);
            txtNombreResponsableArea.Name = "txtNombreResponsableArea";
            txtNombreResponsableArea.Size = new Size(226, 23);
            txtNombreResponsableArea.TabIndex = 6;
            // 
            // btnCreateAreasEmpresas
            // 
            btnCreateAreasEmpresas.BackColor = Color.FromArgb(192, 255, 192);
            btnCreateAreasEmpresas.Image = Properties.Resources.imgBotonGuardar;
            btnCreateAreasEmpresas.ImageAlign = ContentAlignment.TopCenter;
            btnCreateAreasEmpresas.Location = new Point(70, 160);
            btnCreateAreasEmpresas.Name = "btnCreateAreasEmpresas";
            btnCreateAreasEmpresas.Size = new Size(61, 62);
            btnCreateAreasEmpresas.TabIndex = 7;
            btnCreateAreasEmpresas.Text = "Create";
            btnCreateAreasEmpresas.TextAlign = ContentAlignment.BottomCenter;
            btnCreateAreasEmpresas.UseVisualStyleBackColor = false;
            btnCreateAreasEmpresas.Click += btnCreateAreasEmpresas_Click;
            // 
            // btnReadAreasEmpresas
            // 
            btnReadAreasEmpresas.BackColor = Color.FromArgb(192, 255, 255);
            btnReadAreasEmpresas.Image = Properties.Resources.imgBotonLeer;
            btnReadAreasEmpresas.ImageAlign = ContentAlignment.TopCenter;
            btnReadAreasEmpresas.Location = new Point(156, 160);
            btnReadAreasEmpresas.Name = "btnReadAreasEmpresas";
            btnReadAreasEmpresas.Size = new Size(61, 62);
            btnReadAreasEmpresas.TabIndex = 8;
            btnReadAreasEmpresas.Text = "Read";
            btnReadAreasEmpresas.TextAlign = ContentAlignment.BottomCenter;
            btnReadAreasEmpresas.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAreasEmpresas
            // 
            btnUpdateAreasEmpresas.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdateAreasEmpresas.Image = Properties.Resources.imgBotonActualizar;
            btnUpdateAreasEmpresas.ImageAlign = ContentAlignment.TopCenter;
            btnUpdateAreasEmpresas.Location = new Point(250, 160);
            btnUpdateAreasEmpresas.Name = "btnUpdateAreasEmpresas";
            btnUpdateAreasEmpresas.Size = new Size(61, 62);
            btnUpdateAreasEmpresas.TabIndex = 9;
            btnUpdateAreasEmpresas.Text = "Update";
            btnUpdateAreasEmpresas.TextAlign = ContentAlignment.BottomCenter;
            btnUpdateAreasEmpresas.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAreasEmpresas
            // 
            btnDeleteAreasEmpresas.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteAreasEmpresas.Image = Properties.Resources.imgBotonEliminar;
            btnDeleteAreasEmpresas.ImageAlign = ContentAlignment.TopCenter;
            btnDeleteAreasEmpresas.Location = new Point(344, 160);
            btnDeleteAreasEmpresas.Name = "btnDeleteAreasEmpresas";
            btnDeleteAreasEmpresas.Size = new Size(61, 62);
            btnDeleteAreasEmpresas.TabIndex = 10;
            btnDeleteAreasEmpresas.Text = "Delete";
            btnDeleteAreasEmpresas.TextAlign = ContentAlignment.BottomCenter;
            btnDeleteAreasEmpresas.UseVisualStyleBackColor = false;
            // 
            // btnGestionarPersonas
            // 
            btnGestionarPersonas.BackColor = Color.FromArgb(255, 192, 255);
            btnGestionarPersonas.Image = Properties.Resources.imgBotonPersonas;
            btnGestionarPersonas.ImageAlign = ContentAlignment.TopCenter;
            btnGestionarPersonas.Location = new Point(639, 75);
            btnGestionarPersonas.Name = "btnGestionarPersonas";
            btnGestionarPersonas.Size = new Size(87, 73);
            btnGestionarPersonas.TabIndex = 11;
            btnGestionarPersonas.Text = "Gestionar Personas";
            btnGestionarPersonas.TextAlign = ContentAlignment.BottomCenter;
            btnGestionarPersonas.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAreasEmpresas);
            tabControl1.Controls.Add(tabPageInventario);
            tabControl1.Controls.Add(tabPageProduccion);
            tabControl1.Controls.Add(tabPageMercadeo);
            tabControl1.Controls.Add(tabPageFinanzas);
            tabControl1.Location = new Point(75, 248);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(651, 236);
            tabControl1.TabIndex = 12;
            // 
            // tabPageAreasEmpresas
            // 
            tabPageAreasEmpresas.Controls.Add(grdAreasEmpresas);
            tabPageAreasEmpresas.Location = new Point(4, 24);
            tabPageAreasEmpresas.Name = "tabPageAreasEmpresas";
            tabPageAreasEmpresas.Padding = new Padding(3);
            tabPageAreasEmpresas.Size = new Size(643, 208);
            tabPageAreasEmpresas.TabIndex = 0;
            tabPageAreasEmpresas.Text = "Áreas Empresas";
            tabPageAreasEmpresas.UseVisualStyleBackColor = true;
            // 
            // grdAreasEmpresas
            // 
            grdAreasEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAreasEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAreasEmpresas.Location = new Point(27, 20);
            grdAreasEmpresas.Name = "grdAreasEmpresas";
            grdAreasEmpresas.Size = new Size(592, 167);
            grdAreasEmpresas.TabIndex = 0;
            grdAreasEmpresas.SelectionChanged += grdAreasEmpresas_SelectionChanged;
            // 
            // tabPageInventario
            // 
            tabPageInventario.Controls.Add(label1);
            tabPageInventario.Controls.Add(btnGestionarInventario);
            tabPageInventario.Location = new Point(4, 24);
            tabPageInventario.Name = "tabPageInventario";
            tabPageInventario.Padding = new Padding(3);
            tabPageInventario.Size = new Size(643, 208);
            tabPageInventario.TabIndex = 1;
            tabPageInventario.Text = "Inventario";
            tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // tabPageProduccion
            // 
            tabPageProduccion.Location = new Point(4, 24);
            tabPageProduccion.Name = "tabPageProduccion";
            tabPageProduccion.Size = new Size(643, 208);
            tabPageProduccion.TabIndex = 2;
            tabPageProduccion.Text = "Producción";
            tabPageProduccion.UseVisualStyleBackColor = true;
            // 
            // tabPageMercadeo
            // 
            tabPageMercadeo.Location = new Point(4, 24);
            tabPageMercadeo.Name = "tabPageMercadeo";
            tabPageMercadeo.Size = new Size(643, 208);
            tabPageMercadeo.TabIndex = 3;
            tabPageMercadeo.Text = "Mercadeo";
            tabPageMercadeo.UseVisualStyleBackColor = true;
            // 
            // tabPageFinanzas
            // 
            tabPageFinanzas.Location = new Point(4, 24);
            tabPageFinanzas.Name = "tabPageFinanzas";
            tabPageFinanzas.Size = new Size(643, 208);
            tabPageFinanzas.TabIndex = 4;
            tabPageFinanzas.Text = "Finanzas";
            tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // btnGestionarInventario
            // 
            btnGestionarInventario.Location = new Point(51, 61);
            btnGestionarInventario.Name = "btnGestionarInventario";
            btnGestionarInventario.Size = new Size(194, 23);
            btnGestionarInventario.TabIndex = 0;
            btnGestionarInventario.Text = "Gestionar Inventario";
            btnGestionarInventario.UseVisualStyleBackColor = true;
            btnGestionarInventario.Click += btnGestionarInventario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventario de la Empresa";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(tabControl1);
            Controls.Add(btnGestionarPersonas);
            Controls.Add(btnDeleteAreasEmpresas);
            Controls.Add(btnUpdateAreasEmpresas);
            Controls.Add(btnReadAreasEmpresas);
            Controls.Add(btnCreateAreasEmpresas);
            Controls.Add(txtNombreResponsableArea);
            Controls.Add(lblResponsableAreaEmpresa);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombreAreaEmpresa);
            Controls.Add(lblNombreAreaEmpresa);
            Controls.Add(txtIdAreaEmpresa);
            Controls.Add(lstIdArea);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto de aula";
            tabControl1.ResumeLayout(false);
            tabPageAreasEmpresas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAreasEmpresas).EndInit();
            tabPageInventario.ResumeLayout(false);
            tabPageInventario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lstIdArea;
        private TextBox txtIdAreaEmpresa;
        private Label lblNombreAreaEmpresa;
        private TextBox txtNombreAreaEmpresa;
        private Label lblTitulo;
        private Label lblResponsableAreaEmpresa;
        private TextBox txtNombreResponsableArea;
        private Button btnCreateAreasEmpresas;
        private Button btnReadAreasEmpresas;
        private Button btnUpdateAreasEmpresas;
        private Button btnDeleteAreasEmpresas;
        private Button btnGestionarPersonas;
        private TabControl tabControl1;
        private TabPage tabPageAreasEmpresas;
        private TabPage tabPageInventario;
        private TabPage tabPageProduccion;
        private TabPage tabPageMercadeo;
        private TabPage tabPageFinanzas;
        private DataGridView grdAreasEmpresas;
        private Label label1;
        private Button btnGestionarInventario;
    }
}
