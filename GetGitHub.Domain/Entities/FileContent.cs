namespace GetGitHub.Domain.Entities
{
    public class FileContent
    {
        public string Type { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }

        public string Extension { get; set; }

        public decimal Size { get; set; }

        public string SizeUnit { get; set; }

        public long NumberOfLines { get; set; }
    }
}
