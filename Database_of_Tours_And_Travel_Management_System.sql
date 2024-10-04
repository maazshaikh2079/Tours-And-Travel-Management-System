Use tntmsdb;

-- Select * From Railways;
-- Select * From Roadways;
-- Select * From Airways_Domestic;

-- -- Creating Railways Table:

-- create table Railways
-- (Full_name char(70),
-- seat_no numeric(3),
-- Phone_no numeric(10),
-- Address varchar(450),
-- Email_ID varchar(50),
-- Departure char(70),
-- Destination char(70),
-- Train_type char(6),
-- Coach char(8),
-- Class char(6),
-- Ticket char(6),
-- Size char(4),
-- Sub_Total varchar(25),
-- Tax varchar(25),
-- Total varchar(25));

-- -- Creating Roadways Table:

-- create table Roadways
-- (Plan_code Numeric(4),
-- No_of_adults Numeric(3),
-- No_of_kids Numeric(3),
-- Address varchar(450),
-- Phone_no Numeric(10),
-- Email_ID varchar(50),
-- Travelling_from char(80),
-- Travelling_to char(80),
-- No_of_buses varchar(20),
-- Bus_type char(6),
-- Ticket char(6),
-- Sub_Total varchar(25),
-- Tax varchar(25),
-- Total varchar(25));

-- -- Creating Airways_Domestic Table:

-- create table Airways_Domestic
-- (Name char(70),
-- Age char(10),
-- PIN_Code Numeric(6),
-- Phone_no Numeric(10),
-- Email_ID varchar(50),
-- Address varchar(450),
-- Departure char(70),
-- Destination char(70),
-- Ticket char(6),
-- Class char(15),
-- Accommodation char(25),
-- Sub_Total varchar(25),
-- Tax varchar(25), Total varchar(25));

-- Drop table Airways_Domestic;
-- Drop table Railways;
-- Drop table Roadways;