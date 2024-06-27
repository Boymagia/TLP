using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Gestão.Utils;
using Gestão.Dto;



namespace Gestão.Services
{
    public class contactos
    {
        private readonly http _httpContactos;
        public contactos()
        {
         _httpContactos = new http("/contactos");
        }

        public async Task<bool> cadastroproduto(string usercodigos, string usertelefone1, string usertelefone2)
        {
            try
            {
                var body = new
                {
                    usercodigos = usercodigos,
                    usertelefone1 = usertelefone1,
                    usertelefone2 = usertelefone2
                   
                };
                DtoResposta<string> request = await _httpContactos.PostAsync<DtoResposta<string>>("cadastro", null, body);
                if(request.data == "Sucesso")
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
    
}
