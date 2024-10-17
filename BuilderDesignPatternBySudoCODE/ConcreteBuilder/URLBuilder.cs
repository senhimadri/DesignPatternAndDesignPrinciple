using BuilderDesignPatternBySudoCODE.Builder;
using BuilderDesignPatternBySudoCODE.Product;

namespace BuilderDesignPatternBySudoCODE.ConcreteBuilder;

public class URLBuilder : IURLBuilder
{
    private URL _url;

	public URLBuilder()
	{
        _url = new URL();
    }

    public void SetProtocol(string protocol)
    {
        _url.Protocol = protocol;
    }
    public void SetHost(string host)
    {
        _url.Host = host;
    }

    public void SetPath(string path)
    {
        _url.Path = path;
    }

    public void SetPort(int port)
    {
        _url.Port = port;
    }
    public void SetQueryParams(Dictionary<string, string> queryParams)
    {
        _url.QueryParams = queryParams;
    }

    public URL GetURL()
    {
        URL result = _url;
        _url = new URL();
        return result;
    }


}
