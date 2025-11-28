CREATE TABLE [dbo].[tblStudentReg]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[StudentId] INT NOT NULL,
	[Section] VARCHAR(50) NULL,
	[Requirements] VARCHAR(100) NOT NULL
	
)
