using System.ComponentModel;

namespace Clase4GUI
{
    public partial class frmPrincipal : Form
    {
        public BindingList<AreasEmpresas> listaEmpresas = new BindingList<AreasEmpresas>();

        public int contador = 0;
        public frmPrincipal()
        {
            InitializeComponent();
            txtIdAreaEmpresa.Text = contador.ToString();

        }

        private void btnCreateAreasEmpresas_Click(object sender, EventArgs e)
        {
            //contador = contador + 1;
            contador++;

            //Creamos el objeto a enlazar con el DateGridView
            AreasEmpresas areasEmpresas = new AreasEmpresas();

            //Llenar los atributos del objeto con los datos de los textBox

            areasEmpresas.idArea = contador;
            areasEmpresas.nombreArea = txtNombreAreaEmpresa.Text;
            areasEmpresas.responsableArea = txtNombreResponsableArea.Text;

            //Binding (enlazar el objeto o datos a mi Grid)
            listaEmpresas.Add(areasEmpresas);

            //Actualizar mi Grid (DataSource)
            grdAreasEmpresas.DataSource = listaEmpresas;

        }

        private void grdAreasEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdAreasEmpresas.CurrentRow != null && grdAreasEmpresas.CurrentRow.DataBoundItem != null)
            {
                AreasEmpresas areaEmpresaSeleccionada = (AreasEmpresas)grdAreasEmpresas.CurrentRow.DataBoundItem;
                //Mostramos en TextBox
                txtIdAreaEmpresa.Text = areaEmpresaSeleccionada.idArea.ToString();
                txtNombreAreaEmpresa.Text = areaEmpresaSeleccionada.nombreArea;
                txtNombreResponsableArea.Text = areaEmpresaSeleccionada.responsableArea;

            }

        }

        private void btnGestionarInventario_Click(object sender, EventArgs e)
        {
            frmInventario frmInventarioF = new frmInventario(listaEmpresas);
            
            //frmInventarioF.Show(); //No es modal...
            frmInventarioF.ShowDialog();
        }
    }
}
