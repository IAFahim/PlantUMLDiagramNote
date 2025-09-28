namespace _1SequenceDiagram._1._1BasicExamples;

/// <summary>
/// Example 3: Strong Interaction Pattern - Direct Method Calls
/// </summary>
public class AuthenticationService
{
    private UserRepository userRepository;
    
    public bool Authenticate(string username, string password)
    {
        return userRepository.ValidateCredentials(username, password);
    }
}

public class UserRepository
{
    public bool ValidateCredentials(string username, string password)
    {
        throw new NotImplementedException();
    }
}