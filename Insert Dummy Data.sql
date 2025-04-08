USE ArksoftPracticalDb;
GO

-- Remove all existing records and reset identity
TRUNCATE TABLE dbo.Customers;
GO

-- Insert 26 refined dummy records with real‐sounding names
INSERT INTO dbo.Customers (Name, Address, Telephone, ContactName, ContactEmail, VatNumber) VALUES
('Andrew Smith',    '123 Oak St',     '0761234567', 'Alice Brown',   'alice.brown@example.com',   '1234567890'),
('Bethany Jones',   '456 Pine Ave',   NULL,         'Bob White',     NULL,                        '0987654321'),
('Charles Miller',  '789 Maple Rd',   '0822345678', NULL,            'charles.miller@example.com',NULL),
('Diana Wilson',    '101 Elm Blvd',   '0723456789', 'Diana King',    'diana.king@example.com',    '5647382910'),
('Ethan Davis',     '202 Birch Ln',   NULL,         NULL,            NULL,                        '1029384756'),
('Fiona Clark',     '303 Cedar Ct',   '0769876543', 'Eve Adams',     NULL,                        NULL),
('George Lewis',    '404 Spruce Dr',  '0828765432', NULL,            'george.lewis@example.com',  '0192837465'),
('Hannah Robinson', '505 Walnut Way', NULL,         'Grace Hall',    'grace.hall@example.com',    '5647382910'),
('Ian Walker',      '606 Chestnut Pl','0727654321', 'Heidi Young',   NULL,                        '8473625140'),
('Jasmine Young',   '707 Poplar St',  NULL,         NULL,            'ivan.ross@example.com',     NULL),
('Kevin Harris',    '808 Ash Ct',     '0761928374', 'Judy Scott',    'judy.scott@example.com',    '9182736450'),
('Laura Martin',    '909 Fir Ave',    NULL,         'Karl Green',    NULL,                        '5647382910'),
('Michael Lee',     '111 Willow Rd',  '0820192837', NULL,            'leo.baker@example.com',     '1029384756'),
('Natalie Perez',   '222 Palm Blvd',  '0725647382', 'Mallory Reed',  NULL,                        NULL),
('Oliver Turner',   '333 Cypress Ln', NULL,         NULL,            NULL,                        '2938475610'),
('Paula Carter',    '444 Magnolia Dr','0765647382', 'Niaj Brooks',   'niaj.brooks@example.com',   '0192837465'),
('Quentin Rivera',  '555 Dogwood Pl', NULL,         'Olivia Diaz',   NULL,                        NULL),
('Rebecca Cooper',  '666 Redwood Way', '0820192837', NULL,           'peggy.morris@example.com',  '8473625140'),
('Samuel Bailey',   '777 Beech Ct',   '0729182736', 'Quinn Bell',    NULL,                        '9182736450'),
('Tina Murphy',     '888 Holly Rd',   NULL,         NULL,            'rick.wright@example.com',   NULL),
('Ulysses Ward',    '999 Ivy Ave',    '0761029384', 'Sybil Fox',     'sybil.fox@example.com',     '2938475610'),
('Victoria Cox',    '135 Juniper Ln', NULL,         'Trent Brooks',  NULL,                        '1029384756'),
('William Gray',    '246 Laurel Dr',  '0825647382', NULL,            'ursula.russell@example.com',NULL),
('Xavier Bell',     '357 Sequoia St', NULL,         'Victor Price',  'victor.price@example.com',  '0192837465'),
('Yvonne Brooks',   '468 Redwood Pl', '0720192837', NULL,            NULL,                        '8473625140'),
('Zachary Hughes',  '579 Alder Ct',   '0768473625', 'Zara Knight',   'zara.knight@example.com',   '9182736450');
GO
