import "@typespec/rest";
import "@typespec/http";
import "./decorators.js";

using TypeSpec.Http;

@service(
    {
        title: "Pet Store Service",
        version: "2021-03-25"
    }
)
@doc("This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.")
@server(
    "{petStoreUrl}",
    "Endpoint Service",
    {
        petStoreUrl: string,
    }
)
namespace PetStore;

// Model types
model Pet {
  name: string;
  tag?: string;

  @minValue(0)
  @maxValue(20)
  age: int32;
}

model Toy {
  id: int64;
  petId: int64;
  name: string;
}

@doc("Error")
@error
model Error {
  code: int32;
  message: string;
}

@doc("Not modified")
model NotModified<T> {
  @statusCode _: 304;
  @body body: T;
}

@friendlyName("{name}ListResults", T)
model ResponsePage<T> {
  items: T[];
  nextLink?: string;
}

model PetId {
  @path
  @doc("The id of pet.")
  petId: int32;
}

@doc("Manage your pets. You can delete or get the Pet from pet store.")
@summary("Manage your pets.")
@route("/pets")
namespace Pets {
  @doc("Delete a pet.")
  @summary("delete.")
  @delete
  op delete(...PetId): {
    ...Response<200>;
  } | Error;

  // @fancyDoc("List pets.")
  // op list(@query nextLink?: string): OkResponse<ResponsePage<Pet>> | Error;

  @doc("Returns a pet. Supports eTags.")
  op read(...PetId): Pet | NotModified<Pet> | Error;

  @post op create(@body pet: Pet): Pet | Error;
}

@route("/pets/{petId}/toys")
namespace ListPetToysResponse {
  op list(@path petId: string, @query nameFilter: string): ResponsePage<Toy> | Error;
}
