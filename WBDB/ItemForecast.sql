CREATE TABLE [dbo].[Forecast]
(
	[TopLevel] INT NOT NULL , 
    [Material] INT NOT NULL, 
    [Offset] INT NOT NULL, 
    [tstamp] DATETIME NOT NULL, 
    [Qty] INT NOT NULL, 
    PRIMARY KEY ([TopLevel], [Material], [Offset])
)
