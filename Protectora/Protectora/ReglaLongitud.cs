using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Protectora
{
    class ReglaLongitud : ValidationRule
    {
        public int NumCaracteres { set; get; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int longitud = ((string)value).Length;
            if (longitud != NumCaracteres)
                return new ValidationResult(false, "Tiene que contener " + NumCaracteres.ToString() + " dígitos");
            return new ValidationResult(true, null);
        }
    }
}
