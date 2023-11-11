USE universidad;

INSERT INTO departamentos VALUES (1, 'Informática');
INSERT INTO departamentos VALUES (2, 'Matemáticas');
INSERT INTO departamentos VALUES (3, 'Economía y Empresa');
INSERT INTO departamentos VALUES (4, 'Educación');
INSERT INTO departamentos VALUES (5, 'Agronomía');
INSERT INTO departamentos VALUES (6, 'Química y Física');
INSERT INTO departamentos VALUES (7, 'Filología');
INSERT INTO departamentos VALUES (8, 'Derecho');
INSERT INTO departamentos VALUES (9, 'Biología y Geología');


INSERT INTO tipos_personas VALUES (1, 'Alumno');
INSERT INTO tipos_personas VALUES (2, 'Profesor');

INSERT INTO generos VALUES (1, 'Hombre');
INSERT INTO generos VALUES (2, 'Mujer');

INSERT INTO personas VALUES (1, '26902806M', 'Salvador', 'Sánchez', 'Pérez', 'Almería', 'Real del barrio alto', '950254837', '1991-03-28', 1, 1);
INSERT INTO personas VALUES (2, '89542419S', 'Juan', 'Saez', 'Vega', 'Almería', 'Mercurio', '618253876', '1992-08-08', 1, 1);
INSERT INTO personas VALUES (3, '11105554G', 'Zoe', 'Ramirez', 'Gea', 'Almería', 'Marte', '618223876', '1979-08-19', 2, 2);
INSERT INTO personas VALUES (4, '17105885A', 'Pedro', 'Heller', 'Pagac', 'Almería', 'Estrella fugaz', NULL, '2000-10-05', 1, 1);
INSERT INTO personas VALUES (5, '38223286T', 'David', 'Schmidt', 'Fisher', 'Almería', 'Venus', '678516294', '1978-01-19', 1, 2);
INSERT INTO personas VALUES (6, '04233869Y', 'José', 'Koss', 'Bayer', 'Almería', 'Júpiter', '628349590', '1998-01-28', 1, 1);
INSERT INTO personas VALUES (7, '97258166K', 'Ismael', 'Strosin', 'Turcotte', 'Almería', 'Neptuno', NULL, '1999-05-24', 1, 1);
INSERT INTO personas VALUES (8, '79503962T', 'Cristina', 'Lemke', 'Rutherford', 'Almería', 'Saturno', '669162534', '1977-08-21', 2, 2);
INSERT INTO personas VALUES (9, '82842571K', 'Ramón', 'Herzog', 'Tremblay', 'Almería', 'Urano', '626351429', '1996-11-21', 1, 1);
INSERT INTO personas VALUES (10, '61142000L', 'Esther', 'Spencer', 'Lakin', 'Almería', 'Plutón', NULL, '1977-05-19', 2, 2);
INSERT INTO personas VALUES (11, '46900725E', 'Daniel', 'Herman', 'Pacocha', 'Almería', 'Andarax', '679837625', '1997-04-26', 1, 1);
INSERT INTO personas VALUES (12, '85366986W', 'Carmen', 'Streich', 'Hirthe', 'Almería', 'Almanzora', NULL, '1971-04-29', 2, 2);
INSERT INTO personas VALUES (13, '73571384L', 'Alfredo', 'Stiedemann', 'Morissette', 'Almería', 'Guadalquivir', '950896725', '1980-02-01', 1, 2);
INSERT INTO personas VALUES (14, '82937751G', 'Manolo', 'Hamill', 'Kozey', 'Almería', 'Duero', '950263514', '1977-01-02', 1, 2);
INSERT INTO personas VALUES (15, '80502866Z', 'Alejandro', 'Kohler', 'Schoen', 'Almería', 'Tajo', '668726354', '1980-03-14', 1, 2);
INSERT INTO personas VALUES (16, '10485008K', 'Antonio', 'Fahey', 'Considine', 'Almería', 'Sierra de los Filabres', NULL, '1982-03-18', 1, 2);
INSERT INTO personas VALUES (17, '85869555K', 'Guillermo', 'Ruecker', 'Upton', 'Almería', 'Sierra de Gádor', NULL, '1973-05-05', 1, 2);
INSERT INTO personas VALUES (18, '04326833G', 'Micaela', 'Monahan', 'Murray', 'Almería', 'Veleta', '662765413', '1976-02-25', 1, 2);
INSERT INTO personas VALUES (19, '11578526G', 'Inma', 'Lakin', 'Yundt', 'Almería', 'Picos de Europa', '678652431', '1998-09-01', 2, 1);
INSERT INTO personas VALUES (20, '79221403L', 'Francesca', 'Schowalter', 'Muller', 'Almería', 'Quinto pino', NULL, '1980-10-31', 1, 2);
INSERT INTO personas VALUES (21, '79089577Y', 'Juan', 'Gutiérrez', 'López', 'Almería', 'Los pinos', '678652431', '1998-01-01', 1, 1);
INSERT INTO personas VALUES (22, '41491230N', 'Antonio', 'Domínguez', 'Guerrero', 'Almería', 'Cabo de Gata', '626652498', '1999-02-11', 1, 1);
INSERT INTO personas VALUES (23, '64753215G', 'Irene', 'Hernández', 'Martínez', 'Almería', 'Zapillo', '628452384', '1996-03-12', 2, 1);
INSERT INTO personas VALUES (24, '85135690V', 'Sonia', 'Gea', 'Ruiz', 'Almería', 'Mercurio', '678812017', '1995-04-13', 2, 1);
 
INSERT INTO profesores VALUES (1 ,3, 1);
INSERT INTO profesores VALUES (2 ,5, 2);
INSERT INTO profesores VALUES (3 ,8, 3);
INSERT INTO profesores VALUES (4 ,10, 4);
INSERT INTO profesores VALUES (5 ,12, 4);
INSERT INTO profesores VALUES (6 ,13, 6);
INSERT INTO profesores VALUES (7 ,14, 1);
INSERT INTO profesores VALUES (8 ,15, 2);
INSERT INTO profesores VALUES (9 ,16, 3);
INSERT INTO profesores VALUES (10 ,17, 4);
INSERT INTO profesores VALUES (11 ,18, 5);
INSERT INTO profesores VALUES (12 ,20, 6);

INSERT INTO grados VALUES (1, 'Grado en Ingeniería Agrícola (Plan 2015)');
INSERT INTO grados VALUES (2, 'Grado en Ingeniería Eléctrica (Plan 2014)');
INSERT INTO grados VALUES (3, 'Grado en Ingeniería Electrónica Industrial (Plan 2010)');
INSERT INTO grados VALUES (4, 'Grado en Ingeniería Informática (Plan 2015)');
INSERT INTO grados VALUES (5, 'Grado en Ingeniería Mecánica (Plan 2010)');
INSERT INTO grados VALUES (6, 'Grado en Ingeniería Química Industrial (Plan 2010)');
INSERT INTO grados VALUES (7, 'Grado en Biotecnología (Plan 2015)');
INSERT INTO grados VALUES (8, 'Grado en Ciencias Ambientales (Plan 2009)');
INSERT INTO grados VALUES (9, 'Grado en Matemáticas (Plan 2010)');
INSERT INTO grados VALUES (10, 'Grado en Química (Plan 2009)');

INSERT INTO tipos_asignaturas VALUES (1, 'Básica');
INSERT INTO tipos_asignaturas VALUES (2, 'Obligatoria');
INSERT INTO tipos_asignaturas VALUES (3 , 'Optativa');

INSERT INTO asignaturas VALUES (1, 'Álgegra lineal y matemática discreta', 6, 1, 1, 3, 4, 1);
INSERT INTO asignaturas VALUES (2, 'Cálculo', 6, 1, 1, 12, 4, 1);
INSERT INTO asignaturas VALUES (3, 'Física para informática', 6, 1, 1, 3, 4, 1);
INSERT INTO asignaturas VALUES (4, 'Introducción a la programación', 6, 1, 1, 12, 4, 1);
INSERT INTO asignaturas VALUES (5, 'Organización y gestión de empresas', 6, 1, 1, 3, 4, 1);
INSERT INTO asignaturas VALUES (6, 'Estadística', 6, 1, 2, 12, 4, 1);
INSERT INTO asignaturas VALUES (7, 'Estructura y tecnología de computadores', 6, 1, 2, 3, 4, 1);
INSERT INTO asignaturas VALUES (8, 'Fundamentos de electrónica', 6, 1, 2, 12, 4, 1);
INSERT INTO asignaturas VALUES (9, 'Lógica y algorítmica', 6, 1, 2, 3, 4, 1);
INSERT INTO asignaturas VALUES (10, 'Metodología de la programación', 6, 1, 2, 12, 4, 1);
INSERT INTO asignaturas VALUES (11, 'Arquitectura de Computadores', 6, 2, 1, 3, 4, 1);
INSERT INTO asignaturas VALUES (12, 'Estructura de Datos y Algoritmos I', 6, 2, 1, 3, 4, 2);
INSERT INTO asignaturas VALUES (13, 'Ingeniería del Software', 6, 2, 1, 12, 4, 2);
INSERT INTO asignaturas VALUES (14, 'Sistemas Inteligentes', 6, 2, 1, 3, 4, 2);
INSERT INTO asignaturas VALUES (15, 'Sistemas Operativos', 6, 2, 1, 12, 4, 2);
INSERT INTO asignaturas VALUES (16, 'Bases de Datos', 6, 2, 2, 12, 4, 1);
INSERT INTO asignaturas VALUES (17, 'Estructura de Datos y Algoritmos II', 6, 2, 2, 12, 4, 2);
INSERT INTO asignaturas VALUES (18, 'Fundamentos de Redes de Computadores', 6, 2, 2, 3, 4, 2);
INSERT INTO asignaturas VALUES (19, 'Planificación y Gestión de Proyectos Informáticos', 6, 2, 2, 3, 4, 2);
INSERT INTO asignaturas VALUES (20, 'Programación de Servicios Software', 6, 2, 2, 12, 4, 2);
INSERT INTO asignaturas VALUES (21, 'Desarrollo de interfaces de usuario', 6, 3, 1, 12, 4, 2);
INSERT INTO asignaturas VALUES (22, 'Ingeniería de Requisitos', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (23, 'Integración de las Tecnologías de la Información en las Organizaciones', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (24, 'Modelado y Diseño del Software 1', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (25, 'Multiprocesadores', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (26, 'Seguridad y cumplimiento normativo', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (27, 'Sistema de Información para las Organizaciones', 6, 3, 1, NULL, 4, 3); 
INSERT INTO asignaturas VALUES (28, 'Tecnologías web', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (29, 'Teoría de códigos y criptografía', 6, 3, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (30, 'Administración de bases de datos', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (31, 'Herramientas y Métodos de Ingeniería del Software', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (32, 'Informática industrial y robótica', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (33, 'Ingeniería de Sistemas de Información', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (34, 'Modelado y Diseño del Software 2', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (35, 'Negocio Electrónico', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (36, 'Periféricos e interfaces', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (37, 'Sistemas de tiempo real', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (38, 'Tecnologías de acceso a red', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (39, 'Tratamiento digital de imágenes', 6, 3, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (40, 'Administración de redes y sistemas operativos', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (41, 'Almacenes de Datos', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (42, 'Fiabilidad y Gestión de Riesgos', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (43, 'Líneas de Productos Software', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (44, 'Procesos de Ingeniería del Software 1', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (45, 'Tecnologías multimedia', 6, 4, 1, NULL, 4, 3);
INSERT INTO asignaturas VALUES (46, 'Análisis y planificación de las TI', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (47, 'Desarrollo Rápido de Aplicaciones', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (48, 'Gestión de la Calidad y de la Innovación Tecnológica', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (49, 'Inteligencia del Negocio', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (50, 'Procesos de Ingeniería del Software 2', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (51, 'Seguridad Informática', 6, 4, 2, NULL, 4, 3);
INSERT INTO asignaturas VALUES (52, 'Biologia celular', 6, 1, 1, NULL, 7, 1);
INSERT INTO asignaturas VALUES (53, 'Física', 6, 1, 1, NULL, 7, 1);
INSERT INTO asignaturas VALUES (54, 'Matemáticas I', 6, 1, 1, NULL, 7, 1);
INSERT INTO asignaturas VALUES (55, 'Química general', 6, 1, 1, NULL, 7, 1);
INSERT INTO asignaturas VALUES (56, 'Química orgánica', 6, 1, 1, NULL, 7, 1);
INSERT INTO asignaturas VALUES (57, 'Biología vegetal y animal', 6, 1, 2, NULL, 7, 1);
INSERT INTO asignaturas VALUES (58, 'Bioquímica', 6, 1, 2, NULL, 7, 1);
INSERT INTO asignaturas VALUES (59, 'Genética', 6, 1, 2, NULL, 7, 1);
INSERT INTO asignaturas VALUES (60, 'Matemáticas II', 6, 1, 2, NULL, 7, 1);
INSERT INTO asignaturas VALUES (61, 'Microbiología', 6, 1, 2, NULL, 7, 1);
INSERT INTO asignaturas VALUES (62, 'Botánica agrícola', 6, 2, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (63, 'Fisiología vegetal', 6, 2, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (64, 'Genética molecular', 6, 2, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (65, 'Ingeniería bioquímica', 6, 2, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (66, 'Termodinámica y cinética química aplicada', 6, 2, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (67, 'Biorreactores', 6, 2, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (68, 'Biotecnología microbiana', 6, 2, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (69, 'Ingeniería genética', 6, 2, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (70, 'Inmunología', 6, 2, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (71, 'Virología', 6, 2, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (72, 'Bases moleculares del desarrollo vegetal', 4.5, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (73, 'Fisiología animal', 4.5, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (74, 'Metabolismo y biosíntesis de biomoléculas', 6, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (75, 'Operaciones de separación', 6, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (76, 'Patología molecular de plantas', 4.5, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (77, 'Técnicas instrumentales básicas', 4.5, 3, 1, NULL, 7, 2);
INSERT INTO asignaturas VALUES (78, 'Bioinformática', 4.5, 3, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (79, 'Biotecnología de los productos hortofrutículas', 4.5, 3, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (80, 'Biotecnología vegetal', 6, 3, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (81, 'Genómica y proteómica', 4.5, 3, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (82, 'Procesos biotecnológicos', 6, 3, 2, NULL, 7, 2);
INSERT INTO asignaturas VALUES (83, 'Técnicas instrumentales avanzadas', 4.5, 3, 2, NULL, 7, 2);

INSERT INTO cursos_escolares VALUES (1, '2014-01-01', '2015-01-01');
INSERT INTO cursos_escolares VALUES (2, '2015-01-01', '2016-01-01');
INSERT INTO cursos_escolares VALUES (3, '2016-01-01', '2017-01-01');
INSERT INTO cursos_escolares VALUES (4, '2017-01-01', '2018-01-01');
INSERT INTO cursos_escolares VALUES (5, '2018-01-01', '2019-01-01');

INSERT INTO alumno_se_matricula_asignaturas VALUES (1, 1, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (1, 2, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (1, 3, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (2, 1, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (2, 2, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (2, 3, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (4, 1, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (4, 2, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (4, 3, 1);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 1, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 2, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 3, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 4, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 5, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 6, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 7, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 8, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 9, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (24, 10, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 1, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 2, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 3, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 4, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 5, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 6, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 7, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 8, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 9, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (23, 10, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 1, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 2, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 3, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 4, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 5, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 6, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 7, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 8, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 9, 5);
INSERT INTO alumno_se_matricula_asignaturas VALUES (19, 10, 5);