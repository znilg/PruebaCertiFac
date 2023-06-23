using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public bool Correct { get; set; } //1 y 0 por ser booleana
        public Exception Ex { get; set; } // Excepcion
        public string ErrorMessage { get; set; } //Guarda el error
        public object Object { get; set; } //Objeto
        public List<object> Objects { get; set; } //Lista de objetos
    }
}
