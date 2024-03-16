CREATE DATABASE MusicPlayer
GO
USE MusicPlayer
GO
CREATE TABLE USERS
(
	ID INT primary key,
	username varchar(100) not null,
	password varchar(100) not null,
	name nvarchar(100),
	email varchar(100),
	birthday datetime, 
	gender varchar(15) check (gender IN ('Male', 'Female', 'Non-binary')),
	profile_picture nvarchar(255)
)
GO
Alter table users
drop column user_location
CREATE TABLE SINGER
(
    ID INT, -- Không cần PRIMARY KEY ở đây vì sẽ thêm sau
    name nvarchar(100) not null,
    Songs_count int,
    PRIMARY KEY (name)
)
GO
CREATE TABLE SONGS
(
	ID INT primary key,
	name nvarchar(255) not null,
	artist_name nvarchar(100) not null,
	duration int,
	path nvarchar(255)
)
GO

Alter table SOngs drop column track_picture

CREATE TABLE PLAYLISTS
(
	ID int primary key,
	name nvarchar(100) not null,
	owner_id int not null,
	Constraint FK_owner_id_PLAYLISTS_USERS FOREIGN KEY (owner_id) REFERENCES USERS (id)
)
GO
CREATE TABLE PLAYLIST_SONGS
(	
	PlaylistSong_ID int,
	Playlist_ID int,
	Songs_ID int,
	Constraint PK_Playlist_ID_Track_ID PRIMARY KEY (Playlist_ID, Songs_ID),
    Constraint FK_Playlist_ID_PLAYLIST_TRACKS_PLAYLISTS FOREIGN KEY (Playlist_ID) REFERENCES PLAYLISTS (ID),
    Constraint FK_Songs_ID_PLAYLIST_TRACKS_SONGS FOREIGN KEY(Songs_ID) REFERENCES SONGS (ID)
)
GO

ALTER TABLE SONGS
ALTER COLUMN path NVARCHAR(255)


SELECT
  name,
  genres,
  CONCAT(
    RIGHT('00' + CAST(FLOOR(Duration / 60) AS VARCHAR(2)), 2),
    ':',
    RIGHT('00' + CAST(Duration % 60 AS VARCHAR(2)), 2)
  ) AS duration,
  artist_id
FROM SONGS;



SELECT MAX(ID) AS MaxID FROM USERS

INSERT INTO USERS (ID, username, password, name, email, birthday, gender) VALUES(3, 'Qhuy2004', 'Kakashi201', 'Qhuy2004', 'Truongquochuy@gmail.com', '2004/01/05', 'Male')

UPDATE USERS SET password = 'Qhuy204' WHERE email = 'truongquochuy234@gmail.com' 

CREATE TRIGGER TR_AFTER_INSERT_SONGS
ON SONGS
AFTER INSERT
AS
BEGIN

	-- Lấy ra artist_name của bản ghi vừa thêm
	DECLARE @artist_name nvarchar(100)
	SELECT @artist_name = artist_name from inserted 

	-- Kiểm tra xem artist_name đó đã tồn tại trong bảng SINGER chưa
	IF EXISTS (SELECT * FROM SINGER WHERE name = @artist_name)
	BEGIN

		-- Nếu tồn tại thì cập nhật cột Songs_count
		UPDATE SINGER
		SET Songs_count = Songs_count + 1
		WHERE name = @artist_name;

	END
	ELSE
	BEGIN

		-- Nếu chưa tồn tại thì thêm artist đó vào bảng SINGER
		INSERT INTO SINGER (ID, name, Songs_count)
		SELECT ISNULL(MAX(ID), 0) + 1, @artist_name, 1 FROM SINGER;

	END

END;


CREATE TRIGGER TR_AFTER_DELETE_SONGS
ON SONGS
AFTER Delete
AS
BEGIN

	-- Lấy ra artist_name của bản ghi vừa xóa
	DECLARE @artist_name nvarchar(100)
	SELECT @artist_name = artist_name from deleted 
	
	-- Kiểm tra xem artist_name đó đã tồn tại trong bảng SINGER chưa
	IF EXISTS (SELECT * FROM SINGER WHERE name = @artist_name)
	BEGIN

		-- Nếu tồn tại thì cập nhật cột Songs_count
		UPDATE SINGER
		SET Songs_count = Songs_count - 1
		WHERE name = @artist_name
	END
END




CREATE TRIGGER TR_AFTER_DELETE_PLAYLISTS
ON PLAYLISTS
AFTER Delete
AS
BEGIN

	-- Lấy ra ID của bản ghi vừa xóa
	DECLARE @ID INT
	SELECT @ID = ID from deleted 
	
	IF EXISTS (SELECT * FROM PLAYLISTS WHERE ID = @ID)
	BEGIN
		DELETE FROM PLAYLIST_SONGS WHERE Playlist_ID = @ID
	END
END

insert into Songs 
values(1, 'BuonCuaAnh', 'DatG', 288, '"D:\Music\BuonCuaAnh-KICMDatGMasew-5322411.flac"', '')

select * from SINGER

SELECT S.ID, S.name, S.artist_name, FORMAT(DATEADD(SECOND, S.duration, 0), 'mm:ss') AS duration 
FROM SONGS S 
INNER JOIN PLAYLIST_SONGS PLS ON S.ID = PLS.Songs_ID 
INNER JOIN PLAYLISTS PL ON PL.ID = PLS.Playlist_ID 
INNER JOIN USERS U ON U.ID = PL.owner_id
WHERE PL.name = 'Qhuy' AND U.username = 'Qhuy204'

UPDATE PLAYLISTS SET name = 'Hahe' where name = 'hehe'

SELECT ID, name, artist_name, duration FROM SONGS

SELECT ID, name, artist_name, FORMAT(DATEADD(SECOND, duration, 0), 'mm:ss') AS duration FROM SONGS

SELECT * from SONGS



CREATE FUNCTION TimKiemBaiHat
(
  @TENBAIHAT NVARCHAR(100) = NULL,
  @TENNGHESI NVARCHAR(100) = NULL
)
RETURNS TABLE
AS
RETURN
(
  SELECT ID, name, artist_name, FORMAT(DATEADD(SECOND, duration, 0), 'mm:ss') AS duration
  FROM
    SONGS
  WHERE
    (@TENBAIHAT IS NULL OR name LIKE '%' + @TENBAIHAT + '%')
    AND (@TENNGHESI IS NULL OR artist_name LIKE '%' + @TENNGHESI + '%')
)

Select * from TimKiemBaiHat(N'Ánh', N'Phúc')

Insert into PLAYLIST_SONGS VALUES((SELECT ISNULL(MAX(PlaylistSong_ID), 0) + 1 FROM PLAYLIST_SONGS), (SELECT ID FROM PLAYLISTS WHERE name = N'Qhuy'),Convert.ToInt32(dgvplay.SelectedRows[0].Cells["ID"].Value))

Select * from SINGER

Delete from SINGER

SELECT LST.name FROM PLAYLISTS LST INNER JOIN USERS U ON LST.owner_id = U.ID WHERE U.username = 'admin'

UPDATE USERS SET name = N'Trương Quốc Huy', gender = 'Male', birthday = '2004/03/02' where username = 'Qhuy204'

UPDATE USERS SET profile_picture = N'"D:\Visual Studio\Windows Form\Project\Music Player Application\MusicPlayer\Image_n_icon\user.png"'
WHERE username = 'admin'

SELECT COUNT(*) AS Count1 FROM USERS WHERE email = 'truongquochuy234@gmail.com'

DELETE PLST FROM PLAYLISTS PLST INNER JOIN USERS U ON PLST.owner_id = U.ID
WHERE PLST.name = 'Hehe' AND U.username = 'Qhuy204'

SELECT TOP 1 PLST.ID FROM PLAYLISTS PLST INNER JOIN USERS U ON U.ID = PLST.owner_id WHERE PLST.name = N'{cbbPlaylist.Text.Trim()}' AND U.username = '{user.Trim()}'

--DELETE PLS FROM PLAYLIST_SONGS PLS INNER JOIN PLAYLISTS PL ON PL.ID = PLS.Playlist_ID WHERE PL.name = N'{cbbPlaylist.Text.Trim()}' AND PLS.Songs_ID = {selectedId}"


DELETE PLS FROM PLAYLIST_SONGS PLS 
INNER JOIN PLAYLISTS PL ON PL.ID = PLS.Playlist_ID 
INNER JOIN USERS U ON U.ID = PL.owner_id
WHERE PL.name = N'{cbbPlaylist.Text.Trim()}' AND PLS.Songs_ID = {selectedId} AND U.username = '{user}'