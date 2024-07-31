namespace My_App.Infrastructure.Emails.Settings;

/// <summary>
/// Represents the mail settings.
/// </summary>
internal sealed class MailSettings
{
    public const string SettingsKey = "Mail";

    /// <summary>
    /// Gets or Sets the email sender display name.
    /// </summary>
    public string SenderDisplayName { get; set; } = default!;

    /// <summary>
    /// Gets or Sets the email sender display name.
    /// </summary>
    public string SenderEmail { get; set; } = default!;

    /// <summary>
    /// Gets or Sets the email sender.
    /// </summary>
    public string SmtpPassword { get; set; } = default!;

    /// <summary>
    /// Gets or Sets the SMTP server.
    /// </summary>
    public string SmtpServer { get; set; } = default!;

    /// <summary>
    /// Gets or Sets the SMTP port.
    /// </summary>
    public int SmtpPort { get; set; } = default!;
}
