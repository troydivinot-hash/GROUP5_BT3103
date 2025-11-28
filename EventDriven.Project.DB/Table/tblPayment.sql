CREATE TABLE [dbo].[tblPayment]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [StudentId] INT NOT NULL FOREIGN KEY REFERENCES Student(Id), 
    [AmountPaid] DECIMAL(10, 2) NOT NULL, 
    [Change] DECIMAL(10, 2) NOT NULL,
    [DatePaid] DATETIME NULL DEFAULT GETDATE(), 
);

