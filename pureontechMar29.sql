-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2015 at 01:23 PM
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
  `cust_id` int(10) NOT NULL AUTO_INCREMENT,
  `customer_id` varchar(15) NOT NULL,
  `cust_name` varchar(55) NOT NULL,
  `phone_primary` varchar(15) NOT NULL,
  `phone_alt` varchar(15) NOT NULL,
  `door_no` varchar(10) NOT NULL,
  `street_name` varchar(150) NOT NULL,
  `pin_code` varchar(15) NOT NULL,
  `filter_model` varchar(50) NOT NULL,
  `date_of_installation` date NOT NULL,
  `unit_slno` varchar(30) NOT NULL,
  `used_at` int(3) NOT NULL,
  `warrenty_date` date NOT NULL,
  `cont_details` int(2) NOT NULL,
  `acmc_covered_parts` varchar(300) NOT NULL COMMENT 'stores the ACMC parts covered if any',
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `customer_info`
--

INSERT INTO `customer_info` (`cust_id`, `customer_id`, `cust_name`, `phone_primary`, `phone_alt`, `door_no`, `street_name`, `pin_code`, `filter_model`, `date_of_installation`, `unit_slno`, `used_at`, `warrenty_date`, `cont_details`, `acmc_covered_parts`) VALUES
(11, '1PI13MC', 'Abhi J', '9738', '9945', '1118', '14th cross', '560072', 'CRZ12', '2015-02-18', '234', 1, '2015-03-04', 1, 'NULL'),
(12, '1PI', 'Abhijith B S', '3212', '321321', 'c321', '12a', '560072', 'dsa', '2015-02-02', '32dsa', 2, '2015-02-27', 1, 'NULL'),
(14, '1PI12MC', 'Joshua Mark', '2323', '2322', '3232', '14th cs', '48930', 'dlsm9', '2015-02-18', '8009', 3, '2015-02-18', 1, 'NULL'),
(19, '4324', 'Manju', '432', '432', '42', '342', '4322', 'fw2', '2015-02-18', '5432', 1, '2015-02-18', 2, 'R O Membrane'),
(22, '1PI13MCA01', 'Adarsh Murthy', '9738252812', '9986756289', '#119i', '2nd Main', '560073', 'XR-1289', '2015-03-01', '9086', 1, '2015-03-20', 2, 'Sedement,Carbon,R O Membrane'),
(24, '1PI1390', 'Ashok Murthy', '9738252820', '9986286970', '1118', '14th Cross,1st stage,1st Phase', '560072', 'CRXZ01', '2015-02-03', '1290', 2, '2015-03-11', 2, 'Sedement,Carbon,R O Membrane,Solinide valve (SV),Pump');

-- --------------------------------------------------------

--
-- Table structure for table `executive`
--

CREATE TABLE IF NOT EXISTS `executive` (
  `exe_id` int(15) NOT NULL AUTO_INCREMENT,
  `exe_name` varchar(75) NOT NULL,
  `exe_emp_id` varchar(20) NOT NULL,
  `exe_number` varchar(15) NOT NULL,
  `exe_address` varchar(300) NOT NULL,
  `isworking` int(3) NOT NULL,
  PRIMARY KEY (`exe_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `executive`
--

INSERT INTO `executive` (`exe_id`, `exe_name`, `exe_emp_id`, `exe_number`, `exe_address`, `isworking`) VALUES
(2, 'Manju', 'PI123', '2147483647', '#14cross,1st stage,1st phase', 1),
(3, 'Josh', 'PI190', '2147483647', 'Main Road', 1),
(4, 'Alex', 'PI90', '98202139', 'dfqw23', 1),
(5, 'Madhu', 'PI123', '9738252811', '#1118,14th cross,1st stage,1st phase,chandralayout,bangalore-72', 1);

-- --------------------------------------------------------

--
-- Table structure for table `history_card`
--

CREATE TABLE IF NOT EXISTS `history_card` (
  `hist_id` int(15) NOT NULL AUTO_INCREMENT,
  `customer_id` varchar(15) NOT NULL,
  `vist_date` date NOT NULL,
  `work_details` int(2) NOT NULL,
  `parts_replaced` varchar(300) NOT NULL,
  `icr_bill_no` varchar(15) NOT NULL,
  `iccr_no` varchar(15) NOT NULL,
  `iccr_date` date NOT NULL,
  `amount` varchar(15) NOT NULL,
  `exec_attend` int(15) NOT NULL,
  `acmc_part_used` varchar(50) NOT NULL,
  PRIMARY KEY (`hist_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `history_card`
--

INSERT INTO `history_card` (`hist_id`, `customer_id`, `vist_date`, `work_details`, `parts_replaced`, `icr_bill_no`, `iccr_no`, `iccr_date`, `amount`, `exec_attend`, `acmc_part_used`) VALUES
(1, '1PI13MC', '2015-02-11', 1, '$-$Filter$-$Gasket$-$Cap$-$Airfoil$-$', '4321', '1234', '2015-02-22', '2500', 1, 'NULL'),
(2, '1PI12MC', '2015-02-25', 1, '$-$dsad$-$', '21', '21', '2015-02-25', '231', 4, 'NULL'),
(3, '4324', '2015-03-22', 2, '$-$asdasd$-$asdcvs$-$qwddv$-$', '123', '123', '2015-03-22', '1234', -1, 'NULL'),
(4, '4324', '2015-03-22', 1, '$-$sadaf$-$asfg$-$', '134', '123', '2015-03-22', '1234', 5, 'NULL'),
(6, '1PI1390', '2015-03-27', 1, '$-$234$-$', '124', '213', '2015-03-27', '2342', 4, 'R O Membrane,Solinide valve (SV)'),
(9, '1PI13MCA01', '2015-03-29', 1, '$-$345345$-$', '564', '14345', '2015-03-29', '34534', 4, 'R O Membrane'),
(10, '1PI1390', '2015-03-29', 1, '$-$456$-$', '456', '3456', '2015-06-29', '456', 3, 'Sedement,Pump'),
(11, '1PI13MCA01', '2015-03-27', 1, '$-$rets$-$sdfsdf$-$', '2345', '1234', '2015-03-27', '450', 5, 'NULL');

-- --------------------------------------------------------

--
-- Table structure for table `login_info`
--

CREATE TABLE IF NOT EXISTS `login_info` (
  `login_id` int(10) NOT NULL AUTO_INCREMENT,
  `emp_uname` varchar(20) NOT NULL,
  `emp_pword` varchar(20) NOT NULL,
  `emp_privlage` int(2) NOT NULL,
  PRIMARY KEY (`login_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `login_info`
--

INSERT INTO `login_info` (`login_id`, `emp_uname`, `emp_pword`, `emp_privlage`) VALUES
(1, 'Abhi', '123', 1),
(4, 'Josh', 'josh', 0),
(5, 'admin', 'admin', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
