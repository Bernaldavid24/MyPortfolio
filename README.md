# Cloud-Native Live Portfolio Dashboard

A modern, responsive Single Page Application (SPA) built entirely in **C#** using **Blazor WebAssembly**. This project serves as a live portfolio that dynamically fetches project data from the **GitHub REST API** and is deployed via a fully automated CI/CD pipeline to **Azure Static Web Apps**.

**Live Demo:** [INSERT YOUR LIVE URL HERE]

---

## Architecture & Features

This is not a static HTML site. It is a full .NET 8 client-side application running in the browser via WebAssembly.

* ** Blazor WebAssembly (WASM):** Client-side C# execution (no JavaScript frameworks required).
* ** GitHub API Integration:** A custom `GitHubService` uses `HttpClient` to fetch repositories, stars, and descriptions in real-time.
* ** Azure Static Web Apps:** Serverless hosting with global distribution.
* ** CI/CD Pipeline:** GitHub Actions automatically build and deploy the application on every commit to the `main` branch.
* ** Responsive UI:** Built with **Bootstrap 5** and custom CSS for a mobile-first experience.

## Tech Stack

| Component | Technology |
| :--- | :--- |
| **Framework** | .NET 8 (Blazor WebAssembly) |
| **Language** | C# |
| **Styling** | Bootstrap 5, Bootstrap Icons |
| **Data Source** | GitHub REST API (via Octokit or HttpClient) |
| **Hosting** | Azure Static Web Apps (Free Tier) |
| **DevOps** | GitHub Actions (CI/CD) |

---

## Project Structure

```text
MyPortfolio/
├── Pages/
│   ├── Home.razor        # Main dashboard (fetches GitHub data)
│   ├── Resume.razor      # Digital resume & PDF download
│   ├── Skills.razor      # Visual progress bars of tech stack
│   └── Contact.razor     # Formspree integration for emails
├── Services/
│   └── GitHubService.cs  # Logic to consume GitHub API
├── Models/
│   └── PortfolioItem.cs  # Data model for repositories
├── wwwroot/
│   ├── images/           # Profile picture and assets
│   ├── resume.pdf        # Downloadable resume file
│   └── index.html        # SPA entry point
└── Program.cs            # Dependency Injection (DI) setup



Getting Started Locally
Prerequisites
.NET 8 SDK

Visual Studio 2022 OR VS Code

Installation
Clone the repository

Bash

git clone [https://github.com/YOUR_USERNAME/MyPortfolio.git](https://github.com/YOUR_USERNAME/MyPortfolio.git)
cd MyPortfolio
Restore Dependencies

Bash

dotnet restore
Run the Application

Bash

dotnet watch
The site will launch at http://localhost:5209 (or similar port).

Deployment (CI/CD)
This project is configured for continuous deployment to Azure.

Push to GitHub: Any commit to the main branch triggers the GitHub Action defined in .github/workflows/.

Build Process:

Sets up .NET 8

Publishes the Blazor WASM app (dotnet publish -c Release)

Optimizes assets

Deploy:

Uploads the wwwroot build artifacts to Azure Static Web Apps.

Contact
David Bernal Software Engineer | .NET & Azure Specialist LinkedIn | Email via Form
