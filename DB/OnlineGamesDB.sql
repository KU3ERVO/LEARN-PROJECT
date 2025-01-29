CREATE DATABASE OnlineGames;
SHOW DATABASES;
USE OnlineGames;
CREATE TABLE USERS(
user_id INT8 primary key,
user_name TEXT,
email TEXT,
nick TEXT,
login TEXT,
password TEXT,
birthdate DATE
);
CREATE TABLE GAMES(
game_id INT8 primary key,
game_code TEXT,
game_name TEXT,
game_description TEXT,
rules TEXT
);
CREATE TABLE AVATARS(
avatar_id INT8 primary key,
user_id INT8,
game_id INT8,
appeareance TEXT,
avatar_level INT4,
foreign key (user_id) REFERENCES USERS(user_id),
foreign key (game_id) REFERENCES GAMES(game_id)
);
CREATE TABLE MATCHES (
    match_id INT8 primary key,
    game_id INT8,
    match_name TEXT,
    match_password TEXT,
    created_at DATE,
    match_status TEXT,
    creator_avatar_id INT8,
    FOREIGN KEY (game_id) REFERENCES GAMES(game_id),
    FOREIGN KEY (creator_avatar_id) REFERENCES AVATARS(avatar_id)
);
CREATE TABLE MATCH_PARTICIPANTS (
    match_id INT8 primary key,
    avatar_id INT8 primary key,
    FOREIGN KEY (match_id) REFERENCES MATCHES(match_id),
    FOREIGN KEY (avatar_id) REFERENCES AVATARS(avatar_id)
);
CREATE TABLE CONFRONTATIONS (PRIMARY
    confrontation_id INT8 primary key,
    match_id INT8,
    avatar1_id INT8,
    avatar2_id INT8,
    result TEXT,
    FOREIGN KEY (match_id) REFERENCES MATCHES(match_id),
    FOREIGN KEY (avatar1_id) REFERENCES AVATARS(avatar_id),
    FOREIGN KEY (avatar2_id) REFERENCES AVATARS(avatar_id)
);