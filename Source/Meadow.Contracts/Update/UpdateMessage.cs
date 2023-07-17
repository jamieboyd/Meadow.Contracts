namespace Meadow.Update
{
    /// <summary>
    /// Represents an update message.
    /// </summary>
    public record UpdateMessage : UpdateInfo
    {
        /// <summary>
        /// Gets or sets the ID of the MPak.
        /// </summary>
        public string MpakID
        {
            get => ID;
            set => ID = value;
        }

        /// <summary>
        /// Gets or sets the download URL of the MPak.
        /// </summary>
        public string MpakDownloadUrl { get; set; } = default!;

        /// <summary>
        /// Gets or sets the target devices for the update.
        /// </summary>
        public string[] TargetDevices { get; set; } = default!;
    }
}