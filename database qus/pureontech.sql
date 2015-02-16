-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 16, 2015 at 01:05 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `pureontech`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer_info`
--

CREATE TABLE IF NOT EXISTS `customer_info` (
  `cust_id` int(5) NOT NULL AUTO_INCREMENT,
  `customer_id` varchar(7) NOT NULL,
  `cust_name` varchar(55) NOT NULL,
  `phone_primary` int(15) NOT NULL,
  `phone_alt` int(15) NOT NULL,
  `door_no` varchar(10) NOT NULL,
  `street_name` varchar(150) NOT NULL,
  `pin_code` int(10) NOT NULL,
  `filter_model` varchar(50) NOT NULL,
  `date_of_installation` date NOT NULL,
  `unit_slno` varchar(30) NOT NULL,
  `used_at` int(3) NOT NULL,
  `warrenty_date` date NOT NULL,
  `cont_details` int(2) NOT NULL,
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `executive`
--

CREATE TABLE IF NOT EXISTS `executive` (
  `exe_id` int(15) NOT NULL AUTO_INCREMENT,
  `exe_name` varchar(75) NOT NULL,
  `exe_emp_id` varchar(20) NOT NULL,
  `exe_number` int(15) NOT NULL,
  `exe_address` varchar(200) NOT NULL,
  PRIMARY KEY (`exe_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `history_card`
--

CREATE TABLE IF NOT EXISTS `history_card` (
  `hist_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(5) NOT NULL,
  `vist_date` date NOT NULL,
  `work_details` int(2) NOT NULL,
  `parts_replaced` int(5) NOT NULL,
  `icr_bill_no` int(10) NOT NULL,
  `iccr_no` int(10) NOT NULL,
  `iccr_date` date NOT NULL,
  `amount` int(10) NOT NULL,
  `exec_attend` int(15) NOT NULL,
  PRIMARY KEY (`hist_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `login_info`
--

CREATE TABLE IF NOT EXISTS `login_info` (
  `login_id` int(5) NOT NULL AUTO_INCREMENT,
  `emp_uname` varchar(20) NOT NULL,
  `emp_pword` varchar(15) NOT NULL,
  `emp_privlage` int(2) NOT NULL,
  PRIMARY KEY (`login_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `parts`
--

CREATE TABLE IF NOT EXISTS `parts` (
  `parts_id` int(5) NOT NULL AUTO_INCREMENT,
  `history_id` int(10) NOT NULL,
  `parts_repl` varchar(100) NOT NULL,
  PRIMARY KEY (`parts_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `revenue_details`
--

CREATE TABLE IF NOT EXISTS `revenue_details` (
  `revenue_id` int(15) NOT NULL AUTO_INCREMENT,
  `exec_id` int(15) NOT NULL,
  `rev_date` date NOT NULL,
  `rev_amount` int(10) NOT NULL,
  PRIMARY KEY (`revenue_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
