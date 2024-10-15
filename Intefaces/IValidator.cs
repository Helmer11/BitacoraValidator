using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator.Intefaces
{
    public interface IValidator
    {

        bool ValidatorIntenger(string value);
        bool ValidatorBoolean(string value);
        bool ValidatorString(string value);
        bool ValidatorDate(string value);
        bool ValidatorDecimal(string value);
        bool ValidatorByte(string value);   
        bool ValidatorDouble(string value);

        bool ValidatorFloat(string value);
    }
}
