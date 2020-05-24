USE [master]
GO
/****** Object:  Database [Gestion_de_recursos_humanos]    Script Date: 24/5/2020 17:25:03 ******/
CREATE DATABASE [Gestion_de_recursos_humanos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion_de_recursos_humanos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Gestion_de_recursos_humanos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestion_de_recursos_humanos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Gestion_de_recursos_humanos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion_de_recursos_humanos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET QUERY_STORE = OFF
GO
USE [Gestion_de_recursos_humanos]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[FK_Localidad] [int] NOT NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Busqueda]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Busqueda](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[Observacion] [text] NOT NULL,
	[FK_Personal] [int] NOT NULL,
	[FK_Oficina] [int] NOT NULL,
 CONSTRAINT [PK_Busqueda] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[ID] [int] NOT NULL,
	[FK_Barrio] [int] NOT NULL,
	[Calle] [nchar](30) NOT NULL,
	[Numero] [int] NOT NULL,
	[FK_TipoDireccion] [int] NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListaPostulante]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaPostulante](
	[ID] [int] NOT NULL,
	[FK_Postulante] [int] NOT NULL,
	[FK_Busqueda] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[FK_Provincia] [int] NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Necesidad]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Necesidad](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[Observacion] [text] NOT NULL,
	[FK_Personal] [int] NULL,
 CONSTRAINT [PK_Necesidad] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oficina]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oficina](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[FK_Direccion] [int] NOT NULL,
 CONSTRAINT [PK_Oficina] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
	[FK_Cargo] [int] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[ID] [int] NOT NULL,
	[Nombre] [nchar](30) NOT NULL,
	[Apellido] [nchar](30) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[FK_Genero] [int] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[ID] [int] NOT NULL,
	[FechaIngreso] [date] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Legajo] [int] NOT NULL,
	[FK_Direccion] [int] NOT NULL,
	[FK_Cargo] [int] NOT NULL,
	[FK_Oficina] [int] NOT NULL,
	[FK_Telefono] [int] NOT NULL,
	[FK_Supervisor] [int] NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postulante]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postulante](
	[ID] [int] NOT NULL,
	[CV] [text] NOT NULL,
	[FK_Estado] [int] NOT NULL,
 CONSTRAINT [PK_Postulante] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[Numero] [int] NOT NULL,
	[Empresa] [nchar](30) NOT NULL,
	[FK_TipoTelefono] [int] NOT NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDireccion]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDireccion](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_TipoDireccion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTelefono]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTelefono](
	[ID] [int] NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_TipoTelefono] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Barrio] ([ID], [Descripcion], [FK_Localidad]) VALUES (1, N'Lauda                         ', 1)
INSERT [dbo].[Barrio] ([ID], [Descripcion], [FK_Localidad]) VALUES (2, N'Barrio uno                    ', 2)
INSERT [dbo].[Cargo] ([ID], [Descripcion]) VALUES (1, N'Gerente                       ')
INSERT [dbo].[Direccion] ([ID], [FK_Barrio], [Calle], [Numero], [FK_TipoDireccion]) VALUES (1, 1, N'De los Constituyentes         ', 1229, 1)
INSERT [dbo].[Direccion] ([ID], [FK_Barrio], [Calle], [Numero], [FK_TipoDireccion]) VALUES (2, 2, N'Alfonsina Storni              ', 41, 2)
INSERT [dbo].[Genero] ([ID], [Descripcion]) VALUES (1, N'Masculino                     ')
INSERT [dbo].[Localidad] ([ID], [Descripcion], [FK_Provincia]) VALUES (1, N'Luis Guillon                  ', 1)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [FK_Provincia]) VALUES (2, N'Ezeiza                        ', 1)
INSERT [dbo].[Necesidad] ([ID], [Descripcion], [Observacion], [FK_Personal]) VALUES (1, N'Programador .NET              ', N'Se necesita programador .NET junior part time', 1)
INSERT [dbo].[Oficina] ([ID], [Descripcion], [FK_Direccion]) VALUES (1, N'UPE                           ', 2)
INSERT [dbo].[Permiso] ([ID], [Descripcion], [FK_Cargo]) VALUES (1, N'Generar Necesidad             ', 1)
INSERT [dbo].[Permiso] ([ID], [Descripcion], [FK_Cargo]) VALUES (2, N'Visualizar postulante         ', 1)
INSERT [dbo].[Permiso] ([ID], [Descripcion], [FK_Cargo]) VALUES (3, N'Aprobar postulante            ', 1)
INSERT [dbo].[Permiso] ([ID], [Descripcion], [FK_Cargo]) VALUES (4, N'Rechazar postulante           ', 1)
INSERT [dbo].[Permiso] ([ID], [Descripcion], [FK_Cargo]) VALUES (5, N'Borrar necesidad              ', 1)
INSERT [dbo].[Persona] ([ID], [Nombre], [Apellido], [Email], [FK_Genero]) VALUES (1, N'Matias                        ', N'Piedrabuena                   ', N'matias.ezequiel.piedrabuena@gmail.com', 1)
INSERT [dbo].[Personal] ([ID], [FechaIngreso], [FechaNacimiento], [Legajo], [FK_Direccion], [FK_Cargo], [FK_Oficina], [FK_Telefono], [FK_Supervisor], [Contraseña]) VALUES (1, CAST(N'2020-05-22' AS Date), CAST(N'1993-01-14' AS Date), 1, 1, 1, 1, 1138173357, NULL, N'contraseñagenerica')
INSERT [dbo].[Provincia] ([ID], [Descripcion]) VALUES (1, N'Buenos Aires                  ')
INSERT [dbo].[Telefono] ([Numero], [Empresa], [FK_TipoTelefono]) VALUES (1138173357, N'Tuenti                        ', 1)
INSERT [dbo].[TipoDireccion] ([ID], [Descripcion]) VALUES (1, N'Casa                          ')
INSERT [dbo].[TipoDireccion] ([ID], [Descripcion]) VALUES (2, N'Oficina                       ')
INSERT [dbo].[TipoTelefono] ([ID], [Descripcion]) VALUES (1, N'Celular                       ')
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Localidad] FOREIGN KEY([FK_Localidad])
REFERENCES [dbo].[Localidad] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Localidad]
GO
ALTER TABLE [dbo].[Busqueda]  WITH CHECK ADD  CONSTRAINT [Necesidad_Busqueda] FOREIGN KEY([ID])
REFERENCES [dbo].[Necesidad] ([ID])
GO
ALTER TABLE [dbo].[Busqueda] CHECK CONSTRAINT [Necesidad_Busqueda]
GO
ALTER TABLE [dbo].[Busqueda]  WITH CHECK ADD  CONSTRAINT [Para_Oficina] FOREIGN KEY([FK_Oficina])
REFERENCES [dbo].[Oficina] ([ID])
GO
ALTER TABLE [dbo].[Busqueda] CHECK CONSTRAINT [Para_Oficina]
GO
ALTER TABLE [dbo].[Busqueda]  WITH CHECK ADD  CONSTRAINT [RRHH_Busqueda] FOREIGN KEY([FK_Personal])
REFERENCES [dbo].[Personal] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Busqueda] CHECK CONSTRAINT [RRHH_Busqueda]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Barrio] FOREIGN KEY([FK_Barrio])
REFERENCES [dbo].[Barrio] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Barrio]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_TipoDireccion] FOREIGN KEY([FK_TipoDireccion])
REFERENCES [dbo].[TipoDireccion] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_TipoDireccion]
GO
ALTER TABLE [dbo].[ListaPostulante]  WITH CHECK ADD  CONSTRAINT [EnBusqueda] FOREIGN KEY([FK_Busqueda])
REFERENCES [dbo].[Busqueda] ([ID])
GO
ALTER TABLE [dbo].[ListaPostulante] CHECK CONSTRAINT [EnBusqueda]
GO
ALTER TABLE [dbo].[ListaPostulante]  WITH CHECK ADD  CONSTRAINT [Postulado] FOREIGN KEY([FK_Postulante])
REFERENCES [dbo].[Postulante] ([ID])
GO
ALTER TABLE [dbo].[ListaPostulante] CHECK CONSTRAINT [Postulado]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Provincia] FOREIGN KEY([FK_Provincia])
REFERENCES [dbo].[Provincia] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Provincia]
GO
ALTER TABLE [dbo].[Necesidad]  WITH CHECK ADD  CONSTRAINT [Gerente_Necesidad] FOREIGN KEY([FK_Personal])
REFERENCES [dbo].[Personal] ([ID])
GO
ALTER TABLE [dbo].[Necesidad] CHECK CONSTRAINT [Gerente_Necesidad]
GO
ALTER TABLE [dbo].[Oficina]  WITH CHECK ADD  CONSTRAINT [FK_Direccion] FOREIGN KEY([FK_Direccion])
REFERENCES [dbo].[Direccion] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oficina] CHECK CONSTRAINT [FK_Direccion]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [TienePermiso] FOREIGN KEY([FK_Cargo])
REFERENCES [dbo].[Cargo] ([ID])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [TienePermiso]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Genero] FOREIGN KEY([FK_Genero])
REFERENCES [dbo].[Genero] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Genero]
GO
ALTER TABLE [dbo].[Personal]  WITH NOCHECK ADD  CONSTRAINT [Hijo_Personal] FOREIGN KEY([ID])
REFERENCES [dbo].[Persona] ([ID])
GO
ALTER TABLE [dbo].[Personal] NOCHECK CONSTRAINT [Hijo_Personal]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [Organigrama_Personal] FOREIGN KEY([FK_Supervisor])
REFERENCES [dbo].[Personal] ([ID])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [Organigrama_Personal]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [Tiene_Direccion] FOREIGN KEY([FK_Direccion])
REFERENCES [dbo].[Direccion] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [Tiene_Direccion]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [Tiene_Telefono] FOREIGN KEY([FK_Telefono])
REFERENCES [dbo].[Telefono] ([Numero])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [Tiene_Telefono]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [TieneCargo] FOREIGN KEY([FK_Cargo])
REFERENCES [dbo].[Cargo] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [TieneCargo]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [Trabaja_Oficina] FOREIGN KEY([FK_Oficina])
REFERENCES [dbo].[Oficina] ([ID])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [Trabaja_Oficina]
GO
ALTER TABLE [dbo].[Postulante]  WITH CHECK ADD  CONSTRAINT [Estado_Postulante] FOREIGN KEY([FK_Estado])
REFERENCES [dbo].[Estado] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Postulante] CHECK CONSTRAINT [Estado_Postulante]
GO
ALTER TABLE [dbo].[Postulante]  WITH NOCHECK ADD  CONSTRAINT [Hijo_Postulante] FOREIGN KEY([ID])
REFERENCES [dbo].[Persona] ([ID])
GO
ALTER TABLE [dbo].[Postulante] NOCHECK CONSTRAINT [Hijo_Postulante]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_TipoTelefono] FOREIGN KEY([FK_TipoTelefono])
REFERENCES [dbo].[TipoTelefono] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_TipoTelefono]
GO
/****** Object:  StoredProcedure [dbo].[sp_ComprobarUsuario]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ComprobarUsuario] @Legajo int, @Contraseña nvarchar(50)
AS
SELECT [Persona].[Nombre],
	[Persona].[Apellido]
FROM [dbo].[Persona]
WHERE [Persona].[ID] =  
	(SELECT [ID] 
	FROM [PERSONAL]
	WHERE (Legajo = @Legajo) AND (Contraseña = @Contraseña))
GO
/****** Object:  StoredProcedure [dbo].[sp_InformacionCompleta]    Script Date: 24/5/2020 17:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InformacionCompleta] @Legajo int
AS

SELECT Empleado.Legajo, Persona.Nombre, Persona.Apellido, Persona.Email, Genero.Descripcion AS Genero, Cargo.Descripcion AS Cargo, Empleado.FechaNacimiento, Empleado.FechaIngreso, 
		Direccion.Calle, Direccion.Numero AS Altura, TipoDireccion.Descripcion AS TipoDireccion, Provincia.Descripcion AS Provincia, Localidad.Descripcion AS Localidad,
		Barrio.Descripcion AS Barrio, TipoTelefono.Descripcion AS TipoTelefono,Telefono.Numero AS NumeroTel, Oficina.Descripcion AS Oficina, 
		Supervisor.ID AS LegajoSupervisor
FROM Personal AS Empleado
INNER JOIN Persona
ON Empleado.ID = Persona.ID
INNER JOIN Genero
ON Persona.FK_Genero = Genero.ID
INNER JOIN Cargo
ON Empleado.FK_Cargo = Cargo.ID
INNER JOIN Direccion
ON Empleado.FK_Direccion = Direccion.ID
INNER JOIN TipoDireccion
ON Direccion.FK_TipoDireccion = TipoDireccion.ID
INNER JOIN Barrio
ON Direccion.FK_Barrio = Barrio.ID
INNER JOIN Localidad
ON Barrio.FK_Localidad = Localidad.ID
INNER JOIN Provincia
ON Localidad.FK_Provincia = Provincia.ID
INNER JOIN Telefono
ON Empleado.FK_Telefono = Telefono.Numero
INNER JOIN TipoTelefono
ON Telefono.FK_TipoTelefono = TipoTelefono.ID
INNER JOIN Oficina
ON Empleado.FK_Oficina = Oficina.ID
LEFT JOIN Personal AS Supervisor
ON Empleado.FK_Supervisor = Supervisor.ID
Where (Empleado.Legajo = @Legajo);
GO
USE [master]
GO
ALTER DATABASE [Gestion_de_recursos_humanos] SET  READ_WRITE 
GO
