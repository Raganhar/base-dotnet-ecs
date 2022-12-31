using DockerWebAPI.Pulumi;
using DockerWebAPI.Pulumi.InfrastructureTemplates;
using NUnit.Framework;

namespace DockerWebAPITests;

public class SmokeTest
{
    [Test]
    public void Smoke([Values]CpuSize cpus)
    {
        Console.WriteLine(cpus.ToCpuUnits());
    }
    
    [Test]
    [Ignore("just checking stuff")]
    public void Sasdmoke([Values]CpuSize cpus)
    {
        new auctionsdk.Client(null, null).GetWeatherForecastAsync(null);
    }
    
    
}