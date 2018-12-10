create database restaurant collate SQL_Latin1_General_CP1_CI_AS
go

create table MATABLE
(
  id        int identity
    constraint TABLE_PK
      primary key,
  nb_chaise int not null,
  pain      bit,
  bouteille bit
)
go

create table COUVERTS
(
  id        int identity
    constraint COUVERTS_PK
      primary key,
  nom       varchar(50) not null,
  nb_total  int         not null,
  nb_propre int         not null,
  nb_sale   int         not null,
  type      bit         not null,
  id_TABLE  int
    constraint COUVERTS_TABLE_FK
      references MATABLE
)
go

create table TYPE_RECETTE
(
  id  int identity
    constraint TYPE_RECETTE_PK
      primary key,
  nom varchar(50) not null
)
go

create table RECETTE
(
  id              int identity
    constraint RECETTE_PK
      primary key,
  nom             varchar(50) not null,
  tps_cuisson     int,
  tps_preparation int,
  tps_repos       int,
  accompagnement  varchar(20),
  id_TYPE_RECETTE int
    constraint RECETTE_TYPE_RECETTE_FK
      references TYPE_RECETTE
)
go

create table USTENSILES
(
  id        int identity
    constraint USTENSILES_PK
      primary key,
  nom       varchar(50) not null,
  nb_total  int         not null,
  nb_sale   int,
  nb_propre int
)
go

create table RECETTEUSTENSILES
(
  ID_Recette   int not null
    constraint ID_DE_LA_RECETTE
      references RECETTE,
  ID_Ustensile int
    constraint ID_DE_L_USTENSILE
      references USTENSILES
)
go

create table ZONE_CONSERVATION
(
  id               int identity
    constraint ZONE_CONSERVATION_PK
      primary key,
  nom              varchar(50) not null,
  quantite_max     int         not null,
  tps_conservation int
)
go

create table INGREDIENT
(
  id                   int identity
    constraint INGREDIENT_PK
      primary key,
  nom                  varchar(50) not null,
  quantite             int         not null,
  date_peremption      datetime,
  id_ZONE_CONSERVATION int
    constraint INGREDIENT_ZONE_CONSERVATION_FK
      references ZONE_CONSERVATION
)
go

create table COMMANDER
(
  id            int not null
    constraint COMMANDER_RECETTE_FK
      references RECETTE,
  id_TABLE      int not null
    constraint COMMANDER_TABLE0_FK
      references MATABLE,
  id_INGREDIENT int not null
    constraint COMMANDER_INGREDIENT1_FK
      references INGREDIENT,
  constraint COMMANDER_PK
    primary key (id, id_TABLE, id_INGREDIENT)
)
go

create table COMPOSER
(
  id         int not null
    constraint Composer_INGREDIENT_FK
      references INGREDIENT,
  id_RECETTE int not null
    constraint Composer_RECETTE0_FK
      references RECETTE,
  quantite   int not null,
  constraint Composer_PK
    primary key (id, id_RECETTE)
)
go

create table RECETTEINGREDIENT
(
  ID_Recette    int not null
    constraint ID_DE_LA_RECETTES
      references RECETTE,
  ID_Ingredient int not null
    constraint ID_DE_L_INGREDIENT
      references INGREDIENT,
  Quantite      int
)
go


