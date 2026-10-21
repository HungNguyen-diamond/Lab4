==================================================
LAB 4. THIẾT KẾ WINFORMS VÀ ĐIỀU KHIỂN CƠ BẢN
Học phần: Lập trình .NET (IT3212)
Trường Đại học Công nghệ Đông Á - Khoa Công nghệ Thông tin
==================================================

THÔNG TIN SINH VIÊN
- Họ và tên : Nguyễn Tiến Hùng
- Mã sinh viên: 24000091
- Lớp : Lập trình .NET-1-1-26(N03)

--------------------------------------------------
1. MÔI TRƯỜNG
--------------------------------------------------
- Visual Studio
- Windows Forms App (.NET Framework 4.8), ngôn ngữ C#
- Tên project: Lab04_WinFormsBasic

--------------------------------------------------
2. CÁCH CHẠY
--------------------------------------------------
1. Mở file giải pháp (.sln) bằng Visual Studio 2022.
2. Nhấn Ctrl + Shift + B để build (phải báo Build succeeded).
3. Nhấn F5 để chạy. Chương trình mở Form menu "Lab 4 - Chọn bài".
4. Bấm vào nút của từng bài để mở Form tương ứng. Đóng Form bài
   thì quay về menu.

--------------------------------------------------
3. DANH SÁCH BÀI ĐÃ HOÀN THÀNH
--------------------------------------------------
Phần có hướng dẫn (Bài 1-5): thực hiện chung trên một Form
frmSinhVien (theo đúng thiết kế của đề, các bài dùng chung control).

Bài 1. Form thông tin sinh viên
       Nhập mã, họ tên, ngày sinh, giới tính, khoa; nút Hiển thị
       hiện thông tin bằng MessageBox.
Bài 2. Khởi tạo ComboBox và trạng thái Form
       Nạp danh sách khoa khi Form Load, chọn khoa đầu tiên làm mặc
       định, ComboBox ở chế độ DropDownList, mặc định chọn giới tính Nam.
Bài 3. Tính tuổi từ DateTimePicker
       Đổi ngày sinh thì tuổi hiện ngay trên Label (có xử lý trường
       hợp chưa đến sinh nhật trong năm).
Bài 4. Sở thích bằng CheckBox
       Chọn Đọc sách / Thể thao / Lập trình, nút Xem sở thích hiện
       danh sách đã chọn (hoặc "Chưa chọn").
Bài 5. Chọn ảnh đại diện
       Dùng OpenFileDialog chọn ảnh, hiện trong PictureBox (chế độ
       Zoom), có kiểm tra tệp tồn tại, hiện đường dẫn trong ô văn bản.

Bài 6.  frmMayTinh        - Máy tính bốn phép toán (cộng, trừ, nhân,
                            chia; báo lỗi khi nhập sai hoặc chia cho 0;
                            có nút Làm mới và Thoát).
Bài 7.  frmDangNhap       - Form đăng nhập (ghi nhớ đăng nhập, hiện/ẩn
                            mật khẩu).
Bài 8.  frmBMI            - Tính chỉ số BMI và phân loại bằng Label.

Bài 9.  frmDangKyHocPhan  - Đăng ký học phần bằng CheckedListBox, tính
                            tổng số tín chỉ.
Bài 10. frmPhieuNhap      - Phiếu nhập sản phẩm (mã, tên, loại, số
                            lượng, đơn giá, ngày nhập, ảnh, thành tiền).

Form menu: frmMenu - chọn bài để mở.

--------------------------------------------------
4. DỮ LIỆU THỬ
--------------------------------------------------
Bài 1-5 (frmSinhVien):
- Mã: 24000091 | Họ tên: Nguyễn Tiến Hùng | Khoa: Công nghệ thông tin
- Tính tuổi: chọn ngày sinh 26/10/2006 thì tuổi là 19 (tính đến
  21/10/2026, chưa đến sinh nhật).
- Sở thích: tích Đọc sách và Lập trình thì hiện "Đọc sách, Lập trình".
- Ảnh: chọn tệp PNG/JPG bất kỳ (có thể dùng ảnh trong thư mục Images).

Bài 6 (Máy tính):
- 10 và 4: cộng = 14, trừ = 6, nhân = 40, chia = 2,5.
- Chia cho 0 hoặc nhập chữ: báo lỗi.

Bài 7 (Đăng nhập):
- Tài khoản đúng: admin / 123456
- Để trống hoặc sai thông tin: báo lỗi.

Bài 8 (BMI):
- 170 cm, 65 kg: BMI 22,5 - Bình thường.
- 170 cm, 50 kg: BMI 17,3 - Gầy.
- 170 cm, 70 kg: BMI 24,2 - Thừa cân.
- 170 cm, 85 kg: BMI 29,4 - Béo phì.
- Ngưỡng phân loại: dưới 18,5 gầy; 18,5 đến dưới 23 bình thường;
  23 đến dưới 25 thừa cân; từ 25 béo phì.

Bài 9 (Đăng ký học phần):
- Chọn "Lập trình .NET" (3) và "Cấu trúc dữ liệu và giải thuật" (4):
  tổng 7 tín chỉ, 2 môn.

Bài 10 (Phiếu nhập):
- Mã SP01, tên "Chuột không dây", loại Điện tử, số lượng 5,
  đơn giá 150000: thành tiền 750.000 VNĐ.

--------------------------------------------------
5. CẤU TRÚC THƯ MỤC NỘP
--------------------------------------------------
Lab4/
  Lab04_WinFormsBasic/     Mã nguồn project (build và chạy được)
  Anh_ket_qua/             Ảnh chụp kết quả từng bài (Bài 1-10)
  README.txt               Tệp này

--------------------------------------------------
6. GHI CHÚ
--------------------------------------------------
- Lớp SinhVien.cs lấy từ Lab 2 được thêm vào project.
- Bài 1-5 dùng chung một Form frmSinhVien để thống nhất tên control
  (txtMaSV, txtHoTen, dtpNgaySinh, cboKhoa, lblTuoi, chkDocSach,
  picAnh, ...).
- Dữ liệu đăng nhập ở Bài 7 chỉ là tài khoản mẫu để thử giao diện.