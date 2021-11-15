create table persona
(
identificacion VARCHAR(11) Primary Key,
nombre VARCHAR(50) Not null,
edad INT not null,
sexo VARCHAR(1) Not null,
pulsacion decimal (2,1),
fecha DATE
);

drop table persona;
insert into persona (identificacion,nombre,edad,sexo,pulsacion,fecha)values('666','anastacia',19,'F',4.5, '2014-01-8');
insert into persona values('111','ana',18,'F',2.5, '2004-01-8');
insert into persona values('222','sofia',19,'F',2.7, '2006-01-6');
insert into persona values('333','andres',20,'M',2.9,'2012-11-8');
insert into persona values('444','felipe',22,'M',1.5,'2021-02-8');
insert into persona values('555','christina',17,'F',1.5, '2021-04-8');
select *from persona;
commit
update persona set edad=20 where identificacion=222;