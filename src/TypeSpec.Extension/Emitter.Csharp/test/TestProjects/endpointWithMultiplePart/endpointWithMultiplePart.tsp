import "@typespec/rest";
import "@typespec/http";

@service(
    {
        title: "endpoint",
        version: "2015-06-18"
    }
)
@server(
    "{endpointServiceUrl}/id/{id}",
    "Endpoint Service",
    {
        endpointServiceUrl: string,
        id:string
    }
)
namespace endpoint;

using TypeSpec.Http;

@route("/endpoint")
@doc("Path parameter is string with format")
@get
op genEndPoint(@path action: string): void;