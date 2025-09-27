namespace _1SequenceDiagram._1._1BasicExamples;

/// <summary>
/// Example 1: Solid Arrow (->) - Synchronous Authentication
/// </summary>
public class AuthenticationService
{
    public bool Authenticate(AuthenticateRequestData authenticateRequestData)
    {
        throw new NotImplementedException();
    }
}
public record AuthenticateRequestData(string Username, string Password);