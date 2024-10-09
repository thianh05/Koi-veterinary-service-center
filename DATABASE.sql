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
       ('Lê Văn Vũ', 20, 'levanvu@gmail.com'),
       ('Nguyễn Kim Hiền', 8, 'nguyenkimhien@gmail.com'),
	   ('Lê Cát Vũ', 4, 'lecatvu@gmail.com'),
	   ('Trần Quốc Dũng', 2, 'tranquocdung@gmail.com'),
	   ('Nguyễn Thành Danh', 3, 'nguyenthanhdanh@gmail.com'),
       ('Nguyễn Hải Đăng',6,'dangnguyen@gmail.com'),
       ('Trần Văn Duy',10,'tranvanduy8@gmail.com'),
       ('Hoàng Nhật Minh',1,'hoanbgnhatminh1@gamil.com'),
       ('Lê Duy Khánh',12,'leduykhanh2@gmail.com'),
       ('Nguyễn Phú Quốc',9,'nguyenphuquoc7@gmail.com'),
       ('Trần Đình Trọng',7,'trandinhtrong77@gmail.com'),
       ('Nguyễn Ngọc Ngân',2,'nguyenngocngan11@gmail.com'),
       ('Nguyễn Minh Hà',5,'minhha22@gmail.com'),
       ('Lê Bảo Đại',3,'lebaodai9@gmail.com'),
       ('Huỳnh Minh Đạt',6,'huynhminhdat2@gmail.com'),
       ('Lê Duy Minh',7,'leduyminh221@gmail.com'),
       ('Võ Quang Huy',9,'voquanghuy82@gmail.com'),
       ('Ngô Gia Lộc',1,'ngogialoc32@gmail.com');
       
 CREATE TABLE KhachHang(
    TenKhachHang VARCHAR(255),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(255)
);       

INSERT INTO KhachHang (TenKhachHang, SoDienThoai, Email)
VALUES ('Lê Văn Luyện', '0123456789', 'levanluyen6@gmail.com'),
       ('Trần Văn Cam', '0987654321', 'tranvancam22@gmail.com'),
       ('Trần Thị Thúy', '0778542321', 'tranthuy1@gmail.com'),
       ('Nguyễn Lê Đào', '0977233321', 'daole666@gmail.com'),
       ('Vũ Cát Lượng', '0988433621', 'luongvu255@gmail.com'),
       ('Nguyễn Gia Huy', '0996334321', 'huynguyen771@gmail.com'),
       ('Trần Quốc Sơn','0135798642', 'tranquocsoncute@gmail.com'),
       ('Trần Thảo Nguyên', '0185198242', 'nguyentran00@gmail.com'),
       ('Đàm Vĩnh Hưng', '0881928379', 'damvinhhung00@gmail.com'),
       ('Hiếu Thứ Hai', '0173829471','hieuthuhai12@gmail.com'),
       ('Trần Lả Lướt', '0773624152','tranlaluot29@gmail.com'),
       ('Trần Nhân Tông','0283782919', 'trannhantong100@gmail.com'),
       ('Vũ Bảo Hà','0833728379','vubaoha02@gmail.com'),
       ('Phạm Minh Tuấn', '0983321675', 'phamtuan123@gmail.com'),
	   ('Lý Hoàng Nam', '0935278621', 'hoangnamly@gmail.com'),
	   ('Nguyễn Thị Hoa', '0825462931', 'nguyenthihoa90@gmail.com'),
	   ('Bùi Văn An', '0998294372', 'anbuivan123@gmail.com'),
	   ('Phạm Thị Lan', '0973258719', 'lanphamthi1995@gmail.com'),
	   ('Hoàng Duy Khánh', '0851928472', 'khanhduyhoang@gmail.com'),
	   ('Trần Văn Tài', '0928275632', 'tranvan123tai@gmail.com');
       
CREATE TABLE LichHen(
     TenKhachHang VARCHAR(100),
     TenBacSi VARCHAR(100),
     NgayHen DATETIME,
     TrangThai CHAR(50),
     HomeVisit BIT DEFAULT 0
); 

INSERT INTO LichHen (TenKhachHang, TenBacSi, NgayHen, TrangThai, HomeVisit)
VALUES ('Lê Văn Luyện', 'Đặng Thành Phát', '2024-07-10 09:54:34', 'In Progress', 1),
       ('Trần Văn Cam', 'Trần Thị Bình', '2024-07-04 12:39:22', 'In Progress', 0),
       ('Trần Quốc Sơn', 'Lê Văn Vũ','2024-06-4 11:22:53','Completed', 1),
       ('Trần Thị Thúy','Nguyễn Kim Hiền' , '2024-06-10 11:22:53','Completed',1),
       ('Nguyễn Lê Đào', 'Lê Cát Vũ', '2024-07-15 09:02:32','Pending', 0),
       ('Vũ Cát Lượng', 'Trần Quốc Dũng', '2024-04-20 16:15:28','Completed',1),
       ('Nguyễn Gia Huy', 'Nguyễn Thành Danh', '2024-07-3 19:22:08','In Progress',0),
	   ('Trần Thảo Nguyên', 'Nguyễn Hải Đăng', '2024-03-21 13:01:42','Completed',1),
       ('Đàm Vĩnh Hưng', 'Trần Văn Duy', '2024-08-10 09:00:00','Completed',1),
       ('Hiếu Thứ Hai', 'Hoàng Nhật Minh', '2024-08-20 09:30:00','In Progress',0),
       ('Trần Lả Lướt', 'Lê Duy Khánh', '2024-10-20 12:30:00','In Progress' ,1),
       ('Trần Nhân Tông', 'Nguyễn Phú Quốc', '2024-10-11 08:00:00','Completed',1),
       ('Vũ Bảo Hà', 'Trần Đình Trọng', '2024-07-10 09:54:34', 'In Progress', 1),
       ('Phạm Minh Tuấn', 'Nguyễn Ngọc Ngân', '2024-07-04 12:39:22', 'In Progress', 0),
       ('Lý Hoàng Nam', 'Nguyễn Minh Hà', '2024-06-04 11:22:53', 'Completed', 1),
       ('Nguyễn Thị Hoa', 'Lê Bảo Đại', '2024-06-10 11:22:53', 'Completed', 1),
       ('Bùi Văn An', 'Huỳnh Minh Đạt', '2024-07-15 09:02:32', 'Pending', 0),
       ('Phạm Thị Lan', 'Lê Duy Minh', '2024-04-20 16:15:28', 'Completed', 1),
       ('Hoàng Duy Khánh', 'Võ Quang Huy', '2024-07-03 19:22:08', 'In Progress', 0),
       ('Trần Văn Tài', 'Ngô Gia Lộc', '2024-03-21 13:01:42', 'Completed', 1);
       
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

CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY AUTO_INCREMENT,
    TenKhachHang VARCHAR(255),
    Email VARCHAR(255),
    DanhGia ENUM('Tệ', 'Trung bình', 'Khá', 'Tốt'),
    BinhLuan TEXT,
    NgayPhanHoi DATE
);

INSERT INTO Feedback (TenKhachHang, Email, DanhGia, BinhLuan, NgayPhanHoi)
VALUES 
('Lê Văn Luyện', 'levanluyen6@gmail.com', 'Tốt', 'Dịch vụ rất tốt, tôi rất hài lòng.', '2024-10-01'),
('Trần Văn Cam', 'tranvancam22@gmail.com', 'Khá', 'Dịch vụ khá tốt, nhưng cần cải thiện thêm.', '2024-10-02'),
('Trần Quốc Sơn', 'tranquocsoncute@gmail.com', 'Trung bình', 'Dịch vụ trung bình, cần cải thiện nhiều.', '2024-10-03'),
('Trần Văn Hậu', 'tranvanhau123@gmail.com', 'Tốt', 'Dịch vụ ok, có cải thiện nhiều.', '2024-10-03'),
('Lê Văn Hợi', 'levanhoi45@gmail.com', 'Tốt', 'Dịch vụ rất tốt, tôi rất hài lòng.', '2024-10-01'),
('Nguyễn Văn An', 'nguyenvanan41@gmail.com', 'Tốt', 'Dịch vụ rất tốt, tôi rất hài lòng.', '2024-10-04'),
('Trần Thị Hên', 'tranthihen76@gmail.com', 'Khá', 'Dịch vụ khá tốt, nhưng cần cải thiện thêm.', '2024-10-05'),
('Lê Văn Bảy', 'levanbay23@gmail.com', 'Trung bình', 'Dịch vụ trung bình, cần cải thiện nhiều.', '2024-10-06'),
('Phạm Thị Hạnh', 'phamthihanh14@gmail.com', 'Tốt', 'Dịch vụ ok, có cải thiện nhiều.', '2024-10-07'),
('Hoàng Văn Thụ', 'hoangvanthu56@gmail.com', 'Tốt', 'Dịch vụ rất tốt, tôi rất hài lòng.', '2024-10-08'),
('Nguyễn Thị Nhung', 'nguyenthinhung74@gmail.com', 'Khá', 'Dịch vụ khá tốt, nhưng cần cải thiện thêm.', '2024-10-09'),
('Trần Văn Giang', 'tranvangiang78@gmail.com', 'Trung bình', 'Dịch vụ trung bình, cần cải thiện nhiều.', '2024-10-10'),
('Lê Thị Phương', 'lethiphuong25@gmail.com', 'Tốt', 'Dịch vụ ok, có cải thiện nhiều.', '2024-10-11'),
('Phạm Văn Hiếu', 'phamvanhieu42@gmail.com', 'Tốt', 'Dịch vụ rất tốt, tôi rất hài lòng.', '2024-10-12'),
('Hoàng Thị Tuấn', 'hoangthituan33@gmail.com', 'Khá', 'Dịch vụ khá tốt, nhưng cần cải thiện thêm.', '2024-10-13');

SELECT * 
   FROM LichHen
    WHERE TenBacSi = @TenBacSi 
    AND NgayHen = @NgayHen;   
select *
 from LichHen
  where TrangThai='complete';
UPDATE LichHen
SET TrangThai = 'In Progress' 
WHERE TenKhachHang = @TenKhachHang AND TenBacSi = @TenBacSi AND NgayHen = @NgayHen;
select *
from LichHen
where TrangThai = 'In Progress';
UPDATE LichHen
SET TrangThai = 'Completed'
WHERE TenKhachHang = @TenKhachHang AND TenBacSi = @TenBacSi AND NgayHen = @NgayHen;
select *
from LichHen
where TrangThai = 'Completed';
SET SQL_SAFE_UPDATES = 0;

SELECT * 
FROM Feedback;
SELECT * 
FROM Lichhen;
SELECT * 
FROM FAQ;
SELECT * 
FROM Tintuc;
SELECT * 
FROM Banggia;
SELECT * 
FROM Khachhang;
SELECT * 
FROM Bacsi;
SELECT * 
FROM DichVuThuY;








