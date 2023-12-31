USE [BD_COLEGIO_SR]
GO
/****** Object:  User [rcero]    Script Date: 21/08/2023 23:49:18 ******/
CREATE USER [rcero] FOR LOGIN [rcero] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [rcero]
GO
/****** Object:  Table [dbo].[ALUMNO]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNO](
	[AlumnoID] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Dni] [char](8) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[ApoderadoID] [int] NOT NULL,
	[UsuarioID] [int] NOT NULL,
	[GradoSeccionID] [int] NOT NULL,
 CONSTRAINT [XPKALUMNO] PRIMARY KEY CLUSTERED 
(
	[AlumnoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[APODERADO]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APODERADO](
	[ApoderadoID] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Dni] [char](8) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[UsuarioID] [int] NOT NULL,
 CONSTRAINT [XPKAPODERADO] PRIMARY KEY CLUSTERED 
(
	[ApoderadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AREAS]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AREAS](
	[AreaID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[DocenteID] [int] NOT NULL,
 CONSTRAINT [XPKAREAS] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASISTENCIAS]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASISTENCIAS](
	[AsistenciaID] [int] IDENTITY(1,1) NOT NULL,
	[Asistencia] [char](1) NOT NULL,
	[FechaAsistencia] [date] NOT NULL,
	[Observacion] [nvarchar](100) NULL,
	[AreaID] [int] NOT NULL,
	[AlumnoID] [int] NOT NULL,
 CONSTRAINT [XPKASISTENCIAS] PRIMARY KEY CLUSTERED 
(
	[AsistenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPETENCIA]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPETENCIA](
	[CompetenciaID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[AreaID] [int] NOT NULL,
 CONSTRAINT [PK_COMPETENCIA] PRIMARY KEY CLUSTERED 
(
	[CompetenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleAreas]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleAreas](
	[AreaID] [int] NOT NULL,
	[AlumnoID] [int] NOT NULL,
	[Competencia1] [char](2) NULL,
	[Competencia2] [char](2) NULL,
	[Competencia3] [char](2) NULL,
	[Competencia4] [char](2) NULL,
	[PeriodoID] [int] NULL,
 CONSTRAINT [XPKDetalleAreas] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC,
	[AlumnoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCENTE]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCENTE](
	[DocenteID] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Dni] [char](8) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[UsuarioID] [int] NOT NULL,
 CONSTRAINT [XPKDOCENTE] PRIMARY KEY CLUSTERED 
(
	[DocenteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXPERIENCIA]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXPERIENCIA](
	[ExperienciaID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Nota] [char](2) NULL,
	[FechaRegistroNota] [date] NULL,
	[CompetenciaID] [int] NOT NULL,
 CONSTRAINT [PK_EXPERIENCIA] PRIMARY KEY CLUSTERED 
(
	[ExperienciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GRADO]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRADO](
	[GradoID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [XPKGRADO] PRIMARY KEY CLUSTERED 
(
	[GradoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradoSeccion]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradoSeccion](
	[GradoSeccionID] [int] IDENTITY(1,1) NOT NULL,
	[GradoID] [int] NOT NULL,
	[SeccionID] [int] NOT NULL,
 CONSTRAINT [XPKGradoSeccion] PRIMARY KEY CLUSTERED 
(
	[GradoSeccionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERIODO]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERIODO](
	[PeriodoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
 CONSTRAINT [PK_PERIODO] PRIMARY KEY CLUSTERED 
(
	[PeriodoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECCION]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECCION](
	[SeccionID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [XPKSECCION] PRIMARY KEY CLUSTERED 
(
	[SeccionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Rol] [nvarchar](50) NULL,
 CONSTRAINT [XPKUSUARIOS] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ALUMNO]  WITH CHECK ADD  CONSTRAINT [R_12] FOREIGN KEY([ApoderadoID])
REFERENCES [dbo].[APODERADO] ([ApoderadoID])
GO
ALTER TABLE [dbo].[ALUMNO] CHECK CONSTRAINT [R_12]
GO
ALTER TABLE [dbo].[ALUMNO]  WITH CHECK ADD  CONSTRAINT [R_14] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[USUARIOS] ([UsuarioID])
GO
ALTER TABLE [dbo].[ALUMNO] CHECK CONSTRAINT [R_14]
GO
ALTER TABLE [dbo].[ALUMNO]  WITH CHECK ADD  CONSTRAINT [R_15] FOREIGN KEY([GradoSeccionID])
REFERENCES [dbo].[GradoSeccion] ([GradoSeccionID])
GO
ALTER TABLE [dbo].[ALUMNO] CHECK CONSTRAINT [R_15]
GO
ALTER TABLE [dbo].[APODERADO]  WITH CHECK ADD  CONSTRAINT [R_3] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[USUARIOS] ([UsuarioID])
GO
ALTER TABLE [dbo].[APODERADO] CHECK CONSTRAINT [R_3]
GO
ALTER TABLE [dbo].[AREAS]  WITH CHECK ADD  CONSTRAINT [R_9] FOREIGN KEY([DocenteID])
REFERENCES [dbo].[DOCENTE] ([DocenteID])
GO
ALTER TABLE [dbo].[AREAS] CHECK CONSTRAINT [R_9]
GO
ALTER TABLE [dbo].[ASISTENCIAS]  WITH CHECK ADD  CONSTRAINT [R_10] FOREIGN KEY([AreaID])
REFERENCES [dbo].[AREAS] ([AreaID])
GO
ALTER TABLE [dbo].[ASISTENCIAS] CHECK CONSTRAINT [R_10]
GO
ALTER TABLE [dbo].[ASISTENCIAS]  WITH CHECK ADD  CONSTRAINT [R_11] FOREIGN KEY([AlumnoID])
REFERENCES [dbo].[ALUMNO] ([AlumnoID])
GO
ALTER TABLE [dbo].[ASISTENCIAS] CHECK CONSTRAINT [R_11]
GO
ALTER TABLE [dbo].[COMPETENCIA]  WITH CHECK ADD  CONSTRAINT [FK_COMPETENCIA_AREAS] FOREIGN KEY([AreaID])
REFERENCES [dbo].[AREAS] ([AreaID])
GO
ALTER TABLE [dbo].[COMPETENCIA] CHECK CONSTRAINT [FK_COMPETENCIA_AREAS]
GO
ALTER TABLE [dbo].[DetalleAreas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleAreas_PERIODO] FOREIGN KEY([PeriodoID])
REFERENCES [dbo].[PERIODO] ([PeriodoID])
GO
ALTER TABLE [dbo].[DetalleAreas] CHECK CONSTRAINT [FK_DetalleAreas_PERIODO]
GO
ALTER TABLE [dbo].[DetalleAreas]  WITH CHECK ADD  CONSTRAINT [R_6] FOREIGN KEY([AreaID])
REFERENCES [dbo].[AREAS] ([AreaID])
GO
ALTER TABLE [dbo].[DetalleAreas] CHECK CONSTRAINT [R_6]
GO
ALTER TABLE [dbo].[DetalleAreas]  WITH CHECK ADD  CONSTRAINT [R_8] FOREIGN KEY([AlumnoID])
REFERENCES [dbo].[ALUMNO] ([AlumnoID])
GO
ALTER TABLE [dbo].[DetalleAreas] CHECK CONSTRAINT [R_8]
GO
ALTER TABLE [dbo].[DOCENTE]  WITH CHECK ADD  CONSTRAINT [R_2] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[USUARIOS] ([UsuarioID])
GO
ALTER TABLE [dbo].[DOCENTE] CHECK CONSTRAINT [R_2]
GO
ALTER TABLE [dbo].[GradoSeccion]  WITH CHECK ADD  CONSTRAINT [R_4] FOREIGN KEY([GradoID])
REFERENCES [dbo].[GRADO] ([GradoID])
GO
ALTER TABLE [dbo].[GradoSeccion] CHECK CONSTRAINT [R_4]
GO
ALTER TABLE [dbo].[GradoSeccion]  WITH CHECK ADD  CONSTRAINT [R_5] FOREIGN KEY([SeccionID])
REFERENCES [dbo].[SECCION] ([SeccionID])
GO
ALTER TABLE [dbo].[GradoSeccion] CHECK CONSTRAINT [R_5]
GO
/****** Object:  StoredProcedure [dbo].[ActBuscarAsistencia]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActBuscarAsistencia]
@fecha date,@areaid int
as
SELECT AL.AlumnoID AS Id,AL.Apellidos+', '+AL.Nombres as DatosAlumno,Asis.Asistencia AS Asistencia
FROM ASISTENCIAS ASIS INNER JOIN ALUMNO AL
ON ASIS.AlumnoID=AL.AlumnoID
INNER JOIN AREAS A ON A.AreaID=ASIS.AreaID
WHERE A.AreaID=@areaid AND ASIS.FechaAsistencia=@fecha
GO
/****** Object:  StoredProcedure [dbo].[ActualizarAsistencia]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarAsistencia]
@fecha date,@asistencia char(1),@areaid int,@alumnoid int
as
UPDATE ASISTENCIAS SET Asistencia=@asistencia
where FechaAsistencia=@fecha and AreaID=@areaid and AlumnoID=@alumnoid
GO
/****** Object:  StoredProcedure [dbo].[AreasAlumno]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[AreasAlumno]
@idusuario int
as
DECLARE @alumnoid int
SELECT @alumnoid=AL.AlumnoID
FROM ALUMNO AL INNER JOIN USUARIOS US
ON AL.UsuarioID=US.UsuarioID
WHERE US.UsuarioID=@idusuario
SELECT A.AreaID AS ID,A.Descripcion AS AREA,D.Apellidos+', '+D.Nombres AS DOCENTE,GS.GradoID AS GRADO,
S.Descripcion AS SECCION,
DIAS=CASE WHEN A.Descripcion='MATEMATICA' THEN 'LUNES - MIERCOLES'
          WHEN A.Descripcion='ARTE Y CULTURA' THEN 'LUNES'
		  WHEN A.Descripcion='CIENCIA Y TECNOLOGIA' THEN 'LUNES - JUEVES'
		  WHEN A.Descripcion='CIENCIAS SOCIALES' THEN 'MARTES'
		  WHEN A.DESCRIPCION='TUTORIA' THEN 'MARTES - MIERCOLES'
		  WHEN A.DESCRIPCION='EDUCACION FISICA' THEN 'MARTES'
		  WHEN A.DESCRIPCION='DESARROLLO PERSONAL Y CIVICA' THEN 'MIERCOLES'
		  WHEN A .Descripcion='COMUNICACION' THEN 'JUEVES - VIERNES'
		  WHEN A .Descripcion='INGLES' THEN 'JUEVES'
		  WHEN A .Descripcion='EDUCACION RELIGIOSA' THEN 'VIERNES' END
																									
FROM AREAS A INNER JOIN DetalleAreas DET ON DET.AreaID=A.AreaID
INNER JOIN ALUMNO AL ON AL.AlumnoID=DET.AlumnoID
INNER JOIN DOCENTE D ON D.DocenteID=A.DocenteID
INNER JOIN GradoSeccion GS ON GS.GradoSeccionID=AL.GradoSeccionID
INNER JOIN SECCION S ON S.SeccionID=GS.SeccionID
WHERE DET.AlumnoID=@alumnoid
GO
/****** Object:  StoredProcedure [dbo].[AreasAlumnoBuscar]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AreasAlumnoBuscar]
@idusuario int
as
DECLARE @alumnoid int
SELECT @alumnoid=AL.AlumnoID
FROM ALUMNO AL INNER JOIN USUARIOS US
ON AL.UsuarioID=US.UsuarioID
WHERE US.UsuarioID=@idusuario
SELECT A.AreaID AS ID,A.Descripcion AS AREA
FROM AREAS A INNER JOIN DetalleAreas DET ON DET.AreaID=A.AreaID
INNER JOIN ALUMNO AL ON AL.AlumnoID=DET.AlumnoID
WHERE DET.AlumnoID=@alumnoid
GO
/****** Object:  StoredProcedure [dbo].[BuscaCompetenciaNotas]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscaCompetenciaNotas]
@areaid int,@iduser int
as
SELECT C.CompetenciaID,C.Descripcion as Competencia
FROM AREAS A INNER JOIN COMPETENCIA C
ON A.AreaID=C.AreaID
INNER JOIN DOCENTE D ON D.DocenteID=A.DocenteID
INNER JOIN USUARIOS U ON U.UsuarioID=D.UsuarioID
where a.AreaID=@areaid and U.UsuarioID=@iduser
GO
/****** Object:  StoredProcedure [dbo].[BuscarAlumno]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarAlumno]
@dni int,@areaid int
as
SELECT AL.AlumnoID,AL.Apellidos+', '+AL.Nombres AS DATOS
FROM ALUMNO AL INNER JOIN DetalleAreas DET
ON AL.AlumnoID=DET.AlumnoID
INNER JOIN AREAS A ON A.AreaID=DET.AreaID
INNER JOIN DOCENTE D ON D.DocenteID=A.DocenteID
INNER JOIN USUARIOS US ON US.UsuarioID=D.UsuarioID
WHERE AL.Dni=@dni and a.AreaID=@areaid
GO
/****** Object:  StoredProcedure [dbo].[BuscarAlumnoAreaDocente]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarAlumnoAreaDocente]
@idusuariodocente int
as
SELECT AL.AlumnoID AS Id,AL.Apellidos+', '+AL.Nombres AS DatosAlumno
FROM ALUMNO AL INNER JOIN DetalleAreas DET
ON AL.AlumnoID=DET.AlumnoID
INNER JOIN AREAS A ON A.AreaID=DET.AreaID
INNER JOIN DOCENTE DOC ON DOC.DocenteID=A.DocenteID
WHERE DOC.UsuarioID=@idusuariodocente
GO
/****** Object:  StoredProcedure [dbo].[DataNotasEvidencias]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DataNotasEvidencias]
@alumnoid int,@areaid int,@fecha date
as
SELECT Competencia, [Evidencia Aprendizaje 1], [Evidencia Aprendizaje 2], [Evidencia Aprendizaje 3],[Evidencia Aprendizaje 4]
FROM (
    SELECT C.Descripcion AS Competencia,E.Descripcion as Evidencia , E.Nota
    FROM EXPERIENCIA E INNER JOIN COMPETENCIA C
	ON C.CompetenciaID=E.CompetenciaID
	INNER JOIN AREAS A ON A.AreaID=C.AreaID INNER JOIN DetalleAreas DET ON DET.AreaID=A.AreaID
	INNER JOIN ALUMNO AL ON AL.AlumnoID=DET.AlumnoID
	where c.AreaID=@areaid AND AL.AlumnoID=@alumnoid and e.FechaRegistroNota=@fecha
) AS SourceTable
PIVOT (
    MAX(Nota) FOR Evidencia IN ([Evidencia Aprendizaje 1], [Evidencia Aprendizaje 2], [Evidencia Aprendizaje 3],[Evidencia Aprendizaje 4])
) AS PivotTable;
GO
/****** Object:  StoredProcedure [dbo].[EvidenciaRegistroNotas]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EvidenciaRegistroNotas]
@fecharegistro date,@nota char(2),@alumnoid int,@areaid int,@evidencia nvarchar(50),@competenciaid int
as

UPDATE E SET Nota=@nota,FechaRegistroNota=@fecharegistro
--SELECT C.Descripcion AS COMPETENCIA,NOTA=E.Nota,e.FechaRegistroNota,E.Descripcion AS EXPERIENCIA
FROM EXPERIENCIA E INNER JOIN COMPETENCIA C
ON E.CompetenciaID=C.CompetenciaID
INNER JOIN AREAS A ON A.AreaID=C.AreaID
INNER JOIN DetalleAreas DET ON DET.AreaID=A.AreaID
WHERE DET.AlumnoID=@alumnoid AND A.AreaID=@areaid AND E.Descripcion=@evidencia AND C.CompetenciaID=@competenciaid
GO
/****** Object:  StoredProcedure [dbo].[NotasApoderado]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotasApoderado]
@areaid int,@fecha date,@usuapodid int
as
DECLARE @alumnoid int
SELECT @alumnoid=AL.AlumnoID
FROM USUARIOS USU INNER JOIN APODERADO APP
ON USU.UsuarioID=APP.UsuarioID
INNER JOIN ALUMNO AL ON AL.ApoderadoID=APP.ApoderadoID
where USU.UsuarioID=@usuapodid

SELECT Competencia, [Evidencia Aprendizaje 1], [Evidencia Aprendizaje 2], [Evidencia Aprendizaje 3],[Evidencia Aprendizaje 4]
FROM (
    SELECT C.Descripcion AS Competencia,E.Descripcion as Evidencia , E.Nota
    FROM EXPERIENCIA E INNER JOIN COMPETENCIA C
	ON C.CompetenciaID=E.CompetenciaID
	INNER JOIN AREAS A ON A.AreaID=C.AreaID INNER JOIN DetalleAreas DET ON DET.AreaID=A.AreaID
	INNER JOIN ALUMNO AL ON AL.AlumnoID=DET.AlumnoID
	where c.AreaID=@areaid AND AL.AlumnoID=@alumnoid and e.FechaRegistroNota=@fecha
) AS SourceTable
PIVOT (
    MAX(Nota) FOR Evidencia IN ([Evidencia Aprendizaje 1], [Evidencia Aprendizaje 2], [Evidencia Aprendizaje 3],[Evidencia Aprendizaje 4])
) AS PivotTable;
GO
/****** Object:  StoredProcedure [dbo].[RegistrarAlumno]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarAlumno]
@apellidos nvarchar(100),@nombres nvarchar(100),@dni char(8),
@fecha date,@telefono char(9),@apoderado int,@gradoseccion int
as
 DECLARE @iduser int
 INSERT INTO USUARIOS(Usuario,Password,Rol)
 VALUES(UPPER(SUBSTRING(@nombres,0,4)+SUBSTRING(@dni,0,4)),@dni,'ALUMNO')

 SELECT @iduser=UsuarioID FROM USUARIOS WHERE Password=@dni

 INSERT INTO ALUMNO(Apellidos,Nombres,Dni,FechaNacimiento,Telefono,ApoderadoID,UsuarioID,GradoSeccionID)
 VALUES(@apellidos,@nombres,@dni,@fecha,@telefono,@apoderado,@iduser,@gradoseccion)
 
GO
/****** Object:  StoredProcedure [dbo].[RegistrarApoderado]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarApoderado]
@apellidos nvarchar(100),@nombres nvarchar(100),@dni char(8),
@fecha date,@telefono char(9)
as
 DECLARE @iduser int
 INSERT INTO USUARIOS(Usuario,Password,Rol)
 VALUES(UPPER(SUBSTRING(@nombres,0,4)+SUBSTRING(@dni,0,4)),@dni,'APODERADO')

 SELECT @iduser=UsuarioID FROM USUARIOS WHERE Password=@dni

 INSERT INTO APODERADO(Apellidos,Nombres,Dni,FechaNacimiento,Telefono,UsuarioID)
 VALUES(@apellidos,@nombres,@dni,@fecha,@telefono,@iduser)
 
GO
/****** Object:  StoredProcedure [dbo].[RegistrarAsistencia]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarAsistencia]
@asistencia char(1),@fecha date,@areaid int,@alumnoid int
as
INSERT INTO ASISTENCIAS(Asistencia,FechaAsistencia,AreaID,AlumnoID)
VALUES(@asistencia,@fecha,@areaid,@alumnoid)
GO
/****** Object:  StoredProcedure [dbo].[RegistrarDocente]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarDocente]
@apellidos nvarchar(100),@nombres nvarchar(100),@dni char(8),
@fecha date,@telefono char(9)
as
 DECLARE @iduser int
 INSERT INTO USUARIOS(Usuario,Password,Rol)
 VALUES(UPPER(SUBSTRING(@nombres,0,4)+SUBSTRING(@dni,0,4)),@dni,'DOCENTE')

 SELECT @iduser=UsuarioID FROM USUARIOS WHERE Password=@dni

 INSERT INTO DOCENTE(Apellidos,Nombres,Dni,FechaNacimiento,Telefono,UsuarioID)
 VALUES(@apellidos,@nombres,@dni,@fecha,@telefono,@iduser)
 
GO
/****** Object:  StoredProcedure [dbo].[RegistrarNotaExperiencia]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrarNotaExperiencia]
@nota char(2),@fecharegistro date,@competenciaid int
as
UPDATE EXPERIENCIA SET Nota=@nota,FechaRegistroNota=@fecharegistro
where CompetenciaID=@competenciaid
GO
/****** Object:  StoredProcedure [dbo].[RegistrarNotas]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarNotas]
@areaid int,@alumnoid int,@periodoid int,
@competencia1 char(2),@competencia2 char(2),
@competencia3 char(2),@competencia4 char(2)
as

UPDATE DetalleAreas SET Competencia1=@competencia1,Competencia2=@competencia2,
                        Competencia3=@competencia3,Competencia4=@competencia4
WHERE AreaID=@areaid and AlumnoID=@alumnoid and PeriodoID=@periodoid
GO
/****** Object:  StoredProcedure [dbo].[ReporteAsistenciasCursos]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteAsistenciasCursos]
@apodid int
as
DECLARE @alumnoid int
SELECT @alumnoid=AL.AlumnoID
FROM ALUMNO AL INNER JOIN APODERADO APO
ON APO.ApoderadoID=AL.ApoderadoID
INNER JOIN USUARIOS U ON U.UsuarioID=APO.UsuarioID
WHERE U.UsuarioID=@apodid

SELECT A.Descripcion AS AREA,Asistencia AS ASISTENCIA,AST.AsistenciaID AS CANT_ASISTENCIA
INTO #TEM
FROM ASISTENCIAS AST INNER JOIN AREAS A 
ON A.AreaID=AST.AreaID
WHERE AST.AlumnoID=@alumnoid
--GROUP BY A.Descripcion,AST.Asistencia

SELECT AREA,[A] AS ASISTENCIA,[F]AS FALTAS,[T] AS TARDANZAS,Total=SUM([A])+SUM([F])+SUM([T])
FROM #TEM
PIVOT(COUNT(CANT_ASISTENCIA)FOR ASISTENCIA IN ([A],[F],[T]))AS PVT
GROUP BY AREA,[A],[F],[T]
GO
/****** Object:  StoredProcedure [dbo].[ReporteAsistenciasCursosAlumnoS]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ReporteAsistenciasCursosAlumnoS]
@apodid int
as
DECLARE @alumnoid int
SELECT @alumnoid=AL.AlumnoID
FROM ALUMNO AL INNER JOIN USUARIOS U ON U.UsuarioID=AL.UsuarioID
WHERE U.UsuarioID=@apodid

SELECT A.Descripcion AS AREA,Asistencia AS ASISTENCIA,AST.AsistenciaID AS CANT_ASISTENCIA
INTO #TEM
FROM ASISTENCIAS AST INNER JOIN AREAS A 
ON A.AreaID=AST.AreaID
WHERE AST.AlumnoID=@alumnoid
--GROUP BY A.Descripcion,AST.Asistencia

SELECT AREA,[A] AS ASISTENCIA,[F]AS FALTAS,[T] AS TARDANZAS,Total=SUM([A])+SUM([F])+SUM([T])
FROM #TEM
PIVOT(COUNT(CANT_ASISTENCIA)FOR ASISTENCIA IN ([A],[F],[T]))AS PVT
GROUP BY AREA,[A],[F],[T]
GO
/****** Object:  StoredProcedure [dbo].[RFinalNotas]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RFinalNotas]
@areaid int,@alumnoid int,@c1 char(2),@c2 char(2),@c3 char(2),@c4 char(2),
@periodo int 
as
IF @c3='Seleccionar' or @c3='Se'
BEGIN

UPDATE DetalleAreas SET Competencia1=@c1,Competencia2=@c2,PeriodoID=@periodo
where AreaID=@areaid and AlumnoID=@alumnoid

END
IF @c4='Seleccionar' OR @c4='Se'
BEGIN 

UPDATE DetalleAreas SET Competencia1=@c1,Competencia2=@c2,Competencia3=@c3,PeriodoID=@periodo
where AreaID=@areaid and AlumnoID=@alumnoid
END

ELSE
BEGIN 
	
UPDATE DetalleAreas SET Competencia1=@c1,Competencia2=@c2,Competencia3=@c3,Competencia4=@c4,PeriodoID=@periodo
where AreaID=@areaid and AlumnoID=@alumnoid
END


GO
/****** Object:  StoredProcedure [dbo].[ValidarSesion]    Script Date: 21/08/2023 23:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValidarSesion]
@usuario nvarchar(50),@contraseña nvarchar(50)
as
SELECT UsuarioID,Rol FROM USUARIOS WHERE Usuario=@usuario and Password=@contraseña
GO
