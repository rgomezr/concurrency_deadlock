namespace concurrency_deadlock
{
    public class PostcodeAPI
    {
        /*CONSTS*/
        /// <summary>
        /// Used as base URL for URI
        /// </summary>
        private const string GET_BASE_URL = "https://api.postcodes.io/postcodes/";

        /// <summary>
        /// Default UK postcode used for testing
        /// </summary>
        private const string DEFAULT_POSTCODE = "CT5 3NL";

        /// <summary>
        /// Used to check if GET_BASE_URL has a success status code
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> IsPostcodeAPIReachable(string postcode)
        {
            HttpClient httpClient = new();

            string uri = GET_BASE_URL + postcode;

            var response = await httpClient.GetAsync(uri);

            return response.IsSuccessStatusCode;

        }
        /// <summary>
        /// Checks if parametrised <paramref name="ukPostcode"/>
        /// is valid or not. If valid, returns additional info also.
        /// </summary>
        /// <param name="ukPostcode"></param>
        /// <returns></returns>
        public async Task<Dictionary<bool, string>> IsUKPostcodeValid(string ukPostcode)
        {

            HttpClient httpClient = new();

            string uri = GET_BASE_URL + ukPostcode;

            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string dataResponse = await response.Content.ReadAsStringAsync();
                return new Dictionary<bool, string> { [true] = dataResponse };
            }
            else
            {
                return new Dictionary<bool, string> { [false] = "" };
            }
        }
    }
}

