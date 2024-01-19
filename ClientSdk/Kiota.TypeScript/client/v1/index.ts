/* tslint:disable */
/* eslint-disable */
// Generated by Microsoft Kiota
import { ApiRequestBuilder } from './api/';
import { BaseRequestBuilder, type RequestAdapter } from '@microsoft/kiota-abstractions';

/**
 * Builds and executes requests for operations under /v1
 */
export class V1RequestBuilder extends BaseRequestBuilder<V1RequestBuilder> {
    /**
     * The api property
     */
    public get api(): ApiRequestBuilder {
        return new ApiRequestBuilder(this.pathParameters, this.requestAdapter);
    }
    /**
     * Instantiates a new V1RequestBuilder and sets the default values.
     * @param pathParameters The raw url or the Url template parameters for the request.
     * @param requestAdapter The request adapter to use to execute the requests.
     */
    public constructor(pathParameters: Record<string, unknown> | string | undefined, requestAdapter: RequestAdapter) {
        super(pathParameters, requestAdapter, "{+baseurl}/v1", (x, y) => new V1RequestBuilder(x, y));
    }
}
/* tslint:enable */
/* eslint-enable */
