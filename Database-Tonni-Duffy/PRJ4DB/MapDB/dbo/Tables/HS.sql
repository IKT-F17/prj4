--
-- Create Table    : 'HS'   
-- HSID            :  
-- DB2ID           :  (references DB2.DB2ID)
-- ICollectionID   :  (references ICollection_PHS.ICollectionID)
--
CREATE TABLE HS (
    HSID           INT IDENTITY(1,1) NOT NULL,
    DB2ID          INT NULL,
    ICollectionID  INT NOT NULL,
CONSTRAINT pk_HS PRIMARY KEY CLUSTERED (HSID),
CONSTRAINT fk_HS FOREIGN KEY (DB2ID)
    REFERENCES DB2 (DB2ID)
    ON UPDATE CASCADE,
CONSTRAINT fk_HS2 FOREIGN KEY (ICollectionID)
    REFERENCES ICollection_PHS (ICollectionID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)