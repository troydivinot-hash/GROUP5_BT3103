CREATE TABLE [dbo].[Student]
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    LastName VARCHAR(50) NULL,
    FirstName VARCHAR(50) NULL,
    MiddleName VARCHAR(50) NULL,
    Suffix VARCHAR(20) NULL,
    DateOfBirth DATE NULL,
    Address VARCHAR(255) NULL,
    Gender VARCHAR(50) NOT NULL,
    ContactNumber VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    StudentType VARCHAR(50) NOT NULL, 
    FathersName VARCHAR(50) NOT NULL,
    FathersContact VARCHAR(50) NOT NULL,
    MothersName VARCHAR(50) NOT NULL,
    MothersContact VARCHAR(50) NOT NULL,
    GuardianName VARCHAR(50) NULL,
    Relationship VARCHAR(50) NOT NULL
)
