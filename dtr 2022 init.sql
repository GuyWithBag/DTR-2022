-- Create the StarBuko database
CREATE DATABASE StarBuko;

-- Use the StarBuko database
USE StarBuko;

-- Create the Users table with id as primary key
CREATE TABLE Users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    name VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL, -- Stores SHA1 hash (40 characters)
    role VARCHAR(100),
    address VARCHAR(255),
    sex CHAR(1), -- 'M' or 'F'
    birthdate DATE,
    contact_info VARCHAR(100),
    position VARCHAR(50),
    hourly_rate DECIMAL(10,2),
    photo VARCHAR(100)
);

-- Create the user_log table
CREATE TABLE user_log (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    event_time DATETIME,
    event_type ENUM('IN', 'OUT') NOT NULL, -- 'IN' for login, 'OUT' for logout
    FOREIGN KEY (user_id) REFERENCES Users(id)
);

-- Insert one sample value into the Users table
-- Use the StarBuko database
USE StarBuko;

-- Insert a new user with name 'hr' and password '123'
INSERT INTO Users (username, name, password, role, address, sex, birthdate, contact_info, position, hourly_rate, photo)
VALUES (
    '123_user',                -- Unique username
    '123',                     -- Name as specified
    SHA1('123'),                    -- Plain text password (not hashed)
    'HR',                  -- Role (assuming HR is an admin)
    '456 Oak St, City',       -- Sample address
    'F',                      -- Sex (assuming female, can change to 'M' or NULL)
    '1985-06-15',             -- Sample birthdate
    'hr@example.com',         -- Sample contact info (email)
    'HR Manager',             -- Sample position
    60.00,                    -- Sample hourly rate
    NULL                      -- No photo
);

-- Insert one sample value into the user_log table
INSERT INTO user_log (user_id, event_time, event_type)
VALUES (
    1, -- References the id of 123_user (auto-incremented to 1)
    '2025-05-06 08:00:00',
    'IN' -- Login event
);