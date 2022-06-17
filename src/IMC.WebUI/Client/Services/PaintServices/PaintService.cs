using System.Net.Http.Json;

namespace IMC.WebUI.Client.Services.PaintServices
{
    public class PaintService : IPaintService
    {
        private readonly HttpClient _http;

        public List<Paint> Paints { get; private set; } = new List<Paint>();

        public PaintService(HttpClient http)
        {
            this._http = http;
        }

        public Task<Paint> GetPaintAsync()
        {
            throw new NotImplementedException();
        }

        public async Task GetPaintsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<Paint>>("api/paint");
            if (result != null)
                Paints = result;
        }

        public async Task GetPaintsAsyncByName(string name)
        {
            var result = await _http.GetFromJsonAsync<List<Paint>>($"api/paint/{name}");
            if (result != null)
                Paints = result; 
        }

    }
}
