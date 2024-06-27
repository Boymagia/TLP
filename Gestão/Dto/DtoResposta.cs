using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão.Dto
{
    public class DtoResposta<T>
    {
        public string? mensagem { get; set; }
        public T data { get; set; }
    }
}
