-- DDL

CREATE TABLE Albergo(
	albergoID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Indirizzo VARCHAR(250) NOT NULL,
	Valutazione INT NOT NULL CHECK (Valutazione BETWEEN 1 AND 5)
);



CREATE TABLE Facility(
	facilityID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Descrizione TEXT NOT NULL,
	Orario VARCHAR(50) NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID)
);


CREATE TABLE Dipendente(
	dipendenteID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(50) NOT NULL,
	Cognome VARCHAR(50) NOT NULL,
	Cod_unico VARCHAR(5) NOT NULL UNIQUE,
	Telefono VARCHAR(16) NOT NULL,
	Posizione VARCHAR(50) NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID)
);

CREATE TABLE Camera(
	cameraID INT PRIMARY KEY IDENTITY (1,1),
	Num_unico INT NOT NULL,
	Tipo VARCHAR(50) NOT NULL,
	Capacita VARCHAR(50) NOT NULL,
	Tariffa VARCHAR(250) NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID)
);

CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY (1,1),
	Nome VARCHAR(250) NOT NULL,
	Cognome VARCHAR(250) NOT NULL,
	Telefono VARCHAR(16) NOT NULL,
	Email VARCHAR(50) NOT NULL
);

CREATE TABLE Prenotazione(
	prenotazioneID INT PRIMARY KEY IDENTITY (1,1),
	Check_in VARCHAR(100) NOT NULL,
	Check_out VARCHAR(100) NOT NULL,
	cameraRIF INT NOT NULL, 
	clienteRIF INT NOT NULL,
	FOREIGN KEY (clienteRIF) REFERENCES Cliente(clienteID),
	FOREIGN KEY (cameraRIF) REFERENCES Camera(cameraID),
	UNIQUE (Check_in, Check_out, cameraRIF, clienteRIF)
);