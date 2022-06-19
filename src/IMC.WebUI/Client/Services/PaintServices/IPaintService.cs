namespace IMC.WebUI.Client.Services.PaintServices
{
    public interface IPaintService
    {
        List<Paint> Paints { get; }
        Task GetPaintsAsync();
        Task<Paint> GetPaintByIdAsync(Guid id);
        Task GetPaintsByNameAsync(string name);
        Task CreatePaint(Paint paint);
        Task UpdatePaintAsync(Paint paint);
        Task DeletePaintAsync(Guid id);
     
    }
}
