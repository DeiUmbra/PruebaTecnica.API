CREATE DATABASE dbPruebaTecnicaAFP;
GO

USE [dbPruebaTecnicaAFP]
GO
/****** Object:  Table [dbo].[afiliado_datos_generales]    Script Date: 16/10/2020 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[afiliado_datos_generales](
	[afi_id] [int] IDENTITY(1,1) NOT NULL,
	[afi_nombre] [varchar](250) NOT NULL,
	[afi_apellido] [varchar](250) NOT NULL,
	[afi_direccion] [varchar](500) NULL,
	[afi_dui] [varchar](25) NOT NULL,
	[afi_datecreated] [datetime] NULL,
	[afi_dateupdated] [datetime] NULL,
	[afi_status] [int] NOT NULL,
 CONSTRAINT [PK_tb_afiliado_datos_generales] PRIMARY KEY CLUSTERED 
(
	[afi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[afiliado_datos_generales] ON 

INSERT [dbo].[afiliado_datos_generales] ([afi_id], [afi_nombre], [afi_apellido], [afi_direccion], [afi_dui], [afi_datecreated], [afi_dateupdated], [afi_status]) VALUES (1, N'Eduardo', N'Zepeda', N'Urb.Dolores 4 C.Pricinal Casa 22 Mejicanos', N'032908276', CAST(N'2020-10-16T10:26:50.383' AS DateTime), NULL, 1)
INSERT [dbo].[afiliado_datos_generales] ([afi_id], [afi_nombre], [afi_apellido], [afi_direccion], [afi_dui], [afi_datecreated], [afi_dateupdated], [afi_status]) VALUES (2, N'Jose', N'Martinez', N'Avenida 11 casa #20', N'032908233', NULL, CAST(N'2020-10-16T11:25:57.933' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[afiliado_datos_generales] OFF
ALTER TABLE [dbo].[afiliado_datos_generales] ADD  CONSTRAINT [DF_tb_afiliado_datos_generales_afi_datecreated]  DEFAULT (getdate()) FOR [afi_datecreated]
GO
ALTER TABLE [dbo].[afiliado_datos_generales] ADD  CONSTRAINT [DF_tb_afiliado_datos_generales_afi_status]  DEFAULT ((1)) FOR [afi_status]
GO
