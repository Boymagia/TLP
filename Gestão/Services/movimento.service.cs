using Gestão.Dto;
using Gestão.Models;
using Gestão.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão.Services
{
    public class MovimentoService
    {
        private readonly http _httpService;
        public MovimentoService()
        {
            _httpService = new http("/movimentos");
        }

        public async Task<List<Movimento>> getMovimentos()
        {
            List<Movimento> movimentos = new List<Movimento>();
            try
            {
                DtoResposta<List<Movimento>> resposta = await _httpService.GetAsync<DtoResposta<List<Movimento>>>("movimentos", null);
                return resposta.data;
            }
            catch
            {
                return movimentos;
            }
        }
    }
}
