using UnityEngine;

public class GameSettings
{
    public static bool enableShadow;
    public static float globalGravity;
    public static int difficalty;

    private static string apiKey = "123456";

    public static string GetApiKey()
    {
        return apiKey;
    }
}
