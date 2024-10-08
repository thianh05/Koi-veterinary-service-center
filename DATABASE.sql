create Database KVSC;
use KVSC;
CREATE TABLE TrungTam (
     TenTrungTam VARCHAR(100),
     DiaChi VARCHAR(255),
     Hotline VARCHAR(15),
     MoTa TEXT
);

INSERT INTO TrungTam (TenTrungTam, DiaChi, Hotline, Mota)
VALUES ('Trung Tâm Thú Y Cá Koi', '123 Đường Bạch Dằngd, Quận 1, TP. HCM', '091234567', 'Trung tâm Thú Y Cá Koi chuyên cung cấp các các dịch vụ khám bệnh, chữa bệnh cá koi chuyên nghiệp.');
CREATE TABLE DichVuThuY (
    MaDichVu INT PRIMARY KEY AUTO_INCREMENT,
    TenDichVu VARCHAR(100),
    MoTa TEXT
);

INSERT INTO DichVuThuY (TenDichVu, MoTa)
VALUES 
('Khám sức khỏe định kì', 'Dịch vụ khám sức khỏe định kì cho cá Koi.'),
('Chuẩn đoán bệnh', 'Dịch vụ chuẩn đoán bệnh cho cá Koi.'),
('Điều trị', 'Dịch vụ điều trị bệnh cho cá Koi.'),
('Tư vấn dinh dưỡng', 'Dịch vụ tư vấn dinh dưỡng cho cá Koi.'),
('Tư vấn về hồi nuôi, chất lượng nước, cải tạo và bảo trì hồ', 'Dịch vụ tư vấn về hồi nuôi, chất lượng nước, cải tạo và bảo trì hồ cho cá Koi.'),
('Kê đơn thuốc', 'Dịch vụ kê đơn thuốc cho cá Koi.'),
('Dịch vụ điều trị tại nhà', 'Dịch vụ điều trị tại nhà cho cá Koi.');
CREATE TABLE BacSi (
    TenBacSi VARCHAR(100),
    KinhNghiem int,
    Email VARCHAR(100)
);
INSERT INTO BacSi (TenBacSi, KinhNghiem, Email)
VALUES ('Đặng Thành Phát', 10, 'dangthanhphat@gmail.com'),
       ('Trần Thị Bình', 5 , 'tranthibinh@gmail.com'),
       ('Lê Văn Vũ', 20, 'levanvu@gmail.com');
 CREATE TABLE KhachHang(
    TenKhachHang VARCHAR(255),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(255)
);       
INSERT INTO KhachHang (TenKhachHang, SoDienThoai, Email)
VALUES ('Lê Văn Luyện', '0123456789', 'levanluyen6@gmail.com'),
       ('Trần Văn Cam', '0987654321', 'tranvancam22@gmail.com'),
       ('Trần Quốc Sơn', '0135798642', 'tranquocsoncute@gmail.com');   
CREATE TABLE LichHen(
     TenKhachHang VARCHAR(100),
     TenBacSi VARCHAR(100),
     NgayHen DATETIME,
     TrangThai CHAR(50)
); 
INSERT INTO LichHen (TenKhachHang, TenBacSi, NgayHen, TrangThai)
VALUES ('Lê Văn Luyện', 'Đặng Thành Phát', '2024-07-10 09:54:34', 'Pending'),
       ('Trần Văn Cam', 'Trần Thị Bình', '2024-07-4 12:39:22', 'In Progress'),
       ('Trần Quốc Sơn', 'Lê Văn Vũ','2024-06-4 11:22:53','Completed');
CREATE TABLE BangGia(
      TenDichVu VARCHAR(100),
      Gia DECIMAL(10, 2)
);
INSERT INTO BangGia (TenDichVu, Gia)
VALUES('Dịch vụ khám sức khỏe định kì cho cá Koi.', 1000000.00), 
      ('Dịch vụ chuẩn đoán bệnh cho cá Koi.',500000.00),
      ('Dịch vụ điều trị bệnh cho cá Koi.', 10000000.00),
      ('Dịch vụ tư vấn dinh dưỡng cho cá Koi.', 300000.00),
      ('Dịch vụ tư vấn về hồi nuôi, chất lượng nước, cải tạo và bảo trì hồ cho cá Koi.', 150000.00),
      ('Dịch vụ kê đơn thuốc cho cá Koi.',1000000.00),
      ('Dịch vụ điều trị tại nhà cho cá Koi.',15000000.00);
CREATE TABLE FAQ (
    FAQID INT PRIMARY KEY AUTO_INCREMENT,
    CauHoi TEXT,
    CauTraLoi TEXT
);

INSERT INTO FAQ (CauHoi, CauTraLoi)
VALUES 
('Trung tâm cung cấp những dịch vụ nào?', 'Trung tâm cung cấp các dịch vụ khám bệnh, chữa bệnh, tư vấn dinh dưỡng, và nhiều dịch vụ khác cho cá Koi.'),
('Chi phí cho mỗi dịch vụ là bao nhiêu?', 'Chi phí cho mỗi dịch vụ khác nhau, vui lòng tham khảo bảng giá trên trang web của chúng tôi.'),
('Làm thế nào để đặt lịch hẹn với bác sĩ?', 'Bạn có thể đặt lịch hẹn qua điện thoại hoặc trực tiếp tại trung tâm.'),
('Địa chỉ của trung tâm là gì?', '123 Đường Bạch Đằng, Quận 1, TP. HCM.'),
('Giờ làm việc của trung tâm là khi nào?', 'Trung tâm mở cửa từ 8:00 sáng đến 6:00 chiều từ thứ Hai đến thứ Bảy.');

CREATE TABLE TinTuc (
    MaTinTuc INT PRIMARY KEY AUTO_INCREMENT,
    TieuDe VARCHAR(255),
    NoiDung TEXT,
    NgayDang DATE,
    TacGia VARCHAR(100)
);

INSERT INTO TinTuc (TieuDe, NoiDung, NgayDang, TacGia)
VALUES 
('Xuất khẩu thủy sản đạt 6,3 tỷ USD trong 8 tháng đầu năm', 
'Xuất khẩu thủy sản đạt 6,3 tỷ USD, tăng 9% so với cùng kỳ năm ngoái, với tôm, cá tra và cá ngừ đều tăng trưởng mạnh.',
 '2024-08-31', 'Nguyễn Văn An'),
('Phát triển nuôi trồng thủy sản theo hướng bền vững', 
'Cần Thơ đang phát triển nuôi trồng thủy sản theo hướng bền vững, 
tập trung vào các biện pháp bảo vệ môi trường và tăng cường chất lượng sản phẩm.', '2024-09-15', 'Trần Thị Bịnh'),
('Phân biệt các loại cá: cá basa, cá tra, cá hú và cá bông lau', 
'Hướng dẫn cách phân biệt các loại cá phổ biến như cá basa, cá tra, cá hú và cá bông lau.', 
'2024-10-01', 'Lê Văn Ơn');

SELECT * FROM LichHen
WHERE TenBacSi = @TenBacSi AND NgayHen = @NgayHen;
select * 
	from LichHen
    where TrangThai='completed';
ALTER TABLE LichHen
ADD HomeVisit BIT DEFAULT 0;