namespace happy_anniversary.Models
{
    public class Photo
    {
        public string Src { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string CropPosition { get; set; } = "center"; // top, bottom, left, right, center
    }
}
