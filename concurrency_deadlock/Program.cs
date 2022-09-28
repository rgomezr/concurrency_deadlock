const string GET_BASE_URL = "https://api.postcodes.io/postcodes/";

//Dictionary<bool, string> responseDict = await IsUKPostcodeValid("BT35 8HR");

//Console.WriteLine(String.Format("{0}: {1}", responseDict.Keys.FirstOrDefault(), responseDict.Values.FirstOrDefault()));

Thread thread_1 = new(IsUKPostcodeValid);

thread_1.Start("test"); // thread_1 starting task
Thread.Sleep(10000); //main thread sleeping - This will give enough main time for thread_1 and threadpool to complete their corresponding tasks.




 static async void IsUKPostcodeValid(object? ukPostcode) {
    Console.WriteLine("entering method");
    HttpClient httpClient = new();

    string uri = GET_BASE_URL + ukPostcode;
    Console.WriteLine("before await");
    var response = await httpClient.GetAsync(uri).ConfigureAwait(false);
    Console.WriteLine("after await");
    if (response.IsSuccessStatusCode)
    {
        string dataResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        Console.WriteLine("valid");
        //return new Dictionary<bool, string> { [true] = dataResponse };
    } else
    {
        Console.WriteLine("invalid");
        //return new Dictionary<bool, string> { [false] = "" };
    }
}