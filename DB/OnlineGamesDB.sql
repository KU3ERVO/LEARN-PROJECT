CREATE DATABASE OnlineGames;
SHOW DATABASES;
CREATE TABLE USERS(
user_id INT8 primary key,
user_name VARCHAR (255),
email VARCHAR (255),
nick CHAR (10),
login TEXT,
password TEXT,
birthdate TEXT,
);