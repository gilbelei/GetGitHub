namespace GetGitHub.Domain.Entities
{
    public class WebScrapingResult
    {
        public string FileExtension { get; set; }

        public long NumberOfLines { get; set; }

        public long Size { get; set; }

        public string Result { get; set; }
    }
}
