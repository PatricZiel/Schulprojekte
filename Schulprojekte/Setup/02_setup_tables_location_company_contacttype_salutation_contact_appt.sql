create table tbl_location(
	zip varchar(255),
	name varchar (255),
	primary key (zip)
);

create table tbl_company(
	id int,
	name varchar(255),
	primary key(id)
);

create table tbl_contact_type(
	id int,
	name varchar(255),
	primary key(id)
);

create table tbl_salutation(
	id int,
	name varchar(255),
	primary key (id)
);

create table tbl_contact(
	id int,
	first_name varchar(255),
	sur_name varchar(255),
	street varchar(255),
	departement varchar(255),
	tel int,
	mobile int,
	salutation_no int,
	zip varchar(255),
	comp_no int,
	type_no int,
	primary key (id),
	FOREIGN KEY (salutation_no) REFERENCES tbl_salutation(id),
	FOREIGN KEY (zip) REFERENCES tbl_location(zip),
	FOREIGN KEY (comp_no) REFERENCES tbl_company(id),
	FOREIGN KEY (type_no) REFERENCES tbl_contact_type(id)
);

create table tbl_appointment(
	id int,
	description varchar (255),
	time datetime,
	contact_no int,
	primary key (id),
	FOREIGN KEY (contact_no) REFERENCES tbl_contact(id)
);