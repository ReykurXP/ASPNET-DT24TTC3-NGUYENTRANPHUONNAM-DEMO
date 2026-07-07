# ASPNET-DT24TTC3-NGUYENTRANPHUONNAM-DEMO
# ĐỒ ÁN MÔN HỌC: CHUYÊN ĐỀ ASP.NET

## 📌 THÔNG TIN CHUNG
- **Tên đề tài:** Xây dựng website bán linh kiện điện tử
- **Lớp:** DT24TTC3
- **Giảng viên hướng dẫn:** TS. Nguyễn Nhứt Lam

### 👥 THÔNG TIN TÁC GIẢ
- **Họ và tên:** Nguyễn Trần Phương Nam
- **Mã số sinh viên:** 170124311
- **Email:** namntp161103@tvu-onschool.edu.vn

---

## 📝 GIỚI THIỆU ĐỒ ÁN
Dự án tập trung nghiên cứu và xây dựng một hệ thống website thương mại điện tử chuyên kinh doanh các mặt hàng **Linh kiện điện tử** (như vi điều khiển, cảm biến, mạch tích hợp IC, phụ kiện robot, công cụ hàn mạch,...). 

Website hướng tới việc cung cấp giải pháp mua sắm trực tuyến trực quan, quản lý danh mục sản phẩm thông minh theo thông số kỹ thuật đặc thù của ngành điện tử, đồng thời tích hợp hệ thống quản trị (Admin Dashboard) chuyên sâu phục vụ cho việc quản lý tồn kho, xử lý đơn hàng và phân tích doanh thu.

---

## 🚀 YÊU CẦU HỆ THỐNG & CÁCH TRIỂN KHAI (DỰ KIẾN)

### 🛠️ Yêu cầu hệ thống (Prerequisites)
Để chuẩn bị chạy thử nghiệm dự án dưới môi trường phát triển cục bộ (Local), máy tính cần cài đặt sẵn:
- **Hệ điều hành:** Windows 10/11 hoặc macOS/Linux.
- **Bộ công cụ phát triển:** .NET SDK (Dự kiến phiên bản .NET 8.0 hoặc .NET 9.0).
- **Môi trường lập trình (IDE):** Visual Studio 2022 (đã bật gói *ASP.NET and web development*) hoặc Visual Studio Code.
- **Hệ quản trị cơ sở dữ liệu:** SQL Server và công cụ quản lý SQL Server Management Studio (SSMS).

### 🏃‍♂️ Các bước triển khai (Installation Guide)
*   **Hệ quản trị cơ sở dữ liệu:** SQL Server (SQL Server Express hoặc LocalDB) đi kèm công cụ quản lý SQL Server Management Studio (SSMS).

---

### 🏃‍♂️ Các bước triển khai thực tế (Installation & Setup)

#### Tuần 1: Khởi tạo và Chuẩn bị
- Đã cấu hình và hoàn thiện tài liệu hướng dẫn sơ bộ tại `README.md`.
- Đã mời giảng viên hướng dẫn tham gia quản trị dự án với tư cách Collaborator.

#### Tuần 2: Khởi tạo cấu trúc mã nguồn đồ án
Hệ thống được tổ chức theo cấu trúc 3 lớp (3-Layer Architecture) tiêu chuẩn để quản lý mã nguồn chuyên nghiệp, tách biệt giữa giao diện và cơ sở dữ liệu:
1. **Khởi tạo Blank Solution:** Đặt tên Solution đồng bộ theo cú pháp quy định: `ASPNET-da21tta-nguyenngocduyen-DEMO`.
2. **Tạo tầng Hiển thị (LinhKienDienTu.Web):** Sử dụng template *ASP.NET Core Web App (Model-View-Controller)* trên nền tảng `.NET 8.0` để quản lý giao diện bán hàng và admin dashboard.
3. **Tạo tầng Dữ liệu (LinhKienDienTu.DataAccess):** Sử dụng *Class Library* để quản lý cấu trúc các bảng dữ liệu (Entities) và ngữ cảnh kết nối cơ sở dữ liệu.
4. **Tạo tầng Thực thể & Nghiệp vụ (LinhKienDienTu.Models):** Sử dụng *Class Library* độc lập nhằm chứa các đối tượng dữ liệu chung chuyển giữa các lớp.

*(Các bước cấu hình Chuỗi kết nối Database SQL Server và chạy lệnh `Update-Database` thông qua Entity Framework Core sẽ tiếp tục được hiện thực hóa và cập nhật ở tuần tiếp theo)*.

