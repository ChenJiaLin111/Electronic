

IF OBJECT_ID('tb_User') IS NOT NULL										
	DROP TABLE tb_User;									
GO										
CREATE TABLE tb_User									
	(No 									
		CHAR(4) 								
		NOT NULL								
		CONSTRAINT pk_tb_User_No								
			PRIMARY KEY(No)							
		CONSTRAINT ck_tb_User_No								
			CHECK(No LIKE '[0-9][0-9][0-9][0-9]')	
	,Password
	    VARCHAR(20)
		NOT NULL
	,identify
	     VARCHAR(20)
		NOT NULL);	
		

