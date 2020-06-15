USE [Gestion_de_recursos_humanos]
GO
/****** Object:  StoredProcedure [dbo].[sp_ComprobarUsuario]    Script Date: 15/6/2020 13:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_ComprobarUsuario] @Legajo int, @Contraseña nvarchar(50)
AS
 
SELECT [Persona].[Nombre],
	[Persona].[Apellido],
[Personal].[Legajo],
[Personal].[FK_Cargo],
[Cargo].[Descripcion] as 'Cargo'
 FROM Personal 
 INNER JOIN Persona ON Persona.id = Personal.id
 INNER JOIN Cargo ON Cargo.id = Personal.id 
 WHERE (personal.Legajo = @Legajo) and (personal.Contraseña=@Contraseña)

