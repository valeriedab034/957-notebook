namespace WebsiteBaNhat.Models
{
    /// <summary>
    /// Đại diện cho một lời thề danh dự hoặc một điều Bác Hồ dạy CAND.
    /// </summary>
    public class TraditionItem
    {
        // Số thứ tự của nội dung.
        public int Number { get; set; }

        // Tiêu đề ngắn dùng trên giao diện.
        public string ShortTitle { get; set; } = "";

        // Nội dung nguyên văn.
        public string OriginalText { get; set; } = "";

        // Giải thích ý nghĩa cốt lõi.
        public string Meaning { get; set; } = "";

        // Liên hệ với việc học tập và rèn luyện của học viên.
        public string StudentApplication { get; set; } = "";
    }
}