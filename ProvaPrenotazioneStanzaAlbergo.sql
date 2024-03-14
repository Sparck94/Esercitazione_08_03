USE task_vista_albergo;

SELECT * FROM Prenotazione;

/*
Sull'esercizio degli alberghi, permettere la prenotazione solo tramite SP ed 
evitare che la prenotazione ne sovrasti una già attiva su una stanza.
*/
CREATE TABLE Prenotazione (
    prenotazioneID INT PRIMARY KEY IDENTITY (1,1),
    dataCheckIn DATE NOT NULL,
    dataCheckOut DATE NOT NULL,
    cameraRIF INT NOT NULL,
    clienteRIF INT,
    FOREIGN KEY (cameraRIF) REFERENCES Camera(cameraID) ON DELETE CASCADE,
    FOREIGN KEY (clienteRIF) REFERENCES Cliente(clienteID) ON DELETE SET NULL,
	-- DA FINIRE...
);


CREATE PROCEDURE controlloPrenotazione
	@checkIn DATA NOT NULL,
	@checkOut DATA,
	@cameraRiferimento INT,
	@clienteRiferimento INT
AS
	BEGIN
		BEGIN TRY
			SELECT * FROM Prenotazione WHERE cameraRIF = @cameraRiferimento
			BEGIN TRANSACTION
				IF @checkIn > dataCheckIn OR @checkIn < dataCheckOut 
					OR @checkIn BETWEEN dataCheckIn AND dataCheckout
					THROW 50001, 'Stanza occupata',1
				ELSE
				BEGIN 
					INSERT INTO Prenotazione(dataCheckIn, dataCheckOut, cameraRIF, clienteRIF) VALUES
						(@checkIn, @checkOut, @cameraRiferimento, @clienteRiferimento)
					PRINT 'Prenotazione effettuata con successo'
				END
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			
			PRINT 'Errore riscontrato' + ERROR_MESSAGE()
		END CATCH

	END;
