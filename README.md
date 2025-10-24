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
# Nguyễn Huỳnh Đăng Khoa
- Cơ bản chức năng đăng nhập và lấy lại mật khẩu
## Truy vấn SQL

Đã tạo truy vấn từ SQL trong các file sau:

- `AccountRepository.cs` — Xử lý các truy vấn liên quan đến tài khoản (lấy thông tin qua username hoặc email/số điện thoại, paswork).
- `DatabaseHelper.cs` — Hỗ trợ thực thi câu lệnh SQL và trả về kết quả dạng `DataTable`.
# Hồ Thiện Nhân

- Thiết kế giao diện cho các mục:

Đăng Nhập

Đăng Ký

# Nguyễn Xuân Trung 
- Viết chương trình đăng ký kiểm tra dữ liệu đầu vào , hiện thị thông báo khi dữ liệu k đúng định dạng và khi đăng ký thành công
  

