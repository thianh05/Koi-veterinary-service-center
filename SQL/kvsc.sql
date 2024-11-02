-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: kvsc
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bacsi`
-- Chọn bác sĩ theo yêu cầu và phân công bác sĩ
-- Dashboard & Report( và gồm bảng danhgia,lichhen,dichvu)
DROP TABLE IF EXISTS `bacsi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bacsi` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TenBacSi` varchar(255) DEFAULT NULL,
  `KinhNghiem` int DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Availability` enum('Rảnh','Bận') DEFAULT 'Rảnh',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bacsi`
--

LOCK TABLES `bacsi` WRITE;
/*!40000 ALTER TABLE `bacsi` DISABLE KEYS */;
INSERT INTO `bacsi` VALUES (1,'Đặng Thành Phát',10,'dangthanhphat@gmail.com','Rảnh'),(2,'Trần Thị Bình',5,'tranthibinh@gmail.com','Rảnh'),(3,'Lê Văn Vũ',20,'levanvu@gmail.com','Rảnh'),(4,'Nguyễn Kim Hiền',8,'nguyenkimhien@gmail.com','Rảnh'),(5,'Lê Cát Vũ',4,'lecatvu@gmail.com','Rảnh'),(6,'Trần Quốc Dũng',2,'tranquocdung@gmail.com','Rảnh'),(7,'Nguyễn Thành Danh',3,'nguyenthanhdanh@gmail.com','Rảnh'),(8,'Nguyễn Hải Đăng',6,'dangnguyen@gmail.com','Rảnh'),(9,'Trần Văn Duy',10,'tranvanduy8@gmail.com','Rảnh'),(10,'Hoàng Nhật Minh',1,'hoanbgnhatminh1@gamil.com','Rảnh'),(11,'Lê Duy Khánh',12,'leduykhanh2@gmail.com','Rảnh'),(12,'Nguyễn Phú Quốc',9,'nguyenphuquoc7@gmail.com','Rảnh'),(13,'Trần Đình Trọng',7,'trandinhtrong77@gmail.com','Rảnh'),(14,'Nguyễn Ngọc Ngân',2,'nguyenngocngan11@gmail.com','Bận'),(15,'Nguyễn Minh Hà',5,'minhha22@gmail.com','Rảnh'),(16,'Lê Bảo Đại',3,'lebaodai9@gmail.com','Rảnh'),(17,'Huỳnh Minh Đạt',6,'huynhminhdat2@gmail.com','Rảnh'),(18,'Lê Duy Minh',7,'leduyminh221@gmail.com','Rảnh'),(19,'Võ Quang Huy',9,'voquanghuy82@gmail.com','Rảnh'),(20,'Ngô Gia Lộc',1,'ngogialoc32@gmail.com','Rảnh'),(22,'Trần Thị Bình',5,'tranthibinh@gmail.com','Rảnh'),(23,'Lê Văn Vũ',20,'levanvu@gmail.com','Rảnh'),(24,'Nguyễn Kim Hiền',8,'nguyenkimhien@gmail.com','Rảnh'),(25,'Lê Cát Vũ',4,'lecatvu@gmail.com','Rảnh'),(26,'Trần Quốc Dũng',2,'tranquocdung@gmail.com','Rảnh'),(27,'Nguyễn Thành Danh',3,'nguyenthanhdanh@gmail.com','Rảnh'),(28,'Nguyễn Hải Đăng',6,'dangnguyen@gmail.com','Rảnh'),(29,'Trần Văn Duy',10,'tranvanduy8@gmail.com','Rảnh'),(30,'Hoàng Nhật Minh',1,'hoanbgnhatminh1@gamil.com','Rảnh'),(31,'Lê Duy Khánh',12,'leduykhanh2@gmail.com','Rảnh'),(32,'Nguyễn Phú Quốc',9,'nguyenphuquoc7@gmail.com','Rảnh'),(33,'Trần Đình Trọng',7,'trandinhtrong77@gmail.com','Rảnh'),(34,'Nguyễn Ngọc Ngân',2,'nguyenngocngan11@gmail.com','Bận'),(35,'Nguyễn Minh Hà',5,'minhha22@gmail.com','Rảnh'),(36,'Lê Bảo Đại',3,'lebaodai9@gmail.com','Rảnh'),(37,'Huỳnh Minh Đạt',6,'huynhminhdat2@gmail.com','Rảnh'),(38,'Lê Duy Minh',7,'leduyminh221@gmail.com','Rảnh'),(39,'Võ Quang Huy',9,'voquanghuy82@gmail.com','Rảnh'),(40,'Ngô Gia Lộc',1,'ngogialoc32@gmail.com','Rảnh');
/*!40000 ALTER TABLE `bacsi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `banggia`
--

DROP TABLE IF EXISTS `banggia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `banggia` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MaDichVu` int DEFAULT NULL,
  `Gia` decimal(18,0) DEFAULT NULL,
  `Phidichuyen` decimal(18,0) DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banggia`
--

LOCK TABLES `banggia` WRITE;
/*!40000 ALTER TABLE `banggia` DISABLE KEYS */;
INSERT INTO `banggia` VALUES (2,1,100000,0);
/*!40000 ALTER TABLE `banggia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chitietdonthuoc`
-- Quản lý quá trình đặt dịch vụ điều trị bệnh cho cá và kê đơn thuốc nếu cần ( và bảng dichvu )
-- Quản lý hồ sơ khách hàng, lịch sử đơn đặt dịch vụ ( và bảng khachhang và lichhen)
DROP TABLE IF EXISTS `chitietdonthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietdonthuoc` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DonthuocId` int unsigned DEFAULT NULL,
  `Tenthuoc` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `Lieuluong` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `hdsd` varchar(2000) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietdonthuoc`
--

LOCK TABLES `chitietdonthuoc` WRITE;
/*!40000 ALTER TABLE `chitietdonthuoc` DISABLE KEYS */;
/*!40000 ALTER TABLE `chitietdonthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chuandoanbenhcakoi`
--

DROP TABLE IF EXISTS `chuandoanbenhcakoi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chuandoanbenhcakoi` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `LichhenId` int DEFAULT '0',
  `NgayThang` datetime DEFAULT NULL,
  `ChuanDoan` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `DauHieu` text,
  `HinhThucDieuTri` text,
  `TenLoaiCaKoi` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `LichhenId_UNIQUE` (`LichhenId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chuandoanbenhcakoi`
--

LOCK TABLES `chuandoanbenhcakoi` WRITE;
/*!40000 ALTER TABLE `chuandoanbenhcakoi` DISABLE KEYS */;
/*!40000 ALTER TABLE `chuandoanbenhcakoi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chuandoantinhtrangnuoc`
--

DROP TABLE IF EXISTS `chuandoantinhtrangnuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chuandoantinhtrangnuoc` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `KhachhangId` int NOT NULL,
  `LichhenId` int NOT NULL,
  `NgayThang` date DEFAULT NULL,
  `PH` decimal(3,1) DEFAULT NULL,
  `DoCuongNuoc` decimal(5,2) DEFAULT NULL,
  `NhietDo` decimal(4,1) DEFAULT NULL,
  `TinhTrang` text,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chuandoantinhtrangnuoc`
--

LOCK TABLES `chuandoantinhtrangnuoc` WRITE;
/*!40000 ALTER TABLE `chuandoantinhtrangnuoc` DISABLE KEYS */;
/*!40000 ALTER TABLE `chuandoantinhtrangnuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dichvuthuy`
-- Quản lý quá trình đặt dịch vụ điều trị bệnh cho cá và kê đơn thuốc nếu cần (và bảng chitietdonthuoc ) )
-- Quản lý quá trình đặt dịch vụ để quản lý theo các bước ( và bảng lichhen)
-- Dashboard & Report( và gồm bảng danhgia,lichhen,bacsi)
DROP TABLE IF EXISTS `dichvuthuy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dichvuthuy` (
  `MaDichVu` int NOT NULL AUTO_INCREMENT,
  `TenDichVu` varchar(100) DEFAULT NULL,
  `MoTa` text,
  PRIMARY KEY (`MaDichVu`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dichvuthuy`
--

LOCK TABLES `dichvuthuy` WRITE;
/*!40000 ALTER TABLE `dichvuthuy` DISABLE KEYS */;
INSERT INTO `dichvuthuy` VALUES (1,'Khám sức khỏe định kì','Dịch vụ khám sức khỏe định kì cho cá Koi.'),(2,'Chuẩn đoán bệnh','Dịch vụ chuẩn đoán bệnh cho cá Koi.'),(3,'Điều trị','Dịch vụ điều trị bệnh cho cá Koi.'),(4,'Tư vấn dinh dưỡng','Dịch vụ tư vấn dinh dưỡng cho cá Koi.'),(5,'Tư vấn về hồi nuôi, chất lượng nước, cải tạo và bảo trì hồ','Dịch vụ tư vấn về hồi nuôi, chất lượng nước, cải tạo và bảo trì hồ cho cá Koi.'),(6,'Kê đơn thuốc','Dịch vụ kê đơn thuốc cho cá Koi.'),(7,'Dịch vụ điều trị tại nhà','Dịch vụ điều trị tại nhà cho cá Kois.');
/*!40000 ALTER TABLE `dichvuthuy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doitac`
--

DROP TABLE IF EXISTS `doitac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doitac` (
  `MaDoiTac` int NOT NULL AUTO_INCREMENT,
  `TenDoiTac` varchar(100) NOT NULL,
  `LoaiHinhHopTac` varchar(50) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `SoDienThoai` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Website` varchar(100) DEFAULT NULL,
  `GhiChu` text,
  PRIMARY KEY (`MaDoiTac`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doitac`
--

LOCK TABLES `doitac` WRITE;
/*!40000 ALTER TABLE `doitac` DISABLE KEYS */;
INSERT INTO `doitac` VALUES (1,'Công Ty TNHH Dược Phẩm ABC','Cung cấp thuốc','123 Đường ABC, Quận 1, TP.HCM','02812345678','contact@abcpharma.com','www.abcpharma.com','Chuyên cung cấp thuốc và dược phẩm dành cho thú y'),(2,'Công Ty TNHH Thủy Sản Vina','Cung cấp thức ăn cá','456 Đường XYZ, Quận 2, TP.HCM','02898765432','sales@vinasan.com','www.vinasan.com','Đối tác cung cấp thức ăn cho cá Koi'),(3,'Công Ty Cổ Phần Kỹ Thuật An Phú','Hỗ trợ kỹ thuật','789 Đường DEF, Quận 7, TP.HCM','02811223344','support@anphutech.com','www.anphutech.com','Chuyên hỗ trợ kỹ thuật, chăm sóc hồ cá Koi'),(4,'Công Ty TNHH Xây Dựng Nam Long','Thiết kế hồ cá','100 Đường GHI, Quận Bình Thạnh, TP.HCM','02855667788','info@namlong.com','www.namlong.com','Thiết kế và thi công hồ cá Koi');
/*!40000 ALTER TABLE `doitac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donthuoc`
--

DROP TABLE IF EXISTS `donthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donthuoc` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LichhenId` int DEFAULT NULL,
  `Mota` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donthuoc`
--

LOCK TABLES `donthuoc` WRITE;
/*!40000 ALTER TABLE `donthuoc` DISABLE KEYS */;
/*!40000 ALTER TABLE `donthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faq`
--

DROP TABLE IF EXISTS `faq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faq` (
  `FAQID` int NOT NULL AUTO_INCREMENT,
  `CauHoi` text,
  `CauTraLoi` text,
  PRIMARY KEY (`FAQID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faq`
--

LOCK TABLES `faq` WRITE;
/*!40000 ALTER TABLE `faq` DISABLE KEYS */;
INSERT INTO `faq` VALUES (1,'Trung tâm cung cấp những dịch vụ nào?','Trung tâm cung cấp các dịch vụ khám bệnh, chữa bệnh, tư vấn dinh dưỡng, và nhiều dịch vụ khác cho cá Koi.'),(2,'Chi phí cho mỗi dịch vụ là bao nhiêu?','Chi phí cho mỗi dịch vụ khác nhau, vui lòng tham khảo bảng giá trên trang web của chúng tôi.'),(3,'Làm thế nào để đặt lịch hẹn với bác sĩ?','Bạn có thể đặt lịch hẹn qua điện thoại hoặc trực tiếp tại trung tâm.'),(4,'Địa chỉ của trung tâm là gì?','123 Đường Bạch Đằng, Quận 1, TP. HCM.'),(5,'Giờ làm việc của trung tâm là khi nào?','Trung tâm mở cửa từ 8:00 sáng đến 6:00 chiều từ thứ Hai đến thứ Bảy.');
/*!40000 ALTER TABLE `faq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
-- Quản lý đánh giá của bác sĩ sau khi khám cho cá và nhận xét của bác sĩ về các dịch vụ khi cần
-- Quản lý rating, feedback
-- Dashboard & Report ( và gồm bảng lichhen,bacsi,dichvu)
DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feedback` (
  `FeedbackID` int NOT NULL AUTO_INCREMENT,
  `TenKhachHang` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `DanhGia` enum('Tệ','Trung bình','Khá','Tốt') DEFAULT NULL,
  `BinhLuan` text,
  `NgayPhanHoi` date DEFAULT NULL,
  PRIMARY KEY (`FeedbackID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
INSERT INTO `feedback` VALUES (1,'Lê Văn Luyện','levanluyen6@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-01'),(2,'Trần Văn Cam','tranvancam22@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-02'),(3,'Trần Quốc Sơn','tranquocsoncute@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-03'),(4,'Trần Văn Hậu','tranvanhau123@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-03'),(5,'Lê Văn Hợi','levanhoi45@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-01'),(6,'Nguyễn Văn An','nguyenvanan41@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-04'),(7,'Trần Thị Hên','tranthihen76@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-05'),(8,'Lê Văn Bảy','levanbay23@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-06'),(9,'Phạm Thị Hạnh','phamthihanh14@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-07'),(10,'Hoàng Văn Thụ','hoangvanthu56@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-08'),(11,'Nguyễn Thị Nhung','nguyenthinhung74@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-09'),(12,'Trần Văn Giang','tranvangiang78@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-10'),(13,'Lê Thị Phương','lethiphuong25@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-11'),(14,'Phạm Văn Hiếu','phamvanhieu42@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-12'),(15,'Hoàng Thị Tuấn','hoangthituan33@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-13'),(16,NULL,NULL,NULL,NULL,'2024-10-23');
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khachhang`
-- Quản lý hồ sơ khách hàng, lịch sử đơn đặt dịch vụ ( và bảng lichhen và chitietdonthuoc )

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khachhang` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TenKhachHang` varchar(255) DEFAULT NULL,
  `SoDienThoai` varchar(15) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES (1,'Lê Văn Luyện','0123456789','levanluyen6@gmail.com'),(2,'Trần Văn Cam','0987654321','tranvancam22@gmail.com'),(3,'Trần Thị Thúy','0778542321','tranthuy1@gmail.com'),(4,'Nguyễn Lê Đào','0977233321','daole666@gmail.com'),(5,'Vũ Cát Lượng','0988433621','luongvu255@gmail.com'),(6,'Nguyễn Gia Huy','0996334321','huynguyen771@gmail.com'),(7,'Trần Quốc Sơn','0135798642','tranquocsoncute@gmail.com'),(8,'Trần Thảo Nguyên','0185198242','nguyentran00@gmail.com'),(9,'Đàm Vĩnh Hưng','0881928379','damvinhhung00@gmail.com'),(10,'Hiếu Thứ Hai','0173829471','hieuthuhai12@gmail.com'),(11,'Trần Lả Lướt','0773624152','tranlaluot29@gmail.com'),(12,'Trần Nhân Tông','0283782919','trannhantong100@gmail.com'),(13,'Vũ Bảo Hà','0833728379','vubaoha02@gmail.com'),(14,'Phạm Minh Tuấn','0983321675','phamtuan123@gmail.com'),(15,'Lý Hoàng Nam','0935278621','hoangnamly@gmail.com'),(16,'Nguyễn Thị Hoa','0825462931','nguyenthihoa90@gmail.com'),(17,'Bùi Văn An','0998294372','anbuivan123@gmail.com'),(18,'Phạm Thị Lan','0973258719','lanphamthi1995@gmail.com'),(19,'Hoàng Duy Khánh','0851928472','khanhduyhoang@gmail.com'),(20,'Trần Văn Tài','0928275632','tranvan123tai@gmail.com');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lichhen`
-- Quản lý quá trình đặt dịch vụ tư vấn trực tuyến với bác sĩ thú y để tư vấn:
-- Quản lý quá trình đặt dịch vụ hẹn để bác sĩ thú y tới tận nhà đánh giá chất lượng hồ cá Koi và tư vấn cải thiện hồ cá đạt chuẩn
-- Quản lý quá trình đặt dịch vụ để quản lý theo các bước (và bảng dichvu )
-- Quản lý hồ sơ khách hàng, lịch sử đơn đặt dịch vụ ( và bảng khachhang va chitietdonthuoc )
-- Dashboard & Report( và gồm bảng danhgia,bacsi,dichvu)
DROP TABLE IF EXISTS `lichhen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lichhen` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `KhachhangId` int DEFAULT NULL,
  `BacsiId` int DEFAULT NULL,
  `DichVuId` int DEFAULT NULL,
  `Lichhen` datetime DEFAULT NULL,
  `Status` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `KhachhangId_UNIQUE` (`KhachhangId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lichhen`
--

LOCK TABLES `lichhen` WRITE;
/*!40000 ALTER TABLE `lichhen` DISABLE KEYS */;
/*!40000 ALTER TABLE `lichhen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taikhoan` (
  `Id` int NOT NULL AUTO_INCREMENT COMMENT 'Primary',
  `FullName` varchar(500) DEFAULT NULL,
  `Username` varchar(250) DEFAULT NULL,
  `Password` varchar(500) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taikhoan`
--

LOCK TABLES `taikhoan` WRITE;
/*!40000 ALTER TABLE `taikhoan` DISABLE KEYS */;
INSERT INTO `taikhoan` VALUES (1,'Admin','admin','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','2024-10-27 00:00:00');
/*!40000 ALTER TABLE `taikhoan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thanhtuu`
--

DROP TABLE IF EXISTS `thanhtuu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thanhtuu` (
  `MaThanhTuu` int NOT NULL AUTO_INCREMENT,
  `TenThanhTuu` varchar(255) NOT NULL,
  `MoTa` text,
  `NgayDatDuoc` date DEFAULT NULL,
  `GhiChu` text,
  PRIMARY KEY (`MaThanhTuu`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thanhtuu`
--

LOCK TABLES `thanhtuu` WRITE;
/*!40000 ALTER TABLE `thanhtuu` DISABLE KEYS */;
INSERT INTO `thanhtuu` VALUES (1,'Giải thưởng Trung tâm cá Koi xuất sắc 2023','Được vinh danh là trung tâm xuất sắc trong việc chăm sóc và nuôi dưỡng cá Koi năm 2023','2023-05-10','Giải thưởng do Hiệp hội Thủy sản trao tặng'),(2,'Đạt chuẩn quốc tế về chăm sóc cá Koi','Trung tâm đã đạt chứng nhận quốc tế về quy trình chăm sóc cá Koi','2022-08-15','Được cấp bởi tổ chức quốc tế'),(3,'Phát triển hệ thống hồ Koi hiện đại','Trung tâm đã phát triển và xây dựng thành công hệ thống hồ Koi hiện đại, đạt tiêu chuẩn kỹ thuật cao','2021-10-01','Dự án kéo dài trong 6 tháng'),(4,'Tăng trưởng đối tác lên 50%','Trong năm 2023, số lượng đối tác của trung tâm đã tăng trưởng 50% so với năm trước','2023-12-20','Kết quả hợp tác quốc tế'),(5,'Kỷ lục hồ Koi lớn nhất Việt Nam','Trung tâm xây dựng hồ Koi lớn nhất Việt Nam với diện tích 500m2','2024-01-30','Hồ đạt kỷ lục quốc gia'),(6,'Chứng nhận đạt tiêu chuẩn môi trường xanh','Trung tâm đã được cấp chứng nhận về môi trường xanh, bảo vệ động vật và thực vật','2024-04-05','Chứng nhận từ tổ chức bảo vệ môi trường quốc tế'),(7,'Thành viên chính thức của Hiệp hội Thủy sản toàn cầu','Trung tâm trở thành thành viên chính thức của hiệp hội quốc tế, tạo cơ hội hợp tác rộng rãi','2023-11-15','Một bước tiến lớn trong quan hệ quốc tế'),(8,'Chương trình nghiên cứu khoa học về cá Koi','Trung tâm đã hoàn thành nghiên cứu kéo dài 2 năm về đặc điểm sinh học của cá Koi','2023-09-30','Nghiên cứu được công bố trên tạp chí khoa học quốc tế'),(9,'Tổ chức hội thảo quốc tế về chăm sóc cá Koi','Trung tâm đã tổ chức thành công hội thảo quốc tế, thu hút nhiều chuyên gia trong ngành','2024-06-10','Một sự kiện quan trọng cho ngành thủy sản'),(10,'Giải thưởng đổi mới công nghệ trong nuôi trồng thủy sản','Được vinh danh nhờ áp dụng công nghệ mới trong việc nuôi trồng cá Koi','2024-07-20','Giải thưởng từ tổ chức công nghệ quốc tế');
/*!40000 ALTER TABLE `thanhtuu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tintuc`
--

DROP TABLE IF EXISTS `tintuc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tintuc` (
  `MaTinTuc` int NOT NULL AUTO_INCREMENT,
  `TieuDe` varchar(255) DEFAULT NULL,
  `NoiDung` text,
  `NgayDang` date DEFAULT NULL,
  `TacGia` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`MaTinTuc`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tintuc`
--

LOCK TABLES `tintuc` WRITE;
/*!40000 ALTER TABLE `tintuc` DISABLE KEYS */;
INSERT INTO `tintuc` VALUES (1,'Xuất khẩu thủy sản đạt 6,3 tỷ USD trong 8 tháng đầu năm','Xuất khẩu thủy sản đạt 6,3 tỷ USD, tăng 9% so với cùng kỳ năm ngoái, với tôm, cá tra và cá ngừ đều tăng trưởng mạnh.','2024-08-31','Nguyễn Văn An'),(2,'Phát triển nuôi trồng thủy sản theo hướng bền vững','Cần Thơ đang phát triển nuôi trồng thủy sản theo hướng bền vững, \ntập trung vào các biện pháp bảo vệ môi trường và tăng cường chất lượng sản phẩm.','2024-09-15','Trần Thị Bịnh'),(3,'Phân biệt các loại cá: cá basa, cá tra, cá hú và cá bông lau','Hướng dẫn cách phân biệt các loại cá phổ biến như cá basa, cá tra, cá hú và cá bông lau.','2024-10-01','Lê Văn Ơn');
/*!40000 ALTER TABLE `tintuc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trungtam`
--

DROP TABLE IF EXISTS `trungtam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trungtam` (
  `TenTrungTam` varchar(100) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `Hotline` varchar(15) DEFAULT NULL,
  `MoTa` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trungtam`
--

LOCK TABLES `trungtam` WRITE;
/*!40000 ALTER TABLE `trungtam` DISABLE KEYS */;
INSERT INTO `trungtam` VALUES ('Trung Tâm Thú Y Cá Koi','123 Đường Bạch Đằng, Quận 1, TP. HCM','091234567','Trung tâm Thú Y Cá Koi chuyên cung cấp các các dịch vụ khám bệnh, chữa bệnh cá koi chuyên nghiệp.');
/*!40000 ALTER TABLE `trungtam` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-01 16:47:19
