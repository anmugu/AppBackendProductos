using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppBackendProductos;
using Newtonsoft.Json;
using WcfServiceProductos;

namespace WcfServiceWeather
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProductos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProductos.svc o ServiceProductos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProductos : IServiceProductos
    {
        SpProductoDataContext spProduct = new SpProductoDataContext();

        public string findAllProduct()
        {
            var list = spProduct.SP_LIST_PRODUCT();
            return list.ToString();
        }

        public string findAllProductFilterJSON(int fkIdCategory)
        {
            var list = spProduct.SP_LIST_PRODUCT_FILTER(fkIdCategory);
            string listAll = JsonConvert.SerializeObject(list, Formatting.Indented);

            return listAll;
        }

        public string findAllProductJSON()
        {
            var list = spProduct.SP_LIST_PRODUCT();
            string listAll = JsonConvert.SerializeObject(list, Formatting.Indented);

            return listAll;
        }

        public bool registerProduct(int idProduct, string nameProduct, int fkIdProduct)
        {
            int result = spProduct.SP_INSERT_PRODUCT(idProduct, nameProduct, fkIdProduct);
            if (result == 0)
            {
                return true;
            }

            return false;
        }
    }
}
