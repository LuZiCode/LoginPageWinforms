CREATE TABLE UserTable (
    AccountID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FirstName varchar(100) NOT NULL,
    LastName varchar(100) NOT NULL,
	Email varchar(100) NOT NULL,
	Username varchar(100) UNIQUE NOT NULL,
    UserPassword varchar(100) NOT NULL,
	DateCreated smalldatetime
);