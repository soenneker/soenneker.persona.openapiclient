[![](https://img.shields.io/nuget/v/soenneker.persona.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.persona.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.persona.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.persona.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.persona.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.persona.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.persona.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.persona.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Persona.OpenApiClient

Typed request builders and models for Persona identity verification, inquiries, accounts, reports, cases, and webhooks.

## Installation

```bash
dotnet add package Soenneker.Persona.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Persona.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);
httpClient.DefaultRequestHeaders.Add("Persona-Version", "2025-12-08");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new PersonaOpenApiClient(adapter);
var accounts = await client.Accounts.GetAsync(cancellationToken: cancellationToken);
```

The client defaults to `https://api.withpersona.com/api/v1`. The version above is the newest value supported by the packaged schema; pin the header to the version your integration expects.

For configuration-based credentials, version pinning, and managed client reuse, use [`Soenneker.Persona.OpenApiClientUtil`](https://github.com/soenneker/soenneker.persona.openapiclientutil).
