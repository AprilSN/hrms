-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: hrms_employee_database
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
-- Table structure for table `employee_info_table`
--

DROP TABLE IF EXISTS `employee_info_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_info_table` (
  `employee_no` int NOT NULL AUTO_INCREMENT,
  `employee_self_id` int NOT NULL,
  `employee_first_name` varchar(45) NOT NULL,
  `employee_last_name` varchar(45) NOT NULL,
  `employee_date_of_birth` date NOT NULL,
  `employee_age` varchar(45) NOT NULL,
  `employee_nrc_code` varchar(45) NOT NULL,
  `employee_gender` varchar(45) NOT NULL,
  `employee_address` varchar(45) NOT NULL,
  `employee_email` varchar(45) NOT NULL,
  `employee_contact` varchar(45) NOT NULL,
  `employee_start_date` date NOT NULL,
  `employee_position` varchar(45) NOT NULL,
  `employee_department` varchar(45) NOT NULL,
  `employee_salary` decimal(10,0) NOT NULL,
  PRIMARY KEY (`employee_no`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_info_table`
--

LOCK TABLES `employee_info_table` WRITE;
/*!40000 ALTER TABLE `employee_info_table` DISABLE KEYS */;
INSERT INTO `employee_info_table` VALUES (1,123,'BRENDER','MISTY','1990-01-12','30','11/KaTaTa(N)012349','Female','NO(12), UINUSES, YANGON','brendermisties@gmail.com','09367839493','2020-01-10','Assistant Manager','Marketing',300000),(2,456,'PETER','KAVINSKY','1998-06-08','22','11BaTaHta(N)294767','Male','NO(10),ART ST,YANGON','peterkavinsky@gmail.com','09321343987','2020-03-04','Supply Chain Manager','Purchases',600000);
/*!40000 ALTER TABLE `employee_info_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_info_table`
--

DROP TABLE IF EXISTS `user_info_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_info_table` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `user_phone` varchar(45) NOT NULL,
  `user_email` varchar(45) NOT NULL,
  `user_address` varchar(45) NOT NULL,
  `user_password` varchar(45) NOT NULL,
  `user_confirmation` varchar(45) NOT NULL,
  `user_position` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_info_table`
--

LOCK TABLES `user_info_table` WRITE;
/*!40000 ALTER TABLE `user_info_table` DISABLE KEYS */;
INSERT INTO `user_info_table` VALUES (1,'APRIL SOE NAING','09263676890','aprilsoenaing.786@gmail.com','NO(121), SANCHAUNG, YANGON','12042001!','12042001!','Administrator'),(2,'AUNG AUNG','09425897890','aungaung22@gmail.com','NO(23), HINDATA ','12908','12908','Manager'),(3,'EAINDRA SOE NAING','09261556214','eaindrasoenaing18@gmail.com','NO(111), INSEIN YANGON','280915','280915','Inquirer'),(4,'APRIL TUN OO','09289738989','apriltunoo33@gmail.com','NO(22), BARGAYAR, YANGON','21345','21345','Administrator'),(7,'ALEX MARCO','09231897432','alexmarco@gmail.com','GREENVILLAGE US','1234','1234','Manager');
/*!40000 ALTER TABLE `user_info_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-04 20:42:49
