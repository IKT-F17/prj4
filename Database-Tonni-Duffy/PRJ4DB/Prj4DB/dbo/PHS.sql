--
-- Create Table    : 'PHS'   
-- Name            :  
-- TotalHS         :  
-- Map             :  
-- PHSValue        :  
-- DB2ID           :  (references HSDB.DB2ID)
--
CREATE TABLE PHS (
    Name           INT IDENTITY(1,1) NOT NULL UNIQUE,
    TotalHS        BIGINT NULL,
    Map            VARCHAR(50) NULL,
    PHSValue       BIGINT NULL,
    DB2ID          INT NULL,
CONSTRAINT pk_PHS PRIMARY KEY CLUSTERED (Name),
CONSTRAINT fk_PHS FOREIGN KEY (DB2ID)
    REFERENCES HSDB (DB2ID)
    ON UPDATE CASCADE)