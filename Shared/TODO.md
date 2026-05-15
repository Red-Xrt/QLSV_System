# TODO LIST (Cập nhật lần cuối: 14/05/2026)

## 1. Frontend & UI/UX
- [x] **`frmSinhVien`**: 
  - [x] Hiển thị cột "Lớp" trên DataGridView & thêm bộ lọc theo Lớp.
  - [x] Tích hợp công cụ thao tác hàng loạt: Nút Chọn/Bỏ chọn tất cả, Sửa/Xóa nhiều sinh viên cùng lúc.
- [x] **`frmMonHoc`**:
  - [x] Tích hợp công cụ thao tác hàng loạt: Nút Chọn/Bỏ chọn tất cả, Sửa/Xóa nhiều môn cùng lúc.
- [X] **Form Chỉnh Sửa**: Xây dựng Form (hoặc Popup) chuyên dụng để cập nhật thông tin chi tiết cho Sinh Viên/Môn Học.

- [x] **`frmDanhGia`**: Redesign toàn bộ giao diện, tối ưu trải nghiệm (UX) trực quan hơn.
- [ ] **Viết các hàm helper** để chuẩn hóa việc hiển thị dữ liệu trên DataGridView, bao gồm định dạng ngày tháng, điểm

---

## 2. Cơ sở dữ liệu
- [x] **Bảng Sinh Viên**: Thêm trường SĐT, Email, Địa chỉ, Ngày sinh.
- [x] **Bảng Môn Học**: Thêm trường Số tín chỉ, Giảng viên phụ trách, Mô tả tóm tắt.
- [x] **Bảng Đánh Giá/Điểm**: Thêm trường Ngày đánh giá, Điểm thành phần (Quá trình, Giữa kỳ, Cuối kỳ), Nhận xét của Giảng viên.
- [ ] **Viết hàm procedure** để gọi các thằng function sử dụng kết quả trả về sau đó tiến hành UPDATE, DELETE, INSERT đảm bảo phải thêm tính toàn vẹn, commit, rollback.
	- [x] **`Procedure_DangNhap`** để kiểm tra thông tin đăng nhập của người dùng.
	- [x] **`Procedure_LayDanhSachSinhVien`** để lấy danh sách sinh viên.
	- [ ] **`Procedure_TinhDiemTrungBinh`** để tính điểm trung bình của một sinh viên dựa trên các điểm thành phần.
	- [ ] **`Procedure_DemSinhVienGioi`** để đếm số lượng sinh viên đạt loại giỏi trong một lớp học.
	- [ ] **`Procedure_CapNhatXepLoai`** để tự động cập nhật xếp loại học lực của sinh viên khi điểm của họ được cập nhật.
	- [ ] **`Procedure_ThemSinhVien`** để thêm một sinh viên mới vào cơ sở dữ liệu, đảm bảo tất cả các trường cần thiết được điền đầy đủ và hợp lệ.
	- [ ] **`Procedure_SuaSinhVien`** cập nhật thông tin cho sinh viên, bao gồm cả thông tin cá nhân và điểm số.
	- [ ] **`Procedure_SuaMonHoc`** để cập nhật thông tin của một môn học, bao gồm số tín chỉ, giảng viên phụ trách và mô tả tóm tắt.
- [ ] **Viết hàm function** để thực hiện các phép tính hoặc truy vấn phức tạp trên cơ sở dữ liệu, như tính điểm trung bình của một sinh viên, hoặc đếm số lượng sinh viên đạt loại giỏi trong một lớp học.
- [ ] **Viết hàm trigger** để tự động cập nhật các trường liên quan khi có sự thay đổi dữ liệu, ví dụ: khi điểm của một sinh viên được cập nhật, trigger có thể tự động tính lại điểm trung bình và xếp loại học lực của sinh viên đó.
- [ ] **Viêt hàm view** để tạo ra các bảng ảo giúp đơn giản hóa việc truy vấn dữ liệu phức tạp
	- [ ] **`View_DanhSachSinhVien`** để hiển thị thông tin chi tiết của sinh viên, bao gồm cả thông tin lớp học và điểm số.
	- [ ] **`View_DanhSachMonHoc`** để hiển thị thông tin chi tiết của môn học, bao gồm số tín chỉ và giảng viên phụ trách.
	- [ ] **`View_DanhSachDanhGia`** để hiển thị thông tin chi tiết của các đánh giá, bao gồm điểm số và nhận xét của giảng viên.
---

## 3. Backend & Logic
- [ ] **Tách lớp Data Access Layer (DAL)**: Tạo lớp chuyên biệt để xử lý tất cả tương tác với cơ sở dữ liệu, giúp tách biệt rõ ràng giữa logic nghiệp vụ và truy cập dữ liệu.
- [ ] **Viết hàm HTTP helper** cung cấp một sự thống nhất API trên cả codebase, giúp dễ dàng bảo trì và mở rộng.
- [ ] **Viêt hàm database mananger** cung cấp một API tương tác với database
- [ ] **Viết hàm middleware exception** để xử lý lỗi toàn cục, đảm bảo ứng dụng ổn định và dễ dàng debug.
- [ ] **Viết một chuẩn packet json** dùng Generic để truyền dữ liệu giữa client và server, giúp giảm thiểu lỗi và tăng tính nhất quán trong giao tiếp.
- [ ] **Viết hàm JWT helper** để tạo và xác thực JSON Web Tokens, đảm bảo an toàn cho các API và quản lý phiên làm việc của người dùng.
- [ ] **Viết hàm validation helper** để chuẩn hóa việc kiểm tra dữ liệu đầu vào, đảm bảo tính toàn vẹn và an toàn của dữ liệu trước khi lưu vào cơ sở dữ liệu.
---

### 4. Các bước tối ưu hóa đã biết
- [ ] **Tối ưu hóa truy vấn SQL**: Sử dụng chỉ mục (index) cho các cột thường xuyên được lọc hoặc sắp xếp, tránh sử dụng SELECT * và chỉ lấy những cột cần thiết.
- [ ] **Áp dụng database cache** cho các truy vấn thường xuyên để giảm tải cho cơ sở dữ liệu và tăng tốc độ phản hồi.
- [ ] **Phân trang**: Áp dụng phân trang cho các DataGridView để tránh tải quá nhiều dữ liệu cùng lúc, giúp cải thiện hiệu suất và trải nghiệm người dùng.

---

## 5. Future Development
- [ ] **Tìm kiếm đa tiêu chí (Advanced Search)**: 
  - [ ] Sinh viên: Lọc kết hợp theo Tên + Lớp + Mức điểm.
  - [ ] Môn học: Lọc kết hợp theo Tên + Giảng viên + Tín chỉ.
- [ ] **Tích hợp Excel (Import/Export)**: Nhập/Xuất hàng loạt danh sách Sinh viên, Môn học, Bảng điểm để giảm tải nhập liệu thủ công.
- [ ] **Module Báo cáo (Reporting)**: Xuất báo cáo đánh giá tự động theo 3 chuẩn: Lớp học / Môn học / Giảng viên.
- [ ] **Hệ thống thông báo**: Cảnh báo tự động khi có sinh viên đạt điểm thấp, hoặc khi có thay đổi quan trọng trong dữ liệu.
- [ ] **Hệ thống logs trên server**: Ghi lại tất cả các thao tác CRUD, giúp dễ dàng theo dõi và debug khi cần thiết.

---
### Note
- Luôn luôn tuân thủ nguyên tắc DRY (Don't Repeat Yourself) khi viết code, tránh lặp lại logic tương tự ở nhiều nơi.
- Cũng như áp dụng nguyên tắc SOLID, sử dụng DI để khiến code dễ bảo trì và mở rộng trong tương lai.
- Luôn luôn viết unit test cho các hàm quan trọng, đặc biệt là những hàm liên quan đến logic nghiệp vụ và truy cập dữ liệu, để đảm bảo chất lượng code và dễ dàng phát hiện lỗi sớm trong quá trình phát triển.