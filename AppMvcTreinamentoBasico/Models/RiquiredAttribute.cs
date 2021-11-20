using System;

namespace AppMvcTreinamentoBasico.Models
{
    internal class RiquiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}