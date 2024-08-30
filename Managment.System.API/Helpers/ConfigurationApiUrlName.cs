using System.Text.RegularExpressions;

namespace Managment.System.API.Helpers;

public class ConfigurationApiUrlName : IOutboundParameterTransformer
{
    public string TransformOutbound(object value)
        => value == null ? null : Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower();
}
