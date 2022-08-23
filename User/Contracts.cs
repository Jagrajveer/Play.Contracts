namespace Play.Contracts.User;

public record UserCreated(Guid UserId, string FirstName, string LastName, string UserName, string Email);

public record UserUpdated(Guid UserId, string FirstName, string LastName, string UserName, string Email);

public record UserDeleted(Guid UserId);
