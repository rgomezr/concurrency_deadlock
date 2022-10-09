const string GET_BASE_URL = "https://api.postcodes.io/postcodes/";


Console.WriteLine("Hello World! Type an UK postcode to validate: ");
string? ukPostcodeToCheck = Console.ReadLine();


if (!String.IsNullOrEmpty(ukPostcodeToCheck))
{

    Dictionary<bool, string> responseDict = await IsUKPostcodeValid(ukPostcodeToCheck);

    Console.WriteLine(String.Format("{0}: {1}", responseDict.Keys.FirstOrDefault(), responseDict.Values.FirstOrDefault()));

}
else
{
    Console.WriteLine("No postcode was entered");
}


static async Task<Dictionary<bool, string>> IsUKPostcodeValid(string ukPostcode)
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