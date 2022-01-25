﻿using Localiza.Frotas.Domain;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Localiza.Frotas.Infra.Facade
{
    public class VeiculoDetranFacade : IVeiculoDetran
    {
        private DetranOptions detranOptions;
        private IVeiculoRepository veiculoRepository;        
        private readonly IHttpClientFactory httpClientFactory;

        public VeiculoDetranFacade(IOptionsMonitor<DetranOptions> optionsMonitor, IHttpClientFactory httpClientFactory)
        {
            this.detranOptions = optionsMonitor.CurrentValue;
            this.httpClientFactory = httpClientFactory;
            this.veiculoRepository = veiculoRepository;
        }

        public async Task AgendarVistoriaDetran(Guid veiculoId) //await precisa de async
        {
            var veiculo = veiculoRepository.GetById(veiculoId);

            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(detranOptions.BaseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var requestModel = new VistoriaModel()
            {
                Placa = veiculo.Placa,
                AgendadoPara = DateTime.Now.AddDays(detranOptions.QuantidadeDiasParaAgendamento)
            };

            var jsonContent = JsonSerializer.Serialize(requestModel);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            await client.PostAsync(detranOptions.VistoriaUri, contentString);
        }
    }
}
