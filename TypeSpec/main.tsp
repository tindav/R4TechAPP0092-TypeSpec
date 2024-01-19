import "@typespec/http";
import "@typespec/openapi";
import "./common.tsp";
import "./dawndusk.tsp";
import "./geolocation.tsp";

using TypeSpec.Http;
using OpenAPI;

/*Common configuration for all v1 APIs*/
@route("v1")
@service({
  title: "Ready4Tech API",
  version: "v1",
})
@info({
  license: {
    name: "MIT",
  },
})
@server("https://localhost:5001", "Local Dev Server")
namespace Ready4Tech;
