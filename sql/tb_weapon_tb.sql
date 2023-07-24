CREATE TABLE weapon_tb (
weapon_id int(11) NOT NULL AUTO_INCREMENT,
weapon_owner int(11) NOT NULL,
PRIMARY KEY (weapon_id),
UNIQUE KEY weapon_id_UNIQUE (weapon_id),
KEY f_id_idx (weapon_owner),
CONSTRAINT f_id FOREIGN KEY (weapon_owner) REFERENCES player_tb (player_id) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;