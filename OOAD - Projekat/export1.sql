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
  `ID` int(11) NOT NULL AUTO_INCREMENT,
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kartoni`
--

LOCK TABLES `kartoni` WRITE;
/*!40000 ALTER TABLE `kartoni` DISABLE KEYS */;
INSERT INTO `kartoni` VALUES (1,1,NULL,NULL,2),(2,1,4,3,2);
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
  PRIMARY KEY (`ID`),
  KEY `fk_Korisnici_Lokacija_idx` (`Lokacija_ID`),
  CONSTRAINT `fk_Korisnici_Lokacija` FOREIGN KEY (`Lokacija_ID`) REFERENCES `lokacije` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
INSERT INTO `korisnici` VALUES (1,'Nejra','Pasic','NP123','NP123',1,0,'Senka ','1993-10-27'),(2,'Senka','Ibrahimpasic','SI123','SI123',2,1,'Senka ','1994-05-14');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lokacije`
--

LOCK TABLES `lokacije` WRITE;
/*!40000 ALTER TABLE `lokacije` DISABLE KEYS */;
INSERT INTO `lokacije` VALUES (1,'Brcanska 13',1),(2,'Muftije Dzabijca 12',1),(3,'Ferde Haupmana 6',NULL),(4,'Titova 133',NULL),(5,'Ferhadija 18',NULL),(6,'Vrbovska 183',NULL),(7,'Dzemala Bijedica 18',NULL),(8,'Bulevar Mese Selimovica 188',NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radnici`
--

LOCK TABLES `radnici` WRITE;
/*!40000 ALTER TABLE `radnici` DISABLE KEYS */;
INSERT INTO `radnici` VALUES (1,'Faruk','Mustafic','d1337','d1337',0,'2015-05-13'),(2,'Psiho','Ludi','e1337','e1337',1,'2015-05-13'),(3,'Ekonom','Maraka','e1337','e1337',2,'2015-05-13'),(4,'Pravo','Zakon','pr1337','pr1337',3,'2015-05-13'),(5,'Haris','Musovic','d1987','d1987',0,'2015-05-13');
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
  `Vrijeme` time DEFAULT NULL,
  `ID_R` int(11) NOT NULL,
  `ID_K` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Rasporedi_Radnici1_idx` (`ID_R`),
  KEY `fk_Rasporedi_Korisnici1_idx` (`ID_K`),
  CONSTRAINT `fk_Rasporedi_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rasporedi_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rasporedi`
--

LOCK TABLES `rasporedi` WRITE;
/*!40000 ALTER TABLE `rasporedi` DISABLE KEYS */;
INSERT INTO `rasporedi` VALUES (1,NULL,NULL,1,1),(2,NULL,NULL,2,1),(3,NULL,NULL,1,2),(4,NULL,NULL,2,2),(5,NULL,NULL,3,2),(6,NULL,NULL,4,2);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_d`
--

LOCK TABLES `status_d` WRITE;
/*!40000 ALTER TABLE `status_d` DISABLE KEYS */;
INSERT INTO `status_d` VALUES (1,1,1,'Sistematskii\r\n','Biljeska o piscu\r\n\r\n','18.5.2015. 13:29:45\nSistematskii\r\n\n','2015-05-19'),(2,2,1,'Novooo\r\n','Biljeska o piscu 2\r\n','18.5.2015. 13:30:08\nNovooo\r\n\n','2015-05-18');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_e`
--

LOCK TABLES `status_e` WRITE;
/*!40000 ALTER TABLE `status_e` DISABLE KEYS */;
INSERT INTO `status_e` VALUES (1,2,3,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_pr`
--

LOCK TABLES `status_pr` WRITE;
/*!40000 ALTER TABLE `status_pr` DISABLE KEYS */;
INSERT INTO `status_pr` VALUES (1,2,4,NULL,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_ps`
--

LOCK TABLES `status_ps` WRITE;
/*!40000 ALTER TABLE `status_ps` DISABLE KEYS */;
INSERT INTO `status_ps` VALUES (1,1,2,0,NULL,NULL,NULL),(2,2,2,0,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zahtjevi`
--

LOCK TABLES `zahtjevi` WRITE;
/*!40000 ALTER TABLE `zahtjevi` DISABLE KEYS */;
INSERT INTO `zahtjevi` VALUES (1,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(2,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(3,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(4,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(5,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(6,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(7,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(8,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(9,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(10,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(11,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(12,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(13,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(14,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(15,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(16,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(17,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(18,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(19,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(20,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(21,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(22,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(23,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(24,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(25,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(26,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(27,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(28,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(29,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(30,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(31,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(32,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(33,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(34,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(35,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(36,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(37,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(38,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(39,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(40,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(41,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(42,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(43,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(44,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(45,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(46,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(47,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(48,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(49,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(50,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(51,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(52,1,'Zahtjev za medicinsku pomoc',0,1,0,1),(53,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(54,1,'Zahtjev za dodatnu ekonomsku pomoc',0,1,1,3),(55,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(56,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(57,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(58,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(59,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(60,1,'Zahtjev za dodatnu ekonomsku pomoc',0,1,1,3),(61,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(62,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(63,1,'Zahtjev za dodatnu ekonomsku pomoc',0,1,1,3),(64,1,'Zahtjev za medicinsku pomoc',0,1,0,1),(65,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(66,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(67,1,'Zahtjev za medicinsku pomoc',0,1,0,1),(68,1,'Zahtjev za psiholosku pomoc',1,1,0,2),(69,1,'Zahtjev za dodatnu ekonomsku pomoc',0,1,1,3),(70,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(71,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(72,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3),(73,1,'Zahtjev za medicinsku pomoc',1,1,0,1),(74,1,'Zahtjev za psiholosku pomoc',0,1,0,2),(75,1,'Zahtjev za dodatnu ekonomsku pomoc',1,1,1,3);
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

-- Dump completed on 2015-05-20 23:15:56
