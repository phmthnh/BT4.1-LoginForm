# BT4.1 – Form Đăng Nhập (Login Form) chuẩn UX

> **Môn:** Lập trình Windows Forms với C# | **Framework:** .NET 10.0

## Mục tiêu
Xây dựng Login Form có **Validation ErrorProvider**, ẩn/hiện mật khẩu, gán `AcceptButton` / `CancelButton`.

## Tính năng

| Control | Chức năng |
|---------|-----------|
| `txtUsername` | Nhập tên đăng nhập |
| `txtPassword` | Nhập mật khẩu (mặc định ẩn `*`) |
| `chkShowPassword` | ✅ Tick → hiện mật khẩu / bỏ tick → ẩn |
| `btnLogin` | Đăng nhập + Validation · kích hoạt bằng phím **Enter** |
| `btnExit` | Thoát ứng dụng · kích hoạt bằng phím **Esc** |
| `errorProvider` | Hiện lỗi khi bỏ trống Username hoặc Password |

## Demo

![Login Form - Đăng nhập thành công](Screenshot%202026-09-23%20161706.png)

## Cách chạy

```bash
dotnet run
```

hoặc mở file `BT4_1_LoginForm.sln` bằng **Visual Studio 2022+** và nhấn `F5`.

## Yêu cầu hệ thống
- .NET 10.0 SDK
- Windows OS (Windows Forms)
- Visual Studio 2022 (khuyến nghị)
