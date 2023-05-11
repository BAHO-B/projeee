CREATE DATABASE Kütüphane_DB
GO
USE Kütüphane_DB
GO
CREATE TABLE KÝTAPBÝLGÝLERÝ
(
id int IDENTITY(1,1) NOT NULL,
kitapadý varchar(50) NULL,
kategorisi varchar(50) NULL,
yazarý varchar(50) NULL,
sayfasayýsý varchar(50) NULL,
CONSTRAINT PK_KÝTAPBÝLGÝLERÝ PRIMARY KEY(id)
)
CREATE TABLE ÖÐRENCÝBÝLGÝLERÝ
(
	öðrenciid int IDENTITY(1,1) NOT NULL,
	öðrenciadsoyad varchar(50) NULL,
	kullanýcýadý varchar(50) NULL,
	email varchar(50) NULL,
	þifre varchar(50) NULL,
 CONSTRAINT PK_ÖÐRENCÝBÝLGÝLERÝ PRIMARY KEY (öðrenciid) 
 )
 CREATE TABLE YETKÝLÝBÝLGÝLERÝ
 (
	yetkiliid int IDENTITY(1,1) NOT NULL,
	adsoyad varchar(50) NULL,
	telefon varchar(11) NULL,
	tc varchar(11) NULL,
	adres varchar(75) NULL,
	kullanýcýadý varchar(50) NULL,
	þifre varchar(50) NULL,
 CONSTRAINT PK_YETKÝLÝBÝLGÝLERÝ PRIMARY KEY(yetkiliid)
)
