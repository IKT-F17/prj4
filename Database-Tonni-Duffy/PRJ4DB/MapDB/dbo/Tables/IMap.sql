--
-- Create Table    : 'IMap'   
-- IMapID          :  
-- MapName         :  
-- DB2ID           :  (references DB2.DB2ID)
-- DB1ID           :  (references DB1.DB1ID)
--
CREATE TABLE IMap (
    IMapID         INT IDENTITY(1,1) NOT NULL,
    MapName        VARCHAR NOT NULL,
    DB2ID          INT NOT NULL,
    DB1ID          INT NOT NULL,
CONSTRAINT pk_IMap PRIMARY KEY CLUSTERED (IMapID),
CONSTRAINT fk_IMap FOREIGN KEY (DB2ID)
    REFERENCES DB2 (DB2ID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
CONSTRAINT fk_IMap2 FOREIGN KEY (DB1ID)
    REFERENCES DB1 (DB1ID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)