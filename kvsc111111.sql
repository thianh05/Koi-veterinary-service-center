-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: kvsc1
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
--

DROP TABLE IF EXISTS `bacsi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bacsi` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TenBacSi` varchar(255) DEFAULT NULL,
  `KinhNghiem` int DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Availability` enum('Rảnh','Bận') DEFAULT 'Rảnh',
  `Noidung` varchar(500) DEFAULT NULL,
  `Sodienthoai` varchar(45) DEFAULT '0997752127',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bacsi`
--

LOCK TABLES `bacsi` WRITE;
/*!40000 ALTER TABLE `bacsi` DISABLE KEYS */;
INSERT INTO `bacsi` VALUES (1,'Đặng Thành Phát',10,'dangthanhphat@gmail.com','Rảnh','a','0997752127'),(2,'Trần Thị Bình',5,'tranthibinh@gmail.com','Rảnh','a','0997752127'),(3,'Lê Văn Vũ',20,'levanvu@gmail.com','Rảnh','a','0997752127'),(4,'Nguyễn Kim Hiền',8,'nguyenkimhien@gmail.com','Rảnh','a','0997752127'),(5,'Lê Cát Vũ',4,'lecatvu@gmail.com','Rảnh','a','0997752127'),(6,'Trần Quốc Dũng',2,'tranquocdung@gmail.com','Rảnh','a','0997752127'),(7,'Nguyễn Thành Danh',3,'nguyenthanhdanh@gmail.com','Rảnh','a','0997752127'),(8,'Nguyễn Hải Đăng',6,'dangnguyen@gmail.com','Rảnh','a','0997752127'),(9,'Trần Văn Duy',10,'tranvanduy8@gmail.com','Rảnh','a','0997752127'),(10,'Hoàng Nhật Minh',1,'hoanbgnhatminh1@gamil.com','Rảnh','a','0997752127'),(11,'Lê Duy Khánh',12,'leduykhanh2@gmail.com','Rảnh','a','0997752127'),(12,'Nguyễn Phú Quốc',9,'nguyenphuquoc7@gmail.com','Rảnh','a','0997752127'),(13,'Trần Đình Trọng',7,'trandinhtrong77@gmail.com','Rảnh','a','0997752127'),(14,'Nguyễn Ngọc Ngân',2,'nguyenngocngan11@gmail.com','Bận','a','0997752127'),(15,'Nguyễn Minh Hà',5,'minhha22@gmail.com','Rảnh','a','0997752127'),(16,'Lê Bảo Đại',3,'lebaodai9@gmail.com','Rảnh','a','0997752127'),(17,'Huỳnh Minh Đạt',6,'huynhminhdat2@gmail.com','Rảnh','a','0997752127'),(18,'Lê Duy Minh',7,'leduyminh221@gmail.com','Rảnh','a','0997752127'),(19,'Võ Quang Huy',9,'voquanghuy82@gmail.com','Rảnh','a','0997752127'),(22,'Trần Thị Bình',5,'tranthibinh@gmail.com','Rảnh','a','0997752127'),(23,'Lê Văn Vũ',20,'levanvu@gmail.com','Rảnh','a','0997752127'),(24,'Nguyễn Kim Hiền',8,'nguyenkimhien@gmail.com','Rảnh','a','0997752127'),(25,'Lê Cát Vũ',4,'lecatvu@gmail.com','Rảnh','a','0997752127'),(26,'Trần Quốc Dũng',2,'tranquocdung@gmail.com','Rảnh','a','0997752127'),(27,'Nguyễn Thành Danh',3,'nguyenthanhdanh@gmail.com','Rảnh','a','0997752127'),(28,'Nguyễn Hải Đăng',6,'dangnguyen@gmail.com','Rảnh','a','0997752127'),(29,'Trần Văn Duy',10,'tranvanduy8@gmail.com','Rảnh','a','0997752127'),(30,'Hoàng Nhật Minh',1,'hoanbgnhatminh1@gamil.com','Rảnh','a','0997752127'),(31,'Lê Duy Khánh',12,'leduykhanh2@gmail.com','Rảnh','a','0997752127'),(32,'Nguyễn Phú Quốc',9,'nguyenphuquoc7@gmail.com','Rảnh','a','0997752127'),(33,'Trần Đình Trọng',7,'trandinhtrong77@gmail.com','Rảnh','a','0997752127'),(34,'Nguyễn Ngọc Ngân',2,'nguyenngocngan11@gmail.com','Bận','a','0997752127'),(35,'Nguyễn Minh Hà',5,'minhha22@gmail.com','Rảnh','a','0997752127'),(36,'Lê Bảo Đại',3,'lebaodai9@gmail.com','Rảnh','a','0997752127'),(37,'Huỳnh Minh Đạt',6,'huynhminhdat2@gmail.com','Rảnh','a','0997752127'),(38,'Lê Duy Minh',7,'leduyminh221@gmail.com','Rảnh','a','0997752127'),(39,'Võ Quang Huy',9,'voquanghuy82@gmail.com','Rảnh','a','0997752127'),(40,'Ngô Gia Lộc',1,'ngogialoc32@gmail.com','Rảnh','T2-T6: 8h30 - 17h30\r\nT7-CN: 9h - 17h','0997752127');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banggia`
--

LOCK TABLES `banggia` WRITE;
/*!40000 ALTER TABLE `banggia` DISABLE KEYS */;
INSERT INTO `banggia` VALUES (1,1,50000,20000);
/*!40000 ALTER TABLE `banggia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chuandoanbenhcakoi`
--

DROP TABLE IF EXISTS `chuandoanbenhcakoi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chuandoanbenhcakoi` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LichhenId` int DEFAULT '0',
  `NgayThang` datetime DEFAULT NULL,
  `ChuanDoan` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `DauHieu` text,
  `HinhThucDieuTri` text,
  `TenLoaiCaKoi` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `LichhenId_UNIQUE` (`LichhenId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chuandoanbenhcakoi`
--

LOCK TABLES `chuandoanbenhcakoi` WRITE;
/*!40000 ALTER TABLE `chuandoanbenhcakoi` DISABLE KEYS */;
INSERT INTO `chuandoanbenhcakoi` VALUES (1,1,'2024-11-02 16:43:00','Nấm vi sinh','Có nấm trên thân cá','Điều trị bằng thuốc vi sinh','Cá koi No1');
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
  `LichhenId` int NOT NULL,
  `NgayThang` datetime DEFAULT NULL,
  `PH` decimal(3,1) DEFAULT NULL,
  `DoCuongNuoc` decimal(5,2) DEFAULT NULL,
  `NhietDo` decimal(4,1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chuandoantinhtrangnuoc`
--

LOCK TABLES `chuandoantinhtrangnuoc` WRITE;
/*!40000 ALTER TABLE `chuandoantinhtrangnuoc` DISABLE KEYS */;
INSERT INTO `chuandoantinhtrangnuoc` VALUES (21,1,'2024-11-02 00:00:00',7.0,25.00,30.0);
/*!40000 ALTER TABLE `chuandoantinhtrangnuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dichvuthuy`
--

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
-- Table structure for table `donthuoc`
--

DROP TABLE IF EXISTS `donthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donthuoc` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LichhenId` int unsigned DEFAULT NULL,
  `Tenthuoc` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `Lieuluong` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `hdsd` varchar(2000) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donthuoc`
--

LOCK TABLES `donthuoc` WRITE;
/*!40000 ALTER TABLE `donthuoc` DISABLE KEYS */;
INSERT INTO `donthuoc` VALUES (1,1,'Vi sinh loại 1','20','20ml trên / 1 tuần vệ sinh bể cá...');
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feedback` (
  `FeedbackID` int NOT NULL AUTO_INCREMENT,
  `TenKhachHang` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `DanhGia` enum('Tệ','Trung bình','Khá','Tốt') DEFAULT NULL,
  `BinhLuan` text,
  `NgayPhanHoi` datetime DEFAULT NULL,
  PRIMARY KEY (`FeedbackID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
INSERT INTO `feedback` VALUES (1,'Lê Văn Luyện','levanluyen6@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-01 00:00:00'),(2,'Trần Văn Cam','tranvancam22@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-02 00:00:00'),(3,'Trần Quốc Sơn','tranquocsoncute@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-03 00:00:00'),(4,'Trần Văn Hậu','tranvanhau123@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-03 00:00:00'),(5,'Lê Văn Hợi','levanhoi45@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-01 00:00:00'),(6,'Nguyễn Văn An','nguyenvanan41@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-04 00:00:00'),(7,'Trần Thị Hên','tranthihen76@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-05 00:00:00'),(8,'Lê Văn Bảy','levanbay23@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-06 00:00:00'),(9,'Phạm Thị Hạnh','phamthihanh14@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-07 00:00:00'),(10,'Hoàng Văn Thụ','hoangvanthu56@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-08 00:00:00'),(11,'Nguyễn Thị Nhung','nguyenthinhung74@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-09 00:00:00'),(12,'Trần Văn Giang','tranvangiang78@gmail.com','Trung bình','Dịch vụ trung bình, cần cải thiện nhiều.','2024-10-10 00:00:00'),(13,'Lê Thị Phương','lethiphuong25@gmail.com','Tốt','Dịch vụ ok, có cải thiện nhiều.','2024-10-11 00:00:00'),(14,'Phạm Văn Hiếu','phamvanhieu42@gmail.com','Tốt','Dịch vụ rất tốt, tôi rất hài lòng.','2024-10-12 00:00:00'),(15,'Hoàng Thị Tuấn','hoangthituan33@gmail.com','Khá','Dịch vụ khá tốt, nhưng cần cải thiện thêm.','2024-10-13 00:00:00'),(16,NULL,NULL,NULL,NULL,'2024-10-23 00:00:00'),(17,'Phạm Huy Tối','huytoi@gmail.com','Khá','Nói chung dịch vụ mức khá vì xử lý hơi mất thời gian chờ một chút còn lại thì mọi thứ oke ','2024-11-03 15:09:27'),(18,'Phạm Huy Tối','huytoi@gmail.com','Tốt','Khá oke nhé ','2024-11-03 15:15:16'),(19,'Phạm Huy Tối','huytoi@gmail.com','Tốt','oke ạ','2024-11-03 15:16:55'),(20,'Phạm Huy Tối','huytoi@gmail.com','Tốt','oke lắm nhé','2024-11-03 15:21:46'),(21,'Phạm Huy Tối','huytoi@gmail.com','Khá','Nói chung dịch vụ mức khá vì xử lý hơi mất thời gian chờ một chút còn lại thì mọi thứ oke ','2024-11-03 15:29:51'),(22,'Phạm Huy Tối','huytoi@gmail.com','Tốt','Nói chung dịch vụ mức khá vì xử lý hơi mất thời gian chờ một chút còn lại thì mọi thứ oke ','2024-11-03 15:43:54');
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khachhang` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TenKhachHang` varchar(255) DEFAULT NULL,
  `SoDienThoai` varchar(15) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES (1,'Lê Văn Luyện','0123456789','levanluyen6@gmail.com'),(2,'Trần Văn Cam','0987654321','tranvancam22@gmail.com'),(3,'Trần Thị Thúy','0778542321','tranthuy1@gmail.com'),(4,'Nguyễn Lê Đào','0977233321','daole666@gmail.com'),(5,'Vũ Cát Lượng','0988433621','luongvu255@gmail.com'),(6,'Nguyễn Gia Huy','0996334321','huynguyen771@gmail.com'),(7,'Trần Quốc Sơn','0135798642','tranquocsoncute@gmail.com'),(8,'Trần Thảo Nguyên','0185198242','nguyentran00@gmail.com'),(9,'Đàm Vĩnh Hưng','0881928379','damvinhhung00@gmail.com'),(10,'Hiếu Thứ Hai','0173829471','hieuthuhai12@gmail.com'),(11,'Trần Lả Lướt','0773624152','tranlaluot29@gmail.com'),(12,'Trần Nhân Tông','0283782919','trannhantong100@gmail.com'),(13,'Vũ Bảo Hà','0833728379','vubaoha02@gmail.com'),(14,'Phạm Minh Tuấn','0983321675','phamtuan123@gmail.com'),(15,'Lý Hoàng Nam','0935278621','hoangnamly@gmail.com'),(16,'Nguyễn Thị Hoa','0825462931','nguyenthihoa90@gmail.com'),(17,'Bùi Văn An','0998294372','anbuivan123@gmail.com'),(18,'Phạm Thị Lan','0973258719','lanphamthi1995@gmail.com'),(19,'Hoàng Duy Khánh','0851928472','khanhduyhoang@gmail.com'),(20,'Trần Văn Tài','0928275632','tranvan123tai@gmail.com'),(22,'Phạm Huy Tối','0997752122','huytoi@gmail.com');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lichhen`
--

DROP TABLE IF EXISTS `lichhen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lichhen` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `KhachhangId` int DEFAULT NULL,
  `BacsiId` int DEFAULT NULL,
  `DichVuId` int DEFAULT NULL,
  `Ngayhen` datetime DEFAULT NULL,
  `Trangthai` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lichhen`
--

LOCK TABLES `lichhen` WRITE;
/*!40000 ALTER TABLE `lichhen` DISABLE KEYS */;
INSERT INTO `lichhen` VALUES (1,1,2,3,'2024-11-16 00:00:00',2),(2,22,1,0,'2024-11-06 00:00:00',0),(10,22,14,5,'2024-11-07 00:00:00',0),(11,22,13,6,'2024-11-14 00:00:00',2);
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
-- Table structure for table `tintuc`
--

DROP TABLE IF EXISTS `tintuc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tintuc` (
  `MaTinTuc` int NOT NULL AUTO_INCREMENT,
  `TieuDe` varchar(255) DEFAULT NULL,
  `NoiDung` longtext,
  `NgayDang` datetime DEFAULT NULL,
  `TacGia` varchar(100) DEFAULT NULL,
  `Hinhanh` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`MaTinTuc`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tintuc`
--

LOCK TABLES `tintuc` WRITE;
/*!40000 ALTER TABLE `tintuc` DISABLE KEYS */;
INSERT INTO `tintuc` VALUES (1,'Xuất khẩu thủy sản đạt 6,3 tỷ USD trong 8 tháng đầu năm','Xuất khẩu thủy sản đạt 6,3 tỷ USD, tăng 9% so với cùng kỳ năm ngoái, với tôm, cá tra và cá ngừ đều tăng trưởng mạnh. ','2024-08-31 00:00:00','Nguyễn Văn An','241103\\20241103_Fast&Furious8.jpg'),(2,'Phát triển nuôi trồng thủy sản theo hướng bền vững','Cần Thơ đang phát triển nuôi trồng thủy sản theo hướng bền vững, \r\ntập trung vào các biện pháp bảo vệ môi trường và tăng cường chất lượng sản phẩm. ','2024-09-15 00:00:00','Trần Thị Bịnh','241103\\20241103_venom.jpg'),(3,'Phân biệt các loại cá: cá basa, cá tra, cá hú và cá bông lau','<p style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; margin: 0.5em 0px 24px; color: rgb(41, 41, 41); font-family: Inter; font-size: 17px;\"><a href=\"https://thanhnien.vn/soi-noi-giai-cau-ca-the-thao-quoc-gia-2022-post1493689.html\" title=\"Sôi nổi giải câu cá thể thao quốc gia 2022\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; text-decoration: none; color: rgb(0, 152, 209);\">Cần thủ</a>&nbsp;người Anh Andy Hackett (42 tuổi) mới đây đã gặp may, chỉ mất khoảng 25 phút để câu dính con cá. Cà rốt là loài lai giữa&nbsp;<a href=\"https://thanhnien.vn/gac-bang-cu-nhan-nuoi-my-ngu-thu-250-trieu-dong-nam-post1522407.html\" title=\"Gác bằng cử nhân, nuôi \'mỹ ngư\' thu 250 triệu đồng/năm \" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; text-decoration: none; color: rgb(0, 152, 209);\">cá chép da</a>&nbsp;và&nbsp;<a href=\"https://thanhnien.vn/kiem-300-trieu-dong-nam-nho-nuoi-ca-koi-post1514508.html\" title=\"Kiếm 300 triệu đồng/năm nhờ nuôi cá Koi\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; text-decoration: none; color: rgb(0, 152, 209);\">cá koi</a>, và được cho là&nbsp;<a href=\"https://thanhnien.vn/hai-huoc-giu-mieng-ca-lay-mau-xet-nghiem-covid-19-khi-trung-quoc-triet-de-chong-dich-post1444773.html\" title=\"Hài hước giữ miệng cá lấy mẫu xét nghiệm Covid-19 khi Trung Quốc triệt để chống dịch\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; text-decoration: none; color: rgb(0, 152, 209);\">con cá lớn</a>&nbsp;thứ hai thuộc loại này từng bị bắt.</p><p style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; margin: 0.5em 0px 24px; color: rgb(41, 41, 41); font-family: Inter; font-size: 17px;\">Ông Hackett đã tạo dáng và chụp ảnh cùng&nbsp;<a href=\"https://thanhnien.vn/anh-chang-8x-bat-duoc-con-ca-vang-to-nhu-quai-vat-va-hanh-dong-bat-ngo-post1524548.html\" title=\"Anh chàng 8X bắt được con cá vàng to như quái vật và hành động bất ngờ...\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; text-decoration: none; color: rgb(0, 152, 209);\">con cá vàng</a>, sau đó thả nó trở lại hồ.</p><div id=\"zone-l2srqb41\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; box-sizing: border-box; outline: 0px; color: rgb(41, 41, 41); font-family: Inter; font-size: 17px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;\"><div id=\"share-l2srqbkq\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; box-sizing: border-box; outline: 0px;\"><div id=\"placement-kspipz1y\" revenue=\"cpd\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; box-sizing: border-box; outline: 0px;\"><div id=\"banner-l2srqb41-kspiq11b\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; box-sizing: border-box; outline: 0px; min-height: 0px; min-width: 0px;\"><div id=\"slot-1-l2srqb41-kspiq11b\" style=\"-webkit-font-smoothing: antialiased; text-rendering: geometricprecision; box-sizing: border-box; outline: 0px;\"></div></div></div></div></div>','2024-10-01 00:00:00','Lê Văn Ơn','241103\\20241103_unnamed.jpg');
/*!40000 ALTER TABLE `tintuc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trungtam`
--

DROP TABLE IF EXISTS `trungtam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trungtam` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TenTrungTam` varchar(100) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `Hotline` varchar(15) DEFAULT NULL,
  `MoTa` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trungtam`
--

LOCK TABLES `trungtam` WRITE;
/*!40000 ALTER TABLE `trungtam` DISABLE KEYS */;
INSERT INTO `trungtam` VALUES (1,'Trung Tâm Thú Y Cá Koi','123 Đường Bạch Đằng, Quận 1, TP. HCM','091234567','Trung tâm Thú Y Cá Koi chuyên cung cấp các các dịch vụ khám bệnh, chữa bệnh cá koi chuyên nghiệp');
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

-- Dump completed on 2024-11-03 15:48:59
