CREATE TABLE [dbo].[CustomerItemData]
(
	[TopLevel] INT NOT NULL , 
    [Material] INT NOT NULL, 
    [CustomerNumber] NVARCHAR(50) NOT NULL, 
    [NoteProduction] INT NOT NULL, 
    [NoteGeneral] INT NOT NULL, 
    [NoteShipping] INT NOT NULL, 
    [tstamp] DATETIME NOT NULL, 
    PRIMARY KEY ([TopLevel], [Material])
)
