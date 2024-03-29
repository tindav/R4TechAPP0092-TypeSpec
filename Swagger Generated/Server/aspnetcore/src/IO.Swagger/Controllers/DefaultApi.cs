/*
 * Ready4Tech API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using IO.Swagger.Attributes;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace IO.Swagger.Controllers;

/// <summary>
/// </summary>
[ApiController]
public class DefaultApiController : ControllerBase
{
    /// <summary>
    ///     DawnDusk Calculation
    /// </summary>
    /// <param name="body"></param>
    /// <param name="calculationType"></param>
    /// <response code="200">The request has succeeded.</response>
    /// <response code="400">The server could not understand the request due to invalid syntax.</response>
    /// <response code="401">Access is unauthorized.</response>
    /// <response code="500">Server error</response>
    [HttpPost]
    [Route("/v1/api/dawndusk/{calculationType}")]
    [ValidateModelState]
    [SwaggerOperation("DawnDuskCalculationV1")]
    [SwaggerResponse(200, type: typeof(DawnDuskCalculationOutputResponse), description: "The request has succeeded.")]
    [SwaggerResponse(400, type: typeof(ErrorPayload),
        description: "The server could not understand the request due to invalid syntax.")]
    [SwaggerResponse(401, type: typeof(ErrorPayload), description: "Access is unauthorized.")]
    [SwaggerResponse(500, type: typeof(ErrorPayload), description: "Server error")]
    public virtual IActionResult DawnDuskCalculationV1([FromBody] DawnDuskCalculationInputRequest body,
        [FromRoute] [Required] string calculationType)
    {
        //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200, default(DawnDuskCalculationOutputResponse));

        //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(400, default(ErrorPayload));

        //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(401, default(ErrorPayload));

        //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(500, default(ErrorPayload));
        var exampleJson = "{\n  \"Sunset\" : \"" +
                          body.Date!.Value.Date.AddHours(16 + Random.Shared.NextDouble() * 3).ToString("O") +
                          "\",\n  \"calculationId\" : \"" +
                          Guid.NewGuid() +
                          "\",\n  \"Sunrise\" : \"" +
                          body.Date!.Value.Date.AddHours(6 + Random.Shared.NextDouble() * 3).ToString("O") +
                          "\",\n  \"Zenith\" : \"" +
                          body.Date!.Value.Date.AddHours(11 + Random.Shared.NextDouble() * 2).ToString("O")
                          + "\"\n}";

        var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DawnDuskCalculationOutputResponse>(exampleJson)
            : default; //TODO: Change the data returned
        return new ObjectResult(example);
    }

    /// <summary>
    ///     Get geolocation from a city name
    /// </summary>
    /// <param name="city"></param>
    /// <response code="200">The request has succeeded.</response>
    /// <response code="400">The server could not understand the request due to invalid syntax.</response>
    /// <response code="401">Access is unauthorized.</response>
    /// <response code="404">The server cannot find the requested resource.</response>
    /// <response code="500">Server error</response>
    [HttpGet]
    [Route("/v1/api/geolocation/{city}")]
    [ValidateModelState]
    [SwaggerOperation("GetGeolocation")]
    [SwaggerResponse(200, type: typeof(Coordinate), description: "The request has succeeded.")]
    [SwaggerResponse(400, type: typeof(ErrorPayload),
        description: "The server could not understand the request due to invalid syntax.")]
    [SwaggerResponse(401, type: typeof(ErrorPayload), description: "Access is unauthorized.")]
    [SwaggerResponse(404, type: typeof(ErrorPayload), description: "The server cannot find the requested resource.")]
    [SwaggerResponse(500, type: typeof(ErrorPayload), description: "Server error")]
    public virtual IActionResult GetGeolocation([FromRoute] [Required] string city)
    {
        //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200, default(Coordinate));

        //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(400, default(ErrorPayload));

        //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(401, default(ErrorPayload));

        //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(404, default(ErrorPayload));

        //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(500, default(ErrorPayload));
        var nfi = new NumberFormatInfo { NumberDecimalSeparator = "." };

        var exampleJson = "{\n  \"latitude\" : " +
                          (Random.Shared.Next(-90, 90) + Random.Shared.NextDouble()).ToString(nfi) +
                          ",\n  \"longitude\" : " +
                          (Random.Shared.Next(-180, 180) + Random.Shared.NextDouble()).ToString(nfi) + "\n}";

        var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Coordinate>(exampleJson)
            : default; //TODO: Change the data returned
        return new ObjectResult(example);
    }
}