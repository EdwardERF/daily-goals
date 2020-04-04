USE master
GO

IF EXISTS(SELECT * FROM SysDataBases WHERE NAME = 'DailyGoals')
	BEGIN
		DROP DATABASE DailyGoals
	END
GO

CREATE DATABASE DailyGoals
GO

USE DailyGoals
GO

CREATE TABLE USERS
(
	USER_ID UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	USER_NAME VARCHAR(20) NOT NULL,
	USER_MAIL VARCHAR(50) NOT NULL,
	USER_EXPERIENCE INT NOT NULL
)
GO

CREATE TABLE DAILYGOAL
(
	DAILY_GOAL_ID UNIQUEIDENTIFIER DEFAULT NEWID() UNIQUE,
	USER_ID UNIQUEIDENTIFIER FOREIGN KEY REFERENCES USERS(USER_ID),
	GOAL_TEXT VARCHAR(1000) NOT NULL,
	GOAL_DATE DATETIME,
	PRIMARY KEY(DAILY_GOAL_ID, USER_ID)
)
GO

CREATE TABLE GOAL_EMOTION
(
	COLOR VARCHAR(20) NOT NULL,
	DAILY_GOAL_ID UNIQUEIDENTIFIER FOREIGN KEY REFERENCES DAILYGOAL(DAILY_GOAL_ID),
	PRIMARY KEY(COLOR, DAILY_GOAL_ID)
)
GO

CREATE TABLE COMMENT
(
	COMMENT_ID UNIQUEIDENTIFIER DEFAULT NEWID() UNIQUE NOT NULL,
	USER_ID UNIQUEIDENTIFIER FOREIGN KEY REFERENCES USERS(USER_ID),
	COMMENT_MAIN VARCHAR(1000),
	COMMENT_DATE DATETIME
)
GO

CREATE TABLE COMMENT_EMOTION (
	COLOR VARCHAR(20) NOT NULL,
	COMMENT_ID UNIQUEIDENTIFIER FOREIGN KEY REFERENCES COMMENT(COMMENT_ID),
	PRIMARY KEY(COLOR, COMMENT_ID)
)
GO