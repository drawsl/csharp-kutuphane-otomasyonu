/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : asdas

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2024-03-10 18:17:59
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `lib_ayarlar`
-- ----------------------------
DROP TABLE IF EXISTS `lib_ayarlar`;
CREATE TABLE `lib_ayarlar` (
  `KurumAd` varchar(255) DEFAULT '',
  `KurumAdres` text DEFAULT '\'\'',
  `EmanetSure` int(11) DEFAULT 30,
  `EmanetSureUzat` int(11) DEFAULT 30,
  `EmanetGecikmeBedel` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_ayarlar
-- ----------------------------
INSERT INTO `lib_ayarlar` VALUES ('Mehmet Akif Ersoy ÇPAL', 'İstanbul', '14', '14', '5');

-- ----------------------------
-- Table structure for `lib_dolaplar`
-- ----------------------------
DROP TABLE IF EXISTS `lib_dolaplar`;
CREATE TABLE `lib_dolaplar` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Adi` varchar(30) DEFAULT 'Bilinmiyor',
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_dolaplar
-- ----------------------------
INSERT INTO `lib_dolaplar` VALUES ('4', 'Hikaye - Roman: HR1');
INSERT INTO `lib_dolaplar` VALUES ('5', 'Bilimkurgu: BK2');
INSERT INTO `lib_dolaplar` VALUES ('6', 'Polisiye ve Suç: PS3');
INSERT INTO `lib_dolaplar` VALUES ('7', 'Macera: MA4');
INSERT INTO `lib_dolaplar` VALUES ('8', 'Korku (Gothic Korku, Doğaüstü)');
INSERT INTO `lib_dolaplar` VALUES ('9', 'Fantastik (Fantazi): FA6');
INSERT INTO `lib_dolaplar` VALUES ('10', 'Romantizm: RO7');
INSERT INTO `lib_dolaplar` VALUES ('11', 'Drama: DR8');
INSERT INTO `lib_dolaplar` VALUES ('12', 'Mizah (Komedi): MI9');
INSERT INTO `lib_dolaplar` VALUES ('13', 'Bilgisayar - Teknoloji (BT1)');
INSERT INTO `lib_dolaplar` VALUES ('14', 'Tarih: (T1)');

-- ----------------------------
-- Table structure for `lib_emanetler`
-- ----------------------------
DROP TABLE IF EXISTS `lib_emanetler`;
CREATE TABLE `lib_emanetler` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `KitapID` int(11) DEFAULT NULL,
  `OkuyucuID` int(11) DEFAULT NULL,
  `emanetVerilisTarih` date DEFAULT NULL,
  `emanetGeriAlmaTarih` date DEFAULT NULL,
  `emanetİslemTarih` date DEFAULT NULL,
  `durum` int(11) DEFAULT 0,
  `aktif` int(11) DEFAULT 1,
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_emanetler
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_kitaplar`
-- ----------------------------
DROP TABLE IF EXISTS `lib_kitaplar`;
CREATE TABLE `lib_kitaplar` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `KayitNo` int(150) DEFAULT NULL,
  `KitapAdi` varchar(50) DEFAULT '',
  `YazarAdi` varchar(50) DEFAULT NULL,
  `YayinEvi` varchar(30) DEFAULT NULL,
  `BasimYili` varchar(10) DEFAULT '',
  `SayfaSayisi` varchar(10) DEFAULT '',
  `Turu` varchar(30) DEFAULT NULL,
  `Aciklama` text DEFAULT '',
  `Dolap` varchar(30) DEFAULT NULL,
  `Raf` varchar(10) DEFAULT NULL,
  `Sira` varchar(10) DEFAULT NULL,
  `durum` int(11) DEFAULT 1,
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_kitaplar
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_okuyucular`
-- ----------------------------
DROP TABLE IF EXISTS `lib_okuyucular`;
CREATE TABLE `lib_okuyucular` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Ad` varchar(20) DEFAULT '',
  `Soyad` varchar(20) DEFAULT '',
  `Cinsiyet` varchar(10) DEFAULT '',
  `Sinifi` varchar(10) DEFAULT '',
  `OkulNo` varchar(200) DEFAULT '',
  `CepTel` varchar(20) DEFAULT '',
  `Adres` text DEFAULT '',
  `aktif` int(11) DEFAULT 1,
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_okuyucular
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_songiris`
-- ----------------------------
DROP TABLE IF EXISTS `lib_songiris`;
CREATE TABLE `lib_songiris` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `YetkiliID` int(11) DEFAULT NULL,
  `Tarih` datetime DEFAULT NULL,
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_songiris
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_turler`
-- ----------------------------
DROP TABLE IF EXISTS `lib_turler`;
CREATE TABLE `lib_turler` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Adi` varchar(30) DEFAULT '',
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_turler
-- ----------------------------
INSERT INTO `lib_turler` VALUES ('1', 'Roman');
INSERT INTO `lib_turler` VALUES ('2', 'Hikaye (Kısa Hikaye)');
INSERT INTO `lib_turler` VALUES ('3', 'Bilimkurgu (Science Fiction)');
INSERT INTO `lib_turler` VALUES ('4', 'Polisiye ve Suç');
INSERT INTO `lib_turler` VALUES ('5', 'Macera');
INSERT INTO `lib_turler` VALUES ('6', 'Korku (Gothic Korku, Doğaüstü ');
INSERT INTO `lib_turler` VALUES ('7', 'Fantastik (Fantazi)');
INSERT INTO `lib_turler` VALUES ('8', 'Romantizm');
INSERT INTO `lib_turler` VALUES ('9', 'Drama');
INSERT INTO `lib_turler` VALUES ('10', 'Mizah (Komedi)');
INSERT INTO `lib_turler` VALUES ('11', 'Bilgisayar');
INSERT INTO `lib_turler` VALUES ('12', 'Tarih');

-- ----------------------------
-- Table structure for `lib_yayinevleri`
-- ----------------------------
DROP TABLE IF EXISTS `lib_yayinevleri`;
CREATE TABLE `lib_yayinevleri` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Adi` varchar(30) DEFAULT '',
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_yayinevleri
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_yazarlar`
-- ----------------------------
DROP TABLE IF EXISTS `lib_yazarlar`;
CREATE TABLE `lib_yazarlar` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Adi` varchar(30) DEFAULT '',
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_yazarlar
-- ----------------------------

-- ----------------------------
-- Table structure for `lib_yetkililer`
-- ----------------------------
DROP TABLE IF EXISTS `lib_yetkililer`;
CREATE TABLE `lib_yetkililer` (
  `İD` int(11) NOT NULL AUTO_INCREMENT,
  `Ad` varchar(20) DEFAULT '',
  `Soyad` varchar(20) DEFAULT '',
  `KullaniciAdi` varchar(50) DEFAULT '',
  `Sifre` varchar(255) DEFAULT '',
  `aktif` int(11) DEFAULT 1,
  PRIMARY KEY (`İD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of lib_yetkililer
-- ----------------------------
