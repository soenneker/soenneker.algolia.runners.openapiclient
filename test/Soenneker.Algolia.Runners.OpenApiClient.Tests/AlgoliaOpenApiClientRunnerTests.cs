using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Algolia.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class AlgoliaOpenApiClientRunnerTests : FixturedUnitTest
{
    public AlgoliaOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
