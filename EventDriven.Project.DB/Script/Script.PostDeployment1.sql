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

INSERT INTO TblUser (Username, Password, Roles) 
VALUES 
    ('admin', 'admin123', 'Admin'),
    ('registrar', 'registrar123', 'Registrar'),
    ('cashier', 'cashier123', 'Cashier');

-- Student Table Values
INSERT INTO Student
(
    LastName, FirstName, MiddleName, Suffix, DateOfBirth, Address, Gender,
    ContactNumber, Email, StudentType,
    FathersName, FathersContact, MothersName, MothersContact,
    GuardianName, GuardianContact, Relationship
)
VALUES
-- Grade 7
('Santos', 'Juan', 'Reyes', NULL, '2013-08-15', 'Antipolo City', 'Male', '09123456701', 'juan.santos@email.com', 'New', 'Jose Santos', '09991234567', 'Maria Reyes', '09998765432', 'Pedro Santos', '09990001111', 'Uncle'),
('Dela Cruz', 'Maria', 'Lopez', NULL, '2013-07-20', 'Quezon City', 'Female', '09123456702', 'maria.delacruz@email.com', 'New', 'Juan Dela Cruz', '09992345678', 'Ana Lopez', '09997654321', NULL, NULL, 'N/A'),
('Garcia', 'Pedro', 'Bautista', NULL, '2013-04-30', 'Pasig City', 'Male', '09123456703', 'pedro.garcia@email.com', 'New', 'Carlos Garcia', '09993456789', 'Luz Bautista', '09996543210', 'Luis Garcia', '09995432109', 'Guardian'),
('Reyes', 'Ana', 'Torres', NULL, '2013-11-02', 'Marikina City', 'Female', '09123456704', 'ana.reyes@email.com', 'New', 'Jose Torres', '09984321654', 'Maria Torres', '09987654123', NULL, NULL, 'N/A'),
('Mendoza', 'Jose', 'Villanueva', NULL, '2013-06-10', 'Caloocan City', 'Male', '09123456705', 'jose.mendoza@email.com', 'New', 'Luis Mendoza', '09981234567', 'Carmen Villanueva', '09981234568', NULL, NULL, 'N/A'),
('Castillo', 'Rosa', 'Ramos', NULL, '2013-03-18', 'Manila City', 'Female', '09123456706', 'rosa.castillo@email.com', 'Old', 'Pedro Castillo', '09987654321', 'Luisa Ramos', '09987654322', 'Marta Ramos', '09986543210', 'Aunt'),
('Aquino', 'Lito', 'Domingo', NULL, '2013-01-25', 'Mandaluyong City', 'Male', '09123456707', 'lito.aquino@email.com', 'New', 'Gerard Aquino', '09984321654', 'Helen Domingo', '09987651099', NULL, NULL, 'N/A'),
('Domingo', 'Grace', 'Fernandez', NULL, '2013-05-07', 'San Mateo, Rizal', 'Female', '09123456708', 'grace.domingo@email.com', 'New', 'Samuel Fernandez', '09985432100', 'Liza Domingo', '09983421678', 'Carlos Fernandez', '09983217654', 'Guardian'),
('Ramos', 'Nathan', 'Ortiz', NULL, '2013-07-08', 'Taguig City', 'Male', '09123456709', 'nathan.ramos@email.com', 'Old', 'Victor Ramos', '09982345678', 'Clara Ortiz', '09981236754', NULL, NULL, 'N/A'),
('Perez', 'Angela', 'Navarro', NULL, '2013-02-11', 'Pateros City', 'Female', '09123456710', 'angela.perez@email.com', 'New', 'Ricardo Perez', '09980123456', 'Clara Navarro', '09980987654', NULL, NULL, 'N/A'),
('Martinez', 'David', 'Vergara', NULL, '2013-11-22', 'Valenzuela City', 'Male', '09123456711', 'david.martinez@email.com', 'New', 'Alfredo Martinez', '09981234567', 'Maria Vergara', '09987654321', 'Felix Martinez', '09982345654', 'Guardian'),
('Navarro', 'Chloe', 'Aguilar', NULL, '2013-08-30', 'Muntinlupa City', 'Female', '09123456712', 'chloe.navarro@email.com', 'Old', 'Jason Navarro', '09987651234', 'Leah Aguilar', '09985432123', NULL, NULL, 'N/A'),

-- Grade 8
('Jimenez', 'Ryan', 'Dominguez', NULL, '2012-09-18', 'Olongapo City', 'Male', '09123456713', 'ryan.jimenez@email.com', 'New', 'Mario Jimenez', '09983421678', 'Anna Dominguez', '09981236754', NULL, NULL, 'N/A'),
('Serrano', 'Hannah', 'Cortez', NULL, '2012-06-30', 'Lucena City', 'Female', '09123456714', 'hannah.serrano@email.com', 'Old', 'Jose Serrano', '09987654321', 'Linda Cortez', '09987651099', 'Martha Serrano', '09986543210', 'Aunt'),
('Rivera', 'Isabella', 'Navarro', NULL, '2012-11-10', 'Legazpi City', 'Female', '09123456715', 'isabella.rivera@email.com', 'New', 'Ramon Rivera', '09981234567', 'Liza Navarro', '09982345678', NULL, NULL, 'N/A'),
('Pascual', 'Christian', 'Diaz', NULL, '2012-03-05', 'Iloilo City', 'Male', '09123456716', 'christian.pascual@email.com', 'New', 'Manuel Pascual', '09980123456', 'Ana Diaz', '09980987654', NULL, NULL, 'N/A'),
('Torres', 'Angela', 'Castro', NULL, '2012-12-11', 'Davao City', 'Female', '09123456717', 'angela.torres@email.com', 'New', 'Jose Torres', '09983456789', 'Clara Castro', '09987654321', 'Mia Torres', '09985432109', 'Guardian'),
('Vergara', 'David', 'Ramos', NULL, '2012-08-09', 'Zamboanga City', 'Male', '09123456718', 'david.vergara@email.com', 'Old', 'Carlos Vergara', '09986543210', 'Luz Ramos', '09982345654', NULL, NULL, 'N/A'),
('Aquino', 'Sophia', 'Martinez', NULL, '2012-04-24', 'Cavite City', 'Female', '09123456719', 'sophia.aquino@email.com', 'New', 'Gerard Aquino', '09981237856', 'Helen Martinez', '09987651023', NULL, NULL, 'N/A'),
('Domingo', 'Mark', 'Perez', NULL, '2012-02-17', 'Bacoor City', 'Male', '09123456720', 'mark.domingo@email.com', 'New', 'Samuel Perez', '09980123789', 'Liza Domingo', '09981239876', 'Carlos Perez', '09982347561', 'Guardian'),
('Villanueva', 'Ella', 'Reyes', NULL, '2012-10-22', 'Calamba City', 'Female', '09123456721', 'ella.villanueva@email.com', 'Old', 'Victor Villanueva', '09987651099', 'Clara Reyes', '09987653210', NULL, NULL, 'N/A'),
('Delos Santos', 'Ian', 'Garcia', NULL, '2012-05-30', 'Dasmarinas City', 'Male', '09123456722', 'ian.delossantos@email.com', 'New', 'Alfredo Delos Santos', '09982351234', 'Felicia Garcia', '09981237654', NULL, NULL, 'N/A'),
('Tan', 'Julia', 'Torres', NULL, '2012-08-14', 'Trece Martires City', 'Female', '09123456723', 'julia.tan@email.com', 'New', 'Roberto Tan', '09984561234', 'Clarissa Torres', '09983456123', 'Maria Tan', '09987654321', 'Aunt'),
('Lim', 'Kevin', 'Ortiz', NULL, '2012-04-18', 'Imus City', 'Male', '09123456724', 'kevin.lim@email.com', 'Old', 'Daniel Lim', '09986543212', 'Elsa Ortiz', '09983217654', NULL, NULL, 'N/A'),
('Go', 'Karen', 'Lopez', NULL, '2012-06-28', 'San Pedro City', 'Female', '09123456725', 'karen.go@email.com', 'New', 'Alfred Go', '09987654322', 'Lana Lopez', '09985432123', NULL, NULL, 'N/A'),

-- Grade 9
('Aguilar', 'Paulo', 'Ramos', NULL, '2011-08-21', 'Binan City', 'Male', '09123456726', 'paulo.aguilar@email.com', 'New', 'Pedro Aguilar', '09989876543', 'Lana Ramos', '09988765432', 'Jorge Aguilar', '09987654321', 'Guardian'),
('Navarro', 'Bianca', 'Mendoza', NULL, '2011-10-30', 'Sta. Rosa City', 'Female', '09123456727', 'bianca.navarro@email.com', 'Old', 'Juan Navarro', '09986543210', 'Maria Mendoza', '09985432109', NULL, NULL, 'N/A'),
('Vergara', 'Simon', 'Perez', NULL, '2011-11-15', 'Tagaytay City', 'Male', '09123456728', 'simon.vergara@email.com', 'New', 'Carlos Vergara', '09987654322', 'Luz Perez', '09986543211', NULL, NULL, 'N/A'),
('Reyes', 'Elaine', 'Bautista', NULL, '2011-03-22', 'Carmona City', 'Female', '09123456729', 'elaine.reyes@email.com', 'New', 'Jose Reyes', '09981234567', 'Maria Bautista', '09987654321', NULL, NULL, 'N/A'),
('Santos', 'Victor', 'Castillo', NULL, '2011-09-18', 'General Trias City', 'Male', '09123456730', 'victor.santos@email.com', 'Old', 'Alfredo Santos', '09987653210', 'Carmen Castillo', '09981234567', NULL, NULL, 'N/A'),
('Gonzalez', 'Patricia', 'Ortiz', NULL, '2011-12-30', 'Silang, Cavite', 'Female', '09123456731', 'patricia.gonzalez@email.com', 'New', 'Mario Gonzalez', '09986543210', 'Liza Ortiz', '09987654321', NULL, NULL, 'N/A'),
('Ramos', 'Julian', 'Tan', NULL, '2011-05-12', 'Naga City', 'Male', '09123456732', 'julian.ramos@email.com', 'New', 'Victor Ramos', '09985673421', 'Clara Tan', '09987651234', NULL, NULL, 'N/A'),
('Lopez', 'Karla', 'Lim', NULL, '2011-11-23', 'Bicol City', 'Female', '09123456733', 'karla.lopez@email.com', 'Old', 'Roberto Lopez', '09987654321', 'Elsa Lim', '09981234567', 'Maria Lopez', '09986543210', 'Aunt'),
('Martinez', 'Enrique', 'Domingo', NULL, '2011-08-25', 'Lucban, Quezon', 'Male', '09123456734', 'enrique.martinez@email.com', 'New', 'Manuel Martinez', '09987651234', 'Ana Domingo', '09985432123', NULL, NULL, 'N/A'),
('Aquino', 'Fiona', 'Pascual', NULL, '2011-03-18', 'San Fernando, Pampanga', 'Female', '09123456735', 'fiona.aquino@email.com', 'New', 'Gerard Aquino', '09981234567', 'Helen Pascual', '09987654321', NULL, NULL, 'N/A'),

-- Grade 10
('Castillo', 'Megan', 'Ramos', NULL, '2010-02-15', 'Malolos, Bulacan', 'Female', '09123456736', 'megan.castillo@email.com', 'New', 'Pedro Castillo', '09987654321', 'Lana Ramos', '09981234567', NULL, NULL, 'N/A'),
('Bautista', 'Liam', 'Mendoza', NULL, '2010-05-21', 'Tarlac City', 'Male', '09123456737', 'liam.bautista@email.com', 'Old', 'Carlos Bautista', '09981234567', 'Liza Mendoza', '09987654321', 'Jorge Mendoza', '09986543210', 'Guardian'),
('Ramos', 'Nathaniel', 'Cruz', NULL, '2010-05-18', 'Baguio City', 'Male', '09123456738', 'nathaniel.ramos@email.com', 'New', 'Alfredo Ramos', '09982345679', 'Felicia Cruz', '09981234568', 'Walter Ramos', '09983456789', 'Uncle'),
('Perez', 'Andrea', 'Reyes', NULL, '2010-08-22', 'Dagupan City', 'Female', '09123456739', 'andrea.perez@email.com', 'Old', 'Roberto Perez', '09980987654', 'Clarissa Reyes', '09980987655', NULL, NULL, 'N/A'),
('Torres', 'Joshua', 'Castillo', NULL, '2010-11-05', 'Laoag City', 'Male', '09123456740', 'joshua.torres@email.com', 'New', 'Daniel Torres', '09981234567', 'Elsa Castillo', '09987654322', NULL, NULL, 'N/A'),
('Santos', 'Monica', 'Aquino', NULL, '2010-04-11', 'Vigan City', 'Female', '09123456741', 'monica.santos@email.com', 'New', 'Lester Santos', '09981234567', 'Marian Aquino', '09987654321', NULL, NULL, 'N/A'),
('Garcia', 'Samuel', 'Villanueva', NULL, '2010-07-06', 'Bangued City', 'Male', '09123456742', 'samuel.garcia@email.com', 'New', 'Ramon Garcia', '09987654321', 'Luz Villanueva', '09983217654', NULL, NULL, 'N/A'),
('Navarro', 'Isabel', 'Bautista', NULL, '2010-06-15', 'Bontoc City', 'Female', '09123456743', 'isabel.navarro@email.com', 'Old', 'Juan Navarro', '09986543210', 'Maria Bautista', '09987654321', NULL, NULL, 'N/A'),
('Lim', 'Erik', 'Domingo', NULL, '2010-03-26', 'Tuguegarao City', 'Male', '09123456744', 'erik.lim@email.com', 'New', 'Daniel Lim', '09983456123', 'Elsa Domingo', '09981237654', NULL, NULL, 'N/A'),
('Tan', 'Rachel', 'Torres', NULL, '2010-09-21', 'Cabanatuan City', 'Female', '09123456745', 'rachel.tan@email.com', 'New', 'Roberto Tan', '09987651234', 'Clarissa Torres', '09985432123', NULL, NULL, 'N/A');