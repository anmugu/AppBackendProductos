using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCategorias" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCategorias
    { 
        [OperationContract]
        string findAllCategoryJSON();
    }
}
