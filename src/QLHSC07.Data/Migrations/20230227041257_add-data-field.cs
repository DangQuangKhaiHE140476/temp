using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class adddatafield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "84eb6b0c-4c35-4a5c-ba3d-18b06704bfe0");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0ed43dc6-2f81-483f-af36-9a9649007d72");

            migrationBuilder.InsertData(
                schema: "qlhsc07",
                table: "field",
                columns: new[] { "id", "code", "created_by", "created_date", "is_delete", "modified_by", "modified_date", "name", "parent_id" },
                values: new object[,]
                {
                    { 271L, "G20-TH05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3148), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3149), "Xử lý đơn thư", 0L },
                    { 172L, "G16-VH12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2735), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2736), "Quảng cáo", 0L },
                    { 173L, "G02-CT14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2738), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2739), "Quản lý Cạnh tranh", 0L },
                    { 174L, "G10-NN09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2740), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2741), "Quản lý chất lượng nông lâm sản và thủy sản", 0L },
                    { 175L, "G11-QP15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2743), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2744), "Quản lý công nghệ thông tin", 0L },
                    { 176L, "G12-TC09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2745), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2746), "Quản lý công sản", 0L },
                    { 177L, "G10-NN10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2748), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2748), "Quản lý doanh nghiệp", 0L },
                    { 178L, "G17-XD10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2750), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2751), "Quản lý doanh nghiệp", 0L },
                    { 179L, "G12-TC11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2752), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2753), "Quản lý giá", 0L },
                    { 180L, "G17-XD11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2755), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2756), "Quản lý hoạt động xây dựng", 0L },
                    { 181L, "G07-LĐ13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2757), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2758), "Quản lý lao động ngoài nước", 0L },
                    { 182L, "G01-CA09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2760), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2761), "Quản lý ngành nghề đầu tư, kinh doanh có điều kiện về an ninh, trật tự", 0L },
                    { 183L, "BTC-NSNN", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2788), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2789), "Quản lý ngân sách nhà nước", 0L },
                    { 184L, "G17-XD12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2791), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2791), "Quản lý nhà và thị trường bất động sản", 0L },
                    { 185L, "G12-TC12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2793), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2794), "Quản lý nợ", 0L },
                    { 171L, "G10-NN08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2733), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2734), "Phòng, chống thiên tai", 0L },
                    { 186L, "BTC-QLNS", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2796), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2796), "Quản lý quỹ ngân sách, quỹ dự trữ nhà nước và các quỹ tài chính khác của Nhà nước", 0L },
                    { 188L, "BTC_QLT", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2801), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2802), "Quản lý thuế, phí, lệ phí và thu khác của ngân sách nhà nước", 0L },
                    { 189L, "G01-CA10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2803), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2804), "Quản lý vũ khí, vật liệu nổ, công cụ hỗ trợ và pháo", 0L },
                    { 190L, "G10-NN11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2806), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2807), "Quản lý xây dựng công trình", 0L },
                    { 192L, "G15-TP13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2808), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2809), "Quản tài viên", 0L },
                    { 193L, "G12-TC20", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2811), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2812), "Quốc phòng, an ninh", 0L },
                    { 194L, "G08-NG11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2813), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2814), "Quốc tịch", 0L },
                    { 195L, "G15-TP14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2815), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2816), "Quốc tịch", 0L },
                    { 196L, "G03-GD12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2818), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2819), "Quy chế thi, tuyển sinh", 0L },
                    { 197L, "G17-XD13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2820), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2821), "Quy hoạch xây dựng, kiến trúc", 0L },
                    { 198L, "G06-KC03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2823), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2824), "Sở hữu trí tuệ", 0L },
                    { 199L, "G12-TC15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2825), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2826), "Tài chính doanh nghiệp", 0L },
                    { 200L, "G12-TC17", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2828), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2828), "Tài chính ngân hàng", 0L },
                    { 201L, "G18-YT09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2830), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2831), "Tài chính y tế", 0L },
                    { 202L, "G13-TN10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2832), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2833), "Tài nguyên nước", 0L },
                    { 187L, "G16-VH20", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2798), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2799), "Quản lý sử dụng vũ khí, súng săn, vật liệu nổ, công cụ hỗ trợ", 0L },
                    { 203L, "G14-TT07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2835), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2836), "Tần số vô tuyến điện", 0L },
                    { 170L, "G20-TH01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2730), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2731), "Phòng, chống tham nhũng", 0L },
                    { 168L, "G15-TP12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2725), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2726), "Phổ biến giáo dục pháp luật", 0L },
                    { 138L, "G02-CT10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2651), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2652), "Kinh doanh khí", 0L },
                    { 139L, "G10-NN06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2653), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2654), "Kinh tế hợp tác và Phát triển nông thôn", 0L },
                    { 140L, "G17-XD07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2656), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2657), "Kinh tế xây dựng", 0L },
                    { 141L, "G10-NN07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2658), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2659), "Lâm nghiệp", 0L },
                    { 142L, "G07-LĐ07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2661), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2661), "Lao động", 0L },
                    { 143L, "BGT-LVK", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2663), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2664), "Lĩnh vực khác", 0L },
                    { 144L, "LVK", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2666), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2667), "Lĩnh vực khác", 0L },
                    { 145L, "NHCS-LVK", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2668), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2669), "Lĩnh vực khác", 0L },
                    { 146L, "G15-TP09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2671), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2672), "Luật sư", 0L },
                    { 147L, "G16-VH05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2673), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2674), "Lữ hành", 0L },
                    { 148L, "G02-CT11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2676), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2676), "Lưu thông hàng hóa trong nước", 0L },
                    { 149L, "G15-TP10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2678), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2679), "Lý lịch tư pháp", 0L },
                    { 150L, "G08-NG12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2681), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2681), "Miễn thị thực", 0L },
                    { 151L, "G13-TN09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2683), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2684), "Môi trường", 0L },
                    { 169L, "G07-LĐ10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2728), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2728), "Phòng, chống tệ nạn xã hội", 0L },
                    { 152L, "G18-YT08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2686), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2686), "Mỹ phẩm", 0L },
                    { 154L, "G02-CT12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2690), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2691), "Năng lượng", 0L },
                    { 155L, "G16-VH10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2693), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2694), "Nghệ thuật biểu diễn", 0L },
                    { 156L, "G11-QP10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2695), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2696), "Nghĩa vụ quân sự", 0L },
                    { 157L, "G07-LĐ09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2698), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2698), "Người có công", 0L },
                    { 158L, "G07-LĐ12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2700), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2701), "Người lao động Việt Nam đi làm việc ở nước ngoài theo hợp đồng", 0L },
                    { 159L, "G17-XD08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2702), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2703), "Nhà ở và công sở", 0L },
                    { 160L, "G16-VH19", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2705), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2706), "Nhập khẩu văn hoá phẩm nhằm mục đích kinh doanh", 0L },
                    { 161L, "G10-NN16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2708), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2708), "Nông nghiệp", 0L },
                    { 162L, "G15-TP11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2710), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2711), "Nuôi con nuôi", 0L },
                    { 163L, "G09-NV16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2713), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2713), "Pháp chế", 0L },
                    { 164L, "G12-TC24", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2715), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2716), "Pháp chế", 0L },
                    { 165L, "G14-TT05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2717), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2718), "Phát thanh, truyền hình và thông tin điện tử", 0L },
                    { 166L, "G17-XD09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2720), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2721), "Phát triển đô thị", 0L },
                    { 167L, "G06-KC05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2723), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2724), "Phát triển tiềm lực khoa học và công nghệ", 0L },
                    { 153L, "G16-VH09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2688), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2689), "Mỹ thuật, nhiếp ảnh, triển lãm", 0L },
                    { 272L, "G18-YT12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3151), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3152), "Y tế Dự phòng", 0L },
                    { 204L, "G05-KD07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2837), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2838), "Thành lập và hoạt động của doanh nghiệp", 0L },
                    { 206L, "G05-KD09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2842), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2843), "Thành lập và hoạt động của hợp tác xã (liên hiệp hợp tác xã)", 0L },
                    { 241L, "BLD-TCCB", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2954), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2955), "Tổ chức cán bộ", 0L },
                    { 242L, "G12-TC22", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2956), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2957), "Tổ chức cán bộ", 0L },
                    { 243L, "G09-NV10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2959), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2959), "Tổ chức cán bộ", 0L },
                    { 244L, "G18-YT10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2961), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2962), "Tổ chức cán bộ", 0L },
                    { 245L, "G09-NV11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2964), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2964), "Tổ chức phi chính phủ", 0L },
                    { 246L, "G09-NV14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2966), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2967), "Tổng hợp", 0L },
                    { 247L, "G13-TN11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2968), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2969), "Tổng hợp", 0L },
                    { 248L, "G09-NV13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2971), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2972), "Tôn giáo Chính phủ", 0L },
                    { 249L, "G18-YT11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2973), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2974), "Trang thiết bị và công trình y tế", 0L },
                    { 250L, "G07-LĐ04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2976), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2977), "Trẻ em", 0L },
                    { 251L, "G15-TP16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2979), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2980), "Trợ giúp pháp lý", 0L },
                    { 252L, "G15-TP17", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2982), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2983), "Trọng tài thương mại", 0L },
                    { 253L, "G10-NN15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2985), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2986), "Trồng trọt", 0L },
                    { 254L, "G15-TP18", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2988), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2989), "Tư vấn pháp luật", 0L },
                    { 240L, "G09-NV12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2951), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2952), "Tổ chức - Biên chế", 0L },
                    { 255L, "G03-GD14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2991), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2992), "Văn bằng, chứng chỉ", 0L },
                    { 257L, "G16-VH08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2997), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2998), "Văn hóa cơ sở", 0L },
                    { 258L, "G09-NV18", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3002), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3003), "Văn phòng", 0L },
                    { 259L, "G12-TC25", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3005), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3006), "Văn phòng", 0L },
                    { 260L, "G09-NV15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3008), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3009), "Văn thư và Lưu trữ nhà nước", 0L },
                    { 261L, "G02-CT21", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3055), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3056), "Vật liệu nổ công nghiệp, tiền chất thuốc nổ", 0L },
                    { 262L, "G17-XD14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3123), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3125), "Vật liệu xây dựng", 0L },
                    { 263L, "G07-LĐ11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3127), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3128), "Việc làm", 0L },
                    { 264L, "G13-TN12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3130), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3131), "Viễn thám", 0L },
                    { 265L, "G14-TT10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3133), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3134), "Viễn thông và Internet", 0L },
                    { 266L, "G17-XD15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3135), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3136), "Xây dựng", 0L },
                    { 267L, "G14-TT11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3138), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3139), "Xuất Bản, In và Phát hành", 0L },
                    { 268L, "G02-CT22", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3141), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3142), "Xuất nhập khẩu", 0L },
                    { 269L, "G16-VH17", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3143), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3144), "Xuất nhập khẩu văn hóa phẩm không nhằm mục đích kinh doanh", 0L },
                    { 270L, "G02-CT23", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3146), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3147), "Xúc tiến thương mại", 0L },
                    { 256L, "G16-VH13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2994), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2995), "Văn hóa", 0L },
                    { 137L, "G17-XD06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2648), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2649), "Kinh doanh bất động sản", 0L },
                    { 239L, "G12-TC19", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2949), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2950), "Tin học - Thống kê", 0L },
                    { 237L, "G06-KC04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2944), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2945), "Tiêu chuẩn đo lường chất lượng", 0L },
                    { 207L, "G05-KD-12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2845), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2845), "Thành lập và hoạt động của quỹ đầu tư khởi nghiệp sáng tạo", 0L },
                    { 208L, "G05-KD-13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2847), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2848), "Thành lập và hoạt động của tổ hợp tác", 0L },
                    { 209L, "G05-KD10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2849), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2850), "Thành lập và hoạt động doanh nghiệp (hộ kinh doanh)", 0L },
                    { 210L, "G05-KD11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2852), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2852), "Thành lập và hoạt động doanh nghiệp xã hội", 0L },
                    { 211L, "G12-TC23", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2854), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2855), "Thanh tra", 0L },
                    { 212L, "G09-NV07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2856), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2857), "Thanh tra Bộ", 0L },
                    { 213L, "G16-VH14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2859), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2860), "Thể dục thể thao", 0L },
                    { 214L, "G09-NV08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2861), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2862), "Thi đua - khen thưởng", 0L },
                    { 215L, "G12-TC13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2864), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2865), "Thi đua - khen thưởng", 0L },
                    { 216L, "G18-YT14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2866), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2867), "Thi đua, khen thưởng", 0L },
                    { 217L, "G02-CT16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2869), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2870), "Thi đua, khen thưởng", 0L },
                    { 218L, "G16-VH15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2871), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2872), "Thi đua – Khen thưởng", 0L },
                    { 219L, "G15-TP15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2874), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2875), "Thi hành án dân sự", 0L },
                    { 220L, "G03-GD12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2876), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2877), "Thi, tuyển sinh", 0L },
                    { 238L, "G03-GD13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2947), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2947), "Tiêu chuẩn nhà giáo, cán bộ quản lý giáo dục", 0L },
                    { 221L, "G14-TT08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2879), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2880), "Thông tin cơ sở", 0L },
                    { 223L, "G15-TP20", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2884), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2885), "Thừa phát lại", 0L },
                    { 224L, "BHXH-Thu", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2886), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2887), "Thu Bảo hiểm xã hội, bảo hiểm y tế, bảo hiểm thất nghiệp, BHTNLĐ-BNN", 0L },
                    { 225L, "BHXH-CSBH", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2889), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2889), "Thực hiện chính sách bảo hiểm xã hội", 0L },
                    { 226L, "G24-02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2891), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2892), "Thực hiện chính sách bảo hiểm xã hội", 0L },
                    { 227L, "BHXH-THCS", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2893), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2894), "Thực hiện chính sách bảo hiểm y tế", 0L },
                    { 228L, "G12-TC18", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2896), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2897), "Thuế", 0L },
                    { 229L, "G02-CT19", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2898), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2899), "Thương mại quốc tế", 0L },
                    { 230L, "G16-VH11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2901), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2902), "Thư viện", 0L },
                    { 231L, "G10-NN12", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2903), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2904), "Thú y", 0L },
                    { 232L, "G10-NN13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2906), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2907), "Thủy lợi", 0L },
                    { 233L, "G10-NN14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2908), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2909), "Thủy sản", 0L },
                    { 234L, "G07-LĐ08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2911), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2911), "Tiền lương", 0L },
                    { 235L, "G09-NV09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2939), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2940), "Tiền lương", 0L },
                    { 236L, "G20-TH04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2942), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2943), "Tiếp công dân", 0L },
                    { 222L, "G14-TT09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2881), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2882), "Thông tin đối ngoại", 0L },
                    { 205L, "G05-KD08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2840), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2841), "Thành lập và hoạt động của hợp tác xã", 0L },
                    { 136L, "G12-TC07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2646), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2647), "Kho bạc", 0L },
                    { 134L, "G10-NN05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2641), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2642), "Khoa học, Công nghệ và Môi trường", 0L },
                    { 35L, "G08-NG04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2316), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2316), "Công chứng, chứng thực", 0L },
                    { 36L, "G14-TT04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2318), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2319), "Công nghệ thông tin, điện tử", 0L },
                    { 37L, "G02-CT03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2321), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2321), "Công nghiệp địa phương", 0L },
                    { 38L, "G02-CT04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2323), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2324), "Công nghiệp nặng", 0L },
                    { 39L, "G02-CT05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2326), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2326), "Công nghiệp tiêu dùng", 0L },
                    { 40L, "G21-UB01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2328), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2329), "Công tác dân tộc", 0L },
                    { 41L, "CTLS", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2331), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2332), "Công tác lãnh sự", 0L },
                    { 42L, "G09-NV04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2334), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2335), "Công tác thanh niên", 0L },
                    { 43L, "G03-GD01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2336), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2337), "Cơ sở vật chất và thiết bị trường học", 0L },
                    { 44L, "G04-GT01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2340), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2340), "Đăng kiểm", 0L },
                    { 45L, "G15-TP05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2342), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2343), "Đăng ký biện pháp bảo đảm", 0L },
                    { 46L, "G08-NG06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2345), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2346), "Đăng ký công dân", 0L },
                    { 47L, "G01-CA04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2347), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2348), "Đăng ký, quản lý con dấu", 0L },
                    { 48L, "G01-CA05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2350), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2350), "Đăng ký, quản lý cư trú", 0L },
                    { 34L, "G15-TP04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2313), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2314), "Công chứng", 0L },
                    { 49L, "G01-CA06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2352), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2353), "Đăng ký, quản lý phương tiện giao thông đường bộ", 0L },
                    { 51L, "G09-NV05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2383), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2384), "Đào tạo, bồi dưỡng cán bộ công chức, viên chức", 0L },
                    { 52L, "G18-YT03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2386), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2387), "Đào tạo, Nghiên cứu khoa học và Công nghệ thông tin", 0L },
                    { 53L, "G03-GD02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2389), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2390), "Đào tạo với nước ngoài", 0L },
                    { 54L, "G13-TN02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2392), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2393), "Đất đai", 0L },
                    { 55L, "G02-CT06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2394), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2395), "Dầu khí", 0L },
                    { 56L, "G05-KD02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2397), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2398), "Đấu thầu", 0L },
                    { 57L, "G12-TC03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2400), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2401), "Đầu tư", 0L },
                    { 58L, "G05-KD01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2403), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2404), "Đầu tư bằng vốn hỗ trợ phát triển chính thức (ODA) và viện trợ không hoàn lại không thuộc hỗ trợ phát triển chính thức", 0L },
                    { 59L, "G05-KD03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2405), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2406), "Đầu tư tại Việt nam", 0L },
                    { 60L, "G05-KD04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2408), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2409), "Đầu tư từ Việt nam ra nước ngoài", 0L },
                    { 61L, "G05-KD05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2410), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2411), "Đầu tư vào nông nghiệp, nông thôn", 0L },
                    { 62L, "G13-TN03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2413), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2414), "Địa chất và khoáng sản", 0L },
                    { 63L, "DL-DVDM", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2415), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2416), "Dịch vụ cung cấp điện mới", 0L },
                    { 64L, "G16-VH18", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2418), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2419), "Dịch vụ du lịch khác", 0L },
                    { 50L, "G18-YT02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2381), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2382), "Dân số", 0L },
                    { 65L, "G02-CT07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2421), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2422), "Dịch vụ thương mại", 0L },
                    { 33L, "G09-NV03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2311), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2311), "Công chức, viên chức", 0L },
                    { 31L, "G08-NG03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2305), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2305), "Chứng nhận lãnh sự, hợp pháp hóa lãnh sự", 0L },
                    { 274L, "G02-CT26", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2143), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2161), "An toàn đập, hồ chứa thuỷ điện", 0L },
                    { 2L, "G14-TT01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2179), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2180), "An toàn thông tin", 0L },
                    { 3L, "G02-CT01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2182), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2183), "An toàn thực phẩm", 0L },
                    { 4L, "G18-YT01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2184), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2185), "An toàn thực phẩm và Dinh dưỡng", 0L },
                    { 5L, "G02-CT02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2229), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2230), "An toàn vệ sinh lao động", 0L },
                    { 6L, "G07-LĐ01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2232), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2233), "An toàn, vệ sinh lao động", 0L },
                    { 7L, "G15-TP01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2235), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2236), "Bán đấu giá tài sản", 0L },
                    { 8L, "G16-VH01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2238), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2239), "Bản quyền tác giả", 0L },
                    { 9L, "G08-NG01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2242), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2243), "Báo chí", 0L },
                    { 10L, "G11-QP17", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2245), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2246), "Báo chí", 0L },
                    { 11L, "G14-TT02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2248), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2249), "Báo chí", 0L },
                    { 12L, "G12-TC14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2251), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2252), "Bảo hiểm", 0L },
                    { 13L, "G07-LĐ02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2254), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2255), "Bảo hiểm xã hội", 0L },
                    { 14L, "G07-LĐ03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2257), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2258), "Bảo trợ xã hội", 0L },
                    { 32L, "G15-TP03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2307), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2308), "Chứng thực", 0L },
                    { 15L, "G10-NN01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2260), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2261), "Bảo vệ thực vật", 0L },
                    { 17L, "G07-LĐ05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2267), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2268), "Bình đẳng giới", 0L },
                    { 18L, "G15-TP02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2270), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2271), "Bồi thường nhà nước", 0L },
                    { 19L, "G14-TT03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2273), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2274), "Bưu chính", 0L },
                    { 20L, "BGD-GD15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2276), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2277), "Các cơ sở giáo dục khác", 0L },
                    { 21L, "G09-NV01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2279), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2280), "Cải cách hành chính", 0L },
                    { 22L, "G08-NG02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2282), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2283), "Cấp hộ chiếu, giấy thông hành, công hàm đề nghị cấp thị thực", 0L },
                    { 23L, "G01-CA01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2285), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2286), "Cấp, quản lý căn cước công dân", 0L },
                    { 24L, "G08-NG05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2287), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2288), "Cấp thị thực, gia hạn tạm trú", 0L },
                    { 25L, "G10-NN02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2290), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2291), "Chăn nuôi", 0L },
                    { 26L, "G10-NN03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2292), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2293), "Chế biến và phát triển thị trường Nông sản", 0L },
                    { 27L, "G09-NV02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2295), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2296), "Chính quyền địa phương", 0L },
                    { 28L, "G11-QP03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2297), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2298), "Chính sách", 0L },
                    { 29L, "G12-TC01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2300), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2301), "Chính sách Thuế", 0L },
                    { 30L, "G12-TC02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2302), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2303), "Chứng khoán", 0L },
                    { 16L, "G13-TN01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2263), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2264), "Biển và hải đảo", 0L },
                    { 66L, "DL-DVMBD", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2424), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2425), "Dịch vụ trong quá trình thực hiện HĐMBĐ", 0L },
                    { 67L, "G02-CT08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2426), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2427), "Điện", 0L },
                    { 68L, "G16-VH03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2429), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2430), "Điện ảnh", 0L },
                    { 104L, "G15-TP08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2541), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2542), "Hòa giải thương mại", 0L },
                    { 105L, "G08-NG08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2544), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2545), "Hoạt động của các tổ chức hợp tác, nghiên cứu song phương", 0L },
                    { 106L, "G08-NG09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2546), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2547), "Hoạt động của các tổ chức phi chính phủ nước ngoài", 0L },
                    { 107L, "G06-KC02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2549), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2550), "Hoạt động khoa học và công nghệ", 0L },
                    { 108L, "G19-NH05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2552), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2552), "Hoạt động ngoại hối", 0L },
                    { 109L, "G17-XD11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2554), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2555), "Hoạt động xây dựng", 0L },
                    { 110L, "G08-NG10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2556), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2557), "Hồi hương", 0L },
                    { 111L, "G08-NG13", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2559), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2560), "Hội nghị, hội thảo quốc tế", 0L },
                    { 112L, "G17-XD04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2561), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2562), "Hợp tác quốc tế", 0L },
                    { 113L, "G16-VH16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2564), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2565), "Hợp tác quốc tế", 0L },
                    { 114L, "G12-TC21", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2566), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2568), "Hợp tác quốc tế", 0L },
                    { 115L, "G10-NN04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2569), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2570), "Hợp tác quốc tế", 0L },
                    { 116L, "G09-NV06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2572), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2572), "Hợp tác quốc tế", 0L },
                    { 117L, "G18-YT06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2574), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2575), "Hợp tác quốc tế", 0L },
                    { 103L, "G02-CT09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2539), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2540), "Hóa chất", 0L },
                    { 118L, "G13-TN05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2577), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2577), "Hợp tác quốc tế", 0L },
                    { 120L, "G08-NG07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2581), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2582), "Hộ tịch", 0L },
                    { 121L, "G05-KD06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2584), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2585), "Hỗ trợ doanh nghiệp nhỏ và vừa", 0L },
                    { 122L, "G15-TP19", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2586), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2587), "Hỗ trợ pháp lý cho doanh nghiệp nhỏ và vừa", 0L },
                    { 123L, "G16-VH07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2589), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2590), "Karaoke, Vũ trường", 0L },
                    { 124L, "G12-TC05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2591), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2592), "Kế hoạch - tài chính", 0L },
                    { 125L, "G09-NV17", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2594), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2595), "Kế hoạch - Tài chính", 0L },
                    { 126L, "G12-TC06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2597), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2598), "Kế toán, kiểm toán", 0L },
                    { 127L, "G16-VH06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2599), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2600), "Khách sạn", 0L },
                    { 128L, "G18-YT07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2602), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2603), "Khám bệnh, chữa bệnh", 0L },
                    { 129L, "G11-QP20", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2606), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2607), "Khen thưởng", 0L },
                    { 130L, "G01-CA07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2608), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2609), "Khiếu nại, tố cáo", 0L },
                    { 131L, "G13-TN06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2611), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2612), "Khí tượng, thủy văn và Biến đổi khí hậu", 0L },
                    { 132L, "G13-TN08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2636), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2637), "Khoa học công nghệ", 0L },
                    { 133L, "G17-XD05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2638), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2639), "Khoa học công nghệ và môi trường", 0L },
                    { 119L, "G15-TP07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2579), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2580), "Hộ tịch", 0L },
                    { 102L, "G03-GD14", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2537), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2537), "Hệ thống văn bằng, chứng chỉ", 0L },
                    { 101L, "G17-XD03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2534), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2535), "Hạ tầng kỹ thuật đô thị và khu công nghiệp, khu kinh tế và khu công nghệ cao", 0L },
                    { 100L, "G17-XD02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2531), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2532), "Hạ tầng kỹ thuật", 0L },
                    { 69L, "G16-VH02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2431), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2432), "Di sản văn hóa", 0L },
                    { 70L, "G13-TN04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2434), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2435), "Đo đạc, bản đồ và thông tin địa lý", 0L },
                    { 71L, "G16-VH21", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2436), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2437), "Du lịch", 0L },
                    { 72L, "G18-YT04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2439), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2440), "Dược phẩm", 0L },
                    { 73L, "G04-GT02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2441), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2442), "Đường bộ", 0L },
                    { 74L, "G04-GT03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2444), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2445), "Đường sắt", 0L },
                    { 75L, "G04-GT04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2446), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2447), "Đường thủy nội địa", 0L },
                    { 76L, "G12-TC10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2449), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2449), "Dự trữ", 0L },
                    { 77L, "G16-VH04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2451), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2452), "Gia đình", 0L },
                    { 78L, "G20-TH02", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2453), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2454), "Giải quyết khiếu nại", 0L },
                    { 79L, "G20-TH03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2456), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2457), "Giải quyết tố cáo", 0L },
                    { 80L, "G17-XD01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2458), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2459), "Giám định nhà nước về chất lượng công trình xây dựng", 0L },
                    { 81L, "G02-CT27", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2461), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2462), "Giám định thương mại", 0L },
                    { 82L, "G15-TP06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2463), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2464), "Giám định tư pháp", 0L },
                    { 83L, "G18-YT05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2466), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2467), "Giám định y khoa", 0L },
                    { 84L, "G03-GD03", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2468), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2469), "Giáo dục Chuyên nghiệp", 0L },
                    { 85L, "G03-GD04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2471), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2471), "Giáo dục Đại học", 0L },
                    { 99L, "G12-TC16", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2529), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2530), "Hành chính sự nghiệp", 0L },
                    { 98L, "G04-GT06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2527), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2527), "Hàng không", 0L },
                    { 97L, "G04-GT05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2524), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2524), "Hàng Hải", 0L },
                    { 96L, "G12-TC04", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2521), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2522), "Hải quan", 0L },
                    { 95L, "G03-GD11", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2519), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2520), "Giáo dục và Đào tạo thuộc hệ thống giáo dục quốc dân", 0L },
                    { 94L, "G03-GD10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2516), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2517), "Giáo dục Trung học", 0L },
                    { 135L, "G06-KC06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2643), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2644), "Khoa học và công nghệ", 0L },
                    { 93L, "G03-GD10", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2490), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2491), "Giáo dục trung học", 0L },
                    { 91L, "G03-GD08", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2485), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2486), "Giáo dục Thường xuyên", 0L },
                    { 90L, "G03-GD07", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2483), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2484), "Giáo dục Quốc phòng", 0L },
                    { 89L, "G07-LĐ06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2480), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2481), "Giáo dục nghề nghiệp", 0L },
                    { 88L, "G03-GD06", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2478), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2479), "Giáo dục Mầm non", 0L },
                    { 87L, "BGD-GD15", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2475), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2476), "Giáo dục đào tạo thuộc hệ thống giáo dục quốc dân và các cơ sở khác", 0L },
                    { 86L, "G03-GD05", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2473), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2474), "Giáo dục Dân tộc", 0L },
                    { 92L, "G03-GD09", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2488), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2489), "Giáo dục Tiểu học", 0L },
                    { 273L, "G06-KC01", "admin", new DateTime(2023, 2, 27, 11, 12, 56, 610, DateTimeKind.Local).AddTicks(4678), false, "admin", new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(1783), "An toàn bức xạ và hạt nhân", 0L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "23009cfd-eeee-49bf-a7e3-44dcbf6a6e4b");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "66c9a618-00b3-48c8-a40b-0dfeddbe3d8b");
        }
    }
}
