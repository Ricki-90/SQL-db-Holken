-- Lägger till en adress och en kunde som har den adressen
IF NOT EXISTS (SELECT Id FROM Renters WHERE Email = 'sten@domain.com')
	
	
	IF NOT EXISTS (SELECT Id FROM Renter_Addresses WHERE StreetName = 'Gipsvägen 1' AND PostalCode = '168 54')
		INSERT INTO Renter_Addresses VALUES ('Gipsvägen 1', '168 54', 'Stockholm')
	ELSE
		PRINT 'ADDRESS ALREADY EXISTS'
	END
	
	INSERT INTO Renters VALUES ('Sten', 'Flugsson', 'sten@domain.com', '072-090 11 78', 6)
ELSE
	PRINT 'EXISTS'






INSERT INTO Renter_Addresses VALUES ('Gipsvägen 1', '168 54', 'Stockholm')
INSERT INTO Renters VALUES ('Sten', 'Flugsson', 'sten@domain.com', '072-090 11 78', 6)

-- Hämtar alla adresser och hämtar alla kunder
SELECT * FROM Renter_Addresses
SELECT * FROM Renters

-- Hämtar alla kunder och dess adress
SELECT
	c.Id, c.FirstName, c.Lastname, c.Email, PhoneNumber,
	a.StreetName, a.PostalCode, a.City
FROM Renters c
JOIN Renter_Addresses a ON c.Renter_AddressesId = a.Id

-- Hämtar en specifik kund och adressen för kunden
SELECT
	c.Id, c.FirstName, c.Lastname, c.Email, PhoneNumber,
	a.StreetName, a.PostalCode, a.City
FROM Renters c
JOIN Renter_Addresses a ON c.Renter_AddressesId = a.Id
WHERE c.Email = 'kalle@domain.com'
