
DROP TABLE EspecialidadesxDoctor
go



DROP TABLE VentanasxPerfil
go



DROP TABLE Menu
go



DROP TABLE Enfermero
go



DROP TABLE Tecnico
go



DROP TABLE Administrativo
go



DROP TABLE DetalleHorario
go



DROP TABLE Especialidad
go



DROP TABLE Consultorio
go



DROP TABLE Pabellon
go



DROP TABLE Ubigeo
go



DROP TABLE Pais
go



DROP TABLE DiagnosticosxEpisodio
go



DROP TABLE Episodio
go



DROP TABLE HistoriaClinica
go



DROP TABLE Antecedentes
go



DROP TABLE ModoIngreso
go



DROP TABLE FuncionesBiologicas
go



DROP TABLE Enfermedad
go



DROP TABLE ExamenFisico
go



DROP TABLE Diagnostico
go



DROP TABLE Cita
go



DROP TABLE Doctor
go



DROP TABLE Horario
go



DROP TABLE Empleado
go



DROP TABLE Perfil
go



DROP TABLE Area
go



DROP TABLE Paciente
go



DROP TABLE Religion
go



DROP TABLE Idioma
go



DROP TABLE Ocupacion
go



DROP TABLE Persona
go



DROP TABLE Domicilio
go



DROP TABLE LugarNacimiento
go



DROP TABLE TipoDocumento
go



DROP TABLE DetalleDisponibilidad
go



DROP TABLE Disponibilidad
go



DROP TABLE DiagnosticosxFormularioHIS
go



DROP TABLE DetalleFormularioHIS
go



DROP TABLE FormularioHIS
go



DROP TABLE UnidadProductoraServicio
go



DROP TABLE CPT
go



DROP TABLE Laboratorio
go



DROP TABLE Etnia
go



DROP TABLE FinanciadorSalud
go



DROP TABLE Cie10
go



CREATE TABLE Administrativo
( 
	IdAdministrativo     bigint  NOT NULL 
)
go



ALTER TABLE Administrativo
	ADD CONSTRAINT XPKAdministrativo PRIMARY KEY (IdAdministrativo ASC)
go



CREATE TABLE Antecedentes
( 
	IdAntecedentes       bigint IDENTITY ( 1,1 ) ,
	IndTabaco            char(1)  NULL ,
	IndAlcohol           char(1)  NULL ,
	IndCafe              char(1)  NULL ,
	IndTe                char(1)  NULL ,
	IndDrogas            char(1)  NULL ,
	IndDiabetes          char(1)  NULL ,
	DescripcionDiabetes  varchar(300)  NULL ,
	IndHipertension      char(1)  NULL ,
	DescripcionHipertension varchar(300)  NULL ,
	IndCoronariopatia    char(1)  NULL ,
	DescripcionCoronariopatia varchar(300)  NULL ,
	IndDislipidemia      char(1)  NULL ,
	DescripcionDislipidemia varchar(300)  NULL ,
	IndAsma              char(1)  NULL ,
	DescripcionAsma      varchar(300)  NULL ,
	IndPsicopatia        char(1)  NULL ,
	DescripcionPsicopatia varchar(300)  NULL ,
	IndAlergias          char(1)  NULL ,
	DescripcionAlergias  varchar(300)  NULL ,
	IndTuberculosis      char(1)  NULL ,
	DescripcionTuberculosis varchar(300)  NULL ,
	IndAtipia            char(1)  NULL ,
	DescripcionAtipia    varchar(300)  NULL ,
	IndGota              char(1)  NULL ,
	DescripcionGota      varchar(300)  NULL ,
	IndAfeccionBroncopulmonar char(1)  NULL ,
	DescripcionAfeccionBroncopulmonar varchar(300)  NULL ,
	IndEndocrinopatia    char(1)  NULL ,
	DescripcionEndocrinopatia varchar(300)  NULL ,
	IndNefropatia        char(1)  NULL ,
	DescripcionNefropatia varchar(300)  NULL ,
	IndUropatia          char(1)  NULL ,
	DescripcionUropatia  varchar(300)  NULL ,
	IndHemopatia         char(1)  NULL ,
	DescripcionHemopatia varchar(300)  NULL ,
	IndETS               char(1)  NULL ,
	DescripcionETS       varchar(300)  NULL ,
	IndUlcera            char(1)  NULL ,
	DescripcionUlcera    varchar(300)  NULL ,
	IndColecistopatia    char(1)  NULL ,
	DescripcionColecistopatia varchar(300)  NULL ,
	IndHepatitis         char(1)  NULL ,
	DescripcionHepatitis varchar(300)  NULL ,
	IndEnfermedadesNeurologicas char(1)  NULL ,
	DescripcionEnfermedadesNeurologicas varchar(300)  NULL ,
	IndFiebresProlongadas char(1)  NULL ,
	DescripcionFiebresProlongadas varchar(300)  NULL ,
	IndColagenopatia     char(1)  NULL ,
	DescripcionColagenopatia varchar(300)  NULL ,
	Otros                varchar(600)  NULL 
)
go



ALTER TABLE Antecedentes
	ADD CONSTRAINT XPKAntecedentes PRIMARY KEY (IdAntecedentes ASC)
go



CREATE TABLE Area
( 
	IdArea               int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	TipoArea             varchar(14)  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Area
	ADD CONSTRAINT XPKArea PRIMARY KEY (IdArea ASC)
go



CREATE TABLE Cie10
( 
	IdCie10              int IDENTITY ( 1,1 ) ,
	Codigo               varchar(7)  NOT NULL ,
	Descripcion          varchar(400)  NOT NULL 
)
go



ALTER TABLE Cie10
	ADD CONSTRAINT XPKCie10 PRIMARY KEY (IdCie10 ASC)
go



CREATE TABLE Cita
( 
	IdCita               char(18)  NOT NULL ,
	IdPaciente           bigint  NOT NULL ,
	IdDoctor             bigint  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	Hora                 datetime  NOT NULL ,
	FechaRegistro        datetime  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Cita
	ADD CONSTRAINT XPKCita PRIMARY KEY (IdCita ASC)
go



CREATE TABLE Consultorio
( 
	IdConsultorio        int IDENTITY ( 1,1 ) ,
	Piso                 varchar(4)  NOT NULL ,
	Numero               varchar(10)  NOT NULL ,
	IdPabellon           int  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Consultorio
	ADD CONSTRAINT XPKConsultorio PRIMARY KEY (IdConsultorio ASC)
go



CREATE TABLE CPT
( 
	IdCPT                int IDENTITY ( 1,1 ) ,
	Codigo               varchar(6)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(300)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE CPT
	ADD CONSTRAINT XPKCPT PRIMARY KEY (IdCPT ASC)
go



CREATE TABLE DetalleDisponibilidad
( 
	IdDetalleDisponibilidad bigint IDENTITY ( 1,1 ) ,
	IdDisponibilidad     bigint  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	HoraInicio           datetime  NOT NULL ,
	HoraFin              datetime  NOT NULL 
)
go



ALTER TABLE DetalleDisponibilidad
	ADD CONSTRAINT XPKDetalleDisponibilidad PRIMARY KEY (IdDetalleDisponibilidad ASC)
go



CREATE TABLE DetalleFormularioHIS
( 
	IdDetalleFormularioHIS bigint  NOT NULL ,
	NumeroHistoriaClinica varchar(10)  NULL ,
	NumeroDocumento      varchar(20)  NULL ,
	IdFinanciadorSalud   int  NULL ,
	IdEtnia              int  NULL ,
	Distrito             varchar(6)  NULL ,
	Edad                 int  NULL ,
	Sexo                 char(1)  NULL ,
	Establecimiento      char(1)  NULL ,
	Servicio             char(1)  NULL ,
	TipoDiagnostico      char(1)  NULL ,
	IdLaboratorio        int  NULL ,
	IdCPT                int  NULL ,
	IdFormularioHIS      bigint  NULL 
)
go



ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT XPKDetalleFormularioHIS PRIMARY KEY (IdDetalleFormularioHIS ASC)
go



CREATE TABLE DetalleHorario
( 
	IdDetalleHorario     bigint IDENTITY ( 1,1 ) ,
	IdHorario            bigint  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	HoraInicio           datetime  NOT NULL ,
	HoraFin              datetime  NOT NULL ,
	IdConsultorio        int  NOT NULL ,
	IdEspecialidad       int  NOT NULL 
)
go



ALTER TABLE DetalleHorario
	ADD CONSTRAINT XPKDetalleHorario PRIMARY KEY (IdDetalleHorario ASC)
go



CREATE TABLE Diagnostico
( 
	IdDiagnostico        bigint IDENTITY ( 1,1 ) ,
	IdCie10              int  NOT NULL ,
	Descripcion          varchar(500)  NULL 
)
go



ALTER TABLE Diagnostico
	ADD CONSTRAINT XPKDiagnostico PRIMARY KEY (IdDiagnostico ASC)
go



CREATE TABLE DiagnosticosxEpisodio
( 
	IdDiagnosticoEpisodio bigint IDENTITY ( 1,1 ) ,
	IdDiagnostico        bigint  NOT NULL ,
	IdEpisodio           bigint  NOT NULL 
)
go



ALTER TABLE DiagnosticosxEpisodio
	ADD CONSTRAINT XPKDiagnosticosxEpisodio PRIMARY KEY (IdDiagnosticoEpisodio ASC)
go



CREATE TABLE DiagnosticosxFormularioHIS
( 
	IdDiagnosticoFormularioHIS char(18)  NOT NULL ,
	IdCie10              int  NULL ,
	IdDetalleFormularioHIS bigint  NULL 
)
go



ALTER TABLE DiagnosticosxFormularioHIS
	ADD CONSTRAINT XPKDiagnosticosxFormularioHIS PRIMARY KEY (IdDiagnosticoFormularioHIS ASC)
go



CREATE TABLE Disponibilidad
( 
	IdDisponibilidad     bigint IDENTITY ( 1,1 ) ,
	Estado               varchar(8)  NULL 
)
go



ALTER TABLE Disponibilidad
	ADD CONSTRAINT XPKDisponibilidad PRIMARY KEY (IdDisponibilidad ASC)
go



CREATE TABLE Doctor
( 
	IdDoctor             bigint  NOT NULL ,
	CMP                  varchar(5)  NOT NULL ,
	IndicadorHC          char(1)  NOT NULL ,
	IdHorario            bigint  NULL ,
	IdDisponibilidad     bigint  NULL 
)
go



ALTER TABLE Doctor
	ADD CONSTRAINT XPKDoctor PRIMARY KEY (IdDoctor ASC)
go



CREATE TABLE Domicilio
( 
	IdDomicilio          int IDENTITY ( 1,1 ) ,
	Departamento         varchar(40)  NULL ,
	Provincia            varchar(40)  NULL ,
	Distrito             varchar(40)  NULL ,
	Direccion            varchar(100)  NULL 
)
go



ALTER TABLE Domicilio
	ADD CONSTRAINT XPKDomicilio PRIMARY KEY (IdDomicilio ASC)
go



CREATE TABLE Empleado
( 
	IdEmpleado           bigint  NOT NULL ,
	Foto                 varchar(2000)  NULL ,
	Usuario              varchar(20)  NOT NULL ,
	Contrasena           varchar(60)  NOT NULL ,
	TipoEmpleado         varchar(14)  NULL ,
	IdArea               int  NULL ,
	IdPerfil             int  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Empleado
	ADD CONSTRAINT XPKEmpleado PRIMARY KEY (IdEmpleado ASC)
go



CREATE TABLE Enfermedad
( 
	IdEnfermedad         bigint IDENTITY ( 1,1 ) ,
	Tiempo               varchar(3)  NULL ,
	Inicio               varchar(300)  NULL ,
	Curso                varchar(300)  NULL ,
	Sintomas             varchar(1000)  NULL ,
	RelatoCronologico    varchar(1000)  NULL 
)
go



ALTER TABLE Enfermedad
	ADD CONSTRAINT XPKEnfermedad PRIMARY KEY (IdEnfermedad ASC)
go



CREATE TABLE Enfermero
( 
	IdEnfermero          bigint  NOT NULL ,
	NumeroLicencia       varchar(7)  NOT NULL 
)
go



ALTER TABLE Enfermero
	ADD CONSTRAINT XPKEnfermero PRIMARY KEY (IdEnfermero ASC)
go



CREATE TABLE Episodio
( 
	IdEpisodio           bigint IDENTITY ( 1,1 ) ,
	Ectoscopia           varchar(1000)  NULL ,
	IdExamenFisico       bigint  NOT NULL ,
	IdEnfermedad         bigint  NOT NULL ,
	IdFuncionesBiologicas bigint  NOT NULL ,
	FechaRegistro        datetime  NOT NULL ,
	IdDoctor             bigint  NOT NULL ,
	IdModoIngreso        int  NULL ,
	IdHistoriaClinica    bigint  NOT NULL 
)
go



ALTER TABLE Episodio
	ADD CONSTRAINT XPKEpisodio PRIMARY KEY (IdEpisodio ASC)
go



CREATE TABLE Especialidad
( 
	IdEspecialidad       int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	IdArea               int  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Especialidad
	ADD CONSTRAINT XPKEspecialidad PRIMARY KEY (IdEspecialidad ASC)
go



CREATE TABLE EspecialidadesxDoctor
( 
	IdEspecialidadDoctor int IDENTITY ( 1,1 ) ,
	IdEspecialidad       int  NOT NULL ,
	IdDoctor             bigint  NOT NULL 
)
go



ALTER TABLE EspecialidadesxDoctor
	ADD CONSTRAINT XPKEspecialidadesxDoctor PRIMARY KEY (IdEspecialidadDoctor ASC)
go



CREATE TABLE Etnia
( 
	IdEtnia              int IDENTITY ( 1,1 ) ,
	Codigo               varchar(3)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Etnia
	ADD CONSTRAINT XPKEtnia PRIMARY KEY (IdEtnia ASC)
go



CREATE TABLE ExamenFisico
( 
	IdExamenFisico       bigint IDENTITY ( 1,1 ) ,
	Temperatura          varchar(2)  NULL ,
	FrecuenciaCardiaca   varchar(3)  NULL ,
	Pulso                varchar(10)  NULL ,
	FrecuenciaRespiratoria varchar(10)  NULL ,
	PresionArterial      varchar(10)  NULL ,
	Peso                 varchar(6)  NULL ,
	Talla                varchar(5)  NULL ,
	Otros                varchar(1000)  NULL 
)
go



ALTER TABLE ExamenFisico
	ADD CONSTRAINT XPKExamenFisico PRIMARY KEY (IdExamenFisico ASC)
go



CREATE TABLE FinanciadorSalud
( 
	IdFinanciadorSalud   int IDENTITY ( 1,1 ) ,
	Codigo               varchar(2)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(300)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE FinanciadorSalud
	ADD CONSTRAINT XPKFinanciadorSalud PRIMARY KEY (IdFinanciadorSalud ASC)
go



CREATE TABLE FormularioHIS
( 
	IdFormularioHIS      bigint IDENTITY ( 1,1 ) ,
	Numero               varchar(10)  NULL ,
	Codificador          varchar(10)  NULL ,
	Turno                char(1)  NULL ,
	Fecha                datetime  NULL ,
	Establecimiento      varchar(300)  NULL ,
	IdUnidadProductoraServicio int  NULL ,
	ResponsableAtencion  varchar(200)  NULL 
)
go



ALTER TABLE FormularioHIS
	ADD CONSTRAINT XPKFormularioHIS PRIMARY KEY (IdFormularioHIS ASC)
go



CREATE TABLE FuncionesBiologicas
( 
	IdFuncionesBiologicas bigint IDENTITY ( 1,1 ) ,
	Apetito              varchar(300)  NULL ,
	Sed                  varchar(300)  NULL ,
	Orina                varchar(300)  NULL ,
	Deposiciones         varchar(300)  NULL 
)
go



ALTER TABLE FuncionesBiologicas
	ADD CONSTRAINT XPKFuncionesBiologicas PRIMARY KEY (IdFuncionesBiologicas ASC)
go



CREATE TABLE HistoriaClinica
( 
	IdHistoriaClinica    bigint IDENTITY ( 1,1 ) ,
	Numero               varchar(10)  NOT NULL ,
	IdPaciente           bigint  NOT NULL ,
	IdAntecedentes       bigint  NOT NULL ,
	FechaRegistro        datetime  NOT NULL ,
	IdUsuarioCreacion    bigint  NOT NULL 
)
go



ALTER TABLE HistoriaClinica
	ADD CONSTRAINT XPKHistoriaClinica PRIMARY KEY (IdHistoriaClinica ASC)
go



CREATE TABLE Horario
( 
	IdHorario            bigint IDENTITY ( 1,1 ) ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Horario
	ADD CONSTRAINT XPKHorario PRIMARY KEY (IdHorario ASC)
go



CREATE TABLE Idioma
( 
	IdIdioma             int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Idioma
	ADD CONSTRAINT XPKIdioma PRIMARY KEY (IdIdioma ASC)
go



CREATE TABLE Laboratorio
( 
	IdLaboratorio        int IDENTITY ( 1,1 ) ,
	Codigo               varchar(3)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(300)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Laboratorio
	ADD CONSTRAINT XPKLaboratorio PRIMARY KEY (IdLaboratorio ASC)
go



CREATE TABLE LugarNacimiento
( 
	IdLugarNacimiento    int IDENTITY ( 1,1 ) ,
	Pais                 varchar(40)  NULL ,
	Departamento         varchar(40)  NULL ,
	Provincia            varchar(40)  NULL ,
	Distrito             varchar(40)  NULL 
)
go



ALTER TABLE LugarNacimiento
	ADD CONSTRAINT XPKLugarNacimiento PRIMARY KEY (IdLugarNacimiento ASC)
go



CREATE TABLE Menu
( 
	IdMenu               int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL 
)
go



ALTER TABLE Menu
	ADD CONSTRAINT XPKMenu PRIMARY KEY (IdMenu ASC)
go



CREATE TABLE ModoIngreso
( 
	IdModoIngreso        int IDENTITY ( 1,1 ) ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE ModoIngreso
	ADD CONSTRAINT XPKModoIngreso PRIMARY KEY (IdModoIngreso ASC)
go



CREATE TABLE Ocupacion
( 
	IdOcupacion          int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Ocupacion
	ADD CONSTRAINT XPKOcupacion PRIMARY KEY (IdOcupacion ASC)
go



CREATE TABLE Pabellon
( 
	IdPabellon           int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Pabellon
	ADD CONSTRAINT XPKPabellon PRIMARY KEY (IdPabellon ASC)
go



CREATE TABLE Paciente
( 
	IdPaciente           bigint  NOT NULL ,
	IdOcupacion          int  NULL ,
	IdEtnia              int  NULL ,
	IdIdioma             int  NULL ,
	IdReligion           int  NULL ,
	GrupoSanguineo       varchar(2)  NULL ,
	FactorSanguineo      varchar(3)  NULL 
)
go



ALTER TABLE Paciente
	ADD CONSTRAINT XPKPaciente PRIMARY KEY (IdPaciente ASC)
go



CREATE TABLE Pais
( 
	IdPais               int IDENTITY ( 1,1 ) ,
	Nombre               varchar(40)  NOT NULL ,
	Descripcion          varchar(300)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Pais
	ADD CONSTRAINT XPKPais PRIMARY KEY (IdPais ASC)
go



CREATE TABLE Perfil
( 
	IdPerfil             int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	TipoEmpleado         varchar(14)  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Perfil
	ADD CONSTRAINT XPKPerfil PRIMARY KEY (IdPerfil ASC)
go



CREATE TABLE Persona
( 
	IdPersona            bigint IDENTITY ( 1,1 ) ,
	Paterno              varchar(30)  NULL ,
	Materno              varchar(30)  NULL ,
	Nombres              varchar(30)  NULL ,
	Sexo                 varchar(9)  NULL ,
	FechaNacimiento      datetime  NULL ,
	IdTipoDocumento      int  NULL ,
	NumeroDocumento      varchar(50)  NULL ,
	EstadoCivil          varchar(10)  NULL ,
	IdLugarNacimiento    int  NULL ,
	IdDomicilio          int  NULL ,
	Telefono             varchar(12)  NULL ,
	Celular              varchar(12)  NULL ,
	CorreoElectronico    varchar(100)  NULL ,
	FechaRegistro        datetime  NULL ,
	TipoPersona          varchar(8)  NOT NULL 
)
go



ALTER TABLE Persona
	ADD CONSTRAINT XPKPersona PRIMARY KEY (IdPersona ASC)
go



CREATE TABLE Religion
( 
	IdReligion           int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE Religion
	ADD CONSTRAINT XPKReligion PRIMARY KEY (IdReligion ASC)
go



CREATE TABLE Tecnico
( 
	IdTecnico            bigint  NOT NULL 
)
go



ALTER TABLE Tecnico
	ADD CONSTRAINT XPKTecnico PRIMARY KEY (IdTecnico ASC)
go



CREATE TABLE TipoDocumento
( 
	IdTipoDocumento      int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NULL ,
	NumeroDigitos        varchar(2)  NOT NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE TipoDocumento
	ADD CONSTRAINT XPKTipoDocumento PRIMARY KEY (IdTipoDocumento ASC)
go



CREATE TABLE Ubigeo
( 
	IdUbigeo             int IDENTITY ( 1,1 ) ,
	CodDepartamento      varchar(2)  NOT NULL ,
	CodProvincia         varchar(2)  NOT NULL ,
	CodDistrito          varchar(2)  NOT NULL ,
	Descripcion          varchar(40)  NOT NULL 
)
go



ALTER TABLE Ubigeo
	ADD CONSTRAINT XPKUbigeo PRIMARY KEY (IdUbigeo ASC)
go



CREATE TABLE UnidadProductoraServicio
( 
	IdUnidadProductoraServicio int IDENTITY ( 1,1 ) ,
	Codigo               varchar(7)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Descripcion          varchar(300)  NULL ,
	Estado               varchar(8)  NOT NULL 
)
go



ALTER TABLE UnidadProductoraServicio
	ADD CONSTRAINT XPKUnidadProductoraServicio PRIMARY KEY (IdUnidadProductoraServicio ASC)
go



CREATE TABLE VentanasxPerfil
( 
	IdVentanaPerfil      int IDENTITY ( 1,1 ) ,
	IdMenu               int  NOT NULL ,
	IdPerfil             int  NOT NULL 
)
go



ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT XPKVentanasxPerfil PRIMARY KEY (IdVentanaPerfil ASC)
go




ALTER TABLE Administrativo
	ADD  FOREIGN KEY (IdAdministrativo) REFERENCES Empleado(IdEmpleado)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE Cita
	ADD CONSTRAINT R_53 FOREIGN KEY (IdPaciente) REFERENCES Paciente(IdPaciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Cita
	ADD CONSTRAINT R_54 FOREIGN KEY (IdDoctor) REFERENCES Doctor(IdDoctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Consultorio
	ADD CONSTRAINT R_71 FOREIGN KEY (IdPabellon) REFERENCES Pabellon(IdPabellon)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleDisponibilidad
	ADD CONSTRAINT R_73 FOREIGN KEY (IdDisponibilidad) REFERENCES Disponibilidad(IdDisponibilidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT R_59 FOREIGN KEY (IdFinanciadorSalud) REFERENCES FinanciadorSalud(IdFinanciadorSalud)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT R_60 FOREIGN KEY (IdEtnia) REFERENCES Etnia(IdEtnia)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT R_63 FOREIGN KEY (IdLaboratorio) REFERENCES Laboratorio(IdLaboratorio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT R_64 FOREIGN KEY (IdCPT) REFERENCES CPT(IdCPT)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleFormularioHIS
	ADD CONSTRAINT R_65 FOREIGN KEY (IdFormularioHIS) REFERENCES FormularioHIS(IdFormularioHIS)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleHorario
	ADD CONSTRAINT R_31 FOREIGN KEY (IdHorario) REFERENCES Horario(IdHorario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleHorario
	ADD CONSTRAINT R_32 FOREIGN KEY (IdConsultorio) REFERENCES Consultorio(IdConsultorio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DetalleHorario
	ADD CONSTRAINT R_67 FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad(IdEspecialidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Diagnostico
	ADD CONSTRAINT R_44 FOREIGN KEY (IdCie10) REFERENCES Cie10(IdCie10)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DiagnosticosxEpisodio
	ADD CONSTRAINT R_45 FOREIGN KEY (IdDiagnostico) REFERENCES Diagnostico(IdDiagnostico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DiagnosticosxEpisodio
	ADD CONSTRAINT R_46 FOREIGN KEY (IdEpisodio) REFERENCES Episodio(IdEpisodio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DiagnosticosxFormularioHIS
	ADD CONSTRAINT R_61 FOREIGN KEY (IdCie10) REFERENCES Cie10(IdCie10)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DiagnosticosxFormularioHIS
	ADD CONSTRAINT R_62 FOREIGN KEY (IdDetalleFormularioHIS) REFERENCES DetalleFormularioHIS(IdDetalleFormularioHIS)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Doctor
	ADD  FOREIGN KEY (IdDoctor) REFERENCES Empleado(IdEmpleado)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE Doctor
	ADD CONSTRAINT R_68 FOREIGN KEY (IdHorario) REFERENCES Horario(IdHorario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Doctor
	ADD CONSTRAINT R_74 FOREIGN KEY (IdDisponibilidad) REFERENCES Disponibilidad(IdDisponibilidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Empleado
	ADD  FOREIGN KEY (IdEmpleado) REFERENCES Persona(IdPersona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE Empleado
	ADD CONSTRAINT R_29 FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Empleado
	ADD CONSTRAINT R_72 FOREIGN KEY (IdPerfil) REFERENCES Perfil(IdPerfil)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Enfermero
	ADD  FOREIGN KEY (IdEnfermero) REFERENCES Empleado(IdEmpleado)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_47 FOREIGN KEY (IdExamenFisico) REFERENCES ExamenFisico(IdExamenFisico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_48 FOREIGN KEY (IdEnfermedad) REFERENCES Enfermedad(IdEnfermedad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_49 FOREIGN KEY (IdFuncionesBiologicas) REFERENCES FuncionesBiologicas(IdFuncionesBiologicas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_50 FOREIGN KEY (IdDoctor) REFERENCES Doctor(IdDoctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_51 FOREIGN KEY (IdModoIngreso) REFERENCES ModoIngreso(IdModoIngreso)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Episodio
	ADD CONSTRAINT R_52 FOREIGN KEY (IdHistoriaClinica) REFERENCES HistoriaClinica(IdHistoriaClinica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Especialidad
	ADD CONSTRAINT R_66 FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EspecialidadesxDoctor
	ADD CONSTRAINT R_56 FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad(IdEspecialidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EspecialidadesxDoctor
	ADD CONSTRAINT R_57 FOREIGN KEY (IdDoctor) REFERENCES Doctor(IdDoctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE FormularioHIS
	ADD CONSTRAINT R_69 FOREIGN KEY (IdUnidadProductoraServicio) REFERENCES UnidadProductoraServicio(IdUnidadProductoraServicio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_38 FOREIGN KEY (IdPaciente) REFERENCES Paciente(IdPaciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_40 FOREIGN KEY (IdUsuarioCreacion) REFERENCES Empleado(IdEmpleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_43 FOREIGN KEY (IdAntecedentes) REFERENCES Antecedentes(IdAntecedentes)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Paciente
	ADD  FOREIGN KEY (IdPaciente) REFERENCES Persona(IdPersona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE Paciente
	ADD CONSTRAINT R_34 FOREIGN KEY (IdOcupacion) REFERENCES Ocupacion(IdOcupacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Paciente
	ADD CONSTRAINT R_35 FOREIGN KEY (IdEtnia) REFERENCES Etnia(IdEtnia)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Paciente
	ADD CONSTRAINT R_36 FOREIGN KEY (IdIdioma) REFERENCES Idioma(IdIdioma)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Paciente
	ADD CONSTRAINT R_37 FOREIGN KEY (IdReligion) REFERENCES Religion(IdReligion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Persona
	ADD CONSTRAINT R_1 FOREIGN KEY (IdTipoDocumento) REFERENCES TipoDocumento(IdTipoDocumento)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Persona
	ADD CONSTRAINT R_2 FOREIGN KEY (IdLugarNacimiento) REFERENCES LugarNacimiento(IdLugarNacimiento)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Persona
	ADD CONSTRAINT R_3 FOREIGN KEY (IdDomicilio) REFERENCES Domicilio(IdDomicilio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Tecnico
	ADD  FOREIGN KEY (IdTecnico) REFERENCES Empleado(IdEmpleado)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT R_10 FOREIGN KEY (IdMenu) REFERENCES Menu(IdMenu)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT R_11 FOREIGN KEY (IdPerfil) REFERENCES Perfil(IdPerfil)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


