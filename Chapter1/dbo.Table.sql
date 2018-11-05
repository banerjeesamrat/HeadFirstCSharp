CREATE TABLE [dbo].[People]
(
	[ContactId] INT NOT NULL PRIMARY KEY IDENTITY, 
    	[Name] NVARCHAR(50) NULL,
	[Company] NVARCHAR(50) NULL,
	[Telephone] NVARCHAR(50) NULL,
	[Email] NVARCHAR(50) NULL,
	[Client] BIT NULL,
	[LastCall] DATETIME NULL,

)
