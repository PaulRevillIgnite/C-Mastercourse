CREATE TABLE [dbo].[ContactAddresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ContactID] INT NOT NULL, 
    [PhoneNumberID] INT NOT NULL
)
