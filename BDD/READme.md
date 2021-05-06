# Championnat des Lapins : La Base De Donnée  :earth_americas: :honeybee:

Il s'agit de La Base De Donnée du projet. 

## 1. Création des tables :star:

On cherche a créer en premier les tables. on y ajoute les clés primaires en même temps (ci-dessous un exemple de script de table) :

---

```sql
DROP TABLE if exists Participer;
create table Participer (
    idCourse INT NOT NULL,
    idLapin INT NOT NULL,
    Gagnant INT )engine=innodb;
``` 

>> A noter l'ajout du moteur Innodb pour effectuer des transactions un peu plus tard.

## 2. Ajout des Clés Etrangères

On ajoute à la suite des tables et des clés primaire, les clés étrangères (éviter de faire les clés primaires en même temps que les clés étrangères, cela génère souvent des erreurs :-1:):

---

```sql
alter table Participer
add constraint pk_Participer PRIMARY KEY (idCourse, idLapin);
alter table Participer
add constraint fk_Participer_idLapin FOREIGN KEY (idLapin) REFERENCES Lapin(id);
alter table Participer
add constraint fk_Participer_idCourse FOREIGN KEY (idCourse) REFERENCES Course(id);
``` 

## 3. Schéma Workbench. :heart: :heart:

![Capture](https://user-images.githubusercontent.com/71081511/115717487-835a4180-a37a-11eb-8241-f4ed334655c4.PNG)

## 4. Insérez les données. :two_hearts:

Avant de s'attaquez au site web et l'insertion des classes, élèves et autre, on insère les données que l'on possède déjà. : !


```sql
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('bugs',2,4,3,8);
INSERT INTO Course(distance,nom) VALUES(42.25,"Marathon De Paris");
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(1,1,1);
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('test',2,4,3,8);
INSERT INTO Course(distance,nom) VALUES(42.25,"Marathon D'Athènes");
INSERT INTO Course(distance,nom) VALUES(42.25,"test");
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(2,0,2);
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('a',2,4,3,8);
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('z',2,4,3,8);
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('z',2,4,3,8);
INSERT INTO Lapin (surnom, age,vitesse,endurance,chance) VALUES ('ezer',2,4,3,8);
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(3,1,2);
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(4,0,1);
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(5,0,3);
INSERT INTO Participer(idLapin,Gagnant,idCourse) VALUES(6,0,3);
``` 

