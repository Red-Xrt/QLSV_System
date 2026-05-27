# QLSV System

Hệ thống quản lý sinh viên (WinForms + SQL Server).

## Cấu trúc thư mục

```
QLSV_System/
├── Database/          # Script SQL (schema, trigger, stored procedure)
├── Core/              # Logic nghiệp vụ, model, truy cập dữ liệu
│   ├── Models/
│   ├── Data/          # Kết nối + repository (Doc*)
│   ├── Services/      # Xử lý nghiệp vụ (XuLy*)
│   └── Helpers/       # Validation, mã hóa, session
└── Application/       # Ứng dụng WinForms (UI)
    ├── Views/
    │   ├── LopHoc/        # Quản lý lớp
    │   └── LichHoc/       # Lịch học tuần
    ├── Controllers/
    └── Helpers/       # Grid, thông báo (MessageBox)
```

## Chạy dự án

1. **Database**: mở SSMS, chạy `Database/CSDL.sql` (xem thêm `Database/README.txt`).
2. **Connection string**: sửa `Application/App.config` nếu cần (`.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`).
3. **Build**: mở `QLSV_System.slnx` trong Visual Studio, set startup project **QLSV.App**, F5.
4. **Đăng nhập**: `admin` / `123456`

5. **Cập nhật DB** (nếu đã tạo DB trước đó): chạy lại `Database/CSDL.sql` hoặc các proc/view mới trong file đó.

## Tính năng mới

- **Quản lý lớp học**: thêm / sửa / xóa lớp (không xóa lớp còn sinh viên).
- **Hủy đăng ký môn**: trong chi tiết sinh viên, cột **Hủy ĐK** trên bảng môn đã đăng ký.
- **Lịch học tuần**: menu **Lịch Học Tuần** hoặc nút trên hồ sơ SV.
- **Event handler classic**: gắn sự kiện trong Designer (`btnLuu_Click`), không dùng lambda trong constructor.

## Solution

| Project    | Vai trò                                      |
|-----------|-----------------------------------------------|
| QLSV.Core | Class library — không phụ thuộc WinForms UI   |
| QLSV.App  | WinExe — form, điều hướng, tham chiếu Core    |
