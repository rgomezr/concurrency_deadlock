using concurrency_deadlock;

Console.WriteLine("Hello World! Type an UK postcode to validate: ");

string? ukPostcodeToCheck = Console.ReadLine();


if (!String.IsNullOrEmpty(ukPostcodeToCheck))
{
    PostcodeAPI apiInstance = new();
    Dictionary<bool, string> responseDict = await apiInstance.IsUKPostcodeValid(ukPostcodeToCheck);

    Console.WriteLine(String.Format("Valid: {0}: {1}", responseDict.Keys.FirstOrDefault(), responseDict.Values.FirstOrDefault()));

}
else
{
    Console.WriteLine("No postcode was entered");
}