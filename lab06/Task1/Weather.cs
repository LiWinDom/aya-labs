namespace lab06.Task1;

public record Weather
{
    public required string Country { get; set; }
    public required string City { get; set; }
    public required double Temperature { get; set; }
    public required string Description { get; set; }
}