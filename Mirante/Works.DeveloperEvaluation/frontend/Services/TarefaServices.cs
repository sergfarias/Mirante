using Works.DeveloperEvaluation.WebApi.Features.Tarefas.ListarTarefa;
using System.Collections;
using System.Text;
using System.Text.Json;
using Tarefa = Works.DeveloperEvaluation.Frontend.Models.Tarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.RelatorioTarefa;
using Works.DeveloperEvaluation.Domain.Enums;
using Works.DeveloperEvaluation.Frontend.Models;

namespace Works.DeveloperEvaluation.Frontend.Services
{
    public class TarefaServices: ITarefaServices
    {

        readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        private const string ApiBaseUrl = "https://localhost:7181/";


        public TarefaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(ApiBaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<IEnumerable> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/Tarefas/TodosTarefas");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            // Se o JSON tem uma estrutura como: { "data": [...], "success": true }
            using JsonDocument document = JsonDocument.Parse(content);
            JsonElement root = document.RootElement;

            // Pegar o nó específico "data"
            JsonElement dataElement = root.GetProperty("data").GetProperty("data");

            var teste = JsonSerializer.Deserialize<IEnumerable<ListarTarefaResponse>>(
                dataElement.GetRawText(),
                _jsonOptions
            );

            return teste;

        }

        public async Task<ListarTarefaResponse> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Tarefas/TarefaById/{id}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            // Se o JSON tem uma estrutura como: { "data": [...], "success": true }
            using JsonDocument document = JsonDocument.Parse(content);
            JsonElement root = document.RootElement;

            // Pegar o nó específico "data"
            JsonElement dataElement = root.GetProperty("data").GetProperty("data");

            var teste = JsonSerializer.Deserialize<ListarTarefaResponse>(
                dataElement.GetRawText(),
                _jsonOptions
            );

            return teste;
        }

        public async Task<ListarTarefaResponse> CreateAsync(Tarefa Tarefa)
        {
            var json = JsonSerializer.Serialize(Tarefa);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Tarefas/InserirTarefa", content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();


            // Se o JSON tem uma estrutura como: { "data": [...], "success": true }
            using JsonDocument document = JsonDocument.Parse(responseContent);
            JsonElement root = document.RootElement;

            // Pegar o nó específico "data"
            JsonElement dataElement = root.GetProperty("data");

            var teste = JsonSerializer.Deserialize<ListarTarefaResponse>(
                dataElement.GetRawText(),
                _jsonOptions
            );

            return teste;


            //return JsonSerializer.Deserialize<IEnumerable>(responseContent, _jsonOptions);
        }

        public async Task UpdateAsync(int id, Tarefa Tarefa)
        {
            var json = JsonSerializer.Serialize(Tarefa);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"api/Tarefas/alterarTarefa", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Tarefas/deletarTarefa/{id}");
            response.EnsureSuccessStatusCode();
        }


        public async Task<IEnumerable> Relatorio(Status status, DateTime DtInicio, DateTime DtFim)
        {

            try
            {
                Buscar buscar = new();

                buscar.Status = status;
                buscar.DtInicio = DtInicio;
                buscar.DtFim = DtFim;

                var json = JsonSerializer.Serialize(buscar);
                var content = new StringContent(json, Encoding.UTF8, "application/json");


                var response = await _httpClient.PostAsync("api/Tarefas/RelatorioTarefas", content);
                response.EnsureSuccessStatusCode();

                var content2 = await response.Content.ReadAsStringAsync();

                // Se o JSON tem uma estrutura como: { "data": [...], "success": true }
                using JsonDocument document = JsonDocument.Parse(content2);
                JsonElement root = document.RootElement;

                // Pegar o nó específico "data"
                JsonElement dataElement = root.GetProperty("data").GetProperty("data");

                var teste = JsonSerializer.Deserialize<IEnumerable<RelatorioTarefaResponse>>(
                    dataElement.GetRawText(),
                    _jsonOptions
                );

                return teste;
            }
            catch (Exception ex) {
                return null;
            }

        }

    }
}

