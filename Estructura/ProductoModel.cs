using AdministradorDeProductos.Enum;
using Dominio;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Estructura
{
    public class ProductoModel
    {
        private Producto[] productos;
        private Producto[] aux;
        private Producto[] aux1;

        public ProductoModel(Producto[] aux)
        {
            this.aux = aux;
        }

        public ProductoModel()
        {
        }

        public void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("Error, el producto no puede ser null.");
            }

            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
                return;
            }

            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = p;
            productos = tmp;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public void Update(Producto p)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (p.Codigo == productos[i].Codigo)
                {
                    productos[i] = p;
                }
            }

        }
        //el ultimo se convierte en el que voy a borrar
        public void Delete(Producto p)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (p.Codigo == productos[i].Codigo)
                {
                    productos[i] = productos[productos.Length - 1];
                    Producto[] tmp = new Producto[productos.Length - 1];
                    Array.Copy(productos, tmp, productos.Length - 1);

                    productos = tmp;
                }
            }
        }
        public Producto[] ProductosbyCaducidad(DateTime caducidad)
        {

            int t = 0;
            aux = new Producto[productos.Length];

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].Caducidad.CompareTo(caducidad) < 0)
                {

                    // Producto[] aux = new Producto[t];
                    aux[t] = productos[i];
                    t += 1;

                }
            }

            return aux;


        }
        public Producto[] ProductosbyRango(decimal de, decimal hasta)
        {
            int t = 0;
            aux1 = new Producto[productos.Length];

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].Precio >= de && productos[i].Precio <= hasta)
                {

                    //Producto[] aux = new Producto[t];
                    aux1[t] = productos[i];
                    t += 1;

                }
            }
            return aux1;


        }
        public string ConvertToJson()
        {
            var jsonString = new JavaScriptSerializer();
            //Use of Serialize() method
            var jsonResultado = jsonString.Serialize(productos);




            return jsonResultado;
        }
        public Producto[] BuscarId(int d)
        {
            int t = 0;
            aux = new Producto[productos.Length];

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].ID == d)
                {

                    // Producto[] aux = new Producto[t];
                    aux[t] = productos[i];
                    t += 1;

                }


            }

            return aux;

        }
        public Producto[] BuscarUnidad(UnidadDeMedida a)
        {

            int t = 0;
            aux = new Producto[productos.Length];

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].Unidaddemedida.Equals(a))
                {

                     //Producto[] aux = new Producto[t];
                    aux[t] = productos[i];
                    t += 1;

                }
            }

            return aux;

        }
        public Producto[] buscarprecio(decimal a)
        {
            int t = 0;
            aux = new Producto[productos.Length];

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].Precio == a)
                {

                    // Producto[] aux = new Producto[t];
                    aux[t] = productos[i];
                    t += 1;

                }


            }

            return aux;
        }

    }
}
