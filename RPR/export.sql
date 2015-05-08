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
  `ID_K` int(11) NOT NULL,
  `ID_D` int(11) NOT NULL,
  `ID_Pr` int(11) NOT NULL,
  `ID_E` int(11) NOT NULL,
  `ID_Ps` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Kartoni_Korisnici1_idx` (`ID_K`),
  KEY `fk_Kartoni_Radnici1_idx` (`ID_D`),
  KEY `fk_Kartoni_Radnici2_idx` (`ID_Pr`),
  KEY `fk_Kartoni_Radnici3_idx` (`ID_E`),
  KEY `fk_Kartoni_Radnici4_idx` (`ID_Ps`),
  CONSTRAINT `fk_Kartoni_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
  PRIMARY KEY (`ID`),
  KEY `fk_Korisnici_Lokacija_idx` (`Lokacija_ID`),
  CONSTRAINT `fk_Korisnici_Lokacija` FOREIGN KEY (`Lokacija_ID`) REFERENCES `lokacije` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lokacije`
--

LOCK TABLES `lokacije` WRITE;
/*!40000 ALTER TABLE `lokacije` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radnici`
--

LOCK TABLES `radnici` WRITE;
/*!40000 ALTER TABLE `radnici` DISABLE KEYS */;
INSERT INTO `radnici` VALUES (1,'Faruk','Mustafic','D12345','D12345',0),(2,'Zgembo','Adislic','D12346','D12346',0);
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
  CONSTRAINT `fk_Rasporedi_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rasporedi_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rasporedi`
--

LOCK TABLES `rasporedi` WRITE;
/*!40000 ALTER TABLE `rasporedi` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  KEY `fk_Status_D_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_D_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_D_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_D_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_d`
--

LOCK TABLES `status_d` WRITE;
/*!40000 ALTER TABLE `status_d` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  KEY `fk_Status_E_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_E_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_E_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_E_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_e`
--

LOCK TABLES `status_e` WRITE;
/*!40000 ALTER TABLE `status_e` DISABLE KEYS */;
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
  `Status_Prcol` varchar(45) DEFAULT NULL,
  `ID_K` int(11) NOT NULL,
  `ID_R` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Status_Pr_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_Pr_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_Pr_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_Pr_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_pr`
--

LOCK TABLES `status_pr` WRITE;
/*!40000 ALTER TABLE `status_pr` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  KEY `fk_Status_Ps_Korisnici1_idx` (`ID_K`),
  KEY `fk_Status_Ps_Radnici1_idx` (`ID_R`),
  CONSTRAINT `fk_Status_Ps_Korisnici1` FOREIGN KEY (`ID_K`) REFERENCES `korisnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_Ps_Radnici1` FOREIGN KEY (`ID_R`) REFERENCES `radnici` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_ps`
--

LOCK TABLES `status_ps` WRITE;
/*!40000 ALTER TABLE `status_ps` DISABLE KEYS */;
/*!40000 ALTER TABLE `status_ps` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-08 20:17:46