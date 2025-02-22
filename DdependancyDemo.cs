// This is a demo interface that defines a brief definition about a service
public interface IDependency
{
    // this method specifies the definition of a service implementation
    public string ServiceDefinition();

    // this method formats the final dependency message
    public string DependencyDefinition()
    {
        return $"This message is from a service dependency implementing the IDependency interface, the service-specific message is \"{ServiceDefinition()}\"";
    }
}

// The following class implements a demo service dependency
public class DemoService : IDependency
{
    private const string serviceDefinition = "This a Demo service";
    public string ServiceDefinition()
    {
        return serviceDefinition;
    }
}