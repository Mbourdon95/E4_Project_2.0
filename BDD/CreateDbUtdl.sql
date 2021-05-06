drop database if exists dbUtdl;
create database dbUtdl;

use dbUtdl;

DROP TABLE if exists Course;
create table Course (
    id int not null auto_increment PRIMARY key,
    distance int(11) unsigned not null,
    nom varchar(30),
    prixDuGagnant int(11) unsigned not null,
    prixEntree int(11) unsigned not null
)engine=innodb;
DROP TABLE if exists Lapin;
create table Lapin 
    (id int not null auto_increment primary key,
    surnom varchar(20) not null,
    age int(11) unsigned not null,
    vitesse INT NOT NULL,
    chance INT NOT NULL,
    endurance INT NOT NULL,
    idGerant INT)engine=innodb;
DROP TABLE if exists Gerant;
create table Gerant
    (id int not null auto_increment primary key,
    nom VARCHAR(30) NOT NULL,
    prenom VARCHAR(30) NOT NULL,
    pwd VARCHAR(30) NOT NULL,
    age INT NOT NULL,
    budget INT NOT NULL)engine=innodb;
DROP TABLE if exists Participer;
create table Participer (
    idCourse INT NOT NULL,
    idLapin INT NOT NULL,
    Gagnant INT )engine=innodb;

alter table Participer
add constraint pk_Participer PRIMARY KEY (idCourse, idLapin);
alter table Participer
add constraint fk_Participer_idLapin FOREIGN KEY (idLapin) REFERENCES Lapin(id);
alter table Participer
add constraint fk_Participer_idCourse FOREIGN KEY (idCourse) REFERENCES Course(id);

alter table Lapin
add constraint fk_Participer_idGerant FOREIGN KEY (idGerant) REFERENCES Gerant(id);


