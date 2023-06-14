using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONO
{
    class Constantes
    {
        public static String primeraconexion = "Server=localhost;Integrated security=SSPI;database=master";
        public static String conexion = "Server=localhost;Integrated security=SSPI;database=DB_HONO";
        public static String basededatos = "create database DB_HONO";
        public static String eluso = "use DB_HONO";
        public static String tablatareas = "create table tareas(idtareas int primary key identity(1, 1),titulo varchar(100),fecha datetime,nivel varchar(50),estado varchar(50),contenido varchar(max),fechamodificacion datetime,fechaentrega datetime)";
        public static String tablanota = "create table notas(idnotas int primary key identity(1, 1),titulo varchar(100),fecha datetime,nivel varchar(50),contenido varchar(max),fechamodificacion datetime)";
        public static String procedimiento1 = "CREATE PROCEDURE lista_x_nivel "
+"AS "
+"CREATE TABLE #TEMP "
+"(TIPO VARCHAR(5),TITULO VARCHAR(100),FECHA DATETIME,NIVEL VARCHAR(50),ESTADO VARCHAR(50),CONTENIDO VARCHAR(MAX),FECHAMODIFICACION DATETIME,FECHAENTREGA DATETIME) "
+"INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='ALTA' "
+"INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='ALTA' "
+"INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='MEDIA' "
+"INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='MEDIA' "
+"INSERT INTO #TEMP SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS WHERE nivel='BAJA' "
+"INSERT INTO #TEMP SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas WHERE nivel='BAJA' "
+"SELECT* FROM #TEMP "
+"DROP TABLE #TEMP";
        public static String procedimiento2 = "CREATE PROCEDURE lista_x_registro "
+"AS " 
+"CREATE TABLE #TEMPO(TIPO VARCHAR(5),TITULO VARCHAR(100),FECHA DATETIME,NIVEL VARCHAR(50),ESTADO VARCHAR(50),CONTENIDO VARCHAR(MAX),FECHAMODIFICACION DATETIME,FECHAENTREGA DATETIME) "
+"INSERT INTO #TEMPO SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS order by fecha "
+"INSERT INTO #TEMPO SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas order by fecha "
+"SELECT* FROM #TEMPO ORDER BY FECHA "
+"DROP TABLE #TEMPO";
        public static String procedimiento3 = "CREATE PROCEDURE lista_x_modificacion "
+"AS "
+"CREATE TABLE #TEMPOR(TIPO VARCHAR(5),TITULO VARCHAR(100),FECHA DATETIME,NIVEL VARCHAR(50),ESTADO VARCHAR(50),CONTENIDO VARCHAR(MAX),FECHAMODIFICACION DATETIME,FECHAENTREGA DATETIME) "
+"INSERT INTO #TEMPOR SELECT 'TAREA',titulo,fecha,nivel,estado,contenido,fechamodificacion,fechaentrega FROM TAREAS "
+"INSERT INTO #TEMPOR SELECT 'NOTA',titulo,fecha,nivel,'',contenido,fechamodificacion,'' FROM notas "
+"SELECT* FROM #TEMPOR ORDER BY FECHAMODIFICACION "
+"DROP TABLE #TEMPOR";
        public static String procedimiento4 = "create procedure lista_nota_nivel "
+"as "
+"create table #t(TIPO VARCHAR(5),TITULO VARCHAR(100),FECHA DATETIME,NIVEL VARCHAR(50),CONTENIDO VARCHAR(MAX),FECHAMODIFICACION DATETIME) "
+"insert into #t select * from notas where nivel = 'ALTA' "
+"insert into #t select * from notas where nivel = 'MEDIA' "
+"insert into #t select * from notas where nivel = 'BAJA' "
+"select* from #t "
+"drop table #t";
        public static String procedimiento5 = "create procedure lista_tarea_nivel "
+"as "
+"create table #te(TIPO VARCHAR(5),TITULO VARCHAR(100),FECHA DATETIME,NIVEL VARCHAR(50),ESTADO VARCHAR(50),CONTENIDO VARCHAR(MAX),FECHAMODIFICACION DATETIME,FECHAENTREGA DATETIME) "
+"insert into #te select * from tareas where nivel = 'ALTA' "
+"insert into #te select * from tareas where nivel = 'MEDIA' "
+"insert into #te select * from tareas where nivel = 'BAJA' "
+"select* from #te "
+"drop table #te";
        public static String listanotas = "select titulo,idnotas from notas";
        public static String listatareas = "select titulo,idtareas from tareas";
        public static String consulta_nota = "select * from notas where idnotas = '";
        public static String consulta_tarea = "select * from tareas where idtareas = '";
        public static String generar_notas_fechas = "select * from notas order by fecha";
        public static String generar_tareas_fechas = "select * from tareas order by fecha";
        public static String generar_notas_mod = "select * from notas order by fechamodificacion";
        public static String generar_tareas_mod = "select * from tareas order by fechamodificacion";
        public static String generar_notas_niv = "exec lista_nota_nivel";
        public static String generar_tareas_niv = "exec lista_tarea_nivel";
        public static String generar_lista_fecha = "exec lista_x_registro";
        public static String generar_lista_mod = "exec lista_x_modificacion";
        public static String generar_lista_nivel = "exec lista_x_nivel";
        public static String eliminar_nota = "delete from notas where idnotas='";
        public static String eliminar_tarea = "delete from tareas where idtareas='";

    }
}
