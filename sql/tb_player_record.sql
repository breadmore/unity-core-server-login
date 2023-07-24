CREATE TABLE player_record (
player_id int(11) NOT NULL,
player_score varchar(45) NOT NULL DEFAULT '0',
PRIMARY KEY (player_id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;