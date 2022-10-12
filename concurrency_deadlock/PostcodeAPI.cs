using System;
namespace concurrency_deadlock
{
    public static class PostcodeAPI
    {
        /*CONSTS*/
        const string GET_BASE_URL = "https://api.postcodes.io/postcodes/";


        public static async Task<Dictionary<bool, string>> IsUKPostcodeValid(string ukPostcode)
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

