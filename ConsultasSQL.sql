USE [registroEmpleado]
GO

SELECT [id]
      ,[nombre]
      ,[apellido]
      ,[foto]
  FROM [dbo].[empleados]

GO

INSERT INTO [dbo].[empleados]
           ([nombre]
           ,[apellido]
           ,[foto])
     VALUES
     ('Brandon','Alvarado','>D')

	 UPDATE [dbo].[empleados]
   SET [nombre] = 'Brandon'
      ,[apellido] = 'Alvarado'
      ,[foto] = 'aqui va la foto'
 WHERE id = 1;

 DELETE FROM [dbo].[empleados]
      WHERE id = 1

GO
