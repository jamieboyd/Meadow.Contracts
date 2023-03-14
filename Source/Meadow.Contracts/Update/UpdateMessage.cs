namespace Meadow.Update
{
    public class UpdateMessage : UpdateInfo
    {
        public string MpakID
        {
            get => ID;
            set => ID = value;
        }
        public string MpakDownloadUrl { get; set; }
        public string[] TargetDevices { get; set; }
    }
}