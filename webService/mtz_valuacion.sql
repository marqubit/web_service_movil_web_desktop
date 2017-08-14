-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-07-2017 a las 18:20:07
-- Versión del servidor: 5.7.14
-- Versión de PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mtz_valuacion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `avaluos`
--

CREATE TABLE `avaluos` (
  `id_Avaluo` int(10) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `PagoCatastro` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `cto_Avaluo` int(11) NOT NULL,
  `Subtotal` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `id_Cliente` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `avaluos`
--

INSERT INTO `avaluos` (`id_Avaluo`, `Tipo`, `PagoCatastro`, `Fecha`, `cto_Avaluo`, `Subtotal`, `Total`, `id_Cliente`) VALUES
(1, '$tipo', 4444, '2017-07-23', 4, 4444, 4444, 1),
(2, '$tipo', 1, '2017-07-01', 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_Cliente` int(10) NOT NULL,
  `RFC` varchar(20) DEFAULT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Colonia` varchar(45) NOT NULL,
  `Municipio` varchar(45) NOT NULL,
  `Tenencia` varchar(45) NOT NULL,
  `Reg` varchar(45) NOT NULL,
  `Manzana` varchar(45) NOT NULL,
  `Lote` varchar(45) NOT NULL,
  `cPostal` int(10) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Celular` varchar(45) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_Cliente`, `RFC`, `Apellido`, `Nombre`, `Colonia`, `Municipio`, `Tenencia`, `Reg`, `Manzana`, `Lote`, `cPostal`, `Telefono`, `Celular`) VALUES
(1, '$RFC', '$apellido', '$nombre', '$colonia', '$municipio', '$tenencia', '$Reg', '$Manzana', '$Lote', 1, '1', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `concepto`
--

CREATE TABLE `concepto` (
  `id_Concepto` int(11) NOT NULL,
  `Motivo` varchar(45) NOT NULL,
  `UbicacionPredio` varchar(45) NOT NULL,
  `Localidad` varchar(45) NOT NULL,
  `Adquiriente` varchar(45) NOT NULL,
  `Ubicacion` varchar(45) NOT NULL,
  `DomNotificar` varchar(45) NOT NULL,
  `LocalidadNotificar` varchar(45) NOT NULL,
  `No_Cuenta` int(11) NOT NULL,
  `Enajenante` varchar(45) NOT NULL,
  `Fecha` date NOT NULL,
  `id_Avaluo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `concepto`
--

INSERT INTO `concepto` (`id_Concepto`, `Motivo`, `UbicacionPredio`, `Localidad`, `Adquiriente`, `Ubicacion`, `DomNotificar`, `LocalidadNotificar`, `No_Cuenta`, `Enajenante`, `Fecha`, `id_Avaluo`) VALUES
(1, 'Compra venta', 'Penjamo', 'La Estacion', 'Juanchita Morales', 'Penjamo', 'Margen del Rio 8', 'Penjamo', 30278, 'Juanchito Morales', '2017-07-20', 1),
(2, '$motivo', '$ubicacion_predio', '$localidad', '$adquiriente', '$ubicacion', '$domicilio_notificar', '$localidad_notificar', 2, '$enajenante', '2017-07-08', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `avaluos`
--
ALTER TABLE `avaluos`
  ADD PRIMARY KEY (`id_Avaluo`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_Cliente`);

--
-- Indices de la tabla `concepto`
--
ALTER TABLE `concepto`
  ADD PRIMARY KEY (`id_Concepto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `avaluos`
--
ALTER TABLE `avaluos`
  MODIFY `id_Avaluo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_Cliente` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `concepto`
--
ALTER TABLE `concepto`
  MODIFY `id_Concepto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
