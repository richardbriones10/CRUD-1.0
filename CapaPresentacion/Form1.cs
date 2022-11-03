using CapaDato;
using CapaNegocios;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {


        CN_Productos objetoCN = new CN_Productos();
        private SqlConnection Conexion = new SqlConnection("Server=RICHARD-PC;DataBase= DB_IlPadrino;Integrated Security=true");
        DataTable datos = new DataTable();
        SqlCommand comando = new SqlCommand();



        public Form1()
        {
            InitializeComponent();
            autocompletar_producto();
            autocompletar_cliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


    private void MostrarProdctos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView_carrito.DataSource = objeto.MostrarProd();
        }

        private void btn_agregar_carrito_Click(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //Funcion de autocompletado del textbox nombre del producto
        void autocompletar_producto()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            AutoCompleteStringCollection lista2 = new AutoCompleteStringCollection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Producto",Conexion);
            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Nombre"].ToString());
                lista2.Add(datos.Rows[i]["Descripcion"].ToString());

            }
            textBoxProducto.AutoCompleteCustomSource = lista;
            txt_descripcion_prod.AutoCompleteCustomSource = lista2;
        }
        //Funcion de autocompletado del textbox nombre del cliente
        void autocompletar_cliente()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cliente", Conexion);
            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Nombre"].ToString()+" "+ datos.Rows[i]["Apellido"].ToString());
            }
            textBoxCliente.AutoCompleteCustomSource = lista;
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton Buscar Cliente
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE C_Codigo = @cedula",Conexion);
            cmd.Parameters.AddWithValue("@cedula", textBox_cedula_cliente.Text);
            Conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBoxCliente.Text = reader["Nombre"].ToString() +" "+ reader["Apellido"].ToString();
            }
            Conexion.Close();
            

        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE P_Codigo = @ID", Conexion);
            cmd.Parameters.AddWithValue("@ID", textbox_id_prod.Text);
            Conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBoxProducto.Text = reader["Nombre"].ToString();
                txt_precio_unit_producto.Text = reader["Precio"].ToString();
                txt_descripcion_prod.Text = reader["Descripcion"].ToString();

            }
            
            Conexion.Close();
        }

        private void textbox_id_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}