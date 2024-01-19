using OpenAPI;
using TypeSpec.Http;

namespace Ready4Tech;

model Coordinate {
  @minValue(-90)
  @maxValue(90)
  latitude: float64;

  @minValue(-180)
  @maxValue(180)
  longitude: float64;
}

model SpatialCoordinate extends Coordinate {
  altitude: float64;
}

@route("/api/geolocation")
interface geolocationApi {
  @get
  @operationId("getGeolocation")
  @summary("Get geolocation from a city name")
  getCoordinates(
    @path("city")
    city: string,
  ):
    | Coordinate
    | ApiBadRequestResponse
    | ApiNotFoundResponse
    | ApiServerErrorResponse
    | ApiUnauthorizedResponse;
}
