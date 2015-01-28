CREATE TABLE [dbo].[GenericItemData]
(
	[Material] INT NOT NULL PRIMARY KEY, 
    [Brand] NVARCHAR(75) NOT NULL, 
    [Shape] NVARCHAR(75) NOT NULL, 
    [PcWt] DECIMAL NOT NULL, 
    [PH] NCHAR(7) NOT NULL, 
    [tstamp] DATETIME NOT NULL
)
