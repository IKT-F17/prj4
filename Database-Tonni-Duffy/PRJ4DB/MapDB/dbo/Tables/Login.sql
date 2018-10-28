--
-- Create Table    : 'Login'   
-- Name            :  
-- Password        :  
-- DB2ID           :  (references DB2.DB2ID)
--
CREATE TABLE Login (
    Name           INT IDENTITY(1,1) NOT NULL UNIQUE,
    Password       VARCHAR(50) NOT NULL,
    DB2ID          INT NULL,
CONSTRAINT pk_Login PRIMARY KEY CLUSTERED (Name),
CONSTRAINT fk_Login FOREIGN KEY (DB2ID)
    REFERENCES DB2 (DB2ID)
    ON UPDATE CASCADE)