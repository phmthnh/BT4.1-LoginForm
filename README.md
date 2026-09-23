# BT4.1 – Form Đăng Nhập (Login Form) chuẩn UX

**Môn:** Lập trình Windows Forms với C#  
**Mục tiêu:** Xây dựng Login Form có Validation ErrorProvider, ẩn mật khẩu, gán AcceptButton/CancelButton.

## Tính năng

| Control | Chức năng |
|---------|-----------|
| `txtUsername` | Nhập tên đăng nhập |
| `txtPassword` | Nhập mật khẩu (mặc định ẩn `*`) |
| `chkShowPassword` | Tick → hiện mật khẩu; bỏ tick → ẩn |
| `btnLogin` | Đăng nhập + Validation (phím **Enter**) |
| `btnExit` | Thoát ứng dụng (phím **Esc**) |
| `errorProvider` | Hiện lỗi khi bỏ trống Username hoặc Password |

## Cách chạy

```bash
dotnet run
```

## Yêu cầu

- .NET 10.0 SDK
- Windows OS (Windows Forms)
