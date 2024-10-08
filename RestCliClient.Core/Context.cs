using RestCliClient.Core.Consts;
using RestCliClient.Core.Requests;

namespace RestCliClient.Core;

public class Context
{
    public Scopes Scope { get; set; } = Scopes.Global;
    public Response? LastRequest { get; set; } = null;
    public RequestBuilder? RequestBuilder { get; set; }
    public Dictionary<string, string> Variables { get; set; } = new Dictionary<string, string>();
    public Dictionary<string, string> CommonNames { get; set; } = new Dictionary<string, string>();
}