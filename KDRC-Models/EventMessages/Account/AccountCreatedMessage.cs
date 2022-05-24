namespace KDRC_Models.EventMessages.Account;

public class AccountCreatedMessage
{
    public string AccountId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}