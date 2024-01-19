--Create tables:

CREATE TABLE Author (
    ID         INTEGER NOT NULL
                       UNIQUE
                       PRIMARY KEY AUTOINCREMENT,
    GivenName  TEXT    NOT NULL,
    FamilyName TEXT    NOT NULL
);

CREATE TABLE Publisher (
    ID         INTEGER NOT NULL
                       UNIQUE
                       PRIMARY KEY AUTOINCREMENT,
    Title      TEXT    NOT NULL
);

CREATE TABLE Book (
    ID          INTEGER NOT NULL
                        UNIQUE
                        PRIMARY KEY AUTOINCREMENT,
    Title       TEXT    NOT NULL,
    PublisherID         REFERENCES Publisher (ID) 
                        NOT NULL,
    AuthorID            REFERENCES Author (ID) 
                        NOT NULL
);

--Fill tables by data

INSERT INTO Author (GivenName, FamilyName)
VALUES
('Alex', 'Martin'),
('Mike', 'Baker'),
('John', 'Abe');

INSERT INTO Publisher (Title)
VALUES
('Rock'),
('Alex'),
('River');

INSERT INTO Book (Title, PublisherID, AuthorID)
VALUES
('Nature', 1, 1),
('Animals', 1, 2),
('Nature', 2, 2);