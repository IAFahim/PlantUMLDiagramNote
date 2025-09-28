namespace _1SequenceDiagram._1._1BasicExamples;

/// <summary>
/// Example 4: Weak Interaction Pattern - Event-Based Response
/// </summary>
public class EventDrivenAuthService
{
    public event EventHandler<AuthenticationEventArgs> AuthenticationCompleted;
    
    public void Authenticate(string username, string password)
    {
        bool success = username == "test" && password == "test123";
        AuthenticationCompleted?.Invoke(this, new AuthenticationEventArgs(success));
    }
}

public class AuthenticationEventArgs(bool success) : EventArgs
{
    public bool Success { get; } = success;
}