

DROP TABLE IF EXISTS `studenti`;
CREATE TABLE `studenti` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nume` varchar(255) DEFAULT NULL,
  `oras` varchar(45) DEFAULT NULL,
  `adresa` varchar(255) DEFAULT NULL,
  `cnp` decimal(13,0) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;


INSERT INTO `studenti` VALUES (1,'Ionut Dan','Alba Iulia','Str.Tulnicului Nr.18 ',1720305015380),(2,'Danul Alexandru','Alba Iulia','Str. B.P. Hasdeu',6200101140231),(3,'Georgescu Dan','Sibiu','Str. Dumbravii Nr.236',1980104018348),(4,'Cadar Eugen','Cluj Napoca','Str. Pacii nr.12',1990909141671),(5,'Marinca Dana','Brasov','Str.Dumitreni nr.51',2720929010318),(6,'Cicea Cornel','Breaza','Str. 1 Decembrie nr.6',1990502016059),(7,'Avram Alin','Cugir','Str. Morii nr 14A',1982304014560),(10,'Paulescu Ana','Bucuresti','Str. Calarasi Nr.310',1970306017548),(11,'Cristea George ','Aiud','Str.Transilvania Nr.4',1980805018921),(12,'Marinescu Radu','Calarasi','Str. Memorandumului nr.1',1990221312415),(13,'Bulacu Andrei','Botosani','Str. Oituz nr.47',1991226016472),(14,'Luca Cristian','Bistrita','Str. Nasaudului Nr64',1781203322819),(15,'Romosan Flaviu','Targoviste','Str. Campului nr.9',1890411091816),(16,'Buruiana Sorin','Alba Iulia','Str. Toporasilor Nr.4A',1880206121426),(17,'Dobrota Costel','Braila','Str.Docurilor Nr.221',1860424098382),(18,'Burchea Dan','Sibiu','Calea Poplacii Nr.21',1880308082439),(20,'Pop Adrian','Alba Iulia','Str.Transilvaniei Nr.14',1870908019210),(23,'Istrate Adrian','Caracal','Str. Dunarea Nr.87',1881211100376);
