-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-11-2019 a las 20:31:00
-- Versión del servidor: 5.7.24
-- Versión de PHP: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `apuestas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `apuestas`
--

CREATE TABLE `apuestas` (
  `id_mercado` int(11) NOT NULL,
  `tipo_apuesta` float NOT NULL,
  `cuota` float NOT NULL,
  `ingreso` float NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_apuesta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `apuestas`
--

INSERT INTO `apuestas` (`id_mercado`, `tipo_apuesta`, `cuota`, `ingreso`, `id_usuario`, `id_apuesta`) VALUES
(1, 0, 1.6, 400, 1, 1),
(4, 0, 1.5, 700, 2, 2),
(1, 1, 2.2, 50, 1, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE `cuenta` (
  `cuenta` int(11) NOT NULL,
  `banco` varchar(30) NOT NULL,
  `numero_de_tarjeta` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cuenta`
--

INSERT INTO `cuenta` (`cuenta`, `banco`, `numero_de_tarjeta`, `id_usuario`) VALUES
(3400, 'Santander', 7777777, 1),
(2110, 'Bankia', 999999, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE `evento` (
  `id_evento` int(11) NOT NULL,
  `dia` int(11) NOT NULL,
  `hora` int(11) NOT NULL,
  `equipo_local` varchar(30) NOT NULL,
  `equipo_visitante` varchar(30) NOT NULL,
  `Fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `evento`
--

INSERT INTO `evento` (`id_evento`, `dia`, `hora`, `equipo_local`, `equipo_visitante`, `Fecha`) VALUES
(1, 6, 22, 'Valencia', 'España', '2019-11-13 18:26:57'),
(2, 23, 12, 'España', 'Manchester', '2019-11-13 18:26:57'),
(3, 12, 18, 'Atletic', 'Barça', '2019-11-15 18:26:57'),
(4, 9, 13, 'Italia', 'Francia', '2019-11-15 18:26:57'),
(5, 13, 8, 'Suiza', 'Reino Unido', '2019-11-15 18:26:57'),
(6, 12, 6, 'Barça ', 'Atletic', '2019-11-16 18:26:57'),
(7, 13, 14, 'Real Madrid', 'Sevilla', '2019-11-22 18:26:57'),
(8, 12, 12, 'Valencia', 'Barelona', '2019-11-15 12:51:21');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mercados`
--

CREATE TABLE `mercados` (
  `tipo_de_mercado` varchar(10) NOT NULL,
  `informacion_cuota_under` float NOT NULL,
  `informacion_cuota_over` float NOT NULL,
  `dinero_apostado_a_under` float NOT NULL,
  `dinero_apostado_a_over` float NOT NULL,
  `id_mercado` int(11) NOT NULL,
  `id_evento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `mercados`
--

INSERT INTO `mercados` (`tipo_de_mercado`, `informacion_cuota_under`, `informacion_cuota_over`, `dinero_apostado_a_under`, `dinero_apostado_a_over`, `id_mercado`, `id_evento`) VALUES
('1', 1.5, 2.3, 700, 800, 1, 1),
('2', 1.6, 1.5, 500, 600, 2, 1),
('3', 1.7, 1.1, 200, 450, 3, 1),
('1', 1.3, 2.3, 200, 800, 4, 2),
('2', 1.1, 2.3, 600, 700, 5, 2),
('3', 3.4, 2.3, 600, 400, 6, 2),
('1', 2.9, 2.1, 800, 900, 7, 3),
('2', 3.4, 2.1, 300, 600, 8, 3),
('3', 1.1, 3.4, 800, 1000, 9, 3),
('1', 2.1, 2.1, 600, 700, 10, 4),
('2', 3.2, 3.4, 1200, 1300, 11, 4),
('3', 3.1, 2.9, 400, 500, 12, 4),
('1', 2.3, 2.2, 600, 700, 13, 5),
('2', 2.2, 2.8, 800, 1200, 14, 5),
('3', 2.2, 1.1, 500, 200, 15, 5),
('1', 2.2, 1.4, 300, 400, 16, 6),
('2', 1.4, 3.1, 700, 800, 17, 6),
('3', 3.4, 3.5, 200, 400, 18, 6),
('1', 2.1, 2.3, 400, 600, 19, 7),
('2', 2.2, 3.4, 700, 900, 20, 7),
('3', 2.3, 2.4, 700, 900, 21, 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `edad` int(11) NOT NULL,
  `rol` varchar(32) NOT NULL,
  `contraseña` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre`, `apellido`, `email`, `edad`, `rol`, `contraseña`) VALUES
(1, 'Joan', 'Moya', 'joanmoya@gmail.com', 19, 'Administrador', '123'),
(2, 'Carlos', 'Lozano', 'carlosLozano@gmail.com', 22, 'usuario', 'contraseña123'),
(3, '', '', '', 1, 'usuario', '');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `apuestas`
--
ALTER TABLE `apuestas`
  ADD PRIMARY KEY (`id_apuesta`),
  ADD KEY `id_mercado` (`id_mercado`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indices de la tabla `evento`
--
ALTER TABLE `evento`
  ADD PRIMARY KEY (`id_evento`);

--
-- Indices de la tabla `mercados`
--
ALTER TABLE `mercados`
  ADD PRIMARY KEY (`id_mercado`),
  ADD KEY `id_evento` (`id_evento`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `apuestas`
--
ALTER TABLE `apuestas`
  ADD CONSTRAINT `apuestas_ibfk_1` FOREIGN KEY (`id_mercado`) REFERENCES `mercados` (`id_mercado`),
  ADD CONSTRAINT `apuestas_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Filtros para la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD CONSTRAINT `cuenta_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Filtros para la tabla `mercados`
--
ALTER TABLE `mercados`
  ADD CONSTRAINT `mercados_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `evento` (`id_evento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
