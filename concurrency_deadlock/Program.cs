const string GET_BASE_URL = "https://api.postcodes.io/postcodes/";

Dictionary<bool, string> responseDict = await IsUKPostcodeValid("BT35 8HR");

Console.WriteLine(String.Format("{0}: {1}", responseDict.Keys.FirstOrDefault(), responseDict.Values.FirstOrDefault()));



async Task<Dictionary<bool,string>> IsUKPostcodeValid(string ukPostcode) {

    HttpClient httpClient = new HttpClient();

    string uri = GET_BASE_URL + ukPostcode;

    var response = await httpClient.GetAsync(uri);
    if (response.IsSuccessStatusCode)
    {
        string dataResponse = await response.Content.ReadAsStringAsync();
        return new Dictionary<bool, string> { [true] = dataResponse };
    } else
    {
        return new Dictionary<bool, string> { [false] = "" };
    }
}