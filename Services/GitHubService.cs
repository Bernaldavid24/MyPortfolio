using Octokit;
using MyPortfolio.Models; // Links to new model

namespace MyPortfolio.Services;

public class PortfolioService
{
    private readonly GitHubClient _client;

    public PortfolioService()
    {
        // "MyPortfolioApp" can be any string name
        _client = new GitHubClient(new ProductHeaderValue("MyPortfolioApp"));
    }

    public async Task<List<PortfolioItem>> GetPortfolioAsync(string username)
    {
        var repos = await _client.Repository.GetAllForUser(username);

        return repos
            .Where(r => !r.Fork) // Filter out forked repos if needed
            .OrderByDescending(r => r.StargazersCount) // Show best repos first
            .Select(r => new PortfolioItem
            {
                Name = r.Name,
                Description = r.Description ?? "No description provided.",
                Language = r.Language ?? "Unknown",
                Stars = r.StargazersCount,
                LastUpdated = r.UpdatedAt.DateTime,
                Url = r.HtmlUrl
            })
            .ToList();
    }
}