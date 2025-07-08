using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4GUI
{
    public partial class frmInventario : Form
    {
        //Creo un BindingList público para poder trabajar la lista de empresas donde desee
        public BindingList<AreasEmpresas> listaEmpresas1;
        public frmInventario(BindingList<AreasEmpresas> listaEmpresas)
        {
            InitializeComponent();

            listaEmpresas1 = listaEmpresas;

            //Llenar combo de ubicación stock
            cboUbicacionStock.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboUbicacionStock.SelectedIndex = 0;

            //Traer id del binding lista Empresas
            var listaId = listaEmpresas.Select(e => e.idArea).ToList();

            //Mostrar lista en combo box
            cboIdAreaEmpresa.DataSource = listaId;


        }

        private void cboIdAreaEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mirar qué id seleccionó
            int idSeleccionado = (int)cboIdAreaEmpresa.SelectedValue;

            //Mostrar un mensaje con el id seleccionado
            MessageBox.Show("El id seleccionado es: " + idSeleccionado);

            if (idSeleccionado != null)
            {
                //Buscar el área con ese id
                AreasEmpresas areaSeleccionada = listaEmpresas1.FirstOrDefault(e => e.idArea == idSeleccionado);

                //Agrego el nombre y el responsable a los text box

                txtNombreAreaI.Text = areaSeleccionada.nombreArea;
                txtNombreResponsableI.Text = areaSeleccionada.responsableArea;
            }

           
        }
    }
}
