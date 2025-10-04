# Bài tập tuần 3 - Nhóm 10

## Danh sách thành viên
- Hồ Thiện Nhân (23521073)  
- Phạm Hữu Lầu (24520947)  
- Phạm Gia Lâm (24520937)  
- Nguyễn Huỳnh Đăng Khoa (24520829)  
- Nguyễn Xuân Trung (24521888)  





# Công việc của Phạm Hữu Lầu
- Đã viết 2 file Helper:
  - `Helpers/PasswordHelper.cs`: Mã hóa mật khẩu bằng SHA-256
  - `Helpers/DbHelper.cs`: Kết nối SQL Server, kiểm tra username, thêm user, lấy thông tin user

- Cách test:
  - Trong Form1 có nút test
  - Nếu user `admin` chưa tồn tại → sẽ thêm vào DB
  - Nếu user `admin` đã có → báo tồn tại
  - Có thể tìm lại user trong DB

- Kết quả: test thành công (hiện thông báo `Đã thêm user admin` hoặc `User admin đã tồn tại`)


