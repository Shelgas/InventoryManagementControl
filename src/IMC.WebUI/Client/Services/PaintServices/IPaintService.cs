namespace IMC.WebUI.Client.Services.PaintServices
{
    public interface IPaintService
    {
        List<Paint> Paints { get; }
        Task GetPaintsAsync();

        Task GetPaintsAsyncByName();
        Task<Paint> GetPaintAsync();
    }
}
