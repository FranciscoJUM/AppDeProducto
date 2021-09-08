using AdministradorDeProductos.Enum;
using Dominio;
using Estructura;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeProductos
{
    public partial class Form1 : Form
    {
        public int id { get; set; }
        private ProductoModel em;
        private Producto producto;
        public Form1()
        {
            em = new ProductoModel();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            decimal precio;
            decimal  cantidad, tot;
            int codigo;
            DateTime caducidad;
            try
            {
                
                nombre = txtNom.Text;
                descripcion = txtDes.Text;
                if (Caducidadasd== null)
                {
                    MessageBox.Show("Error de fecha", "Debe ingresar una fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime caducidadFind = Caducidadasd.Value.Date;
                  
                }
                caducidad =  Caducidadasd.Value.Date;

                precio = decimal.Parse(txtPre.Text);
                codigo = int.Parse(textCodigo.Text);
                cantidad = decimal.Parse(txtCan.Text);
                tot = Valortotal(precio, cantidad);
                ValidateEmpleado(nombre, descripcion, txtCan.Text, txtPre.Text, textCodigo.Text);
                Producto emp = new Producto()
                {
                    ID = ++this.id,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Cantidad = cantidad,
                    Precio = precio,
                    Caducidad = caducidad,
                    Codigo = codigo,
                    Unidaddemedida = (UnidadDeMedida)UnidadMedida.SelectedIndex,
                   
                };
                


                Producto emp1 = emp;
                em.Add(emp1);




                MessageBox.Show($@"
                                ID: {emp.ID} {Environment.NewLine} 
                                Nombre: {emp.Nombre} {Environment.NewLine} 
                                Descripcion: {emp.Descripcion} {Environment.NewLine} 
                                Cantidad: {emp.Cantidad} {Environment.NewLine} 
                                Precio: {emp.Precio}{Environment.NewLine} 
                                Caducidad: {emp.Caducidad}{Environment.NewLine}
                                Codigo: {emp.Codigo}{Environment.NewLine};
                                Unidad de medida: {emp.Unidaddemedida}{Environment.NewLine}
                                Valor total: {tot}{Environment.NewLine}
");
                 CleanTexbox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CleanTexbox();
            }
            

        }
        public void CleanTexbox()
        {
            txtNom.Text = string.Empty;
            txtDes.Text = string.Empty;
           
            txtPre.Text = string.Empty;
            textCodigo.Text = string.Empty;
            txtCan.Text = string.Empty;

        }
        private void ValidateEmpleado(string nombre, string descripcion, string cantidad, string precio, string codigo)
        {
           
             
            
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(precio) )
            {
                throw new ArgumentException("Error, todos los datos son requeridos.");
            }
           

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                throw new ArgumentException("Error, Nombre y Descripcion no pueden ser vacios");
            }

            if (nombre.Length > 20 || nombre.Length > 20)
            {
                throw new ArgumentException("Error, maximo de caracteres pemitido es 20");
            }

            if (!decimal.TryParse(txtPre.Text, out decimal salario))
            {
                throw new ArgumentException($"Error el salario: {txtPre.Text} no se pudo convertir");
            }
            if (int.Parse(textCodigo.Text) == 0)
            {
                throw new ArgumentException($"Error el codigo no puede estar vacio o no se pudo convertir");
            }

           
        }

        public decimal Valortotal(decimal precio, decimal cantidad)
        {
            decimal total;
            total = (cantidad * precio);

            return total;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            

           
            int BusID = int.Parse(BuscarId.Text);



            Producto[] ran = em.BuscarId(BusID);
            var jsonString = new JavaScriptSerializer();
            //Use of Serialize() method
            var jsonResultado = jsonString.Serialize(ran);
            MessageBox.Show(jsonResultado);

            ClearId();
        }

        private void button2_Click(object sender, EventArgs e)
        {

       

                  if (!decimal.TryParse(Buscarprecio.Text, out decimal x))
            {
                throw new ArgumentException($"Error  ");
            }

            Producto[] pre = em.buscarprecio(x);

            var jsonString = new JavaScriptSerializer();
            //Use of Serialize() method
            var jsonResultado = jsonString.Serialize(pre);
            MessageBox.Show(jsonResultado);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int codigo;
            int cantidad;
            decimal precio;
            string name = txtNom.Text;
          
            if (!int.TryParse(textCodigo.Text, out codigo) || !int.TryParse(txtCan.Text, out cantidad)  || !decimal.TryParse(txtPre.Text, out precio) )
            {
                MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000");
                return;
            }


            else
            {

                cantidad = int.Parse(txtCan.Text);
                codigo = int.Parse(textCodigo.Text);
               
                precio = decimal.Parse(txtPre.Text);
            }
            producto = new Producto()
            {
               
                Cantidad = cantidad,
                Codigo = codigo,
                Nombre = name,
                Precio = precio,
                
            };


           em.Delete(producto);
            textCodigo.Text = string.Empty;
            txtCan.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPre.Text = string.Empty;
            
            
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = txtNom.Text;
          
            int cantidad, codigo;
            decimal precio;
            if (!int.TryParse(textCodigo.Text, out codigo) || !int.TryParse(txtCan.Text, out cantidad)  || !decimal.TryParse(txtPre.Text, out precio))
            {
                MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000");
                return;
            }

            
            else
            {

                cantidad = int.Parse(txtCan.Text);
                codigo = int.Parse(textCodigo.Text);
               
                precio = decimal.Parse(txtPre.Text);
            }
          
            producto.Cantidad = cantidad;
            producto.Codigo = codigo;
            producto.Nombre = name;
            producto.Precio = precio;
        
            em.Update(producto);
            textCodigo.Text = string.Empty;
            txtCan.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPre.Text = string.Empty;
           

        }

        private void btnBuscarRango_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDe.Text, out decimal de) || !decimal.TryParse(btnHasta.Text, out decimal hasta))
            {
                throw new ArgumentException($"Error no ingreso un termino en decimal");
            }
            else if (de > hasta)
            {
                MessageBox.Show("valores incoherentes");
            }
            else
            {

                Producto[] rango = em.ProductosbyRango(de, hasta);
               


                var jsonString = new JavaScriptSerializer();
                //Use of Serialize() method
                var jsonResultado = jsonString.Serialize(rango);
                MessageBox.Show(jsonResultado);

            }
            txtDe.Clear();
            btnHasta.Clear();
        }

        private void btnBuscarCaducidad_Click(object sender, EventArgs e)
        {

          
            if (tmrBuscarCaducidad == null)
            {
                MessageBox.Show("Error de fecha", "Debe ingresar una fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                DateTime caducidadFind = tmrBuscarCaducidad.Value.Date;
                Producto[] caducos = em.ProductosbyCaducidad(caducidadFind);
                

                var jsonString = new JavaScriptSerializer();
                //Use of Serialize() method
                var jsonResultado = jsonString.Serialize(caducos);
                MessageBox.Show(jsonResultado);
            }
        }

        private void btnMostrarJson_Click(object sender, EventArgs e)
        {
            richJson.Text = em.ConvertToJson();
            richJson.Clear();
        }

        private void richJson_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClearId()
        {
            BuscarId.Text = string.Empty;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Producto emp = new Producto()
            {
               
                Unidaddemedida = (UnidadDeMedida)UnidadMedida.SelectedIndex,

            };


            Producto[] caducos =em.BuscarUnidad(emp.Unidaddemedida);


                var jsonString = new JavaScriptSerializer();
                //Use of Serialize() method
                var jsonResultado = jsonString.Serialize(caducos);
                MessageBox.Show(jsonResultado);

            }
    }

}
