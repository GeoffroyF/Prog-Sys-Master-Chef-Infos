/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: ZONE_CONSERVATION
------------------------------------------------------------*/
CREATE TABLE ZONE_CONSERVATION(
	id                 INT IDENTITY (1,1) NOT NULL ,
	nom                VARCHAR (50) NOT NULL ,
	quantite_max       INT  NOT NULL ,
	tps_conservation   INT  NOT NULL  ,
	CONSTRAINT ZONE_CONSERVATION_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: INGREDIENT
------------------------------------------------------------*/
CREATE TABLE INGREDIENT(
	id                     INT IDENTITY (1,1) NOT NULL ,
	nom                    VARCHAR (50) NOT NULL ,
	quantite               INT  NOT NULL ,
	date_peremption        DATETIME NOT NULL ,
	id_ZONE_CONSERVATION   INT  NOT NULL  ,
	CONSTRAINT INGREDIENT_PK PRIMARY KEY (id)

	,CONSTRAINT INGREDIENT_ZONE_CONSERVATION_FK FOREIGN KEY (id_ZONE_CONSERVATION) REFERENCES ZONE_CONSERVATION(id)
);


/*------------------------------------------------------------
-- Table: TYPE_RECETTE
------------------------------------------------------------*/
CREATE TABLE TYPE_RECETTE(
	id    INT IDENTITY (1,1) NOT NULL ,
	nom   VARCHAR (50) NOT NULL  ,
	CONSTRAINT TYPE_RECETTE_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: MA_TABLE
------------------------------------------------------------*/
CREATE TABLE MA_TABLE(
	id          INT IDENTITY (1,1) NOT NULL ,
	nb_chaise   INT  NOT NULL ,
	pain        bit  NOT NULL ,
	bouteille   bit  NOT NULL  ,
	CONSTRAINT MA_TABLE_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: COUVERTS
------------------------------------------------------------*/
CREATE TABLE COUVERTS(
	id            INT IDENTITY (1,1) NOT NULL ,
	nom           VARCHAR (50) NOT NULL ,
	nb_total      INT  NOT NULL ,
	nb_propre     INT  NOT NULL ,
	nb_sale       INT  NOT NULL ,
	type          bit  NOT NULL ,
	id_MA_TABLE   INT    ,
	CONSTRAINT COUVERTS_PK PRIMARY KEY (id)

	,CONSTRAINT COUVERTS_MA_TABLE_FK FOREIGN KEY (id_MA_TABLE) REFERENCES MA_TABLE(id)
);


/*------------------------------------------------------------
-- Table: USTENSILES
------------------------------------------------------------*/
CREATE TABLE USTENSILES(
	id          INT IDENTITY (1,1) NOT NULL ,
	nom         VARCHAR (50) NOT NULL ,
	nb_total    INT  NOT NULL ,
	nb_sale     INT  NOT NULL ,
	nb_propre   INT  NOT NULL  ,
	CONSTRAINT USTENSILES_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: RECETTE
------------------------------------------------------------*/
CREATE TABLE RECETTE(
	id                INT IDENTITY (1,1) NOT NULL ,
	nom               VARCHAR (50) NOT NULL ,
	tps_cuisson       INT  NOT NULL ,
	tps_preparation   INT  NOT NULL ,
	tps_repos         INT  NOT NULL ,
	accompagnement    VARCHAR (20) NOT NULL ,
	id_TYPE_RECETTE   INT  NOT NULL ,
	id_USTENSILES     INT  NOT NULL  ,
	CONSTRAINT RECETTE_PK PRIMARY KEY (id)

	,CONSTRAINT RECETTE_TYPE_RECETTE_FK FOREIGN KEY (id_TYPE_RECETTE) REFERENCES TYPE_RECETTE(id)
	,CONSTRAINT RECETTE_USTENSILES0_FK FOREIGN KEY (id_USTENSILES) REFERENCES USTENSILES(id)
);


/*------------------------------------------------------------
-- Table: RESERVATION
------------------------------------------------------------*/
CREATE TABLE RESERVATION(
	id            INT IDENTITY (1,1) NOT NULL ,
	date          DATETIME NOT NULL ,
	temps         bit  NOT NULL ,
	id_MA_TABLE   INT  NOT NULL  ,
	CONSTRAINT RESERVATION_PK PRIMARY KEY (id)

	,CONSTRAINT RESERVATION_MA_TABLE_FK FOREIGN KEY (id_MA_TABLE) REFERENCES MA_TABLE(id)
	,CONSTRAINT RESERVATION_MA_TABLE_AK UNIQUE (id_MA_TABLE)
);


/*------------------------------------------------------------
-- Table: Composer
------------------------------------------------------------*/
CREATE TABLE Composer(
	id           INT  NOT NULL ,
	id_RECETTE   INT  NOT NULL ,
	quantite     INT  NOT NULL  ,
	CONSTRAINT Composer_PK PRIMARY KEY (id,id_RECETTE)

	,CONSTRAINT Composer_INGREDIENT_FK FOREIGN KEY (id) REFERENCES INGREDIENT(id)
	,CONSTRAINT Composer_RECETTE0_FK FOREIGN KEY (id_RECETTE) REFERENCES RECETTE(id)
);


/*------------------------------------------------------------
-- Table: COMMANDER
------------------------------------------------------------*/
CREATE TABLE COMMANDER(
	id              INT  NOT NULL ,
	id_MA_TABLE     INT  NOT NULL ,
	id_INGREDIENT   INT  NOT NULL  ,
	CONSTRAINT COMMANDER_PK PRIMARY KEY (id,id_MA_TABLE,id_INGREDIENT)

	,CONSTRAINT COMMANDER_RECETTE_FK FOREIGN KEY (id) REFERENCES RECETTE(id)
	,CONSTRAINT COMMANDER_MA_TABLE0_FK FOREIGN KEY (id_MA_TABLE) REFERENCES MA_TABLE(id)
	,CONSTRAINT COMMANDER_INGREDIENT1_FK FOREIGN KEY (id_INGREDIENT) REFERENCES INGREDIENT(id)
);



