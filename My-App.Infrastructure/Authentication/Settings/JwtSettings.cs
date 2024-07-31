namespace My_App.Infrastructure.Authentication.Settings;

public sealed class JwtSettings
{
    public const string SettingsKey = "Jwt";

    public string Issuer { get; set; } = default!;

    public string Audience { get; set; } = default!;

    public string SecurityKey { get; set; } = default!;

    public int TokenExpirationInMinutes { get; set; } = default!;
}
