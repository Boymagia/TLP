using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Gestão.Services;

namespace Gestão.Controllers
{
    public class UsuarioController
    {
      
        public async Task<bool> loginUsuario(string username, string password)
        {
            return await new UsuarioService().loginUsuario(username, password);
        }
    }
}
