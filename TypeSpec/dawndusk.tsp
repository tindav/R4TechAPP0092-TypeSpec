using OpenAPI;
using TypeSpec.Http;

namespace Ready4Tech;

enum DawnDuskType {
  Sunrise,
  Sunset,
  Zenith,
  All,
}

@doc("Input request for DawnDusk Calculation")
model DawnDuskCalculationInputRequest {
  @doc("Coordinate of the location")
  coordinates: Coordinate;

  @doc("Date for the DawnDusk calculation")
  date: utcDateTime;
}

@doc("Output response for DawnDusk Calculation")
model DawnDuskCalculationOutputResponse {
  calculationId: Uuid4;

  @doc("Sunrise time")
  sunrise?: utcDateTime;

  @doc("Sunset time")
  sunset?: utcDateTime;

  @doc("Zenith time")
  zenith?: utcDateTime;
}

@route("/api/dawndusk")
interface DawnDuskApi {
  @post
  @operationId("DawnDuskCalculation-v1")
  @summary("DawnDusk Calculation")
  getDawnDusk(
    @path("calculationType")
    calculationType: DawnDuskType,

    ...DawnDuskCalculationInputRequest,
  ):
    | DawnDuskCalculationOutputResponse
    | ApiBadRequestResponse
    | ApiServerErrorResponse
    | ApiUnauthorizedResponse;
}
