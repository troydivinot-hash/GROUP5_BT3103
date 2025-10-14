CREATE PROCEDURE [dbo].[AddStudent]
	@LastName varchar(50),
	@FirstName varchar(50),
	@MiddleName varchar(50),
	@GradeLevel int,
	@Section varchar(50),
	@Gender varchar(50),
	@ContactNumber varchar(50),
	@Address varchar(50),
	@EnrollmentStatus varchar(50)

	as insert into Student(LastName, FirstName,	MiddleName, 
	GradeLevel, Section, Gender, ContactNumber, Address, EnrollmentStatus) values 
	(@LastName, @FirstName,	@MiddleName, 
	@GradeLevel, @Section, @Gender, @ContactNumber, @Address, @EnrollmentStatus)