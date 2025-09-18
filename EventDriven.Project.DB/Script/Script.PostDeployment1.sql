/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO TblUser (Username, Password) 
VALUES 
    ('admin', 'admin123'),
    ('registrar', 'registrar123'),
    ('cashier', 'cashier123');

-- Student Table Values
INSERT INTO Student (LastName, FirstName, MiddleName, GradeLevel, Section, Gender, ContactNumber, Address, EnrollmentStatus)
VALUES -- Grade 7 - Section Fluorescent
('Santos', 'Juan', 'Reyes', 7, 'Fluorescent', 'Male', '09123456701', 'Antipolo City', 'Enrolled'),
('Dela Cruz', 'Maria', 'Lopez', 7, 'Fluorescent', 'Female', '09123456702', 'Quezon City', 'Enrolled'),
('Garcia', 'Pedro', 'Bautista', 7, 'Fluorescent', 'Male', '09123456703', 'Pasig City', 'Enrolled'),
('Reyes', 'Ana', 'Torres', 7, 'Fluorescent', 'Female', '09123456704', 'Marikina City', 'Enrolled'),
('Mendoza', 'Jose', 'Villanueva', 7, 'Fluorescent', 'Male', '09123456705', 'Caloocan City', 'Enrolled'),
('Castillo', 'Rosa', 'Ramos', 7, 'Fluorescent', 'Female', '09123456706', 'Manila City', 'Enrolled'),
('Aquino', 'Lito', 'Domingo', 7, 'Fluorescent', 'Male', '09123456707', 'Mandaluyong City', 'Enrolled'),
('Domingo', 'Grace', 'Fernandez', 7, 'Fluorescent', 'Female', '09123456708', 'San Mateo, Rizal', 'Enrolled'),
('Ramos', 'Nathan', 'Ortiz', 7, 'Fluorescent', 'Male', '09123456709', 'Taguig City', 'Enrolled'),
('Perez', 'Angela', 'Navarro', 7, 'Fluorescent', 'Female', '09123456710', 'Pateros City', 'Enrolled'),
('Martinez', 'David', 'Vergara', 7, 'Fluorescent', 'Male', '09123456711', 'Valenzuela City', 'Enrolled'),
('Navarro', 'Chloe', 'Aguilar', 7, 'Fluorescent', 'Female', '09123456712', 'Muntinlupa City', 'Enrolled'),

-- Grade 8 - Section LED
('Jimenez', 'Ryan', 'Dominguez', 8, 'LED', 'Male', '09123456713', 'Olongapo City', 'Enrolled'),
('Serrano', 'Hannah', 'Cortez', 8, 'LED', 'Female', '09123456714', 'Lucena City', 'Enrolled'),
('Rivera', 'Isabella', 'Navarro', 8, 'LED', 'Female', '09123456715', 'Legazpi City', 'Enrolled'),
('Pascual', 'Christian', 'Diaz', 8, 'LED', 'Male', '09123456716', 'Iloilo City', 'Enrolled'),
('Torres', 'Angela', 'Castro', 8, 'LED', 'Female', '09123456717', 'Davao City', 'Enrolled'),
('Vergara', 'David', 'Ramos', 8, 'LED', 'Male', '09123456718', 'Zamboanga City', 'Enrolled'),
('Aquino', 'Sophia', 'Martinez', 8, 'LED', 'Female', '09123456719', 'Cavite City', 'Enrolled'),
('Domingo', 'Mark', 'Perez', 8, 'LED', 'Male', '09123456720', 'Bacoor City', 'Enrolled'),
('Villanueva', 'Ella', 'Reyes', 8, 'LED', 'Female', '09123456721', 'Calamba City', 'Enrolled'),
('Delos Santos', 'Ian', 'Garcia', 8, 'LED', 'Male', '09123456722', 'Dasmarinas City', 'Enrolled'),
('Tan', 'Julia', 'Torres', 8, 'LED', 'Female', '09123456723', 'Trece Martires City', 'Enrolled'),
('Lim', 'Kevin', 'Ortiz', 8, 'LED', 'Male', '09123456724', 'Imus City', 'Enrolled'),
('Go', 'Karen', 'Lopez', 8, 'LED', 'Female', '09123456725', 'San Pedro City', 'Enrolled'),

-- Grade 9 - Section Halogen
('Aguilar', 'Paulo', 'Ramos', 9, 'Halogen', 'Male', '09123456726', 'Binan City', 'Enrolled'),
('Navarro', 'Bianca', 'Mendoza', 9, 'Halogen', 'Female', '09123456727', 'Sta. Rosa City', 'Enrolled'),
('Vergara', 'Simon', 'Perez', 9, 'Halogen', 'Male', '09123456728', 'Tagaytay City', 'Enrolled'),
('Reyes', 'Elaine', 'Bautista', 9, 'Halogen', 'Female', '09123456729', 'Carmona City', 'Enrolled'),
('Santos', 'Victor', 'Castillo', 9, 'Halogen', 'Male', '09123456730', 'General Trias City', 'Enrolled'),
('Gonzalez', 'Patricia', 'Ortiz', 9, 'Halogen', 'Female', '09123456731', 'Silang, Cavite', 'Enrolled'),
('Ramos', 'Julian', 'Tan', 9, 'Halogen', 'Male', '09123456732', 'Naga City', 'Enrolled'),
('Lopez', 'Karla', 'Lim', 9, 'Halogen', 'Female', '09123456733', 'Bicol City', 'Enrolled'),
('Martinez', 'Enrique', 'Domingo', 9, 'Halogen', 'Male', '09123456734', 'Lucban, Quezon', 'Enrolled'),
('Aquino', 'Fiona', 'Pascual', 9, 'Halogen', 'Female', '09123456735', 'San Fernando, Pampanga', 'Enrolled'),
('Castillo', 'Megan', 'Ramos', 9, 'Halogen', 'Female', '09123456736', 'Malolos, Bulacan', 'Enrolled'),
('Bautista', 'Liam', 'Mendoza', 9, 'Halogen', 'Male', '09123456737', 'Tarlac City', 'Enrolled'),

-- Grade 10 - Section Incandescent
('Ramos', 'Nathaniel', 'Cruz', 10, 'Incandescent', 'Male', '09123456738', 'Baguio City', 'Enrolled'),
('Perez', 'Andrea', 'Reyes', 10, 'Incandescent', 'Female', '09123456739', 'Dagupan City', 'Enrolled'),
('Torres', 'Joshua', 'Castillo', 10, 'Incandescent', 'Male', '09123456740', 'Laoag City', 'Enrolled'),
('Santos', 'Monica', 'Aquino', 10, 'Incandescent', 'Female', '09123456741', 'Vigan City', 'Enrolled'),
('Garcia', 'Samuel', 'Villanueva', 10, 'Incandescent', 'Male', '09123456742', 'Bangued City', 'Enrolled'),
('Navarro', 'Isabel', 'Bautista', 10, 'Incandescent', 'Female', '09123456743', 'Bontoc City', 'Enrolled'),
('Lim', 'Erik', 'Domingo', 10, 'Incandescent', 'Male', '09123456744', 'Tuguegarao City', 'Enrolled'),
('Tan', 'Rachel', 'Torres', 10, 'Incandescent', 'Female', '09123456745', 'Cabanatuan City', 'Enrolled'),
('Villanueva', 'Harvey', 'Perez', 10, 'Incandescent', 'Male', '09123456746', 'San Jose City', 'Enrolled'),
('Mendoza', 'Alexa', 'Gonzalez', 10, 'Incandescent', 'Female', '09123456747', 'Angeles City', 'Enrolled'),
('Cruz', 'Nathan', 'Lopez', 10, 'Incandescent', 'Male', '09123456748', 'Mabalacat City', 'Enrolled'),
('Aquino', 'Sophia', 'Ortiz', 10, 'Incandescent', 'Female', '09123456749', 'San Fernando, Pampanga', 'Enrolled'),
('Domingo', 'Ethan', 'Ramos', 10, 'Incandescent', 'Male', '09123456750', 'Clark, Pampanga', 'Enrolled');