IF OBJECT_ID(N'[dbo].[MigrationHistory]') IS NULL
BEGIN
    CREATE TABLE [dbo].[MigrationHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK_MigrationHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Company] (
    [Id] int NOT NULL IDENTITY,
    [CreateTime] datetime2 NULL,
    [CreateBy] nvarchar(max) NULL,
    [UpdateTime] datetime2 NULL,
    [UpdateBy] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [Name] nvarchar(125) NOT NULL,
    [Address_Country_Name] nvarchar(max) NULL,
    [Address_Country_Address] nvarchar(max) NULL,
    [Address_Country_Continent] nvarchar(max) NULL,
    [Address_Province] nvarchar(25) NULL,
    [Address_City] nvarchar(25) NULL,
    [Address_Region] nvarchar(500) NULL,
    [Address_Street] nvarchar(500) NULL,
    [Address_DetailAddress] nvarchar(max) NULL,
    [Fix] nvarchar(25) NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Department] (
    [Id] int NOT NULL IDENTITY,
    [CreateTime] datetime2 NULL,
    [CreateBy] nvarchar(max) NULL,
    [UpdateTime] datetime2 NULL,
    [UpdateBy] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [DepartmentNo] nvarchar(max) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [User] (
    [Id] int NOT NULL IDENTITY,
    [CreateTime] datetime2 NULL,
    [CreateBy] nvarchar(max) NULL,
    [UpdateTime] datetime2 NULL,
    [UpdateBy] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [Account] nvarchar(10) NOT NULL,
    [Password] nvarchar(100) NOT NULL,
    [NickName] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [CompanyDepartment] (
    [CompanyId] int NOT NULL,
    [DepartmentId] int NOT NULL,
    [CreateTime] datetime2 NULL,
    [CreateBy] nvarchar(max) NULL,
    [UpdateTime] datetime2 NULL,
    [UpdateBy] nvarchar(max) NULL,
    [Status] int NOT NULL,
    CONSTRAINT [PK_CompanyDepartment] PRIMARY KEY ([DepartmentId], [CompanyId]),
    CONSTRAINT [FK_CompanyDepartment_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Company] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CompanyDepartment_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Employee] (
    [Id] int NOT NULL IDENTITY,
    [CreateTime] datetime2 NULL,
    [CreateBy] nvarchar(max) NULL,
    [UpdateTime] datetime2 NULL,
    [UpdateBy] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [EmployeeNo] nvarchar(max) NULL,
    [Contact] nvarchar(max) NULL,
    [Gender] nvarchar(max) NOT NULL,
    [CompanyId] int NULL,
    [DepartmentId] int NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Employee_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Company] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Employee_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE CASCADE
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateBy', N'CreateTime', N'Fix', N'Name', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[Company]'))
    SET IDENTITY_INSERT [Company] ON;
INSERT INTO [Company] ([Id], [CreateBy], [CreateTime], [Fix], [Name], [Status], [UpdateBy])
VALUES (1, N'System', '2020-03-26T17:02:00.2821258+08:00', N'539855', N'宦梦月', 0, N'System'),
(2, N'System', '2020-03-26T17:02:00.2828702+08:00', N'513756', N'平恩宇', 0, N'System'),
(3, N'System', '2020-03-26T17:02:00.2835243+08:00', N'224060', N'和恩蓉', 0, N'System'),
(4, N'System', '2020-03-26T17:02:00.2842700+08:00', N'123664', N'那振淑', 0, N'System'),
(5, N'System', '2020-03-26T17:02:00.2850158+08:00', N'381607', N'储婷', 0, N'System'),
(6, N'System', '2020-03-26T17:02:00.2856559+08:00', N'665295', N'葛金', 0, N'System'),
(7, N'System', '2020-03-26T17:02:00.2863415+08:00', N'360072', N'令狐子思', 0, N'System'),
(8, N'System', '2020-03-26T17:02:00.2869878+08:00', N'584207', N'谭钰宇', 0, N'System'),
(9, N'System', '2020-03-26T17:02:00.2880356+08:00', N'590559', N'施旭雨', 0, N'System'),
(10, N'System', '2020-03-26T17:02:00.2889418+08:00', N'501501', N'苍淑', 0, N'System');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateBy', N'CreateTime', N'Fix', N'Name', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[Company]'))
    SET IDENTITY_INSERT [Company] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateBy', N'CreateTime', N'DepartmentNo', N'Name', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[Department]'))
    SET IDENTITY_INSERT [Department] ON;
INSERT INTO [Department] ([Id], [CreateBy], [CreateTime], [DepartmentNo], [Name], [Status], [UpdateBy])
VALUES (9, N'System', '2020-03-26T17:02:00.2971992+08:00', NULL, N'郁晨明', 0, N'System'),
(8, N'System', '2020-03-26T17:02:00.2964824+08:00', NULL, N'钮炅', 0, N'System'),
(7, N'System', '2020-03-26T17:02:00.2953008+08:00', NULL, N'栾琳海', 0, N'System'),
(6, N'System', '2020-03-26T17:02:00.2945926+08:00', NULL, N'巩梓', 0, N'System'),
(1, N'System', '2020-03-26T17:02:00.2909581+08:00', NULL, N'马静艺', 0, N'System'),
(4, N'System', '2020-03-26T17:02:00.2932013+08:00', NULL, N'巩金承', 0, N'System'),
(3, N'System', '2020-03-26T17:02:00.2925019+08:00', NULL, N'夏侯瑞晓', 0, N'System'),
(2, N'System', '2020-03-26T17:02:00.2917997+08:00', NULL, N'糜子天', 0, N'System'),
(10, N'System', '2020-03-26T17:02:00.2978798+08:00', NULL, N'邰嘉海', 0, N'System'),
(5, N'System', '2020-03-26T17:02:00.2938927+08:00', NULL, N'巴紫', 0, N'System');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateBy', N'CreateTime', N'DepartmentNo', N'Name', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[Department]'))
    SET IDENTITY_INSERT [Department] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Account', N'CreateBy', N'CreateTime', N'Name', N'NickName', N'Password', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[User]'))
    SET IDENTITY_INSERT [User] ON;
INSERT INTO [User] ([Id], [Account], [CreateBy], [CreateTime], [Name], [NickName], [Password], [Status], [UpdateBy])
VALUES (1, N'Admin', N'System', '2020-03-26T17:02:00.1487084+08:00', N'何骄', N'牛明欣', N'Admin', 0, N'System');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Account', N'CreateBy', N'CreateTime', N'Name', N'NickName', N'Password', N'Status', N'UpdateBy') AND [object_id] = OBJECT_ID(N'[User]'))
    SET IDENTITY_INSERT [User] OFF;

GO

CREATE INDEX [IX_CompanyDepartment_CompanyId] ON [CompanyDepartment] ([CompanyId]);

GO

CREATE INDEX [IX_Employee_CompanyId] ON [Employee] ([CompanyId]);

GO

CREATE INDEX [IX_Employee_DepartmentId] ON [Employee] ([DepartmentId]);

GO

INSERT INTO [dbo].[MigrationHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200326090200_Init', N'3.1.3');

GO

