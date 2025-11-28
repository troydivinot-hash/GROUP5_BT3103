CREATE PROCEDURE InsertStudent
    @LastName VARCHAR(50), 
    @FirstName VARCHAR(50), 
    @MiddleName VARCHAR(50), 
    @Suffix VARCHAR(20) = NULL,
    @DateOfBirth DATE, 
    @Address VARCHAR(255), 
    @Gender VARCHAR(50),  -- NOT NULL, no default
    @ContactNumber VARCHAR(50),  -- NOT NULL
    @Email VARCHAR(100) = NULL, 
    @StudentType VARCHAR(50),  -- NOT NULL
    @FathersName VARCHAR(50),  -- NOT NULL
    @FathersContact VARCHAR(50),  -- NOT NULL
    @MothersName VARCHAR(50),  -- NOT NULL
    @MothersContact VARCHAR(50),  -- NOT NULL
    @GuardianName VARCHAR(50) = NULL, 
    @Relationship VARCHAR(50)  -- NOT NULL, no default
AS
BEGIN
    -- Validation for NOT NULL fields
    IF @Gender IS NULL OR @ContactNumber IS NULL OR @StudentType IS NULL OR 
       @FathersName IS NULL OR @FathersContact IS NULL OR @MothersName IS NULL OR 
       @MothersContact IS NULL OR @Relationship IS NULL
    BEGIN
        RAISERROR('Required fields cannot be NULL.', 16, 1);
        RETURN;
    END;

    BEGIN TRY
        INSERT INTO Student (LastName, FirstName, MiddleName, Suffix, DateOfBirth, Address, Gender, ContactNumber, Email, StudentType, FathersName, FathersContact, MothersName, MothersContact, GuardianName, Relationship)
        VALUES (@LastName, @FirstName, @MiddleName, @Suffix, @DateOfBirth, @Address, @Gender, @ContactNumber, @Email, @StudentType, @FathersName, @FathersContact, @MothersName, @MothersContact, @GuardianName, @Relationship);
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR('Error inserting student: %s', 16, 1, @ErrorMessage);
    END CATCH;
END;