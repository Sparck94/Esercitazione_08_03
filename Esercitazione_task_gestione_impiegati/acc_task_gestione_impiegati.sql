USE acc_task_gestione_impiegati;
-- DDL
DROP TABLE IF EXISTS Impiegato;
DROP TABLE IF EXISTS Reparto;
DROP TABLE IF EXISTS Provincia;
DROP TABLE IF EXISTS Citta;


CREATE TABLE Impiegato(
	impiegatoID INT PRIMARY KEY IDENTITY (1,1),
	matricola VARCHAR(50) NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	data_nascita DATE NOT NULL,
	ruolo VARCHAR(250) NOT NULL,
	reparto VARCHAR(250) NOT NULL,
	indirizzo_residenza VARCHAR(500) NOT NULL,
	citta_residenza VARCHAR(250) NOT NULL,
	provincia_residenza VARCHAR(250) NOT NULL,
);

CREATE TABLE Reparto(
	repartoID INT PRIMARY KEY IDENTITY(1,1),
	nome_reparto VARCHAR(250) NOT NULL,
);

CREATE TABLE Provincia(
	provinciaID INT PRIMARY KEY IDENTITY (1,1),
	nome_provincia VARCHAR(250) NOT NULL UNIQUE,
	sigla VARCHAR(2) NOT NULL UNIQUE,
);

CREATE TABLE Citta(
	cittaID INT PRIMARY KEY IDENTITY (1,1),
	nome_citta VARCHAR(250) NOT NULL UNIQUE,
	provinciaRIF INT NOT NULL,
	FOREIGN KEY (provinciaRIF) REFERENCES Provincia(provinciaID) ON DELETE CASCADE
);

-- DML
-- Inserimento valori tabella Reparto
INSERT INTO Reparto (nome_reparto) VALUES 
('Vendite'),
('Marketing'),
('Risorse Umane'),
('Produzione');

-- Inserimento di dati nella tabella Provincia_di_residenza
INSERT INTO Provincia(nome_provincia, sigla) VALUES 
('Milano', 'MI'),
('Roma', 'RM'),
('Napoli', 'NA'),
('Torino', 'TO');

-- Inserimento di dati nella tabella Citta_di_residenza
INSERT INTO Citta(nome_citta, provinciaRIF) VALUES 
('Milano', 1), 
('Roma', 2),
('Napoli', 3), 
('Torino', 4);

-- Inserimento di dati nella tabella Impiegato
INSERT INTO Impiegato (matricola, nome, cognome, data_nascita, ruolo, reparto, indirizzo_residenza, citta_residenza, provincia_residenza) VALUES 
('001', 'Mario', 'Rossi', '1990-05-15', 'Manager', 'Vendite', 'Via Roma 1', 'Milano', 'MI'),
('002', 'Laura', 'Bianchi', '1985-10-20', 'Analista', 'Marketing', 'Via Verdi 2', 'Roma', 'RM'),
('003', 'Luigi', 'Verdi', '1992-03-25', 'Sviluppatore', 'Produzione', 'Via Napoli 3', 'Napoli', 'NA'),
('004', 'Giulia', 'Rosa', '1988-07-10', 'HR Specialist', 'Risorse Umane', 'Via Torino 4', 'Torino', 'TO');


-- QL
SELECT * FROM Impiegato;
SELECT * FROM Reparto;
SELECT * FROM Provincia;
SELECT * FROM Citta;



