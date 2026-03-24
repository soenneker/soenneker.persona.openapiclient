using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Persona.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PersonaOpenApiClientTests : FixturedUnitTest
{
    public PersonaOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
