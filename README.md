# 🔐 Bài Tập 4.1 – Form Đăng Nhập

Bài tập xây dựng giao diện đăng nhập chuẩn UX sử dụng Windows Forms C#.

---

## 📋 Mô tả

Form đăng nhập với đầy đủ các tính năng:
- Kiểm tra dữ liệu nhập bằng **ErrorProvider** (không để trống)
- Ẩn/hiện mật khẩu bằng **CheckBox**
- Phím **Enter** → kích hoạt nút Đăng Nhập
- Phím **Esc** → thoát ứng dụng

---

## 🖼️ Giao diện

![Giao diện Form Đăng Nhập](Screenshot%202026-09-23%20161706.png)

---

## ⚙️ Các thành phần chính

| Tên Control | Chức năng |
|-------------|-----------|
| `txtUsername` | Ô nhập tên đăng nhập |
| `txtPassword` | Ô nhập mật khẩu (ẩn `***` mặc định) |
| `chkShowPassword` | Tick để hiện mật khẩu, bỏ tick để ẩn |
| `btnLogin` | Nút đăng nhập — gán `AcceptButton` (phím Enter) |
| `btnExit` | Nút thoát — gán `CancelButton` (phím Esc) |
| `errorProvider` | Hiển thị lỗi khi bỏ trống username hoặc password |

---

## 🚀 Cách chạy

**Bằng Visual Studio:**
1. Mở file `BT4_1_LoginForm.sln`
2. Nhấn `F5` để chạy

**Bằng terminal:**
```bash
dotnet run
```

---

## 🛠️ Yêu cầu
- .NET 10.0 SDK
- Windows OS
- Visual Studio 2022 trở lên
