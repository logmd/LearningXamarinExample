using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public interface IBaseResponse
    {
        bool HasError { get; set; }

        string ErrorMessage { get; set; }
    }
}
