using WebGate.Dynamics.Connector;
namespace WebGate.Dynamics.Util;
public class DynamicsConnectorBuilder
{
    private static readonly string DEFAULT_APIPATH = "/api/data/v9.2/";
    public string Resource { get; set; }
    public string ApplicationId { get; set; }
    public string Tenant { get; set; }
    public string ApplicationSecret { get; set; }

    public string ApiPath {set;get;}

    public DynamicsConnectorBuilder() {
        ApiPath = DEFAULT_APIPATH;
    }

    /// <summary>
    /// Set the Url to your Dynamics Instance
    /// </summary>
    /// <param name="resource">e.g. https://yourInstanceName.crm.dynamics.com</param>
    public DynamicsConnectorBuilder WithResource(string resource)
    {
        Resource = resource;
        return this;
    }
    /// <summary>
    /// Set the Dynamics Application id
    /// </summary>
    /// <param name="applicationId">e.g.: aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee</param>
    public DynamicsConnectorBuilder WithApplicationId(string applicationId)
    {
        ApplicationId = applicationId;
        return this;
    }

    /// <summary>
    /// Set the Login Page for your Dynamics
    /// </summary>
    /// <param name="tenant">e.g.https://login.windows.net/yourdomain.com </param>
    public DynamicsConnectorBuilder WithTenant(string tenant)
    {
        Tenant = tenant;
        return this;
    }

    /// <summary>
    /// Set the App Secret
    /// </summary>
    /// <param name="appSecret"></param>
    /// <returns></returns>
    public DynamicsConnectorBuilder WithApplicationSecret(string appSecret)
    {
        ApplicationSecret = appSecret;
        return this;
    }
    /// <summary>
    /// Sets an alternate API Path. Default is "/api/data/v9.2/"
    /// </summary>
    /// <param name="apiPath"></param>
    /// <returns></returns>
    public DynamicsConnectorBuilder WithApiPath(string apiPath)
    {
        ApiPath = apiPath;
        return this;
    }
    /// <summary>
    /// Finaly build the Dynamics Connector
    /// </summary>
    /// <returns></returns>
    public DynamicsConnector Build()
    {
        return new DynamicsConnector(this);
    }
}