--BDD para el proyecto de Analisis y Dise�o de Sistemas
use master; 
DROP DATABASE IF EXISTS TodoBus;
CREATE DATABASE TodoBus;
use TodoBus;

DROP TABLE IF EXISTS users;
CREATE TABLE users(
	id int NOT NULL IDENTITY,
	name varchar(50) NOT NULL,
	last_name varchar(50) NOT NULL,
	email varchar(50) NOT NULL UNIQUE,
	age int CHECK(age >= 18),
	password varchar(200) DEFAULT NULL,
	PRIMARY KEY(id)
);

INSERT INTO users VALUES ('Samuel','Peña', 'samuel07@gmail.com', 25, '6dad920bd261ddc177c720d8dade39984f228de59e3700f89231a480f3761c66');

DROP TABLE IF EXISTS clients;
CREATE TABLE clients(
	id int NOT NULL identity,
	client_name varchar(50) NOT NULL,
	contact_name varchar(50) NOT NULL,
	phone varchar(15) NOT NULL,
	alternative_phone varchar(15),
	client_type TINYINT NULL DEFAULT 0,
	address varchar(255) NULL,
	email varchar(50) NOT NULL,
	alternative_email varchar(50),
	units_total int NOT NULL,
	user_id int NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(user_id) REFERENCES users(id)
);

DROP TABLE IF EXISTS brands;
CREATE TABLE brands(
	id int NOT NULL identity,
	name varchar(50) NOT NULL UNIQUE,
	description varchar(100) NULL,

	PRIMARY KEY(id)
);

DROP TABLE IF EXISTS spare_categories;
CREATE TABLE spare_categories(
	id int NOT NULL IDENTITY,
	code varchar(25) NOT NULL UNIQUE,
	name varchar(150) NOT NULL

	PRIMARY KEY(id)
);
select * from spare_categories
INSERT INTO spare_categories VALUES('10', 'ARTÍCULOS VARIOS');
INSERT INTO spare_categories VALUES('11', 'ARTÍCULOS Y SERVICIOS NO INGRESADOS');
INSERT INTO spare_categories VALUES('12', 'PARTES DE CARROCERÍA');
INSERT INTO spare_categories VALUES('13', 'PARTES PARA AIRE ACONDICIONADO');
INSERT INTO spare_categories VALUES('14', 'PARTES DE REPUESTO CHASIS');
INSERT INTO spare_categories VALUES('BR', 'REPUESTOS PARA UNIDADES BRASILEÑAS');
INSERT INTO spare_categories VALUES('RX', 'REPUESTOS CON VARIAS UTILIDADES');
INSERT INTO spare_categories VALUES('IR', 'INVERSIÓN RETORNABLE INMEDIATA');

DROP TABLE IF EXISTS spare_subcategories;
CREATE TABLE spare_subcategories(
	id int NOT NULL IDENTITY,
	code varchar(20) NOT NULL,
	name varchar(100) NOT NULL,
	category_id int NOT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(category_id) REFERENCES spare_categories(id)
);

--Para Articulos varios
INSERT INTO spare_subcategories VALUES('1', 'HERRAMIENTAS', 1);
INSERT INTO spare_subcategories VALUES('2', 'MATERIALES', 1);
--Para partes de carroceria
INSERT INTO spare_subcategories VALUES('0', 'LIQUIDACION', 3);
INSERT INTO spare_subcategories VALUES('1', 'CARROCERIA EXTERNA', 3);
INSERT INTO spare_subcategories VALUES('2', 'CARROCERIA INTERNA', 3);
INSERT INTO spare_subcategories VALUES('3', 'SISTEMAS DE FUNCIONAMIENTO', 3);
INSERT INTO spare_subcategories VALUES('4', 'VIDRIOS', 3);
INSERT INTO spare_subcategories VALUES('5', 'ACABAMIENTOS', 3);
--Para aire acondicionado
INSERT INTO spare_subcategories VALUES('1', 'VALVULAS', 4);
INSERT INTO spare_subcategories VALUES('2', 'FILTROS', 4);
INSERT INTO spare_subcategories VALUES('3', 'COMPRESORES', 4);
INSERT INTO spare_subcategories VALUES('4', 'KIT REPAROS', 4);
INSERT INTO spare_subcategories VALUES('5', 'VENTILADORES', 4);
INSERT INTO spare_subcategories VALUES('6', 'VARIOS', 4);
--Para partes de repuesto chasis
INSERT INTO spare_subcategories VALUES('1', 'CHASIS', 5);
INSERT INTO spare_subcategories VALUES('2', 'MOTOR', 5);
INSERT INTO spare_subcategories VALUES('3', 'CAJA VELOCIDADES', 5);
INSERT INTO spare_subcategories VALUES('4', 'TRANSMISIÓN', 5);
--Para repuestos para unidades brasileñas
INSERT INTO spare_subcategories VALUES('10', 'ARTICULOS AIRE ACONDICIONADO', 6);
INSERT INTO spare_subcategories VALUES('11', 'DELANTERO EXTERIOR', 6);
INSERT INTO spare_subcategories VALUES('12', 'TRASERO EXTERIOR', 6);
INSERT INTO spare_subcategories VALUES('13', 'LATERAL EXTERIOR', 6);
INSERT INTO spare_subcategories VALUES('14', 'SUPERIOR - TECHO', 6);
INSERT INTO spare_subcategories VALUES('21', 'CABINA INTERIOR', 6);
INSERT INTO spare_subcategories VALUES('22', 'SALON INTERIOR', 6);
INSERT INTO spare_subcategories VALUES('23', 'OTROS COMPONENTES', 6);
INSERT INTO spare_subcategories VALUES('31', 'ELÉCTRICO', 6);
INSERT INTO spare_subcategories VALUES('32', 'NEUMÁTICO', 6);
INSERT INTO spare_subcategories VALUES('33', 'MECÁNICO', 6);
INSERT INTO spare_subcategories VALUES('34', 'HIDRÁULICO', 6);
INSERT INTO spare_subcategories VALUES('41', 'PARABRISAS', 6);
INSERT INTO spare_subcategories VALUES('42', 'VIDRIOS DE VENTANA', 6);
INSERT INTO spare_subcategories VALUES('43', 'VIDRIOS DE PUERTA', 6);
INSERT INTO spare_subcategories VALUES('44', 'OTROS VIDRIOS', 6);
INSERT INTO spare_subcategories VALUES('45', 'ESPEJOS', 6);
INSERT INTO spare_subcategories VALUES('51', 'PERFILES ALUMNIO', 6);
INSERT INTO spare_subcategories VALUES('52', 'EMPAQUES', 6);
INSERT INTO spare_subcategories VALUES('53', 'TELAS', 6);
INSERT INTO spare_subcategories VALUES('54', 'ASIENTOS', 6);
INSERT INTO spare_subcategories VALUES('55', 'SOPORTES/TOPES', 6);
INSERT INTO spare_subcategories VALUES('56', 'ADHESIVOS', 6);
INSERT INTO spare_subcategories VALUES('57', 'PERFILES PLÁSTICOS', 6);
INSERT INTO spare_subcategories VALUES('58', 'LAMINAS', 6);

DROP TABLE IF EXISTS spare_subclasses;
CREATE TABLE spare_subclasses(
	id int NOT NULL IDENTITY,
	code varchar(20) NOT NULL,
	name varchar(100) NOT NULL,
	subcategory_id int NOT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(subcategory_id) REFERENCES spare_subcategories(id)
);

--Para HERRAMIENTAS
INSERT INTO spare_subclasses VALUES('1', 'MANUALES', 1);
INSERT INTO spare_subclasses VALUES('2', 'ELECTRICAS', 1);
--Para MATERIALES
INSERT INTO spare_subclasses VALUES('1', 'ADHESIVOS', 2);
INSERT INTO spare_subclasses VALUES('2', 'QUIMICOS', 2);
--Para CARROCERIA EXTERNA
INSERT INTO spare_subclasses VALUES('1', 'FIBRA DE VIDRIO DELANTERO', 4);
INSERT INTO spare_subclasses VALUES('2', 'FIBRA DE VIDRIO TRASERO', 4);
INSERT INTO spare_subclasses VALUES('3', 'LATERAL', 4);
INSERT INTO spare_subclasses VALUES('4', 'SUPERIOR - TECHO', 4);
--Para CARROCERIA INTERNA
INSERT INTO spare_subclasses VALUES('1', 'CABINA', 5);
INSERT INTO spare_subclasses VALUES('2', 'SALON', 5);
--Para SISTEMAS DE FUNCIONAMIENTO
INSERT INTO spare_subclasses VALUES('1', 'ELÉCTRICO', 6);
INSERT INTO spare_subclasses VALUES('2', 'NEUMÁTICO', 6);
INSERT INTO spare_subclasses VALUES('3', 'MECÁNICO', 6);
INSERT INTO spare_subclasses VALUES('4', 'HIDRÁULICO', 6);
--Para VIDRIOS
INSERT INTO spare_subclasses VALUES('1', 'PARABRISAS', 7);
INSERT INTO spare_subclasses VALUES('2', 'VIDRIOS DE VENTANA', 7);
INSERT INTO spare_subclasses VALUES('3', 'VIDRIOS DE PUERTA', 7);
INSERT INTO spare_subclasses VALUES('4', 'OTROS VIDRIOS', 7);
INSERT INTO spare_subclasses VALUES('5', 'ESPEJOS', 7);
--Para ACABAMIENTOS
INSERT INTO spare_subclasses VALUES('1', 'PERFILES ALUMINIO', 8);
INSERT INTO spare_subclasses VALUES('2', 'EMPAQUES', 8);
INSERT INTO spare_subclasses VALUES('3', 'TELAS', 8);
INSERT INTO spare_subclasses VALUES('4', 'ASIENTOS', 8);
INSERT INTO spare_subclasses VALUES('5', 'SOPORTES/TOPES', 8);
INSERT INTO spare_subclasses VALUES('6', 'ADHESIVOS', 8);
INSERT INTO spare_subclasses VALUES('7', 'PERFILES PLÁSTICOS/PVC/VYNIL/NYLON', 8);
INSERT INTO spare_subclasses VALUES('8', 'LAMINAS', 8);
--Para VALVULAS
INSERT INTO spare_subclasses VALUES('1', 'EXPANSIÓN', 9);
--Para FILTROS
INSERT INTO spare_subclasses VALUES('1', 'SECADORES', 10);
INSERT INTO spare_subclasses VALUES('2', 'PARA POLVO', 10);
--Para COMPRESORES
INSERT INTO spare_subclasses VALUES('1', 'AUTOBUS', 11);
INSERT INTO spare_subclasses VALUES('2', 'MICROBUS', 11);
--Para KIT REPAROS
INSERT INTO spare_subclasses VALUES('1', 'COMPRESOR', 12);
--Para VENTILADORES
INSERT INTO spare_subclasses VALUES('1', 'EVAPORADOR BLOWER', 13);
INSERT INTO spare_subclasses VALUES('2', 'CONDENSADOR', 13);
--Para VARIOS
INSERT INTO spare_subclasses VALUES('1', 'VISORES DE INSPECCIÓN', 14);
--Para CHASIS
INSERT INTO spare_subclasses VALUES('1', 'LLANTAS', 15);

DROP TABLE IF EXISTS spare;
CREATE TABLE spare(
	id int NOT NULL IDENTITY,
	name varchar(255) NOT NULL,
	image varchar(255) NOT NULL,
	code varchar(25) NOT NULL,
	brand_id int NULL,
	spare_type_id int NOT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(spare_type_id) REFERENCES spare_categories(id),
	FOREIGN KEY (brand_id) REFERENCES brands(id),
);

DROP TABLE IF EXISTS units;
CREATE TABLE units(
	id int NOT NULL IDENTITY,
	measure_description varchar(255) null,
	total int NOT NULL CHECK(total > 0),
	diseño_pintura varchar(100) null,
	año int null,
	modelo varchar(150),
	numero_FC varchar (17) null, /*numero de fabricacion de carroceria*/
	numero_FCH varchar (17) null, /*numero de fabricacion de chasis*/
	marca_carroceria int NOT NULL,
	marca_chasis int NOT NULL,
	marca_motor int NOT NULL,
	brand_id int NOT NULL,
	client_id int NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (brand_id) REFERENCES brands(id),
	FOREIGN KEY (marca_carroceria) REFERENCES brands(id),
	FOREIGN KEY (marca_chasis) REFERENCES brands(id),
	FOREIGN KEY (marca_motor) REFERENCES brands(id),
	FOREIGN KEY (client_id) REFERENCES clients(id)
);

DROP TABLE IF EXISTS units_spare;
CREATE TABLE units_spare(
	id int NOT NULL IDENTITY,
	unit_id int NOT NULL,
	spare_id int NOT NULL

	PRIMARY KEY(id),
	FOREIGN KEY(unit_id) REFERENCES units(id),
	FOREIGN KEY(spare_id) REFERENCES spare(id)
);

DROP TABLE IF EXISTS spare_codes;
CREATE TABLE spare_codes(
	id INT NOT NULL IDENTITY,
	code VARCHAR(20) NOT NULL,
	count_spare INT NOT NULL DEFAULT 0

	PRIMARY KEY(id)
);
