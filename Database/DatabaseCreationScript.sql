CREATE TABLE users (
	id bigint primary key identity,
	username varchar(255) unique,
	email varchar(255),
	password varchar(255)
);

CREATE TABLE exercise (
	id bigint primary key identity,
	name varchar(255),
	image varchar(255)
);

CREATE TABLE workout (
	id bigint primary key identity,
	name varchar(255),
	workout_date date,
	duration varchar(255),
	id_user bigint
	FOREIGN KEY (id_user) REFERENCES users(id)
);

CREATE TABLE muscle (
	id bigint primary key identity,
	name varchar(255),
	image varchar(255)
);

CREATE TABLE target (
	id bigint primary key identity,
	id_muscle bigint,
	id_exercise bigint,
	FOREIGN KEY (id_muscle) REFERENCES muscle(id),
	FOREIGN KEY (id_exercise) REFERENCES exercise(id)
);

CREATE TABLE session (
	id bigint primary key identity,
	reps int,
	type varchar(255),
	id_workout bigint,
	id_exercise bigint,
	FOREIGN KEY (id_workout) REFERENCES workout(id),
	FOREIGN KEY (id_exercise) REFERENCES exercise(id)
);