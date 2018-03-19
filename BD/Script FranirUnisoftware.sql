SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `FranirUniSoftware` ;
CREATE SCHEMA IF NOT EXISTS `FranirUniSoftware` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `FranirUniSoftware` ;

-- -----------------------------------------------------
-- Table `FranirUniSoftware`.`tipo_pagamento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `FranirUniSoftware`.`tipo_pagamento` ;

CREATE  TABLE IF NOT EXISTS `FranirUniSoftware`.`tipo_pagamento` (
  `cd_tipo_pagamento` INT NOT NULL ,
  `nm_tipo_pagamento` VARCHAR(10) NOT NULL ,
  PRIMARY KEY (`cd_tipo_pagamento`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FranirUniSoftware`.`transacao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `FranirUniSoftware`.`transacao` ;

CREATE  TABLE IF NOT EXISTS `FranirUniSoftware`.`transacao` (
  `cd_transacao` INT(5) NOT NULL ,
  `nm_pessoa_transacao` VARCHAR(80) NOT NULL ,
  `cd_tipo_pagamento` INT(1) NOT NULL ,
  `vl_transacao` DECIMAL(5,2) NOT NULL ,
  `dt_transacao` DATETIME NOT NULL ,
  `qt_parcelas_transacao` INT(2) NOT NULL ,
  `ds_transacao` VARCHAR(150) NOT NULL ,
  INDEX `fk_pagamento_tipo_pagamento_idx` (`cd_tipo_pagamento` ASC) ,
  PRIMARY KEY (`cd_transacao`) ,
  CONSTRAINT `fk_pagamento_tipo_pagamento`
    FOREIGN KEY (`cd_tipo_pagamento` )
    REFERENCES `FranirUniSoftware`.`tipo_pagamento` (`cd_tipo_pagamento` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `FranirUniSoftware` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
