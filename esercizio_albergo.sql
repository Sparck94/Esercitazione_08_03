-- DDL

CREATE TABLE Albergo(
	albergoID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Indirizzo VARCHAR(250) NOT NULL,
	UNIQUE (Nome, Indirizzo)	
);
CREATE TABLE Facility(
	facilityID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Descrizione TEXT NOT NULL,
	Orario TEXT NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE
);
CREATE TABLE Dipendente(
	dipendenteID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(50) NOT NULL,
	Cognome VARCHAR(50) NOT NULL,
	Cod_unico VARCHAR(5) NOT NULL UNIQUE,
	Telefono VARCHAR(16) NOT NULL,
	Posizione VARCHAR(50) NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE
);
CREATE TABLE Camera(
	cameraID INT PRIMARY KEY IDENTITY (1,1),
	Num_unico INT NOT NULL,
	Tipo VARCHAR(50) NOT NULL,
	Capacita VARCHAR(50) NOT NULL,
	Tariffa DECIMAL(10, 2) NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE
);
CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Cognome VARCHAR(250) NOT NULL,
	Telefono VARCHAR(16) NOT NULL,
	Email VARCHAR(50) NOT NULL,
);
CREATE TABLE Prenotazione(
	prenotazioneID INT PRIMARY KEY IDENTITY (1,1),
	Check_in DATE NOT NULL,
	Check_out DATE NOT NULL,
	cameraRIF INT NOT NULL, 
	clienteRIF INT NOT NULL,
	FOREIGN KEY (clienteRIF) REFERENCES Cliente(clienteID),
	FOREIGN KEY (cameraRIF) REFERENCES Camera(cameraID),
	UNIQUE (cameraRIF, Check_in)
);
CREATE TABLE Recensione(
	recensioneID INT PRIMARY KEY IDENTITY (1,1),
	valutazione INT CHECK (valutazione BETWEEN 1 AND 5),
	descrizione TEXT,
	prenotazioneRIF INT NOT NULL,
	FOREIGN KEY (prenotazioneRIF) REFERENCES Prenotazione(prenotazioneID) ON DELETE CASCADE
	-- Verificare se la recensione può essere inserita a fine del soggiorno (chekout riempito)
);
--VIEWS
CREATE VIEW albergoConRelativiClienti AS 
	SELECT al.Nome AS 'Albergo', cl.Nome + ' ' + cl.Cognome AS 'Nominativo'
		FROM Albergo al 
		JOIN Camera ca ON al.albergoID = ca.albergoRIF
		JOIN Prenotazione p ON ca.cameraID = p.cameraRIF
		JOIN Cliente cl ON p.clienteRIF = cl.clienteID;

SELECT * FROM albergoConRelativiClienti;

------------------------------------------
CREATE VIEW albergoGeneraleConClienti AS
	SELECT albergoID, al.Nome AS nome_albergo, Indirizzo, cl.Nome + ' ' + cl.Cognome AS 'Nominativo'
		FROM Albergo al 
		JOIN Camera ca ON al.albergoID = ca.albergoRIF
		JOIN Prenotazione p ON ca.cameraID = p.cameraRIF
		JOIN Cliente cl ON p.clienteRIF = cl.clienteID;

SELECT * FROM albergoGeneraleConClienti;

SELECT *, Facility.Nome AS facility_nome
	FROM albergoGeneraleConClienti
	JOIN Facility ON albergoGeneraleConClienti.albergoID = Facility.albergoRIF;



	

