public static class UserSession
{
    public static int Id { get; private set; }
    public static string Username { get; private set; }

    public static void StartSession(int id, string username)
    {
        Id = id;
        Username = username;
    }

    public static void EndSession()
    {
        Id = 0;
        Username = null;

    }
}