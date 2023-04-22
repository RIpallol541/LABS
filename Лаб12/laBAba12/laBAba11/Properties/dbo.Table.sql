CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Достопремечательность] NCHAR(10) NOT NULL, 
    [Фото] NCHAR(10) NOT NULL, 
    [Год открытия] INT NOT NULL, 
    [Местоположение ] NCHAR(10) NOT NULL, 
    [Описание] NCHAR(10) NOT NULL
)
