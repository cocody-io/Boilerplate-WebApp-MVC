USE [Quality]
GO
SET IDENTITY_INSERT [dbo].[ref_CauseZE] ON 

INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (1, N'Machine', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (2, N'Main d''œuvre', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (3, N'Matière
', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (4, N'Méthode
', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (6, N'Matériel
', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (7, N'Flux', N'PR')
INSERT [dbo].[ref_CauseZE] ([ref_CauseZEId], [Name], [ProductionAreaName]) VALUES (8, N'Autre', N'PR')
SET IDENTITY_INSERT [dbo].[ref_CauseZE] OFF
SET IDENTITY_INSERT [dbo].[ref_CQ] ON 

INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (6, N'Cintrage complexe', N'PC', NULL, NULL, 3)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (9, N'Décrochement RD (sur CXRD)', N'PC', NULL, NULL, 4)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (10, N'Aspect produit (soufflure, trou, déchirures,......)
', N'PC', NULL, NULL, 0)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (11, N'Empreinte d''intercalaire
', N'PC', NULL, NULL, 10)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (12, N'Pli ou repli', N'PC', NULL, NULL, 11)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (13, N'Cohésion FE/PT
', N'PC', NULL, NULL, 12)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (14, N'Poids
', N'PC', NULL, NULL, 21)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (15, N'Non conformité tracés KM
', N'PC', NULL, NULL, 25)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (16, N'Dispersion des constituants du mélange
', N'PC', NULL, NULL, 28)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (17, N'Pollution (autre mélange, métal, bois, papier,…)
', N'PC', NULL, NULL, 29)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (18, N'Cotes de doublage
', N'PC', NULL, NULL, 31)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (19, N'Conformité géométrique (largeur, épaisseur,…)', N'PC', NULL, NULL, 34)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (20, N'HDV', N'PC', NULL, NULL, 37)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (21, N'Produit non-utilisé (Arrêt dim, prélim.)
', N'PC', NULL, NULL, 38)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (22, N'Non conformité striage, moletage, grain d''orge, petits couteaux
', N'PC', NULL, NULL, 40)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (23, N'Identification
', N'PC', NULL, NULL, 43)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (24, N'Collant à cru (dissolutionnage, produit blanc)
', N'PC', NULL, NULL, 53)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (25, N'Grattons
', N'PC', NULL, NULL, 55)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (26, N'Soudure forte ou faible
', N'PC', NULL, NULL, 56)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (27, N'Produit coupé par matière étrangère (ME) sous lame
', N'PC', NULL, NULL, 60)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (28, N'Intercalaires défectueux
', N'PC', NULL, NULL, 71)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (29, N'Bobines défectueuses
', N'PC', NULL, NULL, 72)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (30, N'Jonc (manque, empreinte, nœud,…)
', N'PC', NULL, NULL, 73)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (31, N'Mauvais enroulage
', N'PC', NULL, NULL, 74)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (32, N'Décentrage produit/intercalaire
', N'PC', NULL, NULL, 75)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (33, N'Fausse manœuvre
', N'PC', NULL, NULL, 81)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (34, N'Panne machine
', N'PC', NULL, NULL, 82)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (35, N'Rupture ébarbage
', N'PC', NULL, NULL, 83)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (36, N'Bourrage
', N'PC', NULL, NULL, 84)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (37, N'Phase de réglage
', N'PC', NULL, NULL, 90)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (38, N'Bobine non-pleine
', N'PC', NULL, NULL, 91)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (39, N'Essai
', N'PC', NULL, NULL, 94)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (40, N'2ème passage sur MARS tringle H
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (41, N'Accidenté
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (42, N'Agrafe ouverte
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (43, N'Arrêt dimension
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (44, N'Aspect tringle nue
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (45, N'Aspect tringle habillée
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (46, N'Autre (préciser la cause)
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (47, N'Azimutage non conforme
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (48, N'Centrage hors tolérance
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (49, N'Décomplexage carcasse
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (50, N'Décorticage tringle
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (51, N'Déchet technologique (H Gomme)
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (52, N'Empreintes
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (53, N'Erreur de réglage
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (54, N'Erreur de BA
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (55, N'Essai 
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (56, N'Grattons
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (57, N'Hors Poids
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (58, N'Ecart entre les spires
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (59, N'Largeur produit
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (60, N'Manque étiquette
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (62, N'Mauvais habillage
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (63, N'Marquage roulette
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (64, N'Non renseigné
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (65, N'Ovalisée
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (66, N'Plis
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (67, N'Piquage sur HT
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (68, N'Poids RT lourd
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (69, N'Poids RT léger
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (70, N'Poids HT lourd
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (71, N'Poids HT léger
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (72, N'Pollution
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (73, N'HDV
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (74, N'Tringles collées
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (75, N'Soudure faible
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (76, N'Soudure non faite
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (77, N'Soudure forte
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (78, N'Soufflure
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (79, N'Sens soudure
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (80, N'Stéaratage non conforme
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (81, N'Tringles collées
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (82, N'Tringles voilées
', N'PR TRINGLES', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (83, N'Nombre de couches
', N'PR ROBOTS', NULL, NULL, 401)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (84, N'Nombre de fils
', N'PR ROBOTS', NULL, NULL, 402)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (85, N'Jeux entre couches et entre fils
', N'PR ROBOTS', NULL, NULL, 403)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (86, N'Voile de la tringle
', N'PR ROBOTS', NULL, NULL, 404)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (87, N'Déformation du fil
', N'PR ROBOTS', NULL, NULL, 405)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (88, N'Jeux aux extrémités des fils
', N'PR ROBOTS', NULL, NULL, 406)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (89, N'Décalage aux extrémités des fils
', N'PR ROBOTS', NULL, NULL, 407)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (90, N'Nombre de colliers
', N'PR ROBOTS', NULL, NULL, 411)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (91, N'Tenue des colliers sertis
', N'PR ROBOTS', NULL, NULL, 412)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (92, N'Décalage des colliers
', N'PR ROBOTS', NULL, NULL, 413)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (93, N'Rebiquage des colliers
', N'PR ROBOTS', NULL, NULL, 414)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (94, N'Jeux sous colliers
', N'PR ROBOTS', NULL, NULL, 415)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (95, N'Position colliers extrêmes
', N'PR ROBOTS', NULL, NULL, 416)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (96, N'Anomalies aspect de surface
', N'PR ROBOTS', NULL, NULL, 421)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (97, N'Marques sur la tringle
', N'PR ROBOTS', NULL, NULL, 422)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (98, N'Non conformité d''obtention non imputable au Sce O
', N'PR ROBOTS', NULL, NULL, 423)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (99, N'Taches sur plat ou angle du fil sous colliers soudés
', N'PR ROBOTS', NULL, NULL, 424)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (100, N'Etat de surface des colliers
', N'PR ROBOTS', NULL, NULL, 425)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (101, N'Vieillissement feuillard
', N'PR ROBOTS', NULL, NULL, 427)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (102, N'Vieillissement et conditions de conservation du fil rectangulaire zingué
', N'PR ROBOTS', NULL, NULL, 65)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (103, N'Conditionnement produit (Enroulage / Centrage / Sens / Condt / Trop plein)
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (104, N'Dimensionnel produit (Longueur fil / Largeur / cote RD / Radialité)
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (105, N'Aspect produit (grattons, décalandrage, plis, fils en pinceau, pollution, ….)
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (106, N'Soudures produit (ouvertes / faibles / décrochement / superposées/
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (107, N'Identification produit
', N'PM', NULL, NULL, NULL)
GO
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (108, N'CAC (+ ou -)
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (109, N'Produit HDV
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (110, N'Arrêt Produit
', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (111, N'Autre', N'PM', NULL, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (112, N'Debut et fin de NDF
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (113, N'Changement de dimension
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (114, N'Tractionnement Soudure ou Ech. CAC
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (115, N'Erreur de reglage
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (116, N'Mauvais CAC imputable à RYO
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (117, N'Incidents machine (Pb coupe, bourrage, enroulage …)
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (118, N'Incident conditionnement (Pb Intercalaire, bobine,..)
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (119, N'Essais
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (120, N'Fosses NSZ
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (121, N'Autres
', N'PM', NULL, 1, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (122, N'Lisières (faible ou forte)
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (123, N'Mauvaise géométrie laize en fin de pièce
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (124, N'Mauvais enroulage
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (125, N'Manque calandrage
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (126, N'Trous / arrachement skim en surface de NDF
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (127, N'Grains grattons
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (128, N'Replis de skim, surépaisseur sur NDF
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (129, N'Pollution / matières étrangères
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (130, N'Ecart de pas, fil manquant, croisé ou sauté
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (131, N'Rebicage, ondulation ou fil nerveux
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (132, N'Autres', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (133, N'Interruption NDF
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (134, N'Découpe tissus en lisière
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (135, N'Collant à cru
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (136, N'Tortillon détecté à épurer
', N'PM', 1, NULL, NULL)
INSERT [dbo].[ref_CQ] ([ref_CQId], [Name], [ProductionAreaName], [IsSupplierCQ], [IsRyoCQ], [Code]) VALUES (137, N'Intercalaire trop long (ou manque de produit)
', N'PM', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ref_CQ] OFF
SET IDENTITY_INSERT [dbo].[ref_Imputation] ON 

INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (1, N'PM', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (2, N'PZ', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (3, N'PK = Fournisseur
', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (4, N'ZP = Fournisseur
', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (5, N'ESSAIS
', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (6, N'CARISTES
', N'PM')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (7, N'Agent (PC)
', N'PC')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (8, N'PR
', N'PC')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (9, N'PZ
', N'PC')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (10, N'FOURNISSEUR MELANGE (CHO)
', N'PC')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (11, N'PR', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (12, N'CARISTES
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (13, N'PZ', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (14, N'PC
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (15, N'PM', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (16, N'VAN = Fournisseur
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (17, N'CHO = Fournisseur
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (18, N'HBG = Fournisseur
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (19, N'UMO = Fournisseur
', N'PR ROBOTS')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (50, N'PR', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (61, N'CARISTES
', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (62, N'PZ', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (63, N'PC
', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (64, N'PM', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (65, N'VAN = Fournisseur
', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (66, N'CHO = Fournisseur
', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (67, N'HBG = Fournisseur
', N'PR TRINGLES')
INSERT [dbo].[ref_Imputation] ([ref_ImputationId], [Name], [ProductionAreaName]) VALUES (68, N'UMO = Fournisseur
', N'PR TRINGLES')
SET IDENTITY_INSERT [dbo].[ref_Imputation] OFF
SET IDENTITY_INSERT [dbo].[ref_Machine] ON 

INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (2, N'Robot N°4
', N'R4
', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (3, N'Robot N°3
', N'R3', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (5, N'Robot N°1
', N'R1', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (6, N'M4
', N'M4
', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (7, N'M2
', N'M2
', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (8, N'M1
', N'M1
', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (9, N'C1
', N'C1
', N'PR ROBOTS
')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (10, N'MARS
', N'MARS
', N'PR TRINGLES')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (12, N'Boudineuse N°1
', N'B1', N'PR TRINGLES')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (13, N'Boudineuse N°2
', N'B2', N'PR TRINGLES')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (14, N'Boudineuse N°4
', N'B4', N'PR TRINGLES')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (15, N'Doubleuse RD
', N'ER2', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (16, N'Abouteuse Laize Manuelle
', N'ALM1', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (17, N'Abouteuse Laize Manuelle
', N'ALM2 ', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (18, N'Coupeuse auto
', N'NSQ1', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (19, N'Coupeuse auto
', N'NSZ2
', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (20, N'Coupeuse manuelle
', N'CM5
', N'PM')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (21, N'MP550
', N'MP550
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (22, N'Doubleuse FE 1
', N'Doubleuse FE 1
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (23, N'Doubleuse FE 3
', N'Doubleuse FE 3
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (24, N'Quadriex
', N'Quadriex
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (25, N'Calandre
', N'EB4', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (26, N'Nez a rouleau 2
', N'NAR 2
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (27, N'Nez a rouleau 5
', N'NAR 5
', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (28, N'Nez a rouleau 7
', N'NAR 7', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (29, N'Nez a rouleau 8
', N'NAR 8', N'PC')
INSERT [dbo].[ref_Machine] ([ref_MachineId], [Name], [Code], [ProductionAreaName]) VALUES (30, N'Nez a rouleau 9
', N'NAR 9', N'PC')
SET IDENTITY_INSERT [dbo].[ref_Machine] OFF
SET IDENTITY_INSERT [dbo].[ref_PieceType] ON 

INSERT [dbo].[ref_PieceType] ([ref_PieceTypeId], [Name]) VALUES (1, N'Rouleau')
INSERT [dbo].[ref_PieceType] ([ref_PieceTypeId], [Name]) VALUES (2, N'Chariot')
SET IDENTITY_INSERT [dbo].[ref_PieceType] OFF
SET IDENTITY_INSERT [dbo].[ref_ProductionArea] ON 

INSERT [dbo].[ref_ProductionArea] ([ref_ProductionAreaId], [Name]) VALUES (1, N'PM')
INSERT [dbo].[ref_ProductionArea] ([ref_ProductionAreaId], [Name]) VALUES (2, N'PC')
INSERT [dbo].[ref_ProductionArea] ([ref_ProductionAreaId], [Name]) VALUES (3, N'PR ROBOTS')
INSERT [dbo].[ref_ProductionArea] ([ref_ProductionAreaId], [Name]) VALUES (4, N'PR TRINGLES')
SET IDENTITY_INSERT [dbo].[ref_ProductionArea] OFF
SET IDENTITY_INSERT [dbo].[ref_Unit] ON 

INSERT [dbo].[ref_Unit] ([ref_UnitId], [Name]) VALUES (1, N'KG')
INSERT [dbo].[ref_Unit] ([ref_UnitId], [Name]) VALUES (2, N'UNITE')
SET IDENTITY_INSERT [dbo].[ref_Unit] OFF
SET IDENTITY_INSERT [dbo].[ref_Ventilation] ON 

INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (1, N'Machine
', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (2, N'Main d''œuvre
', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (3, N'Matière
', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (4, N'Méthode
', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (5, N'Matériel
', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (6, N'Flux', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (7, N'Autre', N'PM')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (8, N'H = Jeté
', N'PC')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (9, N'R = Récupéré
', N'PC')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (10, N'Jeter
', N'PR')
INSERT [dbo].[ref_Ventilation] ([ref_VentilationId], [Name], [ProductionAreaName]) VALUES (11, N'Récupérer
', N'PR')
SET IDENTITY_INSERT [dbo].[ref_Ventilation] OFF



SET IDENTITY_INSERT [dbo].[ref_ProductCode] ON 
GO
INSERT [dbo].[ref_ProductCode] ([ref_ProductCodeId], [Code]) VALUES (1, N'Gomme')
GO
INSERT [dbo].[ref_ProductCode] ([ref_ProductCodeId], [Code]) VALUES (2, N'Métal')
GO
INSERT [dbo].[ref_ProductCode] ([ref_ProductCodeId], [Code]) VALUES (3, N'Tissu')
GO
SET IDENTITY_INSERT [dbo].[ref_ProductCode] OFF
GO
SET IDENTITY_INSERT [dbo].[ref_ProductType] ON 
GO
INSERT [dbo].[ref_ProductType] ([ref_ProductTypeId], [Name]) VALUES (1, N'type1')
GO
INSERT [dbo].[ref_ProductType] ([ref_ProductTypeId], [Name]) VALUES (2, N'type2')
GO
SET IDENTITY_INSERT [dbo].[ref_ProductType] OFF
GO
