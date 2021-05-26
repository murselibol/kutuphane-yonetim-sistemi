CREATE DATABASE  IF NOT EXISTS `kutuphane` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kutuphane`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: kutuphane
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Dumping events for database 'kutuphane'
--

--
-- Dumping routines for database 'kutuphane'
--
/*!50003 DROP PROCEDURE IF EXISTS `p_adminEkle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_adminEkle`(
  IN p_ad varchar(45),
  IN p_soyad varchar(45),
  IN p_eMail varchar(100),
  IN p_telefon varchar(45),
  IN p_adres varchar(45) 
 )
BEGIN
insert into admin(ad,soyad,eMail,telefon,adres) values (p_ad,p_soyad,p_eMail,p_telefon,p_adres);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_adminGuncelle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_adminGuncelle`(
IN p_ad varchar(45),
IN p_soyad varchar(45),
IN p_eMail varchar(100),
IN p_telefon varchar(45),
IN p_adres varchar(45)
)
BEGIN
UPDATE admin SET 
ad = p_ad,
soyad = p_soyad,
telefon = p_telefon,
adres = p_adres
where eMail = p_eMail;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_adminSil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_adminSil`(IN p_eMail varchar(100))
BEGIN
 DELETE FROM admin WHERE eMail = p_eMail;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_girisKontrol` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_girisKontrol`(
IN f_eMail varchar(100),
IN f_sifre varchar(45),
IN f_tablo varchar(45)
)
BEGIN
SELECT ad,soyad FROM f_tablo WHERE eMail = f_eMail AND sifre = f_sifre;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_islemEkle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_islemEkle`(
  IN p_uyeID int,
  IN p_kitapID int,
  IN p_adminID int,
  IN p_islemTarihi date,
  IN p_iadeTarihi date,
  IN p_emanetDurumu varchar(45)
  
 )
BEGIN


#kitabı pasif yapve işlem sayisini arttır.
UPDATE kitap SET kitapDurumu = 0, islemSayisi=islemSayisi + 1 where kitapID=p_kitapID; 
insert into islem(uyeID,kitapID,adminID,islemTarihi,iadeTarihi,emanetDurumu) values (p_uyeID,p_kitapID,p_adminID,p_islemTarihi,p_iadeTarihi,p_emanetDurumu);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_islemSil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_islemSil`(IN p_islemID int)
BEGIN
#kitap durumunu aktif yapmak için

declare p_onbesGun date;
declare p_uyeninDurumu INT;
declare p_uyeID INT;

set p_uyeID = (select uyeID from islem where islemID = p_islemID);

set p_onbesGun = current_date() + INTERVAL 15 DAY;
set p_uyeninDurumu = (SELECT uyelikDurumu from uye where uyeID = p_uyeID);

UPDATE kitap SET kitapDurumu = 1 where kitapID = (select kitapID from islem where islemID=p_islemID); 
DELETE FROM islem WHERE islemID = p_islemID;

if p_uyeninDurumu = 0 then
	UPDATE uye SET cezaTarihi = p_onbesGun where uyeID = p_uyeID;
end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_kitapEkle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_kitapEkle`(
IN p_ISBN varchar(13),
IN  p_ad varchar(45),
IN  p_yazar varchar(45),
IN  p_baskiYili varchar(45),
IN  p_yayinEvi varchar(45),
IN  p_sayfaSayisi varchar(45),
IN  p_fotograf blob,
IN  p_aciklama longtext,
IN  p_kategoriAd varchar(45),
IN p_adminID int
 )
BEGIN
declare p_kitapID INT;
declare p_kategoriID INT;

insert into kitap(ISBN,ad,yazar,baskiYili,yayinEvi,sayfaSayisi,fotograf,aciklama,adminID) values (p_ISBN,p_ad,p_yazar,p_baskiYili,p_yayinEvi,p_sayfaSayisi,p_fotograf,p_aciklama,p_adminID);
set p_kitapID = (select kitapID from kitap where ISBN = p_ISBN);
set p_kategoriID = (select kategoriID from kategori where kategoriAdi = p_kategoriAd);
insert into kitap_kategori(kitapID,kategoriID) values (p_kitapID,p_kategoriID);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_kitapGuncelle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_kitapGuncelle`(
IN p_ISBN varchar(13),
IN  p_ad varchar(45),
IN  p_yazar varchar(45),
IN  p_baskiYili varchar(45),
IN  p_yayinEvi varchar(45),
IN  p_sayfaSayisi varchar(45),
IN  p_fotograf blob,
IN  p_aciklama longtext,
IN  p_kategoriAd varchar(45),
IN p_adminID int
)
BEGIN
declare p_kitapID INT;
declare p_kategoriID INT;



UPDATE kitap SET 
ad = p_ad,
yazar = p_yazar,
baskiYili = p_baskiYili,
yayinEvi = p_yayinEvi,
sayfaSayisi = p_sayfaSayisi,
fotograf = p_fotograf,
aciklama = p_aciklama,
adminID = p_adminID
where ISBN = p_ISBN;


set p_kitapID = (select kitapID from kitap where ISBN = p_ISBN);
set p_kategoriID = (select kategoriID from kategori where kategoriAdi = p_kategoriAd);
UPDATE kitap_kategori SET kategoriID = p_kategoriID where kitapID = p_kitapID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_kitapSil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_kitapSil`(IN p_ISBN varchar(13), IN p_adminID int)
BEGIN
declare islemVarMi int;

set islemVarMi = (SELECT count(kitapID) FROM islem where kitapID =(SELECT kitapID FROM kitap WHERE ISBN = p_ISBN)) ;

if islemVarMi = 0 THEN
	UPDATE kitap SET adminID = p_adminID where ISBN = p_ISBN;
	DELETE FROM kitap_kategori WHERE kitapID = (Select kitapID from kitap where ISBN = p_ISBN);# Kategorideki kaydı siler.
	DELETE FROM kitap WHERE ISBN = p_ISBN; # islemde fk olduğu için varsa zaten silemez.
elseif islemVarMi = 1 THEN
	DELETE FROM kitap WHERE ISBN = p_ISBN;
 end if;
 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_kitapUzat` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_kitapUzat`(
IN p_islemID int,
IN p_iadeTarihi varchar(45)
)
BEGIN

	UPDATE islem SET iadeTarihi = p_iadeTarihi, emanetDurumu = p_iadeTarihi, islemDurumu = islemDurumu + 1  WHERE islemID = p_islemID;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_uyeEkle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_uyeEkle`(
  IN p_ad varchar(45),
  IN p_soyad varchar(45),
  IN p_eMail varchar(100),
  IN p_telefon varchar(45),
  IN p_adres varchar(45),
  IN p_adminID int,
  IN p_cezaTarihi date
 )
BEGIN
insert into uye(ad,soyad,eMail,telefon,adres,adminID,cezaTarihi) values (p_ad,p_soyad,p_eMail,p_telefon,p_adres,p_adminID,p_cezaTarihi);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_uyeGuncelle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_uyeGuncelle`(
IN p_ad varchar(45),
IN p_soyad varchar(45),
IN p_eMail varchar(100),
IN p_telefon varchar(45),
IN p_adres varchar(45)
)
BEGIN
UPDATE uye SET 
ad = p_ad,
soyad = p_soyad,
telefon = p_telefon,
adres = p_adres

where eMail = p_eMail;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p_uyeSil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `p_uyeSil`(IN p_eMail varchar(100), IN p_adminID int)
BEGIN
UPDATE uye SET adminID = p_adminID where eMail = p_eMail;
DELETE FROM uye WHERE eMail = p_eMail;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-27  0:49:29
