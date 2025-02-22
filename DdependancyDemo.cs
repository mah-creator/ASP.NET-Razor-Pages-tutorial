// This interface defines how a service dependency constructs a brief difinition about itself
public interface IDependency
{
    // this method specified the definition of a service implementation
    public string ServiceDefinition();

    // this method formats the final dependency message
    public string DependencyDefinition()
    {
        return $"This message is from a service dependency implementing the IDependency interface, the service-specific message is \"{ServiceDefinition()}\"";
    }
}

// The following class implements an Email sender service dependency
public class DemoService : IDependency
{
    private const string serviceDefinition = "This an Demo service";

    public string ServiceDefinition()
    {
        return serviceDefinition;
    }
}