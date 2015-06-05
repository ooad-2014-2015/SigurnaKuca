-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	5.6.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `kartoni`
--

DROP TABLE IF EXISTS `kartoni`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kartoni` (
  `ID` int(11) NOT NULL,
  `ID_D` int(11) NOT NULL,
  `ID_Pr` int(11) DEFAULT NULL,
  `ID_E` int(11) DEFAULT NULL,
  `ID_Ps` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Kartoni_Radnici1_idx` (`ID_D`),
  KEY `fk_Kartoni_Radnici2_idx` (`ID_Pr`),
  KEY `fk_Kartoni_Radnici3_idx` (`ID_E`),
  KEY `fk_Kartoni_Radnici4_idx` (`ID_Ps`),
  CONSTRAINT `fk_Kartoni_Radnici1` FOREIGN KEY (`ID_D`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Kartoni_Radnici2` FOREIGN KEY (`ID_Pr`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Kartoni_Radnici3` FOREIGN KEY (`ID_E`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Kartoni_Radnici4` FOREIGN KEY (`ID_Ps`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kartoni`
--

LOCK TABLES `kartoni` WRITE;
/*!40000 ALTER TABLE `kartoni` DISABLE KEYS */;
INSERT INTO `kartoni` VALUES (1,1,NULL,NULL,2),(2,1,NULL,NULL,2),(3,1,NULL,NULL,3),(4,1,5,4,2),(5,1,5,4,2),(6,1,NULL,NULL,3),(8,1,5,4,2);
/*!40000 ALTER TABLE `kartoni` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `korisnici`
--

DROP TABLE IF EXISTS `korisnici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `korisnici` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(45) NOT NULL,
  `Prezime` varchar(45) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Lokacija_ID` int(11) NOT NULL,
  `Anonimnost` tinyint(1) NOT NULL,
  `DodatneOsobe` varchar(100) NOT NULL,
  `DatumRodjenja` date NOT NULL,
  `DatumPrijema` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Korisnici_Lokacija_idx` (`Lokacija_ID`),
  CONSTRAINT `fk_Korisnici_Lokacija` FOREIGN KEY (`Lokacija_ID`) REFERENCES `lokacije` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
INSERT INTO `korisnici` VALUES (1,'Nejra','Pašic','NP123','NP123',3,0,'Seeenka ','1993-10-27','2015-05-23'),(2,'Konzum','Market','KM123','KM123',1,0,'Blaaaa ','2015-05-12','2015-05-25'),(3,'Korisnik','Korisnik','KK123','KK123',2,0,'Dzemka Fikro Arnela ','2015-05-13','2015-05-06'),(4,'Aida','Ploco','AP123','AP123',8,1,'','1993-06-11','2015-05-12'),(5,'Novi','Najnoviji','NN987','NN987',5,1,'','2015-06-11','2015-06-03'),(6,'Opet','Proba','OP098','OP098',7,0,'','2015-06-11','2015-06-05'),(7,'Novi','Noviu','NN987','NN987',4,1,'','2015-06-17','2015-06-10'),(8,'Blabala','Palala','BP1234','BP1234',6,1,'','2015-06-09','2015-06-11');
/*!40000 ALTER TABLE `korisnici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lokacije`
--

DROP TABLE IF EXISTS `lokacije`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lokacije` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Adresa` varchar(45) DEFAULT NULL,
  `Zauzeta` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lokacije`
--

LOCK TABLES `lokacije` WRITE;
/*!40000 ALTER TABLE `lokacije` DISABLE KEYS */;
INSERT INTO `lokacije` VALUES (1,'Brcanska 13',1),(2,'Muftije Dzabijca 12',1),(3,'Ferde Haupmana 6',1),(4,'Titova 133',1),(5,'Ferhadija 18',1),(6,'Vrbovska 183',1),(7,'Dzemala Bijedica 18',1),(8,'Bulevar Mese Selimovica 188',1),(9,'Bulevar Meše Selimovica 25',NULL),(10,'Kulovica 12',NULL),(11,'Dalmatinska 25',NULL),(12,'Džamijska 39',NULL),(13,'Žrtava Fašizma 2',NULL),(14,'Prijedosrka 29',NULL);
/*!40000 ALTER TABLE `lokacije` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `radnici`
--

DROP TABLE IF EXISTS `radnici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `radnici` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(45) DEFAULT NULL,
  `Prezime` varchar(45) DEFAULT NULL,
  `Username` varchar(20) DEFAULT NULL,
  `Password` varchar(20) DEFAULT NULL,
  `Opis` int(11) DEFAULT NULL,
  `DatumRodjenja` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radnici`
--

LOCK TABLES `radnici` WRITE;
/*!40000 ALTER TABLE `radnici` DISABLE KEYS */;
INSERT INTO `radnici` VALUES (1,'Faruk','Mustafic','d1337','d1337',0,'2015-05-05'),(2,'Psiho','Ludi','p1337','p1337',1,'2015-05-07'),(3,'Adis','Bibic','ps1987','ps1987',1,'1993-04-08'),(4,'Ekonom','Maraka','e1337','e1337',2,'2015-05-13'),(5,'Zakoni','IZabrane','pr1337','pr1337',3,'2015-05-27'),(6,'Dolari','Marke','e1234','e1234',2,'2015-06-11'),(7,'Novu','Novu','d1234','d1234',0,'2015-06-10');
/*!40000 ALTER TABLE `radnici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rasporedi`
--

DROP TABLE IF EXISTS `rasporedi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rasporedi` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Dan` varchar(45) DEFAULT NULL,
  `Vrijeme` varchar(10) DEFAULT NULL,
  `ID_R` int(11) NOT NULL,
  `ID_K` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Rasporedi_Radnici1_idx` (`ID_R`),
  KEY `fk_Rasporedi_Korisnici1_idx` (`ID_K`),
  CONSTRAINT `fk_Rasporedi_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rasporedi_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rasporedi`
--

LOCK TABLES `rasporedi` WRITE;
/*!40000 ALTER TABLE `rasporedi` DISABLE KEYS */;
INSERT INTO `rasporedi` VALUES (1,'Ponedjeljak','09',1,1),(2,'Srijeda','09',2,1),(3,'Ponedjeljak','11',1,2),(4,'Ponedjeljak','09',2,2),(5,'Ponedjeljak','13',1,3),(6,'Ponedjeljak','09',3,3),(7,'Srijeda','09',1,4),(8,'Ponedjeljak','13',2,4),(9,'Ponedjeljak','09',4,4),(10,'Ponedjeljak','11',5,4),(11,'Srijeda','17',1,4),(12,'Petak','17',2,4),(13,'Srijeda','11',4,4),(14,'Petak','15',5,4),(15,'Cetvrtak','13',1,4),(16,'Cetvrtak','09',2,4),(17,'Cetvrtak','15',4,4),(18,'Srijeda','13',1,4),(19,'Ponedjeljak','15',1,5),(20,'Ponedjeljak','17',2,5),(21,'Ponedjeljak','11',4,5),(22,'Ponedjeljak','09',5,5),(23,'Ponedjeljak','17',1,6),(24,'Ponedjeljak','11',3,6),(27,'Utorak','17',2,4),(28,'Petak','09',1,4),(29,'Srijeda','13',5,5),(30,NULL,NULL,2,5),(31,'Utorak','09',1,8),(32,'Ponedjeljak','15',2,8),(33,'Ponedjeljak','13',4,8),(34,'Ponedjeljak','17',5,8),(35,'Cetvrtak','11',1,4);
/*!40000 ALTER TABLE `rasporedi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_d`
--

DROP TABLE IF EXISTS `status_d`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_d` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_K` int(11) NOT NULL,
  `ID_R` int(11) NOT NULL,
  `Nalazi` varchar(100) DEFAULT NULL,
  `LicniUtisak` varchar(100) DEFAULT NULL,
  `Historija` varchar(1000) DEFAULT NULL,
  `DatumPromjene` date DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Status_D_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_D_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_D_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_D_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_d`
--

LOCK TABLES `status_d` WRITE;
/*!40000 ALTER TABLE `status_d` DISABLE KEYS */;
INSERT INTO `status_d` VALUES (1,1,1,'novi novi nov bla bla bla\r\n',NULL,'4.6.2015. 9:27:06\nnovi novi nov bla bla bla\r\n\n','2015-06-04'),(2,2,1,'nejra nejra nejra nejra\r\n','sdflksdfllsflsdfl\r\n','4.6.2015. 9:27:18\nnejra nejra nejra nejra\r\n\n','2015-06-04'),(3,3,1,'dfdsfsdf\r\n',NULL,'4.6.2015. 9:26:49\nsenka oooad reha nejra\r\n\n4.6.2015. 9:41:48\ndfdsfsdf\r\n\n','2015-06-04'),(4,4,1,NULL,NULL,NULL,NULL),(5,5,1,NULL,NULL,NULL,NULL),(6,6,1,NULL,NULL,NULL,NULL),(7,8,1,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `status_d` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_e`
--

DROP TABLE IF EXISTS `status_e`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_e` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_K` int(11) NOT NULL,
  `ID_R` int(11) NOT NULL,
  `LicniUtisak` varchar(100) DEFAULT NULL,
  `Historija` varchar(1000) DEFAULT NULL,
  `PrijedlogRjesenja` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Status_E_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_E_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_E_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_E_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_e`
--

LOCK TABLES `status_e` WRITE;
/*!40000 ALTER TABLE `status_e` DISABLE KEYS */;
INSERT INTO `status_e` VALUES (1,4,4,NULL,NULL,NULL),(2,5,4,NULL,NULL,NULL),(3,8,4,NULL,NULL,NULL);
/*!40000 ALTER TABLE `status_e` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_pr`
--

DROP TABLE IF EXISTS `status_pr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_pr` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_K` int(11) NOT NULL,
  `ID_R` int(11) NOT NULL,
  `OpisProblema` varchar(1000) DEFAULT NULL,
  `PrijedlogRjesenja` varchar(100) DEFAULT NULL,
  `HistorijaRjesenja` varchar(1000) DEFAULT NULL,
  `LicniUtisak` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Status_Pr_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_Pr_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_Pr_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_Pr_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_pr`
--

LOCK TABLES `status_pr` WRITE;
/*!40000 ALTER TABLE `status_pr` DISABLE KEYS */;
INSERT INTO `status_pr` VALUES (1,4,5,NULL,NULL,NULL,NULL),(2,5,5,NULL,NULL,NULL,NULL),(3,8,5,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `status_pr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_ps`
--

DROP TABLE IF EXISTS `status_ps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_ps` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_K` int(11) NOT NULL,
  `ID_R` int(11) NOT NULL,
  `Doktor` tinyint(1) NOT NULL,
  `LicniUtisak` varchar(100) DEFAULT NULL,
  `Dijagnoza` varchar(100) DEFAULT NULL,
  `Historija` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Status_Ps_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_Ps_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_Ps_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_Ps_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_ps`
--

LOCK TABLES `status_ps` WRITE;
/*!40000 ALTER TABLE `status_ps` DISABLE KEYS */;
INSERT INTO `status_ps` VALUES (1,1,2,0,NULL,NULL,NULL),(2,2,2,0,NULL,NULL,NULL),(3,3,3,0,NULL,NULL,NULL),(4,4,2,0,NULL,NULL,NULL),(5,5,2,0,NULL,NULL,NULL),(6,6,3,0,NULL,NULL,NULL),(7,8,2,0,NULL,NULL,NULL);
/*!40000 ALTER TABLE `status_ps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zahtjevi`
--

DROP TABLE IF EXISTS `zahtjevi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zahtjevi` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Korisnici_ID` int(11) NOT NULL,
  `OpisZahtjeva` varchar(50) DEFAULT NULL,
  `Obradjen` tinyint(1) DEFAULT NULL,
  `Seen` tinyint(1) DEFAULT NULL,
  `DodatniZahtjev` tinyint(1) NOT NULL,
  `SifraZahtjeva` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Zahtjevi_Korisnici1_idx` (`Korisnici_ID`),
  CONSTRAINT `fk_Zahtjevi_Korisnici1` FOREIGN KEY (`Korisnici_ID`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zahtjevi`
--

LOCK TABLES `zahtjevi` WRITE;
/*!40000 ALTER TABLE `zahtjevi` DISABLE KEYS */;
INSERT INTO `zahtjevi` VALUES (1,1,'Zahtjev za medicinsku pomoc',1,0,0,1),(2,1,'Zahtjev za psiholosku pomoc',1,0,0,2),(3,1,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(4,1,'Zahtjev za medicinsku pomoc',0,0,0,1),(5,1,'Zahtjev za psiholosku pomoc',1,0,0,2),(7,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(8,4,'Zahtjev za dodatnu psihološku pomoc',1,0,1,2),(9,4,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(10,4,'Zahtjev za dodatnu pravnu pomoc',1,0,1,4),(11,4,'Promjena termina u rasporedu',1,0,0,5),(12,1,'Zahtjev za medicinsku pomoc',1,0,0,1),(13,1,'Zahtjev za psiholosku pomoc',1,0,0,2),(15,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(16,4,'Zahtjev za dodatnu psiholosku pomoc',1,0,1,2),(17,4,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(18,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(19,4,'Zahtjev za dodatnu psiholosku pomoc',1,0,1,2),(20,4,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(21,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(22,4,'Zahtjev za dodatnu psiholosku pomoc',1,0,1,2),(23,4,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(24,5,'Zahtjev za medicinsku pomoc',0,0,0,1),(25,5,'Zahtjev za psihološku pomoc',1,0,0,2),(26,5,'Zahtjev za pravnu pomoc',1,0,0,4),(27,5,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(28,5,'Zahtjev za dodatnu psihološku pomoc',1,0,1,2),(29,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(30,4,'Zahtjev za dodatnu psiholosku pomoc',NULL,NULL,1,2),(31,4,'Zahtjev za dodatnu ekonomsku pomoc',1,0,1,3),(32,5,'Zahtjev za dodatnu psihološku pomoc',1,0,1,2),(33,5,'Zahtjev za dodatnu pravnu pomoc',1,0,1,4),(34,4,'Zahtjev za dodatnu medicinsku pomoc',1,0,1,1),(35,4,'Zahtjev za dodatnu psiholosku pomoc',NULL,NULL,1,2),(36,4,'Zahtjev za dodatnu ekonomsku pomoc',NULL,NULL,1,3),(37,1,'Promjena termina u rasporedu',NULL,NULL,0,5),(38,1,'Zahtjev za medicinsku pomoc',NULL,NULL,0,1);
/*!40000 ALTER TABLE `zahtjevi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-05 12:03:01
