CREATE TABLE player_tb (
player_id int(11) NOT NULL AUTO_INCREMENT,
player_address varchar(50) NOT NULL,
PRIMARY KEY (player_id),
UNIQUE KEY player_address_UNIQUE (player_address)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;