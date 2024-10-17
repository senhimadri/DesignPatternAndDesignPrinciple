using BuilderDesignPatternBySudoCODE.Builder;

namespace BuilderDesignPatternBySudoCODE.Director;

internal class URLDirector
{
    private IURLBuilder _builder;

	public URLDirector(IURLBuilder builder) => _builder = builder;

    public void BuildSimpleURL()
    {
        _builder.SetProtocol("http");
        _builder.SetHost("example.com");
        _builder.SetPort(80);
        _builder.SetPath("index.html");
    }
    public void BuildComplexURL()
    {
        _builder.SetProtocol("https");
        _builder.SetHost("example.com");
        _builder.SetPort(443);
        _builder.SetPath("search");
        _builder.SetQueryParams(new Dictionary<string, string>
        {
            { "q", "builder pattern" },
            { "lang", "en" }
        });
    }
}
