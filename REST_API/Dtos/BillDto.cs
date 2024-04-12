namespace REST_API.Dtos;

public class BillDto {
    public string Id { get; set; } = null!;
    public DateTime BillDate { get; set; } = DateTime.UtcNow;
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public bool SendStartEmail { get; set; }
}