CREATE DATABASE task_ferramenta;
USE task_ferramenta;
DROP TABLE IF EXISTS Prodotto;
-- DDL
CREATE TABLE Prodotto(
	prodottoId INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL (10,2) NOT NULL CHECK (prezzo >=0),
	quantita INT NOT NULL CHECK (quantita >= 0),
	categoria VARCHAR(250) NOT NULL UNIQUE,
	data_creazione DATE NOT NULL
);

SELECT * FROM Prodotto;