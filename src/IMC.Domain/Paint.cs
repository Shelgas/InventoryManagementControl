
namespace IMC.Domain
{
    public class Paint
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string? Type { get; set; }

    }
}