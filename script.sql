USE [master]
GO
/****** Object:  Database [NBA]    Script Date: 08.05.2024 18:39:00 ******/
CREATE DATABASE [NBA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NBA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\NBA.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NBA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\NBA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [NBA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NBA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NBA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NBA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NBA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NBA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NBA] SET ARITHABORT OFF 
GO
ALTER DATABASE [NBA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NBA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NBA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NBA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NBA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NBA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NBA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NBA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NBA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NBA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NBA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NBA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NBA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NBA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NBA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NBA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NBA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NBA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NBA] SET  MULTI_USER 
GO
ALTER DATABASE [NBA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NBA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NBA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NBA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NBA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NBA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NBA', N'ON'
GO
ALTER DATABASE [NBA] SET QUERY_STORE = ON
GO
ALTER DATABASE [NBA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [NBA]
GO
/****** Object:  Table [dbo].[ActionType]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionType](
	[ActionTypeId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ActionType] PRIMARY KEY CLUSTERED 
(
	[ActionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Jobnumber] [varchar](6) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Passwords] [varchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[RoleId] [char](1) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Jobnumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conference]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conference](
	[ConferenceId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Conference] PRIMARY KEY CLUSTERED 
(
	[ConferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryCode] [char](3) NOT NULL,
	[CountryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Division]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Division](
	[DivisionId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ConferenceId] [int] NOT NULL,
 CONSTRAINT [PK_Division] PRIMARY KEY CLUSTERED 
(
	[DivisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matchup]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matchup](
	[MatchupId] [int] IDENTITY(1,1) NOT NULL,
	[SeasonId] [int] NOT NULL,
	[MatchupTypeId] [int] NOT NULL,
	[Team_Away] [int] NOT NULL,
	[Team_Home] [int] NOT NULL,
	[Starttime] [datetime] NOT NULL,
	[Team_Away_Score] [int] NOT NULL,
	[Team_Home_Score] [int] NOT NULL,
	[Location] [varchar](200) NULL,
	[Status] [int] NOT NULL,
	[CurrentQuarter] [varchar](50) NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[MatchupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchupDetail]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NOT NULL,
	[Quarter] [int] NOT NULL,
	[Team_Away_Score] [int] NOT NULL,
	[Team_Home_Score] [int] NOT NULL,
 CONSTRAINT [PK_MatchupDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchupLog]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NOT NULL,
	[Quarter] [int] NOT NULL,
	[OccurTime] [varchar](10) NOT NULL,
	[TeamId] [int] NOT NULL,
	[PlayerId] [int] NOT NULL,
	[ActionTypeId] [int] NOT NULL,
	[Remark] [varchar](300) NULL,
 CONSTRAINT [PK_MatchupLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchupType]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupType](
	[MatchupTypeId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ScheduleType] PRIMARY KEY CLUSTERED 
(
	[MatchupTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pictures]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Img] [image] NOT NULL,
	[Description] [varchar](50) NULL,
	[NumberOfLike] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PictureInGallery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PositionId] [int] NOT NULL,
	[JoinYear] [date] NOT NULL,
	[Height] [decimal](10, 2) NOT NULL,
	[Weight] [decimal](10, 2) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[College] [varchar](50) NULL,
	[CountryCode] [char](3) NOT NULL,
	[Img] [image] NULL,
	[IsRetirment] [bit] NOT NULL,
	[RetirmentTime] [date] NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerInTeam]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerInTeam](
	[PlayerInTeamId] [int] IDENTITY(1,1) NOT NULL,
	[PlayerId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
	[SeasonId] [int] NOT NULL,
	[ShirtNumber] [varchar](10) NOT NULL,
	[Salary] [decimal](10, 2) NOT NULL,
	[StarterIndex] [int] NOT NULL,
 CONSTRAINT [PK_PlayerInTeam] PRIMARY KEY CLUSTERED 
(
	[PlayerInTeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerStatistics]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerStatistics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
	[PlayerId] [int] NOT NULL,
	[IsStarting] [int] NOT NULL,
	[Min] [decimal](10, 2) NOT NULL,
	[Point] [int] NOT NULL,
	[Assist] [int] NOT NULL,
	[FieldGoalMade] [int] NOT NULL,
	[FieldGoalMissed] [int] NOT NULL,
	[3-PointFieldGoalMade] [int] NOT NULL,
	[3-PointFieldGoalMissed] [int] NOT NULL,
	[FreeThrowMade] [int] NOT NULL,
	[FreeThrowMissed] [int] NOT NULL,
	[Rebound] [int] NOT NULL,
	[OFFR] [int] NOT NULL,
	[DFFR] [int] NOT NULL,
	[Steal] [int] NOT NULL,
	[Block] [int] NOT NULL,
	[Turnover] [int] NOT NULL,
	[Foul] [int] NOT NULL,
 CONSTRAINT [PK_PlayerStatistics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Abbr] [char](3) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostSeason]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostSeason](
	[TeamId] [int] NOT NULL,
	[SeasonId] [int] NOT NULL,
	[Rank] [int] NOT NULL,
 CONSTRAINT [PK_PostSeason] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC,
	[SeasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [char](1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Season](
	[SeasonId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED 
(
	[SeasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 08.05.2024 18:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [int] NOT NULL,
	[TeamName] [varchar](50) NOT NULL,
	[DivisionId] [int] NOT NULL,
	[Coach] [varchar](50) NOT NULL,
	[Abbr] [char](3) NOT NULL,
	[Stadium] [varchar](100) NULL,
	[Logo] [image] NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pictures] ADD  CONSTRAINT [DF_PictureInGallery_NumberOfLike]  DEFAULT ((0)) FOR [NumberOfLike]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Role]
GO
ALTER TABLE [dbo].[Division]  WITH CHECK ADD  CONSTRAINT [FK_Division_Conference] FOREIGN KEY([ConferenceId])
REFERENCES [dbo].[Conference] ([ConferenceId])
GO
ALTER TABLE [dbo].[Division] CHECK CONSTRAINT [FK_Division_Conference]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Matchup_Season] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([SeasonId])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Matchup_Season]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_SeasonType] FOREIGN KEY([MatchupTypeId])
REFERENCES [dbo].[MatchupType] ([MatchupTypeId])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Schedule_SeasonType]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Team] FOREIGN KEY([Team_Away])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Schedule_Team]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Team1] FOREIGN KEY([Team_Home])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Schedule_Team1]
GO
ALTER TABLE [dbo].[MatchupDetail]  WITH CHECK ADD  CONSTRAINT [FK_MatchupResult_Schedule] FOREIGN KEY([MatchupId])
REFERENCES [dbo].[Matchup] ([MatchupId])
GO
ALTER TABLE [dbo].[MatchupDetail] CHECK CONSTRAINT [FK_MatchupResult_Schedule]
GO
ALTER TABLE [dbo].[MatchupLog]  WITH CHECK ADD  CONSTRAINT [FK_MatchupLog_ActionType] FOREIGN KEY([ActionTypeId])
REFERENCES [dbo].[ActionType] ([ActionTypeId])
GO
ALTER TABLE [dbo].[MatchupLog] CHECK CONSTRAINT [FK_MatchupLog_ActionType]
GO
ALTER TABLE [dbo].[MatchupLog]  WITH CHECK ADD  CONSTRAINT [FK_MatchupLog_Player] FOREIGN KEY([PlayerId])
REFERENCES [dbo].[Player] ([PlayerId])
GO
ALTER TABLE [dbo].[MatchupLog] CHECK CONSTRAINT [FK_MatchupLog_Player]
GO
ALTER TABLE [dbo].[MatchupLog]  WITH CHECK ADD  CONSTRAINT [FK_MatchupLog_Schedule] FOREIGN KEY([MatchupId])
REFERENCES [dbo].[Matchup] ([MatchupId])
GO
ALTER TABLE [dbo].[MatchupLog] CHECK CONSTRAINT [FK_MatchupLog_Schedule]
GO
ALTER TABLE [dbo].[MatchupLog]  WITH CHECK ADD  CONSTRAINT [FK_MatchupLog_Team] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[MatchupLog] CHECK CONSTRAINT [FK_MatchupLog_Team]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Country] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([CountryCode])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Country]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Position] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Position] ([PositionId])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Position]
GO
ALTER TABLE [dbo].[PlayerInTeam]  WITH CHECK ADD  CONSTRAINT [FK_PlayerInTeam_Player] FOREIGN KEY([PlayerId])
REFERENCES [dbo].[Player] ([PlayerId])
GO
ALTER TABLE [dbo].[PlayerInTeam] CHECK CONSTRAINT [FK_PlayerInTeam_Player]
GO
ALTER TABLE [dbo].[PlayerInTeam]  WITH CHECK ADD  CONSTRAINT [FK_PlayerInTeam_Season] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([SeasonId])
GO
ALTER TABLE [dbo].[PlayerInTeam] CHECK CONSTRAINT [FK_PlayerInTeam_Season]
GO
ALTER TABLE [dbo].[PlayerInTeam]  WITH CHECK ADD  CONSTRAINT [FK_PlayerInTeam_Team] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[PlayerInTeam] CHECK CONSTRAINT [FK_PlayerInTeam_Team]
GO
ALTER TABLE [dbo].[PlayerStatistics]  WITH CHECK ADD  CONSTRAINT [FK_MatchupStatistics_Player] FOREIGN KEY([PlayerId])
REFERENCES [dbo].[Player] ([PlayerId])
GO
ALTER TABLE [dbo].[PlayerStatistics] CHECK CONSTRAINT [FK_MatchupStatistics_Player]
GO
ALTER TABLE [dbo].[PlayerStatistics]  WITH CHECK ADD  CONSTRAINT [FK_MatchupStatistics_Schedule] FOREIGN KEY([MatchupId])
REFERENCES [dbo].[Matchup] ([MatchupId])
GO
ALTER TABLE [dbo].[PlayerStatistics] CHECK CONSTRAINT [FK_MatchupStatistics_Schedule]
GO
ALTER TABLE [dbo].[PlayerStatistics]  WITH CHECK ADD  CONSTRAINT [FK_MatchupStatistics_Team] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[PlayerStatistics] CHECK CONSTRAINT [FK_MatchupStatistics_Team]
GO
ALTER TABLE [dbo].[PostSeason]  WITH CHECK ADD  CONSTRAINT [FK_TeamInPostseason_Season] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([SeasonId])
GO
ALTER TABLE [dbo].[PostSeason] CHECK CONSTRAINT [FK_TeamInPostseason_Season]
GO
ALTER TABLE [dbo].[PostSeason]  WITH CHECK ADD  CONSTRAINT [FK_TeamInPostseason_Team] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[PostSeason] CHECK CONSTRAINT [FK_TeamInPostseason_Team]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Division] FOREIGN KEY([DivisionId])
REFERENCES [dbo].[Division] ([DivisionId])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Division]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [CK_Admin] CHECK  (([Gender]='F' OR [Gender]='M'))
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [CK_Admin]
GO
USE [master]
GO
ALTER DATABASE [NBA] SET  READ_WRITE 
GO
