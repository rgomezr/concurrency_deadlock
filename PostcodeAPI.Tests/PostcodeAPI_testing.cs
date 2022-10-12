namespace PostcodeAPI.Tests
{
    public class PostcodeAPI_testing
    {

        [Theory]
        [InlineData("CT5 3NL")]
        [InlineData("KY8 2FE")]
        public async void IsAPIReacheable_ReturnTrue(string postcode)
        {
            bool response = await concurrency_deadlock.PostcodeAPI.IsPostcodeAPIReachable(postcode);
            Assert.True(response, "API should be reachable");
        }
    }
}

