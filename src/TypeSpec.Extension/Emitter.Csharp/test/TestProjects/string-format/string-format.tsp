import "@typespec/rest";
import "@typespec/http";

@service(
    {
        title: "stringFormat",
        version: "2015-06-18"
    }
)
namespace stringFormat;

using TypeSpec.Http;

@route("/utcDateTime")
@doc("Path parameter is string with utcDateTime format")
@get
op getUtcDateTime(
    @path
    time: utcDateTime): void;
model Uri {
    @path
    @pattern("^[a-zA-Z0-9-]{3,24}$")
    @format("Uri")
    uri: string;
}
@route("/uri")
@doc("path paramter is string with uri format")
@get
op getUri(... Uri): void;
