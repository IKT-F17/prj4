--
-- Create Table    : 'IMap'   
-- IMapID          :  
-- MapName         :  
-- DB2ID           :  (references HSDB.DB2ID)
-- DB1ID           :  (references MAPDB.DB1ID)
--
CREATE TABLE IMap (
    IMapID         INT IDENTITY(1,1) NOT NULL,
    MapName        VARCHAR NOT NULL,
    DB2ID          INT NOT NULL,
    DB1ID          INT NOT NULL,
CONSTRAINT pk_IMap PRIMARY KEY CLUSTERED (IMapID),
CONSTRAINT fk_IMap FOREIGN KEY (DB2ID)
    REFERENCES HSDB (DB2ID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
CONSTRAINT fk_IMap2 FOREIGN KEY (DB1ID)
    REFERENCES MAPDB (DB1ID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)