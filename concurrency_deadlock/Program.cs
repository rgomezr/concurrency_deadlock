using concurrency_deadlock;

Console.WriteLine("Hello World! Type an UK postcode to validate: ");
string? ukPostcodeToCheck = Console.ReadLine();


if (!String.IsNullOrEmpty(ukPostcodeToCheck))
{

    Dictionary<bool, string> responseDict = await PostcodeAPI.IsUKPostcodeValid(ukPostcodeToCheck);

    Console.WriteLine(String.Format("{0}: {1}", responseDict.Keys.FirstOrDefault(), responseDict.Values.FirstOrDefault()));

}
else
{
    Console.WriteLine("No postcode was entered");
}