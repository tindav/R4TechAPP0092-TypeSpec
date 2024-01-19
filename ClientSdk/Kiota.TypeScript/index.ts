import { AnonymousAuthenticationProvider } from "@microsoft/kiota-abstractions";
import { FetchRequestAdapter } from "@microsoft/kiota-http-fetchlibrary";
import { KiotaClient } from "./client/kiotaClient";
import { DawnDuskCalculationInputRequest } from "./client/models";

// API requires no authentication, so use the anonymous
// authentication provider
const authProvider = new AnonymousAuthenticationProvider();
// Create request adapter using the fetch-based implementation
const adapter = new FetchRequestAdapter(authProvider);
adapter.baseUrl = "https://localhost:5001";

// Create the API client
const client = new KiotaClient(adapter);

async function main(): Promise<void> {
  try {
    process.env["NODE_TLS_REJECT_UNAUTHORIZED"] = "0";

    const coordinates = await client.v1.api.geolocation
      .byCity("Issy-les-moulineaux")
      .get();
    console.log(
      `Retrieved Lat:${coordinates?.latitude}, Long:${coordinates?.longitude} as coordinates for Issy-les-Moulineaux"`
    );

    const body: DawnDuskCalculationInputRequest = {
      coordinates: coordinates,
      date: new Date(),
    };

    const dawnDusk = await client.v1.api.dawndusk
      .byCalculationType("all")
      .post(body);
    console.log(
      `At provided coordinates, Sunrise will be: ${dawnDusk?.sunrise?.toISOString()}, Sunset will be: ${dawnDusk?.sunset?.toISOString()} and Zenith will be: ${dawnDusk?.zenith?.toISOString()}`
    );
  } catch (err) {
    console.log(err);
  }
}

main();
