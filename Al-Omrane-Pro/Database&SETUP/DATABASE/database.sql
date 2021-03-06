-- détacher dik la base li 3andk f l sql w  exécuter hadi bnafs smiya 
Create database data_amrani

USE [data_amrani]
GO
/****** Object:  Table [dbo].[CATEGORIE]    Script Date: 08/30/2013 11:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIE](
	[ID_CAT] [int] NOT NULL,
	[LIB_CATEG] [nvarchar](50) NULL,
 CONSTRAINT [PK_CATEGORIE] PRIMARY KEY CLUSTERED 
(
	[ID_CAT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CATEGORIE] ([ID_CAT], [LIB_CATEG]) VALUES (1, N'maçon')
INSERT [dbo].[CATEGORIE] ([ID_CAT], [LIB_CATEG]) VALUES (2, N'electricien')
INSERT [dbo].[CATEGORIE] ([ID_CAT], [LIB_CATEG]) VALUES (3, N'plombièr')
INSERT [dbo].[CATEGORIE] ([ID_CAT], [LIB_CATEG]) VALUES (4, N'gardien')
INSERT [dbo].[CATEGORIE] ([ID_CAT], [LIB_CATEG]) VALUES (8, N'architecte')
/****** Object:  Table [dbo].[ARTICLE]    Script Date: 08/30/2013 11:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICLE](
	[REF_ART] [int] NOT NULL,
	[NOM_ART] [nvarchar](50) NULL,
	[DESIGNATION] [nvarchar](50) NULL,
	[FOURNISSEUR] [nvarchar](50) NULL,
	[UNITE] [nvarchar](50) NULL,
	[PRIX_UNIT] [money] NULL,
	[MODE_PAY] [nvarchar](50) NULL,
	[TVA] [real] NULL,
 CONSTRAINT [PK_ARTICLE] PRIMARY KEY CLUSTERED 
(
	[REF_ART] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (1, N'CIMENT', N'CIMENT F1', N'BERRADA', N'UNITE', 900.0000, N'CHEQUE', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (2, N'FER', N'FER 10', N'SQALLI', N'KG', 1000.0000, N'CHEQUE', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (3, N'COU', N'COU 10', N'BERRADA', N'UNITE', 10.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (4, N'paint', N'paint rouge bl', N'colorado', N'UNITE', 100.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (5, N'paint', N'paint jaune', N'colorado', N'LITRE', 120.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (6, N'paint', N'paint noir sl', N'colorado', N'LITRE', 200.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (54, N'gh', N'ghh', N'frghj', N'TON', 89.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (56, N'tyy', N'hhyty', N'ty', N'KG', 89.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (66, N'teyar', N'teyyara', N'sdgfhjklò', N'UNITE', 8988.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (77, N'9ar3a', N'khedra', N'ghhggh', N'METRE', 675.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (87, N'otman', N'otma', N'hagha', N'KG', 1234.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (90, N'lkcheb', N'lkcheb l arz', N'moul kheb', N'UNITE', 9000.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (91, N'lkheb', N'lkheb l byed', N'hwa', N'METRE', 120.0000, N'CHEQUE', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (93, N'hhhhh', N'hhhhhhhhhhh', N'pookh', N'TON', 130.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (98, N'king', N'king fighter', N'japan', N'UNITE', 9013.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (102, N'Devdas', N'Devda', N'kaka', N'UNITE', 20.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (234, N'train', N'train d japan', N'maroc', N'TON', 12900.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (456, N'kok', N'e7eeeem', N'frghj', N'UNITE', 698.0000, N'CASH', 20)
INSERT [dbo].[ARTICLE] ([REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITE], [PRIX_UNIT], [MODE_PAY], [TVA]) VALUES (1211, N'ggg', N'ggggg', N'ggggg', N'TON', 222.0000, N'CASH', 20)
/****** Object:  Table [dbo].[DETAIL]    Script Date: 08/30/2013 11:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETAIL](
	[ID_DET] [int] IDENTITY(1,1) NOT NULL,
	[REF_ART] [int] NULL,
	[NOM_ART] [nvarchar](50) NULL,
	[DESIGNATION] [nvarchar](50) NULL,
	[FOURNISSEUR] [nvarchar](50) NULL,
	[UNITEE] [nvarchar](50) NULL,
	[PRIX_UNITAIRE] [real] NULL,
	[QUANTITE] [int] NULL,
	[MODE_PAY] [nvarchar](50) NULL,
	[TVA] [real] NULL,
	[DATE_DAQUISTATION] [datetime] NULL,
	[MONTANT_HT] [real] NULL,
	[MONTANT_TTC] [real] NULL,
 CONSTRAINT [PK_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID_DET] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DETAIL] ON
INSERT [dbo].[DETAIL] ([ID_DET], [REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITEE], [PRIX_UNITAIRE], [QUANTITE], [MODE_PAY], [TVA], [DATE_DAQUISTATION], [MONTANT_HT], [MONTANT_TTC]) VALUES (24, 1, N'CIMENT', N'CIMENT F1', N'BERRADA', N'UNITE', 900, 10, N'CHEQUE', 20, CAST(0x0000A15900000000 AS DateTime), 9000, 10800)
INSERT [dbo].[DETAIL] ([ID_DET], [REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITEE], [PRIX_UNITAIRE], [QUANTITE], [MODE_PAY], [TVA], [DATE_DAQUISTATION], [MONTANT_HT], [MONTANT_TTC]) VALUES (25, 56, N'tyy', N'hhyty', N'ty', N'KG', 89, 20, N'CASH', 20, CAST(0x0000A20C00000000 AS DateTime), 1780, 2136)
INSERT [dbo].[DETAIL] ([ID_DET], [REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITEE], [PRIX_UNITAIRE], [QUANTITE], [MODE_PAY], [TVA], [DATE_DAQUISTATION], [MONTANT_HT], [MONTANT_TTC]) VALUES (26, 102, N'Devdas', N'Devda', N'kaka', N'UNITE', 20, 80, N'CASH', 20, CAST(0x0000A22800000000 AS DateTime), 1600, 1920)
INSERT [dbo].[DETAIL] ([ID_DET], [REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITEE], [PRIX_UNITAIRE], [QUANTITE], [MODE_PAY], [TVA], [DATE_DAQUISTATION], [MONTANT_HT], [MONTANT_TTC]) VALUES (27, 456, N'kok', N'e7eeeem', N'frghj', N'UNITE', 698, 2225, N'CASH', 20, CAST(0x0000A21500000000 AS DateTime), 1553050, 1863660)
INSERT [dbo].[DETAIL] ([ID_DET], [REF_ART], [NOM_ART], [DESIGNATION], [FOURNISSEUR], [UNITEE], [PRIX_UNITAIRE], [QUANTITE], [MODE_PAY], [TVA], [DATE_DAQUISTATION], [MONTANT_HT], [MONTANT_TTC]) VALUES (28, 3, N'COU', N'COU 10', N'BERRADA', N'UNITE', 10, 1, N'CASH', 20, CAST(0x0000A21500000000 AS DateTime), 10, 12)
SET IDENTITY_INSERT [dbo].[DETAIL] OFF
/****** Object:  Table [dbo].[PERSONNEL]    Script Date: 08/30/2013 11:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONNEL](
	[CIN] [nvarchar](50) NOT NULL,
	[NOM] [nvarchar](50) NULL,
	[PRENOM] [nvarchar](50) NULL,
	[TELEPHONE] [nvarchar](50) NULL,
	[ADRESSE] [nvarchar](50) NULL,
	[SALAIRE] [money] NULL,
	[MODE_PAY] [nvarchar](50) NULL,
	[ID_CATEG] [int] NULL,
	[Code_cheque] [nvarchar](50) NULL,
 CONSTRAINT [PK_PERSONNEL] PRIMARY KEY CLUSTERED 
(
	[CIN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'c898989', N'loper', N'lekili', N'0987654321', N'csablanca', 90.0000, N'CASH', 2, N'NONE(CASH)')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'c9078', N'lopez', N'andrea', N'09877654343', N'milano', 900.0000, N'CASH', 4, N'')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'cd120987', N'hammadi', N'anas', N'0654323212', N'casablanca', 9000.0000, N'CHEQUE', 3, N'n232314')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'CD454534', N'ALAMI', N'KAMAL', N'0675432198', N'RABAT', 80.0000, N'CASH', 3, N'NONE(CASH)')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'CD787878', N'AMMAR', N'DRWICH', N'0654323310', N'FES', 90.0000, N'CASH', 2, N'NONE(CASH)')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'cd908978', N'debbagh', N'youssef', N'06453423', N'fes', 9000.0000, N'CHEQUE', 3, N'n232315')
INSERT [dbo].[PERSONNEL] ([CIN], [NOM], [PRENOM], [TELEPHONE], [ADRESSE], [SALAIRE], [MODE_PAY], [ID_CATEG], [Code_cheque]) VALUES (N'cy676767', N'devdas', N'lowner', N'098775654', N'como', 500.0000, N'CASH', 2, N'NONE(CASH)')
/****** Object:  Table [dbo].[DETAIL_perso]    Script Date: 08/30/2013 11:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETAIL_perso](
	[ID_DP] [int] IDENTITY(1,1) NOT NULL,
	[CIN] [nvarchar](50) NOT NULL,
	[DATE_PAY] [datetime] NOT NULL,
 CONSTRAINT [PK_DETAIL_perso] PRIMARY KEY CLUSTERED 
(
	[ID_DP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DETAIL_perso] ON
INSERT [dbo].[DETAIL_perso] ([ID_DP], [CIN], [DATE_PAY]) VALUES (1, N'c898989', CAST(0x0000A1B500000000 AS DateTime))
INSERT [dbo].[DETAIL_perso] ([ID_DP], [CIN], [DATE_PAY]) VALUES (2, N'c898989', CAST(0x00009FEA00000000 AS DateTime))
INSERT [dbo].[DETAIL_perso] ([ID_DP], [CIN], [DATE_PAY]) VALUES (3, N'cd908978', CAST(0x0000806800000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[DETAIL_perso] OFF
/****** Object:  View [dbo].[V_detail]    Script Date: 08/30/2013 11:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_detail]
AS
SELECT        dbo.DETAIL.*
FROM            dbo.DETAIL
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DETAIL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_detail'
GO
/****** Object:  View [dbo].[V_Per]    Script Date: 08/30/2013 11:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Per]
AS
SELECT        dbo.DETAIL_perso.CIN, dbo.PERSONNEL.NOM, dbo.PERSONNEL.PRENOM, dbo.DETAIL_perso.DATE_PAY
FROM            dbo.DETAIL_perso INNER JOIN
                         dbo.PERSONNEL ON dbo.DETAIL_perso.CIN = dbo.PERSONNEL.CIN
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DETAIL_perso"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PERSONNEL"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 218
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Per'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Per'
GO
/****** Object:  ForeignKey [FK_DETAIL_ARTICLE]    Script Date: 08/30/2013 11:23:22 ******/
ALTER TABLE [dbo].[DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_DETAIL_ARTICLE] FOREIGN KEY([REF_ART])
REFERENCES [dbo].[ARTICLE] ([REF_ART])
GO
ALTER TABLE [dbo].[DETAIL] CHECK CONSTRAINT [FK_DETAIL_ARTICLE]
GO
/****** Object:  ForeignKey [FK_DETAIL_perso_PERSONNEL]    Script Date: 08/30/2013 11:23:22 ******/
ALTER TABLE [dbo].[DETAIL_perso]  WITH CHECK ADD  CONSTRAINT [FK_DETAIL_perso_PERSONNEL] FOREIGN KEY([CIN])
REFERENCES [dbo].[PERSONNEL] ([CIN])
GO
ALTER TABLE [dbo].[DETAIL_perso] CHECK CONSTRAINT [FK_DETAIL_perso_PERSONNEL]
GO
/****** Object:  ForeignKey [FK_PERSONNEL_CATEGORIE]    Script Date: 08/30/2013 11:23:22 ******/
ALTER TABLE [dbo].[PERSONNEL]  WITH CHECK ADD  CONSTRAINT [FK_PERSONNEL_CATEGORIE] FOREIGN KEY([ID_CATEG])
REFERENCES [dbo].[CATEGORIE] ([ID_CAT])
GO
ALTER TABLE [dbo].[PERSONNEL] CHECK CONSTRAINT [FK_PERSONNEL_CATEGORIE]
GO
