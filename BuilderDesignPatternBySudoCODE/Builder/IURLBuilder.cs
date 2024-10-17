using BuilderDesignPatternBySudoCODE.Product;

namespace BuilderDesignPatternBySudoCODE.Builder;

internal interface IURLBuilder
{
    void SetProtocol(string protocol);
    void SetHost(string host);
    void SetPort(int port);
    void SetPath(string path);
    void SetQueryParams(Dictionary<string,string> queryParams);
    URL GetURL();
}
