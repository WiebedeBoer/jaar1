CREATE TABLE userlist
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [email] NVARCHAR(80) NOT NULL, 
    [password] NCHAR(10) NOT NULL, 
    [brideId] INT NULL, 
    [unikey] NCHAR(10) NULL, 
    [bridemail] NCHAR(80) NULL
)
