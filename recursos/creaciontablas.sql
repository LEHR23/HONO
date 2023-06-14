create database DB_HONOP

use DB_HONOP

create table notas(idnotas int primary key identity(1,1),titulo varchar(100),fecha datetime,nivel varchar(50),contenido varchar(max),fechamodificacion datetime);

create table tareas(idtareas int primary key identity(1,1),titulo varchar(100),fecha datetime,nivel varchar(50),estado varchar(50),contenido varchar(max),fechamodificacion datetime,fechaentrega datetime);


CREATE PROCEDURE lista_x_nivel
AS
CREATE TABLE #TEMP
(
TIPO VARCHAR(5),
TITULO VARCHAR(100),
FECHA DATETIME,
NIVEL VARCHAR(50),
ESTADO VARCHAR(50),
CONTENIDO VARCHAR(MAX),
FECHAMODIFICACION DATETIME,
FECHAENTREGA DATETIME
)
INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='ALTA'
INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='ALTA'
INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='MEDIA'
INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='MEDIA'
INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='BAJA'
INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='BAJA'
SELECT * FROM #TEMP
DROP TABLE #TEMP


CREATE PROCEDURE lista_x_registro
AS
CREATE TABLE #TEMPO
(
TIPO VARCHAR(5),
TITULO VARCHAR(100),
FECHA DATETIME,
NIVEL VARCHAR(50),
ESTADO VARCHAR(50),
CONTENIDO VARCHAR(MAX),
FECHAMODIFICACION DATETIME,
FECHAENTREGA DATETIME
)
INSERT INTO #TEMPO SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS order by fecha
INSERT INTO #TEMPO SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas order by fecha
SELECT * FROM #TEMPO ORDER BY FECHA
DROP TABLE #TEMPO




CREATE PROCEDURE lista_x_modificacion
AS
CREATE TABLE #TEMPOR
(
TIPO VARCHAR(5),
TITULO VARCHAR(100),
FECHA DATETIME,
NIVEL VARCHAR(50),
ESTADO VARCHAR(50),
CONTENIDO VARCHAR(MAX),
FECHAMODIFICACION DATETIME,
FECHAENTREGA DATETIME
)
INSERT INTO #TEMPOR SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS
INSERT INTO #TEMPOR SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas
SELECT * FROM #TEMPOR ORDER BY FECHAMODIFICACION
DROP TABLE #TEMPOR


create procedure lista_nota_nivel
as
create table #t
(
TIPO VARCHAR(5),
TITULO VARCHAR(100),
FECHA DATETIME,
NIVEL VARCHAR(50),
CONTENIDO VARCHAR(MAX),
FECHAMODIFICACION DATETIME
)
insert into #t select * from notas where nivel = 'ALTA'
insert into #t select * from notas where nivel = 'MEDIA'
insert into #t select * from notas where nivel = 'BAJA'
select * from #t
drop table #t


create procedure lista_tarea_nivel
as
create table #te
(
TIPO VARCHAR(5),
TITULO VARCHAR(100),
FECHA DATETIME,
NIVEL VARCHAR(50),
ESTADO VARCHAR(50),
CONTENIDO VARCHAR(MAX),
FECHAMODIFICACION DATETIME,
FECHAENTREGA DATETIME
)
insert into #te select * from tareas where nivel = 'ALTA'
insert into #te select * from tareas where nivel = 'MEDIA'
insert into #te select * from tareas where nivel = 'BAJA'
select * from #te
drop table #te



EXEC lista_x_registro

EXEC lista_x_nivel

EXEC lista_x_modificacion

exec lista_nota_nivel

exec lista_tarea_nivel

select * from notas order by fecha

select * from notas order by fechamodificacion

select * from notas order by nivel

select * from tareas order by fecha

select * from tareas order by fechamodificacion

select * from tareas order by nivel
