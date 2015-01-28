CREATE TABLE [dbo].[Historical]
(
	[TopLevel] INT NOT NULL , 
    [Customer] INT NOT NULL, 
    [Material] INT NOT NULL, 
    [tstamp] DATETIME NOT NULL, 
    [Avg3Month] DECIMAL NOT NULL, 
    [Avg6Month] DECIMAL NOT NULL, 
    [Avg12Month] DECIMAL NOT NULL, 
    [PeakConsumptionQty] INT NOT NULL, 
    [PeakConsumptionMonthOffset] INT NOT NULL, 
    [MinConsumptionQty] INT NOT NULL, 
    [MinConsumptionMonthOffset] INT NOT NULL, 
    [EightMonthHistory] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY ([Material], [Customer], [TopLevel])
)
