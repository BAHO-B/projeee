CREATE DATABASE K�t�phane_DB
GO
USE K�t�phane_DB
GO
CREATE TABLE K�TAPB�LG�LER�
(
id int IDENTITY(1,1) NOT NULL,
kitapad� varchar(50) NULL,
kategorisi varchar(50) NULL,
yazar� varchar(50) NULL,
sayfasay�s� varchar(50) NULL,
CONSTRAINT PK_K�TAPB�LG�LER� PRIMARY KEY(id)
)
CREATE TABLE ��RENC�B�LG�LER�
(
	��renciid int IDENTITY(1,1) NOT NULL,
	��renciadsoyad varchar(50) NULL,
	kullan�c�ad� varchar(50) NULL,
	email varchar(50) NULL,
	�ifre varchar(50) NULL,
 CONSTRAINT PK_��RENC�B�LG�LER� PRIMARY KEY (��renciid) 
 )
 CREATE TABLE YETK�L�B�LG�LER�
 (
	yetkiliid int IDENTITY(1,1) NOT NULL,
	adsoyad varchar(50) NULL,
	telefon varchar(11) NULL,
	tc varchar(11) NULL,
	adres varchar(75) NULL,
	kullan�c�ad� varchar(50) NULL,
	�ifre varchar(50) NULL,
 CONSTRAINT PK_YETK�L�B�LG�LER� PRIMARY KEY(yetkiliid)
)
