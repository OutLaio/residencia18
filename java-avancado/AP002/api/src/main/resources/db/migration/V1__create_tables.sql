CREATE TABLE IF NOT EXISTS User (
    id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
    username VARCHAR(255) unique NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(255) unique NOT NULL,
    role VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);