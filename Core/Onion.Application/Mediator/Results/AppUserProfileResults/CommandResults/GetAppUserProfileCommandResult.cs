namespace Onion.Application.Mediator.Results.AppUserProfileResults.CommandResults
{
    public class GetAppUserProfileCommandResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}
