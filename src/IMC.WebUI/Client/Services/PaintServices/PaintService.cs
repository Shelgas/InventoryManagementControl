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


        public async Task GetPaintsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<Paint>>("api/paint");
            if (result != null)
                Paints = result;
        }

        public async Task GetPaintsByNameAsync(string name)
        {
            var result = await _http.GetFromJsonAsync<List<Paint>>($"api/paint/{name}");
            if (result != null)
                Paints = result; 
        }


        public async Task<Paint> GetPaintByIdAsync(Guid id)
        {
            var result = await _http.GetFromJsonAsync<Paint>($"api/paint/{id}/edit");
            if (result != null)
                return result;
            throw new Exception("Paint not found!");
        }

        public Task CreatePaint(Paint paint)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePaintAsync(Paint paint)
        {
            throw new NotImplementedException();
        }

        public Task DeletePaintAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
