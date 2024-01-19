import "@typespec/http";

using TypeSpec.Http;

alias Uuid4Pattern = "^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-4[0-9a-fA-F]{3}-[890abAB]{1}[0-9a-fA-F]{3}-[0-9a-fA-F]{12}$";

@pattern(Uuid4Pattern)
@format("uuid")
scalar Uuid4 extends string;

model ErrorDetail {
  path?: string;
  location?: string;
  target?: string;
  message?: string;
  errorCode?: string;
  code?: string;
}

model ErrorPayload {
  error: {
    code: string;
    message: string;
    details?: ErrorDetail[];
  };
}

model ApiNoContentResponse {
  @statusCode
  statusCode: 204;
}

@error
model ApiErrorResponse {
  @body
  body: ErrorPayload;
}

model ApiBadRequestResponse is ApiErrorResponse {
  @statusCode
  statusCode: 400;
}

model ApiUnauthorizedResponse is ApiErrorResponse {
  @statusCode
  statusCode: 401;
}

model ApiNotFoundResponse is ApiErrorResponse {
  @statusCode
  statusCode: 404;
}

model ApiForbiddenResponse is ApiErrorResponse {
  @statusCode
  statusCode: 403;
}

model ApiServerErrorResponse is ApiErrorResponse {
  @statusCode
  statusCode: 500;
}
