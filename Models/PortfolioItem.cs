namespace MyPortfolio.Models;

public class PortfolioItem
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Language { get; set; }
    public int Stars { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? Url { get; set; }
}