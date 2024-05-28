using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        public int CurrentPage { get; set; }
    }
}
