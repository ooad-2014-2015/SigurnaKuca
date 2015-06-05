-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: igricabaza
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
-- Table structure for table `highscore`
--

DROP TABLE IF EXISTS `highscore`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `highscore` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(20) DEFAULT NULL,
  `Vrijeme` int(11) DEFAULT NULL,
  `Nivo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `highscore`
--

LOCK TABLES `highscore` WRITE;
/*!40000 ALTER TABLE `highscore` DISABLE KEYS */;
INSERT INTO `highscore` VALUES (1,NULL,180,1),(2,NULL,160,2),(3,NULL,140,3),(4,NULL,120,4),(5,NULL,100,5),(6,NULL,180,1),(7,NULL,180,1),(8,NULL,180,1),(9,NULL,180,1),(10,NULL,160,2),(11,NULL,160,2),(12,NULL,160,2),(13,NULL,160,2),(14,NULL,140,3),(15,NULL,140,3),(16,NULL,140,3),(17,NULL,140,3),(18,NULL,120,4),(19,NULL,120,4),(20,NULL,120,4),(21,NULL,120,4),(22,NULL,100,5),(23,NULL,100,5),(24,NULL,100,5),(25,NULL,100,5),(26,'Reha',75,1),(27,'Reha',75,1),(28,'RajaNaKafi',108,1);
/*!40000 ALTER TABLE `highscore` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stringovi`
--

DROP TABLE IF EXISTS `stringovi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stringovi` (
  `indeks` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(20) DEFAULT NULL,
  `Kategorija` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`indeks`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stringovi`
--

LOCK TABLES `stringovi` WRITE;
/*!40000 ALTER TABLE `stringovi` DISABLE KEYS */;
INSERT INTO `stringovi` VALUES (1,'Edo Maajka',NULL),(2,'Smoke Mardeljano',NULL),(3,'Sassja',NULL),(4,'Marlon Brutal',NULL),(5,'Frenkie',NULL),(6,'Kontra',NULL),(7,'Eminem',NULL),(8,'Ajs Nigrutin',NULL),(9,'Kontra',NULL),(10,'50 Cent',NULL),(11,'2Pac',NULL),(12,'Bad Copy',NULL),(13,'Prti Bee Gee',NULL),(14,'Bolesna Braca',NULL),(15,'Busta Rymes',NULL),(16,'Cypress Hill',NULL),(17,'Djecaci',NULL),(18,'DMX',NULL),(19,'Connect',NULL),(20,'Dr Dre',NULL),(21,'General Woo',NULL),(22,'Ice Cube',NULL),(23,'Marcelo',NULL),(24,'Shaggy',NULL),(25,'The Fugees',NULL),(26,'Vanilla Ice',NULL),(27,'Who See',NULL),(28,'Tram 11',NULL),(29,'Aca Lukas',NULL),(30,'Aco Pejvoic',NULL),(31,'Ana Bekuta',NULL),(32,'Dejan Matic',NULL),(33,'Saša Matic',NULL),(34,'Džej',NULL),(35,'Halid Bešlic',NULL),(36,'Haris Džinovic',NULL),(37,'Jana',NULL),(38,'Keba',NULL),(39,'Lepa Brena',NULL),(40,'Ljuba Alicic',NULL),(41,'Miroslav Ilic',NULL),(42,'Nataša Bekvalac',NULL),(43,'Nikola Rokvic',NULL),(44,'Toma Zdravkovic',NULL),(45,'Šaban Šaulic',NULL),(46,'Sinan Sakic',NULL),(47,'Željko Joksimovic',NULL),(48,'Željko Samardžic',NULL),(49,'Zorica Brunclik',NULL),(50,'Azra',NULL),(51,'Bajaga',NULL),(52,'Bijelo dugme',NULL),(53,'Bombaj štampa',NULL),(54,'Tifa',NULL),(55,'Colonia',NULL),(56,'Crvena jabuka',NULL),(57,'Daleka obala',NULL),(58,'Dino Merlin',NULL),(59,'EKV',NULL),(60,'Haustor',NULL),(61,'Magazin',NULL),(62,'Novi Fosili',NULL),(63,'Parni valjak',NULL),(64,'Prljavo kazalište',NULL),(65,'Plavi Orkestar',NULL),(66,'Valentino',NULL),(67,'Van Gogh',NULL),(68,'Zoster',NULL),(69,'Dubioza Kolektiv',NULL),(70,'Letu Štuke',NULL),(71,'Skroz',NULL),(72,'Zabranjeno pušenje',NULL);
/*!40000 ALTER TABLE `stringovi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-05 11:55:28
