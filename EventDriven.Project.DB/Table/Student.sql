CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [LastName] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [MiddleName] VARCHAR(50) NOT NULL, 
    [GradeLevel] INT NOT NULL, 
    [Section] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [ContactNumber] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [EnrollmentStatus] VARCHAR(50) NULL
)
