drop table if exists products cascade;
create table products(
	id serial not null,
	name varchar(50) not null,
	type varchar(40) not null,
	unit varchar(40) not null,
	code varchar(40),
	sales_price numeric(9,2) not null,
	purchase_price numeric(9,2),
	min_qty numeric(6,2),
	max_qty numeric(6,2),
	primary key (id)
);

drop table if exists locations cascade;
create table locations(
	id serial not null,
	name varchar(50) not null,
	type varchar(40) not null,
	primary key (id)
);

drop table if exists moves cascade;
create table moves(
	id serial not null,
	contact varchar(60) not null,
	contact_address varchar(90) not null,
	type varchar(40),
	source_location_id int not null,
	destination_location_id int not null,
	schedule_date date not null default current_date,
	primary key(id),
	constraint fk_source_location_id foreign key (source_location_id) references locations(id),
	constraint fk_destination_location_id foreign key (destination_location_id) references locations(id)
);

drop table if exists move_lines;
create table move_lines(
	id serial not null,
	move_id int not null,
	product_id int not null,
	qty numeric(6,2) not null default 1.00,
	type varchar(40) not null,
	source_location_id int not null,
	destination_location_id int not null,
	primary key(id),
	constraint fk_move_id foreign key (move_id) references moves(id),
	constraint fk_product_id foreign key (product_id) references products(id),
	constraint fk_source_location_id foreign key (source_location_id) references locations(id),
	constraint fk_destination_location_id foreign key (destination_location_id) references locations(id)
);

insert into products(name, type, unit, code, sales_price, purchase_price, min_qty, max_qty) 
values ('Pan', 'Almacenable', 'units', 'PRDCT 001', 10.00, 5.00, 25.00, 100.00);
insert into products(name, type, unit, code, sales_price, purchase_price, min_qty, max_qty) 
values ('Leche', 'Almacenable', 'cans', 'PRDCT 002', 75.00, 30.00, 25.00, 10.00);
insert into products(name, type, unit, code, sales_price, purchase_price, min_qty, max_qty) 
values ('Arroz', 'Almacenable', 'pounds','PRDCT 003', 35.00, 20.00, 50.00, 25.00);
insert into products(name, type, unit, code, sales_price, purchase_price, min_qty, max_qty) 
values ('Huevo', 'Almacenable', 'units','PRDCT 004', 7.00, 3.00, 50.00, 25.00);
insert into products(name, type, unit, code, sales_price, purchase_price, min_qty, max_qty) 
values ('Queso', 'Almacenable', 'pounds', 'PRDCT 005', 130.00, 90.00, 40.00, 20.00);

insert into locations(name, type)
values('Stock Location', 'Internal');
insert into locations(name, type)
values('Scrap Location', 'Waste');
insert into locations(name, type)
values('Customer Location', 'Customer');
insert into locations(name, type)
values('Supplier Location', 'Supplier');

insert into moves(contact, contact_address, type, source_location_id, destination_location_id) 
values('Carlos Ramirez', 'Santo Domingo', 'receipt', 4, 2);
insert into moves(contact, contact_address, type, source_location_id, destination_location_id) 
values('Carlos Ramirez', 'Santo Domingo', 'internal', 2, 1);
insert into moves(contact, contact_address, type, source_location_id, destination_location_id) 
values('Carlos Ramirez', 'Santo Domingo', 'customer', 1, 3);

insert into move_lines(move_id, product_id, qty, type, source_location_id, destination_location_id)
values(1, 1, 2.00, 'receipt', 4, 2);
insert into move_lines(move_id, product_id, qty, type, source_location_id, destination_location_id)
values(2, 2, 5.00, 'internal', 2, 1);
insert into move_lines(move_id, product_id, qty, type, source_location_id, destination_location_id)
values(3, 3, 3.00, 'customer', 1, 2);

select * from products;
select * from locations;
select * from moves;
select * from move_lines;

