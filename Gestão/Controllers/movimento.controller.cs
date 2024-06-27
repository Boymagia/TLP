using Gestão.Models;
using Gestão.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão.Controllers
{
    public class MovimentoController
    {
        public static async Task<List<Movimento>> todosMovimentos()
        {
            return await new MovimentoService().getMovimentos();
        }
    }
}
