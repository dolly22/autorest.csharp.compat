import "@typespec/rest";
import "@typespec/http";
import "@azure-tools/typespec-client-generator-core";

@service(
    {
        title: "client",
        version: "2015-06-18"
    }
)
@server(
    "{clientServiceUrl}",
    "Client Service",
    {
        clientServiceUrl: string,
    }
)
namespace Azure.ClientService;

using TypeSpec.Http;
using Azure.ClientGenerator.Core;

enum Clients { ServiceClient };

@client({name: "MyServiceClient"})
namespace Alpha {
    #suppress "@azure-tools/typespec-azure-core/use-standard-operations" "This is test code."
    @route("/Alpha")
    op one(): string;
}

@client({name: "TeamServiceClient"})
namespace Beta {
    #suppress "@azure-tools/typespec-azure-core/use-standard-operations" "This is test code."
    @route("/Beta")
    op two(): string;

    //namespace SubBeta {
    //#suppress "@azure-tools/typespec-azure-core/use-standard-operations" "This is test code."
      //  @route("/SubBeta")
        //op three(): string;
    //}
}

@client({name:"ServiceClient3"})
namespace Gamma {
    #suppress "@azure-tools/typespec-azure-core/use-standard-operations" "This is test code."
    @route("/Gamma")
    op four(): string;

    #suppress "@azure-tools/typespec-azure-core/use-standard-operations" "This is test code."
    @route("/Gamma")
    @put op five(): string;
}
