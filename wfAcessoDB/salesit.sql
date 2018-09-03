# Host: localhost  (Version 5.7.17-log)
# Date: 2018-09-01 20:21:09
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "tb_funcionario"
#

DROP TABLE IF EXISTS `tb_funcionario`;
CREATE TABLE `tb_funcionario` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Matricula` varchar(10) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Funcionários da empresa';

#
# Data for table "tb_funcionario"
#

INSERT INTO `tb_funcionario` VALUES (1,'846118','CARLOS HENRIQUE MEIRELES CORBO');

#
# Structure for table "tb_funcionario_dependentes"
#

DROP TABLE IF EXISTS `tb_funcionario_dependentes`;
CREATE TABLE `tb_funcionario_dependentes` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Codigo_funcionario` int(11) DEFAULT NULL,
  `Nome` varchar(50) DEFAULT NULL,
  `Data_Nascimento` date DEFAULT NULL,
  `GrauParentesco` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `Codigo` (`Codigo`,`Codigo_funcionario`),
  KEY `Codigo_funcionario` (`Codigo_funcionario`),
  CONSTRAINT `tb_funcionario_dependentes_ibfk_1` FOREIGN KEY (`Codigo_funcionario`) REFERENCES `tb_funcionario` (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COMMENT='Dependentes do funcionário';

#
# Data for table "tb_funcionario_dependentes"
#

INSERT INTO `tb_funcionario_dependentes` VALUES (1,1,'POLIANA MOREIRA MEIRELES CORBO','2010-02-03','FILHO'),(2,1,'TATIANE MOREIRA DA SILVA CORBO','1982-06-04','ESPOSA');
