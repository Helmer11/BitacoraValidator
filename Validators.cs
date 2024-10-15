using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.Intefaces;

namespace Validator
{
    public class Validators : IValidator
    {
        public bool ValidatorBoolean(string value)
        {
           return Boolean.TryParse(value, out Boolean result);
        }

        public bool ValidatorByte(string value)
        {
            return Byte.TryParse(value, out Byte result);
        }

        public bool ValidatorDate(string value)
        {
            return DateTime.TryParse(value, out DateTime result);
        }

        public bool ValidatorDecimal(string value)
        {
            return Decimal.TryParse(value, out Decimal result);
        }

        public bool ValidatorDouble(string value)
        {
           return Double.TryParse(value, out Double result);
        }

        public bool ValidatorFloat(string value)
        {
           return float.TryParse(value, out float result);
        }

        public bool ValidatorIntenger(string value)
        {
           return int.TryParse(value, out int result);
        }

        public bool ValidatorString(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? false :true;
        }
    }
}
