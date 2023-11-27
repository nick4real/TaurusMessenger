namespace TaurusMessenger.Shared.Model
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public int UploadedBy { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
