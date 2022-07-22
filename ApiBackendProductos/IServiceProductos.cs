using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceWeather
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProductos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProductos
    { 
        [OperationContract]
        bool registerProduct(int idProduct, string nameProduct, int fkIdProduct);

        [OperationContract]
        string findAllProduct();

        [OperationContract]
        string findAllProductJSON();

        [OperationContract]
        string findAllProductFilterJSON(int fkIdCategory);
    }
}
