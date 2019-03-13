CREATE DATABASE  IF NOT EXISTS `zapateria` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `zapateria`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: zapateria
-- ------------------------------------------------------
-- Server version	5.6.21-log

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `IdCliente` int(45) NOT NULL AUTO_INCREMENT,
  `TipoDocumento` varchar(45) NOT NULL,
  `DocumentoCliente` varchar(45) NOT NULL,
  `NombreCliente` varchar(45) NOT NULL,
  `DireccionCliente` varchar(45) NOT NULL,
  `TelefonoCliente` varchar(45) NOT NULL,
  `Activo` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'DNI','28793197','Herbst German Carlos','Centenario  1524 Alvear Oeste','(261)533-5600',1),(2,'DNI','29880743','Tellez Viviana','Pierola 650 Ciudad Alvear','(   )   -',1),(3,'DNI','35563679','Maximiliano Kadyszyn','Tomás Jofre 864','(262)552-1400',1),(4,'DNI','1','1','1','(262)5  -',1),(5,'DNI','123','1231','1231','(  1)23 -',1),(6,'CEDULA IDENTIDAD','12','123','123','(123)   -',0);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentacorriente`
--

DROP TABLE IF EXISTS `cuentacorriente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuentacorriente` (
  `IdCuentaCorriente` int(11) NOT NULL AUTO_INCREMENT,
  `Activo` int(11) NOT NULL,
  `IdCliente` int(11) NOT NULL,
  PRIMARY KEY (`IdCuentaCorriente`),
  KEY `IdCliente_idx` (`IdCliente`),
  CONSTRAINT `IdCliente` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentacorriente`
--

LOCK TABLES `cuentacorriente` WRITE;
/*!40000 ALTER TABLE `cuentacorriente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentacorriente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleventa` (
  `IdDetalleventa` int(45) NOT NULL AUTO_INCREMENT,
  `VentaAsociada` int(11) NOT NULL,
  `Producto` int(11) NOT NULL,
  `CantidadProducto` int(11) NOT NULL,
  `TotalProducto` float NOT NULL,
  `CantidadEfectivo` float DEFAULT NULL,
  `CantidadCuentaCorriente` float DEFAULT NULL,
  `UltimaActualizacionUsuario` int(11) DEFAULT NULL,
  `FechaModificacion` date DEFAULT NULL,
  PRIMARY KEY (`IdDetalleventa`),
  KEY `VentaAsociada_idx` (`VentaAsociada`),
  KEY `Producto_idx` (`Producto`),
  KEY `UltimaActualizacionUsuario_idx` (`UltimaActualizacionUsuario`),
  CONSTRAINT `Producto` FOREIGN KEY (`Producto`) REFERENCES `producto` (`IdProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `UltimaActualizacionUsuario` FOREIGN KEY (`UltimaActualizacionUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `VentaAsociada` FOREIGN KEY (`VentaAsociada`) REFERENCES `venta` (`IdVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `IdProducto` int(11) NOT NULL AUTO_INCREMENT,
  `CodigoProducto` varchar(45) NOT NULL,
  `NombreProducto` varchar(45) DEFAULT NULL,
  `GeneroProducto` varchar(45) DEFAULT NULL,
  `TalleProducto` varchar(45) DEFAULT NULL,
  `TipoProducto` int(11) DEFAULT NULL,
  `Proveedor` int(11) DEFAULT NULL,
  `PrecioCompra` varchar(45) DEFAULT NULL,
  `PrecioVenta` varchar(45) DEFAULT NULL,
  `Stock` varchar(45) DEFAULT NULL,
  `Activo` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IdProducto`),
  KEY `Proveedor_idx` (`Proveedor`),
  KEY `TipoProducto_idx` (`TipoProducto`),
  CONSTRAINT `Proveedor` FOREIGN KEY (`Proveedor`) REFERENCES `proveedor` (`IdProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TipoProducto` FOREIGN KEY (`TipoProducto`) REFERENCES `tipoproducto` (`IdTipoProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `IdProveedor` int(11) NOT NULL AUTO_INCREMENT,
  `CUIT` varchar(45) NOT NULL,
  `NombreProveedor` varchar(45) NOT NULL,
  `DireccionProveedor` varchar(45) NOT NULL,
  `TelefonoProveedor` varchar(45) NOT NULL,
  `PaginaWebProveedor` varchar(45) NOT NULL,
  `Activo` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IdProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (3,'22-        -','2','2','2','2',1);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_usuario` (
  `IdTipoUsuario` int(11) NOT NULL,
  `NivelUsuario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdTipoUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipopago`
--

DROP TABLE IF EXISTS `tipopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipopago` (
  `IdTipoPago` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`IdTipoPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipopago`
--

LOCK TABLES `tipopago` WRITE;
/*!40000 ALTER TABLE `tipopago` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoproducto`
--

DROP TABLE IF EXISTS `tipoproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoproducto` (
  `IdTipoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `TipoProducto` varchar(255) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Activo` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IdTipoProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoproducto`
--

LOCK TABLES `tipoproducto` WRITE;
/*!40000 ALTER TABLE `tipoproducto` DISABLE KEYS */;
INSERT INTO `tipoproducto` VALUES (1,'Mocasin','',1),(2,'Zapatos Taco Chino','',1),(3,'Zapatos de Fiesta','',1),(4,'Botines','',1),(5,'Zapatos','',1),(6,'Botines','',0),(7,'botines','',0);
/*!40000 ALTER TABLE `tipoproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `IdUsuario` int(45) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) DEFAULT NULL,
  `Nivel` int(11) NOT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `Contrasenia` varchar(45) DEFAULT NULL,
  `Activo` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IdUsuario`),
  KEY `Nivel_idx` (`Nivel`),
  CONSTRAINT `Nivel` FOREIGN KEY (`Nivel`) REFERENCES `tipo_usuario` (`IdTipoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venta` (
  `IdVenta` int(45) NOT NULL AUTO_INCREMENT,
  `Cliente` int(11) NOT NULL,
  `Usuario` int(11) DEFAULT NULL,
  `TipoPago` int(11) DEFAULT NULL,
  `Total` float NOT NULL,
  `Fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdVenta`),
  KEY `TipoPago_idx` (`TipoPago`),
  KEY `Cliente_idx` (`Cliente`),
  CONSTRAINT `Cliente` FOREIGN KEY (`Cliente`) REFERENCES `cliente` (`IdCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TipoPago` FOREIGN KEY (`TipoPago`) REFERENCES `tipopago` (`IdTipoPago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-12 23:07:52
