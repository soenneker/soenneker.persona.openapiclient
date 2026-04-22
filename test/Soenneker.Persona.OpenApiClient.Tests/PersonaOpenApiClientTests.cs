using Soenneker.Tests.HostedUnit;

namespace Soenneker.Persona.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PersonaOpenApiClientTests : HostedUnitTest
{
    public PersonaOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
