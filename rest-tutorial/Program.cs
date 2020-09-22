﻿using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace rest_tutorial
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var repositories = await ProcessRepositories();
            
            foreach (var repo in repositories)
            {
                Console.WriteLine(repo.Name);
                Console.WriteLine($"\tDescription: {(repo.Description == null ? "*No Description Found*".ToUpper() : repo.Description)}");
                Console.WriteLine($"\tGitHub URL: {repo.GitHubHomeUrl}");
                Console.WriteLine($"\tHomepage: {repo.Homepage}");
                Console.WriteLine($"\tNumber of watchers: {repo.Watchers}");
                Console.WriteLine($"\tLast Push: {repo.LastPush}");
                Console.WriteLine();
            }
        }
        private static async Task<List<Repository>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            // var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

            return repositories;
        }
    }
}
