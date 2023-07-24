CREATE TABLE player_data (
player_id int(11) NOT NULL,
player_gold int(11) NOT NULL DEFAULT '0',
player_potion int(11) DEFAULT '0',
PRIMARY KEY (player_id),
CONSTRAINT f_pid FOREIGN KEY (player_id) REFERENCES player_tb (player_id) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
SELECT * FROM sweetp_db.player_record;