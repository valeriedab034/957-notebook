using WebsiteBaNhat.Models;

namespace WebsiteBaNhat.Services
{
    /// <summary>
    /// Cung cấp dữ liệu cho phân đoạn
    /// "Truyền thống – Danh dự – Lý tưởng".
    /// </summary>
    public class TraditionService
    {
        /// <summary>
        /// Lấy Năm lời thề danh dự của CAND Việt Nam.
        /// </summary>
        public List<TraditionItem> GetFiveOaths()
        {
            return new List<TraditionItem>
            {
                new TraditionItem
                {
                    Number = 1,
                    ShortTitle = "Tuyệt đối trung thành",

                    OriginalText =
                        "Tuyệt đối trung thành với Tổ quốc và nhân dân Việt Nam, " +
                        "với Đảng Cộng sản Việt Nam, với Nhà nước Cộng hoà Xã hội " +
                        "Chủ nghĩa Việt Nam, suốt đời phấn đấu, hy sinh vì độc lập, " +
                        "tự do, chủ quyền, thống nhất và toàn vẹn lãnh thổ, " +
                        "vì an ninh Tổ quốc.",

                    Meaning =
                        "Khẳng định lòng trung thành tuyệt đối và trách nhiệm đặt " +
                        "lợi ích của Tổ quốc, Đảng, Nhà nước và Nhân dân lên trên hết.",

                    StudentApplication =
                        "Giữ vững lập trường; học tập nghiêm túc; có trách nhiệm " +
                        "với lời nói, hành động và mọi nhiệm vụ được giao."
                },

                new TraditionItem
                {
                    Number = 2,
                    ShortTitle = "Nghiêm chỉnh chấp hành",

                    OriginalText =
                        "Nghiêm chỉnh chấp hành chủ trương, đường lối, chính sách " +
                        "của Đảng, pháp luật của Nhà nước, nghị quyết, chỉ thị và " +
                        "Điều lệnh Công an Nhân dân; sẵn sàng đi bất cứ đâu, " +
                        "làm bất cứ việc gì khi Tổ quốc, Đảng và nhân dân cần đến.",

                    Meaning =
                        "Thể hiện tính tổ chức, kỷ luật, tinh thần phục tùng và sự " +
                        "sẵn sàng nhận nhiệm vụ trong mọi điều kiện, hoàn cảnh.",

                    StudentApplication =
                        "Nghiêm chỉnh chấp hành nội quy, điều lệnh và thời gian biểu; " +
                        "không né tránh khó khăn, không đùn đẩy trách nhiệm."
                },

                new TraditionItem
                {
                    Number = 3,
                    ShortTitle = "Tận tụy phục vụ Nhân dân",

                    OriginalText =
                        "Kính trọng, lễ phép với nhân dân. Sẵn sàng bảo vệ tính mạng, " +
                        "tài sản, quyền và lợi ích hợp pháp của nhân dân. Suốt đời " +
                        "tận tụy phục vụ nhân dân, vì cuộc sống bình yên và hạnh phúc " +
                        "của nhân dân.",

                    Meaning =
                        "Xác định Nhân dân là đối tượng phục vụ, là nguồn sức mạnh " +
                        "và là trung tâm của hoạt động bảo vệ an ninh, trật tự.",

                    StudentApplication =
                        "Giao tiếp đúng mực, biết lắng nghe, tôn trọng Nhân dân " +
                        "và chủ động giúp đỡ khi Nhân dân gặp khó khăn."
                },

                new TraditionItem
                {
                    Number = 4,
                    ShortTitle = "Kiên quyết đấu tranh",

                    OriginalText =
                        "Đề cao cảnh giác, kiên quyết, mưu trí, dũng cảm đấu tranh " +
                        "phòng, chống các thế lực thù địch, các loại tội phạm và " +
                        "các hành vi vi phạm pháp luật.",

                    Meaning =
                        "Kết hợp bản lĩnh và lòng dũng cảm với sự tỉnh táo, mưu trí " +
                        "và tinh thần thượng tôn pháp luật.",

                    StudentApplication =
                        "Rèn luyện khả năng quan sát, tư duy tình huống, ý thức " +
                        "cảnh giác và tác phong bình tĩnh, đúng nguyên tắc."
                },

                new TraditionItem
                {
                    Number = 5,
                    ShortTitle = "Học tập và thực hiện lời Bác",

                    OriginalText =
                        "Ra sức học tập, thực hiện nghiêm túc 6 điều Chủ tịch " +
                        "Hồ Chí Minh dạy Công an Nhân dân, luôn xứng đáng với " +
                        "danh dự và truyền thống của Công an Nhân dân Việt Nam.",

                    Meaning =
                        "Gắn danh dự của người chiến sĩ CAND với quá trình tự học, " +
                        "tự rèn và thực hiện Sáu điều Bác Hồ dạy trong thực tiễn.",

                    StudentApplication =
                        "Tự đánh giá bản thân hằng ngày; phát huy ưu điểm, sửa chữa " +
                        "hạn chế và xây dựng lối sống kỷ luật, nhân văn."
                }
            };
        }

        /// <summary>
        /// Lấy Sáu điều Chủ tịch Hồ Chí Minh dạy CAND.
        /// </summary>
        public List<TraditionItem> GetSixTeachings()
        {
            return new List<TraditionItem>
            {
                new TraditionItem
                {
                    Number = 1,
                    ShortTitle = "Đối với tự mình",

                    OriginalText =
                        "Đối với tự mình, phải cần, kiệm, liêm, chính.",

                    Meaning =
                        "Cần cù, tiết kiệm, trong sạch và ngay thẳng là nền móng " +
                        "để mỗi người tự hoàn thiện bản thân.",

                    StudentApplication =
                        "Học tập chăm chỉ; sử dụng thời gian và vật chất tiết kiệm; " +
                        "sống trung thực; tự giác nhận và sửa khuyết điểm."
                },

                new TraditionItem
                {
                    Number = 2,
                    ShortTitle = "Đối với đồng sự",

                    OriginalText =
                        "Đối với đồng sự, phải thân ái, giúp đỡ.",

                    Meaning =
                        "Tình đồng chí, đồng đội được xây dựng bằng sự chân thành, " +
                        "tôn trọng, sẻ chia và cùng nhau hoàn thành nhiệm vụ.",

                    StudentApplication =
                        "Giúp đỡ đồng đội tiến bộ; góp ý có trách nhiệm; không gây " +
                        "chia rẽ và không thờ ơ trước khó khăn của tập thể."
                },

                new TraditionItem
                {
                    Number = 3,
                    ShortTitle = "Đối với Chính phủ",

                    OriginalText =
                        "Đối với Chính phủ, phải tuyệt đối trung thành.",

                    Meaning =
                        "Sự trung thành được thể hiện bằng bản lĩnh chính trị " +
                        "vững vàng và việc nghiêm chỉnh thực hiện nhiệm vụ.",

                    StudentApplication =
                        "Nắm vững quy định, chấp hành tổ chức và giữ sự thống nhất " +
                        "giữa nhận thức, lời nói với hành động."
                },

                new TraditionItem
                {
                    Number = 4,
                    ShortTitle = "Đối với Nhân dân",

                    OriginalText =
                        "Đối với nhân dân, phải kính trọng, lễ phép.",

                    Meaning =
                        "Kính trọng Nhân dân phải được thể hiện bằng thái độ, " +
                        "ngôn ngữ, tác phong và trách nhiệm phục vụ.",

                    StudentApplication =
                        "Biết chào hỏi, lắng nghe, giải thích rõ ràng; cư xử đúng " +
                        "mực và không gây phiền hà cho Nhân dân."
                },

                new TraditionItem
                {
                    Number = 5,
                    ShortTitle = "Đối với công việc",

                    OriginalText =
                        "Đối với công việc, phải tận tụy.",

                    Meaning =
                        "Tận tụy là làm việc có trách nhiệm, có chất lượng, " +
                        "đến nơi đến chốn và hướng đến lợi ích chung.",

                    StudentApplication =
                        "Đúng giờ, chuẩn bị kỹ, hoàn thành phần việc và chủ động " +
                        "báo cáo khi có khó khăn phát sinh."
                },

                new TraditionItem
                {
                    Number = 6,
                    ShortTitle = "Đối với địch",

                    OriginalText =
                        "Đối với địch, phải cương quyết, khôn khéo.",

                    Meaning =
                        "Cương quyết về nguyên tắc, mục tiêu nhưng phải tỉnh táo, " +
                        "linh hoạt và phù hợp trong phương pháp đấu tranh.",

                    StudentApplication =
                        "Rèn luyện bản lĩnh và khả năng xử lý tình huống; không " +
                        "nóng vội, chủ quan hoặc mất cảnh giác."
                }
            };
        }
    }
}