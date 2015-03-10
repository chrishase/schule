-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 22. Mai 2014 um 13:02
-- Server Version: 5.5.8
-- PHP-Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `gasthaus`
--
CREATE DATABASE `gasthaus` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gasthaus`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gast`
--

CREATE TABLE IF NOT EXISTS `gast` (
  `GID` int(11) NOT NULL,
  `TID` int(11) NOT NULL,
  `KNr` int(11) NOT NULL,
  `Hauptgericht` varchar(20) NOT NULL,
  PRIMARY KEY (`GID`),
  KEY `TID` (`TID`),
  KEY `KNr` (`KNr`),
  KEY `Hauptgericht` (`Hauptgericht`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `gast`
--

INSERT INTO `gast` (`GID`, `TID`, `KNr`, `Hauptgericht`) VALUES
(1, 1, 1, 'Fisch'),
(2, 1, 1, 'Schnitzel'),
(3, 2, 1, 'Schnitzel'),
(4, 2, 1, 'Truthahn'),
(5, 2, 3, 'Schaschlik'),
(6, 2, 3, 'Fisch'),
(7, 3, 2, 'Schaschlik'),
(8, 3, 2, 'Wurstsalat'),
(9, 4, 3, 'Fisch');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `hauptgericht`
--

CREATE TABLE IF NOT EXISTS `hauptgericht` (
  `Hauptgericht` varchar(20) NOT NULL,
  `Preis` decimal(10,0) NOT NULL,
  PRIMARY KEY (`Hauptgericht`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `hauptgericht`
--

INSERT INTO `hauptgericht` (`Hauptgericht`, `Preis`) VALUES
('Fisch', 14),
('Schaschlik', 11),
('Schnitzel', 12),
('Truthahn', 14),
('Wurstsalat', 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kellner`
--

CREATE TABLE IF NOT EXISTS `kellner` (
  `KNr` int(11) NOT NULL AUTO_INCREMENT,
  `KName` varchar(20) NOT NULL,
  `KVorname` varchar(20) NOT NULL,
  PRIMARY KEY (`KNr`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Daten für Tabelle `kellner`
--

INSERT INTO `kellner` (`KNr`, `KName`, `KVorname`) VALUES
(1, 'Born', 'Klaus'),
(2, 'Acht', 'Else'),
(3, 'Dürr', 'Karin');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tisch`
--

CREATE TABLE IF NOT EXISTS `tisch` (
  `Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Tischplatz` varchar(20) NOT NULL,
  PRIMARY KEY (`Nr`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Daten für Tabelle `tisch`
--

INSERT INTO `tisch` (`Nr`, `Tischplatz`) VALUES
(1, 'Eingang'),
(2, 'Fenster West'),
(3, 'Stammtisch'),
(4, 'Fenster Süd');

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `gast`
--
ALTER TABLE `gast`
  ADD CONSTRAINT `gast_ibfk_1` FOREIGN KEY (`TID`) REFERENCES `tisch` (`Nr`),
  ADD CONSTRAINT `gast_ibfk_2` FOREIGN KEY (`KNr`) REFERENCES `kellner` (`KNr`),
  ADD CONSTRAINT `gast_ibfk_3` FOREIGN KEY (`Hauptgericht`) REFERENCES `hauptgericht` (`Hauptgericht`);
