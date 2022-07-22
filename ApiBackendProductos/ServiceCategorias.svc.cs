﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppBackendProductos;
using Newtonsoft.Json;

namespace WcfServiceProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCategorias" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCategorias.svc o ServiceCategorias.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCategorias : IServiceCategorias
    {

        SpCategoriaDataContext spCategory = new SpCategoriaDataContext();

        public string findAllCategoryJSON()
        {
            var list = spCategory.SP_LIST_CATEGORY();
            string listAll = JsonConvert.SerializeObject(list, Formatting.Indented);

            return listAll;
        }
    }
}
