--
-- Create Table    : 'Login'   
-- Name            :  
-- Password        :  
-- DB2ID           :  (references HSDB.DB2ID)
--
CREATE TABLE Login (
    Name           INT IDENTITY(1,1) NOT NULL UNIQUE,
    Password       VARCHAR(50) NOT NULL,
    DB2ID          INT NULL,
CONSTRAINT pk_Login PRIMARY KEY CLUSTERED (Name),
CONSTRAINT fk_Login FOREIGN KEY (DB2ID)
    REFERENCES HSDB (DB2ID)
    ON UPDATE CASCADE)