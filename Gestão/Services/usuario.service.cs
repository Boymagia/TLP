using Gestão.Dto;
using Gestão.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão.Services
{
    public class UsuarioService
    {
        private readonly http _httpService;
        public UsuarioService() 
        {
            _httpService = new http("/Usuario");
        }

        public async Task<bool> loginUsuario(string username, string password)
        {
            try
            {
                var body = new 
                {
                    username = username,
                    password = password
                };
                DtoResposta<string> request = await _httpService.PostAsync<DtoResposta<string>>("cadastrar", null, body);
                if (request.data == "Sucesso")
                {
                    return true;
                }
            }
            catch
            {

            }
            return true;
        }

    }
}
