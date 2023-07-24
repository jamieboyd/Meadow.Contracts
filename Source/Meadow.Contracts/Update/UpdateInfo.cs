using System;
using System.ComponentModel;

namespace Meadow.Update
{
    /// <summary>
    /// Represents information about a specific Meadow Update package
    /// </summary>
    public record UpdateInfo : INotifyPropertyChanged
    {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private bool _applied;
        private bool _retrieved;

        /// <summary>
        /// Date and time when the update was published
        /// </summary>
        public DateTime PublishedOn { get; set; }
        /// <summary>
        /// A unique identifier for the Update
        /// </summary>
        public string ID { get; protected set; } = default!;
        /// <summary>
        /// The type of the Update
        /// </summary>
        public UpdateType UpdateType { get; set; }
        /// <summary>
        /// Version information for the Update
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// The size, in bytes, of the Update
        /// </summary>
        public long DownloadSize { get; set; }
        /// <summary>
        /// An optional, human-readable summray of the Update
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// An optional, human-readable detail of the Update
        /// </summary>
        public string? Detail { get; set; }
        /// <summary>
        /// Indicates if the Update has been retrieved
        /// </summary>
        public bool Retrieved
        {
            get => _retrieved;
            set
            {
                if (value == Retrieved) return;
                _retrieved = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Retrieved)));
            }
        }

        /// <summary>
        /// Indicates if the Update has been applied
        /// </summary>
        public bool Applied
        {
            get => _applied;
            set
            {
                if (value == Applied) return;
                _applied = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Applied)));
            }
        }
        /// <summary>
        /// The expected Hash of the Update package
        /// </summary>
        public string DownloadHash { get; set; } = string.Empty;
    }
}