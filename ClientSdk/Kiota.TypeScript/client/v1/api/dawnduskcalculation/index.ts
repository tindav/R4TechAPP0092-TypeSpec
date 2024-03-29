/* tslint:disable */
/* eslint-disable */
// Generated by Microsoft Kiota
import { WithCalculationTypeItemRequestBuilder } from './item/';
import { BaseRequestBuilder, getPathParameters, type RequestAdapter } from '@microsoft/kiota-abstractions';

/**
 * Builds and executes requests for operations under /v1/api/dawnduskcalculation
 */
export class DawnduskcalculationRequestBuilder extends BaseRequestBuilder<DawnduskcalculationRequestBuilder> {
    /**
     * Gets an item from the ApiSdk.v1.api.dawnduskcalculation.item collection
     * @param calculationType Unique identifier of the item
     * @returns a WithCalculationTypeItemRequestBuilder
     */
    public byCalculationType(calculationType: string) : WithCalculationTypeItemRequestBuilder {
        if(!calculationType) throw new Error("calculationType cannot be undefined");
        const urlTplParams = getPathParameters(this.pathParameters);
        urlTplParams["calculationType"] = calculationType
        return new WithCalculationTypeItemRequestBuilder(urlTplParams, this.requestAdapter);
    }
    /**
     * Instantiates a new DawnduskcalculationRequestBuilder and sets the default values.
     * @param pathParameters The raw url or the Url template parameters for the request.
     * @param requestAdapter The request adapter to use to execute the requests.
     */
    public constructor(pathParameters: Record<string, unknown> | string | undefined, requestAdapter: RequestAdapter) {
        super(pathParameters, requestAdapter, "{+baseurl}/v1/api/dawnduskcalculation", (x, y) => new DawnduskcalculationRequestBuilder(x, y));
    }
}
/* tslint:enable */
/* eslint-enable */
