using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaVeterinaria.CapaIntegracion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace ServicioVeterinariaWeb
{
    public partial class frmMedicamento : System.Web.UI.Page
    {

        DataSet dsTratamiento;
        DataTable dtTratamiento;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarComboBox();
            cargarGridTratamiento();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                tratamiento.insertarTratamiento(int.Parse(txtMedicamento_id.Text),(txtDosis.Text),
                    txtObservaciones.Text, "A");
                
            }
            cargarComboBox();
            cargarGridTratamiento();
        }

        public void cargarComboBox()
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                if (!IsPostBack)
                {
                    DDLTratamiento.DataSource = tratamiento.listarTratamientos();
                    DDLTratamiento.DataValueField = "Tratamiento_id";
                    DDLTratamiento.DataTextField = "Tratamiento_id";

                    DDLTratamiento.DataBind();
                    DDLTratamiento.SelectedIndex=0;
                }
                
            }
        }

        public void cargarGridTratamiento()
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                if (!IsPostBack)
                {
                    GVTratamientro.DataSource = tratamiento.listarTratamientos();
                    GVTratamientro.DataBind();
                }
            }
        }

        protected void btnCargarDatos_Click(object sender, EventArgs e)
        {
            int Tratamiento_id = int.Parse( DDLTratamiento.SelectedValue.ToString());

            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                this.dsTratamiento =  tratamiento.consultaTratamientos(Tratamiento_id);
                this.dtTratamiento = this.dsTratamiento.Tables[0];
            }
            cargarDatosTratamiento();
        }
        private void cargarDatosTratamiento()
        {
            txtId.Text = this.dtTratamiento.Rows[0]["Tratamiento_id"].ToString();
            txtMedicamento_id.Text = this.dtTratamiento.Rows[0]["Medicamento_id"].ToString();
            txtDosis.Text = this.dtTratamiento.Rows[0]["Tratamiento_dosis"].ToString();
            txtObservaciones.Text = this.dtTratamiento.Rows[0]["Tratamiento_observaciones"].ToString();
            txtEstado.Text = this.dtTratamiento.Rows[0]["Tratamiento_Estado"].ToString();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}