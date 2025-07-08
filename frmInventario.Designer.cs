namespace Clase4GUI
{
    partial class frmInventario
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
            lblInventario = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotalProductosStock = new Label();
            txtTotalProductosStock = new TextBox();
            dtpFechaInventario = new DateTimePicker();
            cboUbicacionStock = new ComboBox();
            cboIdAreaEmpresa = new ComboBox();
            txtNombreAreaI = new TextBox();
            txtNombreResponsableI = new TextBox();
            SuspendLayout();
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventario.Location = new Point(56, 25);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(235, 25);
            lblInventario.TabIndex = 0;
            lblInventario.Text = "Formulario de Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 98);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha de inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 136);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 4;
            label2.Text = "Ubicación Stank";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 177);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "ID Área";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 232);
            label4.Name = "label4";
            label4.Size = new Size(215, 15);
            label4.TabIndex = 7;
            label4.Text = "Datos Id Áreas Empresas Seleccionando";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 257);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre Área";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 259);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 10;
            label6.Text = "Nombre del Responsable";
            // 
            // lblTotalProductosStock
            // 
            lblTotalProductosStock.AutoSize = true;
            lblTotalProductosStock.Location = new Point(67, 66);
            lblTotalProductosStock.Name = "lblTotalProductosStock";
            lblTotalProductosStock.Size = new Size(199, 15);
            lblTotalProductosStock.TabIndex = 11;
            lblTotalProductosStock.Text = "Número total de productos en Stock";
            // 
            // txtTotalProductosStock
            // 
            txtTotalProductosStock.Location = new Point(286, 61);
            txtTotalProductosStock.Name = "txtTotalProductosStock";
            txtTotalProductosStock.Size = new Size(166, 23);
            txtTotalProductosStock.TabIndex = 12;
            // 
            // dtpFechaInventario
            // 
            dtpFechaInventario.Format = DateTimePickerFormat.Short;
            dtpFechaInventario.Location = new Point(286, 98);
            dtpFechaInventario.Name = "dtpFechaInventario";
            dtpFechaInventario.Size = new Size(103, 23);
            dtpFechaInventario.TabIndex = 13;
            // 
            // cboUbicacionStock
            // 
            cboUbicacionStock.FormattingEnabled = true;
            cboUbicacionStock.Location = new Point(285, 139);
            cboUbicacionStock.Name = "cboUbicacionStock";
            cboUbicacionStock.Size = new Size(121, 23);
            cboUbicacionStock.TabIndex = 14;
            // 
            // cboIdAreaEmpresa
            // 
            cboIdAreaEmpresa.FormattingEnabled = true;
            cboIdAreaEmpresa.Location = new Point(285, 181);
            cboIdAreaEmpresa.Name = "cboIdAreaEmpresa";
            cboIdAreaEmpresa.Size = new Size(121, 23);
            cboIdAreaEmpresa.TabIndex = 15;
            cboIdAreaEmpresa.SelectedIndexChanged += cboIdAreaEmpresa_SelectedIndexChanged;
            // 
            // txtNombreAreaI
            // 
            txtNombreAreaI.Location = new Point(70, 299);
            txtNombreAreaI.Name = "txtNombreAreaI";
            txtNombreAreaI.Size = new Size(207, 23);
            txtNombreAreaI.TabIndex = 16;
            // 
            // txtNombreResponsableI
            // 
            txtNombreResponsableI.Location = new Point(303, 301);
            txtNombreResponsableI.Name = "txtNombreResponsableI";
            txtNombreResponsableI.Size = new Size(234, 23);
            txtNombreResponsableI.TabIndex = 17;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombreResponsableI);
            Controls.Add(txtNombreAreaI);
            Controls.Add(cboIdAreaEmpresa);
            Controls.Add(cboUbicacionStock);
            Controls.Add(dtpFechaInventario);
            Controls.Add(txtTotalProductosStock);
            Controls.Add(lblTotalProductosStock);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInventario);
            Name = "frmInventario";
            Text = "Formulario Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTotalProductosStock;
        private TextBox txtTotalProductosStock;
        private DateTimePicker dtpFechaInventario;
        private ComboBox cboUbicacionStock;
        private ComboBox cboIdAreaEmpresa;
        private TextBox txtNombreAreaI;
        private TextBox txtNombreResponsableI;
    }
}