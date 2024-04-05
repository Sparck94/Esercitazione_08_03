USE acc_task_database_nasa;
-- DDL
DROP TABLE IF EXISTS OggettoCeleste;

CREATE TABLE OggettoCeleste(
	OggettoCelesteID INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(250) NOT NULL,
	Codice VARCHAR(250) NOT NULL,
	DataScoperta DATE NOT NULL,
	Scopritore VARCHAR(250) DEFAULT 'Sconosciuto',
	Tipologia VARCHAR(250) NOT NULL,
	Distanza DECIMAL(20,2) NOT NULL,
	CoordinataRadiale DECIMAL (10,2) NOT NULL,
	CoordinataAngolare DECIMAL(10,2) NOT NULL,
);

DROP TABLE IF EXISTS Sistema;

CREATE TABLE Sistema(
	sistemaID INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(250) NOT NULL,
	Codice VARCHAR(250) NOT NULL,
	Tipo VARCHAR(250) NOT NULL,	
);

DROP TABLE IF EXISTS Pianeta_Sistema;

CREATE TABLE OggettoCeleste_Sistema(
	oggettoCelesteRIF INT NOT NULL,
	sistemaRIF INT NOT NULL,
	FOREIGN KEY (oggettoCelesteRIF) REFERENCES Sistema(sistemaID),
	FOREIGN KEY (sistemaRIF) REFERENCES OggettoCeleste(oggettoCelesteID),
	PRIMARY KEY (oggettoCelesteRIF, sistemaRIF)
);

SELECT * FROM OggettoCeleste;
SELECT * FROM Sistema;
SELECT * FROM OggettoCeleste_Sistema;
-- DML
INSERT INTO OggettoCeleste(Nome, Codice, DataScoperta, Scopritore, Tipologia, Distanza, CoordinataRadiale, CoordinataAngolare)VALUES
	('Giove', 'JUP', '1610-01-07', 'Galileo Galilei', 'Gigante gassoso', 5.20, 4.00, 45.00),
	('Terra', 'TER', '1549-02-05', 'Davide Giungato', 'Pianeta', 10.2, 6.00, 60.00),
	('Saturno', 'SAT', '1600-05-08', 'Giorgio Moroni', 'Gigante gassoso', 25.3, 5.00, 85.00),
	('Plutone', 'PLU', '1800-07-03',DEFAULT , 'Pianeta', 50.5, 10.00, 120.00),
	('Nettuno', 'NEP', '2000-01-01','Stella' ,'Marco Parisi', 10.00, 25.50, 260);

INSERT INTO Sistema(Nome, Codice, Tipo) VALUES
	('Andromeda', 'AND', 'Galassia'),
	('Alpha Centauri', 'ALP', 'Binario'),
	('Trappist-1', 'TRA', 'Esopianeti');




