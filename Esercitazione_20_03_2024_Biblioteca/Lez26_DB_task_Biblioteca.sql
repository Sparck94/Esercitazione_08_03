-- DDL
--DROP TABLE IF EXISTS Utente;
CREATE TABLE Utente(
	utenteId INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250),
	codiceUtente VARCHAR(50) NOT NULL UNIQUE
);
--DROP TABLE IF EXISTS Libro;
CREATE TABLE Libro (
	libroId INT PRIMARY KEY IDENTITY(1,1),
	titolo VARCHAR(250) NOT NULL,
	annoPub INT NOT NULL,
	isDisponibile BIT DEFAULT 1,
	isbn VARCHAR(50)NOT NULL UNIQUE,
	deleted DATETIME					-- Non essendo null puo non esistere, nel momento in cui esiste segnala la data di cancellazione
);
--DROP TABLE IF EXISTS Prestiti;
CREATE TABLE Prestiti(
	prestitiId INT PRIMARY KEY IDENTITY(1,1),
	dataPrestito DATE DEFAULT CURRENT_TIMESTAMP,
	dataRitorno DATE,
	utenteRIF INT NOT NULL,
	libroRIF INT NOT NULL,
	codicePrestito VARCHAR(50) NOT NULL UNIQUE
	FOREIGN KEY (utenteRIF) REFERENCES Utente(utenteId),
	FOREIGN KEY (libroRIF) REFERENCES Libro(libroId),
);