CREATE PROCEDURE UpdateStudent
    @Id INT, 
    @LastName VARCHAR(50), 
    @FirstName VARCHAR(50), 
    @MiddleName VARCHAR(50), 
    @Suffix VARCHAR(20) = NULL,
    @DateOfBirth DATE, 
    @Address VARCHAR(255), 
    @Gender VARCHAR(50),  -- NOT NULL
    @ContactNumber VARCHAR(50),  -- NOT NULL
    @Email VARCHAR(100) = NULL, 
    @StudentType VARCHAR(50),  -- NOT NULL
    @FathersName VARCHAR(50),  -- NOT NULL
    @FathersContact VARCHAR(50),  -- NOT NULL
    @MothersName VARCHAR(50),  -- NOT NULL
    @MothersContact VARCHAR(50),  -- NOT NULL
    @GuardianName VARCHAR(50) = NULL, 
    @GuardianContact VARCHAR(50) = NULL, 
    @Relationship VARCHAR(50)  -- NOT NULL
AS
BEGIN
    -- Validation
    IF @Id IS NULL OR @Id <= 0
    BEGIN
        RAISERROR('Invalid or missing Student ID.', 16, 1);
        RETURN;
    END;
    IF @Gender IS NULL OR @ContactNumber IS NULL OR @StudentType IS NULL OR 
       @FathersName IS NULL OR @FathersContact IS NULL OR @MothersName IS NULL OR 
       @MothersContact IS NULL OR @Relationship IS NULL
    BEGIN
        RAISERROR('Required fields cannot be NULL.', 16, 1);
        RETURN;
    END;

    BEGIN TRY
        UPDATE Student SET
            LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, Suffix = @Suffix,
            DateOfBirth = @DateOfBirth, Address = @Address, Gender = @Gender, ContactNumber = @ContactNumber,
            Email = @Email, StudentType = @StudentType, FathersName = @FathersName, FathersContact = @FathersContact,
            MothersName = @MothersName, MothersContact = @MothersContact, GuardianName = @GuardianName,
            GuardianContact = @GuardianContact, Relationship = @Relationship
        WHERE ID = @Id;

        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No student found with the specified ID.', 16, 1);
        END;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR('Error updating student: %s', 16, 1, @ErrorMessage);
    END CATCH;
END;