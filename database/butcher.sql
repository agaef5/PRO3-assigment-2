CREATE SCHEMA butcher;
SET SCHEMA 'butcher';

CREATE TABLE animal(
    animalID SERIAL PRIMARY KEY,
    arrival_datetime TIMESTAMP NOT NULL,
    animal_weight INT,
    species VARCHAR
);

CREATE TABLE animal_part(
    animalID INT REFERENCES animal(animalID),
    partID SERIAL PRIMARY KEY,
    part_weight INT,
    part_type VARCHAR
);

CREATE TABLE tray(
    trayID SERIAL PRIMARY KEY,
    part_type INT REFERENCES animal_part(partID),
    max_capacity INT,
    current_weight INT CHECK (current_weight <= tray.max_capacity)
);

CREATE TABLE product(
    productID SERIAL PRIMARY KEY,
    product_type VARCHAR,
    product_weight INT,
    trayID INT REFERENCES tray(trayID)
);

CREATE TABLE recall(
    animalID INT REFERENCES animal(animalID),
    productID INT REFERENCES product(productID)
);

