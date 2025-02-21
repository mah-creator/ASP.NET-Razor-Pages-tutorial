// This interface defines how a service dependancy constructs a brief difinition about itself
public interface IDependancy
{
    // this method specified the definition of a service implementation
    public string ServiceDefinition();

    // this method formats the final dependancy message
    public string DependancyDefinition()
    {
        return $"This is a dependancy of an app, the service-specific message is \"{ServiceDefinition()}\"";
    }
}

// The following class implements an Email sender service dependancy
public class EmailSenderService : IDependancy
{
    private const string serviceDefinition = "This an Email sending service";

    public string ServiceDefinition()
    {
        return serviceDefinition;
    }
}