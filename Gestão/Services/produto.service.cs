using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Gestão.Dto;
using Gestão.Utils;

namespace Gestão.Services
{
    public class produtoService
    {
        private readonly http _httpService;

        public produtoService()
        {
            _httpService = new http("/produto");
        }

        public async Task<bool> cadastroproduto(string produtofotografia, string produtonome, string categoria, string tipo, float quantidade, float Total)
        {
            try
            {
                var body = new
                {
                    produtofotografia = produtofotografia,
                    produtonome = produtonome,
                    categoria = categoria,
                    tipo = tipo,
                    quantidade = quantidade,
                    Total = Total
                };
                DtoResposta<string> request = await _httpService.PostAsync<DtoResposta<string>>("cadastrar", null, body);
                if(request.data == "Sucesso")
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

    }
}
