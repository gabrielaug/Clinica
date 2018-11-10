/* ---------------------------------------------*/
/* DATABASE DO PROJETO DE SISTEMAS DISTRIBUIDOS */
/* SCRIPT FEITO PARA O SQL SEVER				*/
/* ---------------------------------------------*/


IF  NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'sistemaBD')
    BEGIN
        CREATE DATABASE sistemaBD;

    USE sistemaBD;
    


CREATE TABLE Usuario (	UserName VARCHAR(20) PRIMARY KEY,
						Senha VARCHAR(50) NOT NULL,
						Nome VARCHAR(100),
						sn_Ativo CHAR(1) NOT NULL DEFAULT 'S'
						);


CREATE TABLE Paciente (		Cd_Paciente INT PRIMARY KEY IDENTITY(1,1),
							Nm_Paciente VARCHAR(100) NOT NULL,
							Nm_Mae VARCHAR(100),
							Nm_Pai VARCHAR(100),
							Nm_Social VARCHAR(100),
							CPF VARCHAR(11) NOT NULL,
							RG VARCHAR(20),
							Dt_Nascimento Date NOT NULL,
							Telefone VARCHAR(15) NOT NULL,
							Endereco VARCHAR(50),
							Email VARCHAR(100),
							Cidade VARCHAR(20),
							Bairro VARCHAR(20),
							Estado VARCHAR(20)
					 	);

CREATE TABLE Prestador (	Cd_Prestador INT PRIMARY KEY IDENTITY(1,1),
							Nm_Prestador VARCHAR(100) NOT NULL,
							CPF VARCHAR(11) NOT NULL,
							Telefone VARCHAR(15) NOT NULL,
							Nr_Conselho VARCHAR(20) NOT NULL,
							sn_Ativo CHAR(1) NOT NULL DEFAULT 'S'
							);

CREATE TABLE Agendamento (	Cd_Agendamento INT PRIMARY KEY IDENTITY(1000,1),
							Dt_Consulta Date NOT NULL,
							Cd_Paciente INT REFERENCES Paciente (Cd_Paciente),
							Cd_Prestador INT REFERENCES Prestador (Cd_Prestador),
							UserName VARCHAR(20) FOREIGN KEY REFERENCES Usuario (UserName)
							);

CREATE TABLE Convenio (		Cd_Convenio INT PRIMARY KEY IDENTITY(1,1),
							Nm_Convenio VARCHAR(100) NOT NULL,
							sn_Ativo CHAR(1) NOT NULL DEFAULT 'S'
							);

CREATE TABLE Tipo_Consulta (Cd_Consulta INT PRIMARY KEY IDENTITY(1,1),
							Nm_Consulta VARCHAR(100) NOT NULL,
							sn_Ativo CHAR(1) NOT NULL DEFAULT 'S' 
							);

CREATE TABLE Procedimento (	Cd_Procedimento VARCHAR(50) PRIMARY KEY,  /* Codigo sem auto-incremento pois possui para cada Convenio*/
							Nm_Procedimento VARCHAR(100) NOT NULL,
							Valor Decimal(6,2),
							Cd_Convenio INT REFERENCES Convenio (Cd_Convenio),
							sn_Ativo CHAR(1) NOT NULL DEFAULT 'S'
							); 

CREATE TABLE Atendimento (	Cd_Atendimento INT PRIMARY KEY IDENTITY(1,1),
							Dt_Atendimento Date NOT NULL,
							Cd_Prestador INT REFERENCES Prestador (Cd_Prestador), /* Utilizado Novamente pois Pode ser Agendado para um Prestador e Atendido por Outro*/
							Cd_Agendamento INT REFERENCES Agendamento (Cd_Agendamento), 
							Cd_Procedimento INT REFERENCES Procedimento (Cd_Procedimento),
							Cd_Consulta INT  REFERENCES Tipo_Consulta (Cd_Consulta), /* falta verifica o que é e se fica em atendimento ou procedimento. (Alterando possivelmente o Modelo Conceitual.*/
							UserName VARCHAR(20)  REFERENCES Usuario (UserName),
							Dt_AtendFinalizado Date NOT NULL
							);

END;