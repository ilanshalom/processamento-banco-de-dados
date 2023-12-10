/*
SQLyog Community v9.33 GA
MySQL - 5.5.28 : Database - congresso
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`congresso` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `congresso`;

/*Table structure for table `areas` */

DROP TABLE IF EXISTS `areas`;

CREATE TABLE `areas` (
  `codarea` int(5) NOT NULL DEFAULT '0',
  `descarea` varchar(58) DEFAULT NULL,
  PRIMARY KEY (`codarea`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `areas` */

insert  into `areas`(`codarea`,`descarea`) values (1,'Inteligência Artificial'),(2,'Linguagens de Programação'),(3,'Engenharia de Software');

/*Table structure for table `paises` */

DROP TABLE IF EXISTS `paises`;

CREATE TABLE `paises` (
  `pais` varchar(40) NOT NULL DEFAULT '',
  `continente` varchar(40) DEFAULT NULL,
  `capital` varchar(40) DEFAULT NULL,
  `populacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`pais`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `paises` */

insert  into `paises`(`pais`,`continente`,`capital`,`populacao`) values ('Argentina','America do Sul','Buenos Aires',34000000),('Brasil','America do Sul','Brasilia',160000000),('Chile','America do Sul','Santiago de Chile',25600000),('China','Asia','Pequim',820000000),('Espanha','Europa','Madri',45000000),('Franca','Europa','Paris',78000000),('Inglaterra','Europa','Londres',24000000),('Italia','Europa','Roma',28000000),('Japao','Asia','Tokio',130000000),('Portugal','Europa','Lisboa',16000000),('Suica','Europa','Genebra',7000000);

/*Table structure for table `participantes` */

DROP TABLE IF EXISTS `participantes`;

CREATE TABLE `participantes` (
  `cod` int(5) NOT NULL DEFAULT '0',
  `nome` varchar(55) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `continente` varchar(40) DEFAULT NULL,
  `codarea` int(5) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `participantes` */

insert  into `participantes`(`cod`,`nome`,`pais`,`continente`,`codarea`) values (123,'Juan José Fernández','Espanha','Europa',1),(190,'Paulo Luiz de Souza','Brasil','América do Sul',2),(342,'Amilton Lopes','Brasil','América do Sul',1),(382,'Guido Ghetti','Itália','Europa',1),(444,'Dolores Concepción Hernández','Espanha','Europa',1),(451,'Alberto Lidenberg Souza','Brasil','América do Sul',1),(555,'Rodrigo da Silva Jr.','Brasil','América do Sul',2),(666,'Carlos Antonio Sánchez','Argentina','América do Sul',2);

/*Table structure for table `usuarios` */

DROP TABLE IF EXISTS `usuarios`;

CREATE TABLE `usuarios` (
  `login` varchar(20) NOT NULL DEFAULT '',
  `senha` varchar(20) DEFAULT NULL,
  `nome` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `usuarios` */

insert  into `usuarios`(`login`,`senha`,`nome`) values ('100','cem','Luiz Alves de Souza'),('101','centoeum','Eng. Pedro Monteiro'),('102','umzerodois','Dra. Adair Pereira'),('1112','ledon','Prof. Ledón'),('1223','alc56','Prof. Alcides'),('1234','kim45','Adriana Lopes');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
