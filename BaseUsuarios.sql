create database baseusuarios;
use baseusuarios;


create table usuario(
CodUsu int auto_increment,
nombre varchar (20),
pass varchar (15),
constraint pk_usuario primary key (CodUsu)
);

CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(20),
    mail VARCHAR(50),
    telefono VARCHAR(20),
    apto_fisico BOOLEAN
);

CREATE TABLE Socio (
    id_socio INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    carnet_entregado BOOLEAN,
    cuota_mensual DECIMAL(10, 2),
    estado_pago BOOLEAN,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE
);

CREATE TABLE NoSocio (
    id_nosocio INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    pago_diario DECIMAL(10, 2),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE
);

CREATE TABLE Actividad (
    idActividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    dia VARCHAR(10),
    horario VARCHAR(10),
    monto DECIMAL(10, 2),
    cupo INT,
    cupoActual INT NOT NULL DEFAULT 0
);

CREATE TABLE Inscripciones (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    idActividad INT,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE,
    FOREIGN KEY (idActividad) REFERENCES Actividad(idActividad) ON DELETE CASCADE
);

CREATE TABLE Cuota (
    id_cuota INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    monto DECIMAL(10, 2),
    fecha_pago DATE DEFAULT (CURRENT_DATE),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE
);

insert into usuario(nombre,pass) values
('administracion','1234');


-- Stored Procedure para ingresar al Sistema 

DELIMITER //

CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
  SELECT nombre, pass
  FROM usuario u 
  WHERE u.nombre = Usu AND u.pass = Pass;
END //

DELIMITER ;

-- Stored Procedure para AgregarSocio
DELIMITER //

CREATE PROCEDURE AgregarSocio(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_dni VARCHAR(20),
    IN p_mail VARCHAR(50),
    IN p_telefono VARCHAR(20),
    IN p_apto_fisico BOOLEAN,
    IN p_cuota_mensual DECIMAL(10,2),
    IN p_carnet_entregado BOOLEAN,
    IN p_estado_pago BOOLEAN
)
BEGIN
    -- Declarar la variable para almacenar el ID del cliente
    DECLARE id_cliente INT;
    
    -- Insertar en la tabla Cliente
    INSERT INTO Cliente (nombre, apellido, dni, mail, telefono, apto_fisico) 
    VALUES (p_nombre, p_apellido, p_dni, p_mail, p_telefono, p_apto_fisico);
    
    -- Obtener el ID del último cliente insertado
    SET id_cliente = LAST_INSERT_ID();
    
    -- Insertar en la tabla Socio con el ID del cliente
    INSERT INTO Socio (id_cliente, carnet_entregado, cuota_mensual, estado_pago) 
    VALUES (id_cliente, p_carnet_entregado, p_cuota_mensual, p_estado_pago);
    
    -- Insertar un registro en la tabla Cuota si el estado de pago es TRUE
    IF p_estado_pago = TRUE THEN
        INSERT INTO Cuota (id_cliente, monto)
        VALUES (id_cliente, p_cuota_mensual);
    END IF;
END //

DELIMITER ;

-- Llamadas al Stored para insertar Socios

CALL AgregarSocio('Ger', 'Rod', '38102369', 'ger_rod@gmail.com', 1124563987, True, 25000, True, True);
CALL AgregarSocio('Juan', 'Dua', '37145236', 'juan_dua@gmail.com', 1107892385, True, 20000, False, True);
CALL AgregarSocio('Manu', 'Gas', '40102578', 'manu_gas@gmail.com', 1141526893, True, 22000, True, False);
CALL AgregarSocio('Nico', 'Wei', '41412563', 'nico_wei@gmail.com', 1181369424, True, 25000, True, True);
CALL AgregarSocio('Ro', 'Gom', '42512036', 'ro_gom@gmail.com', 1167982031, True, 22000, False, False);
CALL AgregarSocio('Jaz', 'Cal', '43625190', 'jaz_cal@gmail.com', 1174589623, True, 22000, False, True);

-- Stored Procedure para ModificarSocio
DELIMITER //

CREATE PROCEDURE ModificarSocio(
    IN p_id_cliente INT,
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_dni VARCHAR(20),
    IN p_mail VARCHAR(50),
    IN p_telefono VARCHAR(20),
    IN p_apto_fisico BOOLEAN,
    IN p_cuota_mensual DECIMAL(10,2),
    IN p_carnet_entregado BOOLEAN,
    IN p_estado_pago BOOLEAN
)
BEGIN
    -- Declarar variables al inicio
    DECLARE last_cuota_fecha DATE;

    -- Actualizar los datos del cliente en la tabla Cliente
    UPDATE Cliente
    SET 
        nombre = p_nombre,
        apellido = p_apellido,
        dni = p_dni,
        mail = p_mail,
        telefono = p_telefono,
        apto_fisico = p_apto_fisico
    WHERE 
        id_cliente = p_id_cliente;
    
    -- Actualizar los datos del socio en la tabla Socio
    UPDATE Socio
    SET 
        carnet_entregado = p_carnet_entregado,
        cuota_mensual = p_cuota_mensual,
        estado_pago = p_estado_pago
    WHERE 
        id_cliente = p_id_cliente;
    
    -- Si el estado de pago es TRUE, insertar una nueva cuota si es necesario
    IF p_estado_pago = TRUE THEN
        -- Buscar la fecha de la última cuota del cliente
        SELECT fecha_pago
        INTO last_cuota_fecha
        FROM Cuota
        WHERE id_cliente = p_id_cliente
        ORDER BY fecha_pago DESC
        LIMIT 1;

        -- Insertar una nueva cuota si no hay cuota registrada o la última fue hace más de un mes
        IF last_cuota_fecha IS NULL OR last_cuota_fecha < DATE_SUB(CURRENT_DATE, INTERVAL 1 MONTH) THEN
            INSERT INTO Cuota (id_cliente, monto, fecha_pago)
            VALUES (p_id_cliente, p_cuota_mensual, CURRENT_DATE);
        END IF;
    END IF;
END //

DELIMITER ;


-- Stored Procedure para Agregar actividades
DELIMITER //

CREATE PROCEDURE sp_AgregarActividad(
	IN nombreActividad VARCHAR(50),
    IN diaActividad VARCHAR(50),
    IN horarioActividad TIME,
    IN montoActividad DECIMAL(10, 2),
    IN cupoActividad INT
)
BEGIN
    INSERT INTO Actividad (nombre, dia, horario, monto, cupo)
    VALUES (nombreActividad, diaActividad, horarioActividad, montoActividad, cupoActividad);
END //

DELIMITER ;

-- Llamadas al Stored para insertar actividades

CALL sp_AgregarActividad('Fútbol', 'Lunes', '10:00', 4000.00, 20);
CALL sp_AgregarActividad('Yoga', 'Miércoles', '18:00', 3000.00, 15);
CALL sp_AgregarActividad('Spinning', 'Martes', '19:00', 3000.00, 12);
CALL sp_AgregarActividad('Funcional', 'Viernes', '08:00', 4000.00, 20);
CALL sp_AgregarActividad('Boxeo', 'Jueves', '20:00', 6000.00, 10);
CALL sp_AgregarActividad('Voley', 'Sábado', '09:00', 4000.00, 12);


-- Stored Procedure para ACTUALIZAR MONTOS de las actividades

DELIMITER //

CREATE PROCEDURE sp_ActualizarMonto(
    IN p_idActividad INT,
    IN p_nuevoMonto DECIMAL(10,2)
)
BEGIN
    UPDATE Actividad
    SET monto = p_nuevoMonto
    WHERE idActividad = p_idActividad;
END //

DELIMITER ;


-- Stored Procedure para Eliminar actividades

DELIMITER //

CREATE PROCEDURE sp_EliminarActividad(
    IN id INT
)
BEGIN
    DELETE FROM Actividad WHERE idActividad = id;
END //

DELIMITER ;

-- Stored procedure para incrementar el cupo actual de las actividades 

DELIMITER //

CREATE PROCEDURE incrementarCupoActual(IN idAct int)
BEGIN
	UPDATE actividad
    SET cupoActual= cupoActual + 1
    Where idActividad=idAct;
END  //

DELIMITER;

-- Stored procedure para decrementarlo. 

DELIMITER //

CREATE PROCEDURE decrementarCupoActual(IN idAct int)
BEGIN
	UPDATE actividad
    SET cupoActual= cupoActual - 1
    Where idActividad=idAct;
END  //

DELIMITER;


-- Stored Procedure para Agregar No socios

DELIMITER //

CREATE PROCEDURE AgregarNoSocio(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_dni VARCHAR(20),
    IN p_mail VARCHAR(50),
    IN p_telefono VARCHAR(20),
    IN p_apto_fisico BOOLEAN,
    IN p_pago_diario DECIMAL(10, 2)
)
BEGIN
    -- Declarar la variable para almacenar el ID del cliente
    DECLARE id_cliente INT;

    -- Insertar en la tabla Cliente
    INSERT INTO Cliente (nombre, apellido, dni, mail, telefono, apto_fisico) 
    VALUES (p_nombre, p_apellido, p_dni, p_mail, p_telefono, p_apto_fisico);
    
    -- Obtener el ID del último cliente insertado
    SET id_cliente = LAST_INSERT_ID();
    
    -- Insertar en la tabla NoSocio
    INSERT INTO NoSocio (id_cliente, pago_diario) 
    VALUES (id_cliente, p_pago_diario);
END //

DELIMITER ;

-- Llamadas al Stored para insertar Socios

CALL AgregarNoSocio('Can', 'Gon', '27415236', 'can_gon@gmail.com', 1145872103, True, 5000);
CALL AgregarNoSocio('Tom', 'Cro', '43010203', 'tom_cro@gmail.com', 1147123659, True, 2000);
CALL AgregarNoSocio('Mil', 'Vel', '20987321', 'mil_vel@gmail.com', 1115698547, True, 3100);
CALL AgregarNoSocio('Mat', 'Tol', '28659124', 'mat_tol@gmail.com', 1184759623, True, 2500);
CALL AgregarNoSocio('Seb', 'Pol', '29415698', 'seb_pol@gmail.com', 1145201369, True, 4300);

-- Stored Procedure para Inscribir clientes en actividad 

DELIMITER //

CREATE PROCEDURE InscribirActividad(
    IN p_id_cliente INT,
    IN p_id_actividad INT
)
BEGIN
    -- Verificar que el cliente no esté inscrito ya en la actividad
    IF NOT EXISTS (SELECT 1 FROM Inscripciones WHERE id_cliente = p_id_cliente AND idActividad = p_id_actividad) THEN
		-- Verificar si hay cupo disponible
		IF EXISTS (SELECT 1 FROM Actividad WHERE idActividad = p_id_actividad AND cupoActual < cupo) THEN
			-- Insertar la inscripción en la tabla Inscripciones (relacionando Cliente con Actividad)
			INSERT INTO Inscripciones (id_cliente, idActividad) 
			VALUES (p_id_cliente, p_id_actividad);
			
			-- Actualizar el cupo de la actividad
			CALL incrementarCupoActual(p_id_actividad);
			
			SELECT 'El cliente ha sido inscrito exitosamente en la actividad.' AS mensaje;
        ELSE
			SELECT 'No hay más cupo disponible para esta actividad.' AS mensaje;
		END IF;
    ELSE
        SELECT 'Este cliente ya está inscrito en la actividad.' AS mensaje;
    END IF;

END //

DELIMITER ;

-- Stored Procedure para Mostrar las actividades.

DELIMITER //

CREATE PROCEDURE VerEstadoActividad(
    IN p_id_actividad INT
)
BEGIN
    SELECT nombre, dia, horario, monto, cupo, cupoActual
    FROM Actividad
    WHERE idActividad = p_id_actividad;
END //

DELIMITER ;

-- Stored Procedure para eliminar clientes 

DELIMITER //

CREATE PROCEDURE EliminarCliente(IN p_id_cliente INT)
BEGIN
    -- Actualizar el cupoActual de las actividades relacionadas con el cliente
    UPDATE Actividad A
    INNER JOIN Inscripciones I ON A.idActividad = I.idActividad
    SET A.cupoActual = A.cupoActual - 1
    WHERE I.id_cliente = p_id_cliente;

    -- Eliminar al cliente (y sus inscripciones gracias al ON DELETE CASCADE)
    DELETE FROM Cliente WHERE id_cliente = p_id_cliente;
END//

DELIMITER ;


-- Stored procedure para registrar el pago de socios 

DELIMITER //

CREATE PROCEDURE RegistrarPago(
    IN p_id_cliente INT
)
BEGIN
    DECLARE v_estado_pago BOOLEAN;
    DECLARE v_cuota_mensual DECIMAL(10, 2);

    -- Obtener el estado de pago y la cuota mensual del socio
    SELECT estado_pago, cuota_mensual
    INTO v_estado_pago, v_cuota_mensual
    FROM Socio
    WHERE id_cliente = p_id_cliente;

    -- Verificar el estado de pago del socio
    IF v_estado_pago = TRUE THEN
        -- Si el estado de pago es TRUE, no creamos una nueva cuota
        SELECT 'El socio ya ha pagado la cuota de este mes' AS mensaje;
    ELSE
        -- Si el estado de pago es FALSE, insertamos una nueva cuota
        INSERT INTO Cuota (id_cliente, monto, fecha_pago)
        VALUES (p_id_cliente, v_cuota_mensual, CURRENT_DATE);
        
        -- Actualizar el estado de pago del socio a TRUE
        UPDATE Socio
        SET estado_pago = TRUE
        WHERE id_cliente = p_id_cliente;
        
        SELECT 'Pago registrado con éxito' AS mensaje; -- Mensaje de éxito
    END IF;

END //
DELIMITER ;

-- Stored procedure para Actualizar el estado de los pagos de los socios 

DELIMITER //

CREATE PROCEDURE ActualizarEstadoPagoSocios()
BEGIN
    -- Actualizar estado_pago a FALSE para socios cuya última cuota sea más antigua que 1 mes
    UPDATE Socio s
    SET s.estado_pago = FALSE
    WHERE s.id_cliente IN (
        -- Socios con cuota vencida hace más de 1 mes
        SELECT id_cliente
        FROM Cuota
        GROUP BY id_cliente
        HAVING MAX(fecha_pago) < DATE_SUB(CURRENT_DATE, INTERVAL 1 MONTH)
    );
END //

DELIMITER ;

-- Generar fechas de pago próximas a vencer
UPDATE `baseusuarios`.`cuota` SET `fecha_pago` = '2024-10-15' WHERE (`id_cuota` = '1');
UPDATE `baseusuarios`.`cuota` SET `fecha_pago` = '2024-10-18' WHERE (`id_cuota` = '2');
UPDATE `baseusuarios`.`cuota` SET `fecha_pago` = '2024-10-18' WHERE (`id_cuota` = '3');