CREATE DATABASE dbPruebaTecnicaAFP;
GO

USE [dbPruebaTecnicaAFP]
GO
/****** Object:  Table [dbo].[cita]    Script Date: 28/09/2021 02:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cita](
	[id_cita] [int] IDENTITY(1,1) NOT NULL,
	[paciente_id] [int] NULL,
	[doctor_id] [int] NULL,
	[fecha_cita] [date] NULL,
 CONSTRAINT [PK_cita] PRIMARY KEY CLUSTERED 
(
	[id_cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diagnostico]    Script Date: 28/09/2021 02:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnostico](
	[id_diagnostico] [int] IDENTITY(1,1) NOT NULL,
	[paciente_id] [int] NULL,
	[doctor_id] [int] NULL,
	[diagnostico_texto] [varchar](500) NULL,
	[date_created] [datetime] NULL,
 CONSTRAINT [PK_diagnostico] PRIMARY KEY CLUSTERED 
(
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor_informacion_basica]    Script Date: 28/09/2021 02:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_informacion_basica](
	[id_doctor] [int] IDENTITY(1,1) NOT NULL,
	[doctor_nombre] [varchar](50) NULL,
	[doctor_apellido] [varchar](50) NULL,
	[doctor_codigo] [varchar](50) NULL,
 CONSTRAINT [PK_doctor_informacion_basica] PRIMARY KEY CLUSTERED 
(
	[id_doctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente_informacion]    Script Date: 28/09/2021 02:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente_informacion](
	[id_paciente] [int] IDENTITY(1,1) NOT NULL,
	[paciente_nombre] [varchar](50) NULL,
	[paciente_apellido] [varchar](50) NULL,
	[paciente_direccion] [varchar](250) NULL,
	[paciente_telefono] [varchar](20) NULL,
	[paciente_documento] [varchar](20) NULL,
	[paciente_numero_documento] [nchar](20) NULL,
	[date_created] [datetime] NULL,
 CONSTRAINT [PK_paciente_informacion] PRIMARY KEY CLUSTERED 
(
	[id_paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cita] ON 
GO
INSERT [dbo].[cita] ([id_cita], [paciente_id], [doctor_id], [fecha_cita]) VALUES (1, 1, 4, CAST(N'2021-12-30' AS Date))
GO
INSERT [dbo].[cita] ([id_cita], [paciente_id], [doctor_id], [fecha_cita]) VALUES (2, 1, 3, CAST(N'2021-11-10' AS Date))
GO
SET IDENTITY_INSERT [dbo].[cita] OFF
GO
SET IDENTITY_INSERT [dbo].[doctor_informacion_basica] ON 
GO
INSERT [dbo].[doctor_informacion_basica] ([id_doctor], [doctor_nombre], [doctor_apellido], [doctor_codigo]) VALUES (1, N'Jose', N'Hermandez', N'DOC-01')
GO
INSERT [dbo].[doctor_informacion_basica] ([id_doctor], [doctor_nombre], [doctor_apellido], [doctor_codigo]) VALUES (2, N'Pedro', N'Hernandez', N'DOC02')
GO
INSERT [dbo].[doctor_informacion_basica] ([id_doctor], [doctor_nombre], [doctor_apellido], [doctor_codigo]) VALUES (3, N'Juan', N'Perez', N'DC01')
GO
INSERT [dbo].[doctor_informacion_basica] ([id_doctor], [doctor_nombre], [doctor_apellido], [doctor_codigo]) VALUES (4, N'Eduardo', N'Zepeda', N'EZ01')
GO
SET IDENTITY_INSERT [dbo].[doctor_informacion_basica] OFF
GO
SET IDENTITY_INSERT [dbo].[paciente_informacion] ON 
GO
INSERT [dbo].[paciente_informacion] ([id_paciente], [paciente_nombre], [paciente_apellido], [paciente_direccion], [paciente_telefono], [paciente_documento], [paciente_numero_documento], [date_created]) VALUES (1, N'Pedro', N'Sanchez', N'Calle el progreso casa 2', N'22889966', N'DUI', N'00000001            ', CAST(N'2021-09-28T13:09:53.787' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[paciente_informacion] OFF
GO
ALTER TABLE [dbo].[diagnostico] ADD  CONSTRAINT [DF_diagnostico_date_created]  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[paciente_informacion] ADD  CONSTRAINT [DF_paciente_informacion_date_created]  DEFAULT (getdate()) FOR [date_created]
GO

