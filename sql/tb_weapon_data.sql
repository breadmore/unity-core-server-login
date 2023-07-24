CREATE TABLE weapon_data (
weapon_id int(11) NOT NULL,
weapon_type int(11) NOT NULL,
weapon_unique tinyint(4) NOT NULL DEFAULT '0',
weapon_atk int(11) NOT NULL,
weapon_hp int(11) NOT NULL,
weapon_element int(11) NOT NULL DEFAULT '0',
weapon_durability int(11) NOT NULL DEFAULT '100',
weapon_upgrade int(11) NOT NULL DEFAULT '0',
PRIMARY KEY (weapon_id),
CONSTRAINT f_wid FOREIGN KEY (weapon_id) REFERENCES weapon_tb (weapon_id) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;