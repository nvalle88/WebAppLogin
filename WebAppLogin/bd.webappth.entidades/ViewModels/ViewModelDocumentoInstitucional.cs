using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
    public class ViewModelDocumentoInstitucional
    {
        public string Nombre { get; set; }

        [DataType(DataType.Url)]
        public string  Archivo { get; set; }
    }
}
