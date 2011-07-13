
CREATE TABLE Administrativo
(
	Id_Administrativo    int  NOT NULL ,
	Id_AreaAdministrativa int  NULL 
)
go


ALTER TABLE Administrativo
	ADD CONSTRAINT XPKAdministrativo PRIMARY KEY (Id_Administrativo ASC)
go


CREATE TABLE Antecedentes
(
	Id_Antecedentes      int IDENTITY (1,1) ,
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
	Otros                varchar(1000)  NULL 
)
go


ALTER TABLE Antecedentes
	ADD CONSTRAINT XPKAntecedentes PRIMARY KEY (Id_Antecedentes ASC)
go


CREATE TABLE Area
(
	Id_Area              int IDENTITY (1,1) ,
	Descripcion          varchar(200)  NULL ,
	Nombre               varchar(30)  NOT NULL ,
	TipoArea             varchar(14)  NOT NULL ,
	Estado               varchar(8)  NULL 
)
go


ALTER TABLE Area
	ADD CONSTRAINT XPKArea PRIMARY KEY (Id_Area ASC)
go


CREATE TABLE AreaAdministrativa
(
	Id_AreaAdministrativa int  NOT NULL 
)
go


ALTER TABLE AreaAdministrativa
	ADD CONSTRAINT XPKAreaAdministrativa PRIMARY KEY (Id_AreaAdministrativa ASC)
go


CREATE TABLE AreaMedica
(
	Id_AreaMedica        int  NOT NULL 
)
go


ALTER TABLE AreaMedica
	ADD CONSTRAINT XPKAreaMedica PRIMARY KEY (Id_AreaMedica ASC)
go


CREATE TABLE Cie10
(
	Id_Cie10             int IDENTITY (1,1) ,
	Codigo               varchar(7)  NULL ,
	Descripcion          varchar(400)  NULL 
)
go


ALTER TABLE Cie10
	ADD CONSTRAINT XPKCie10 PRIMARY KEY (Id_Cie10 ASC)
go


CREATE TABLE Cita
(
	Id_Cita              int IDENTITY (1,1) ,
	Fecha                datetime  NULL ,
	Hora                 datetime  NULL ,
	FechaRegistro        datetime  NULL ,
	Id_Paciente          int  NULL ,
	Id_Doctor            int  NULL ,
	Estado               char(18)  NULL 
)
go


ALTER TABLE Cita
	ADD CONSTRAINT XPKCita PRIMARY KEY (Id_Cita ASC)
go


CREATE TABLE Consulta
(
	Id_Consulta          int IDENTITY (1,1) ,
	Id_Paciente          int  NULL ,
	Id_Doctor            int  NULL ,
	Fecha                datetime  NULL ,
	Hora                 datetime  NULL ,
	FechaRegistro        datetime  NULL 
)
go


ALTER TABLE Consulta
	ADD CONSTRAINT XPKConsulta PRIMARY KEY (Id_Consulta ASC)
go


CREATE TABLE DetalleHorario
(
	Dia                  char(18)  NULL ,
	HoraInicio           char(18)  NULL ,
	HoraFin              char(18)  NULL ,
	Id_DetalleHorario    char(18)  NOT NULL ,
	Id_Horario           char(18)  NULL 
)
go


ALTER TABLE DetalleHorario
	ADD CONSTRAINT XPKDetalleHorario PRIMARY KEY (Id_DetalleHorario ASC)
go


CREATE TABLE Diagnóstico
(
	Id_Diagnostico       int IDENTITY (1,1) ,
	Id_Cie10             int  NULL ,
	Descripcion          varchar(1000)  NULL ,
	FechaRegistro        datetime  NULL 
)
go


ALTER TABLE Diagnóstico
	ADD CONSTRAINT XPKDiagnóstico PRIMARY KEY (Id_Diagnostico ASC)
go


CREATE TABLE Doctor
(
	Id_Doctor            int  NOT NULL ,
	CMP                  varchar(5)  NULL ,
	IndicadorHC          char(1)  NULL ,
	Id_AreaMedica        int  NULL 
)
go


ALTER TABLE Doctor
	ADD CONSTRAINT XPKDoctor PRIMARY KEY (Id_Doctor ASC)
go


CREATE TABLE Domicilio
(
	Id_Domicilio         int IDENTITY (1,1) ,
	Departamento         varchar(40)  NULL ,
	Provincia            varchar(40)  NULL ,
	Distrito             varchar(40)  NULL ,
	Direccion            varchar(200)  NULL 
)
go


ALTER TABLE Domicilio
	ADD CONSTRAINT XPKDomicilio PRIMARY KEY (Id_Domicilio ASC)
go


CREATE TABLE EnfermedadActual
(
	Id_EnfermedadActual  int IDENTITY (1,1) ,
	TiempoEnfermedad     varchar(3)  NULL ,
	InicioEnfermedad     varchar(300)  NULL ,
	CursoEnfermedad      varchar(300)  NULL ,
	SintomasPrincipales  varchar(1000)  NULL ,
	RelatoCronologico    varchar(1000)  NULL 
)
go


ALTER TABLE EnfermedadActual
	ADD CONSTRAINT XPKEnfermedadActual PRIMARY KEY (Id_EnfermedadActual ASC)
go


CREATE TABLE Enfermera
(
	Id_Enfermera         int  NOT NULL ,
	NumeroLicenciatura   varchar(10)  NULL ,
	Id_AreaMedica        int  NULL 
)
go


ALTER TABLE Enfermera
	ADD CONSTRAINT XPKEnfermera PRIMARY KEY (Id_Enfermera ASC)
go


CREATE TABLE Episodio
(
	Id_Episodio          int IDENTITY (1,1) ,
	Ectoscopia           varchar(1000)  NULL ,
	Id_Diagnostico       int  NULL ,
	Id_EnfermedadActual  int  NULL ,
	Id_FuncionesBiologicas char(18)  NULL ,
	Id_ExamenFisico      int  NULL ,
	FechaRegistro        char(18)  NULL ,
	DoctorRegistro       int  NULL 
)
go


ALTER TABLE Episodio
	ADD CONSTRAINT XPKEpisodio PRIMARY KEY (Id_Episodio ASC)
go


CREATE TABLE EpisodiosxHistoriaClinica
(
	Id_HistoriaClinica   int  NOT NULL ,
	Id_Episodio          int  NOT NULL 
)
go


ALTER TABLE EpisodiosxHistoriaClinica
	ADD CONSTRAINT XPKEpisodiosxHistoriaClinica PRIMARY KEY (Id_HistoriaClinica ASC,Id_Episodio ASC)
go


CREATE TABLE Especialidad
(
	Id_Especialidad      int IDENTITY (1,1) ,
	Descripcion          varchar(200)  NULL ,
	Nombre               varchar(30)  NOT NULL ,
	Estado               varchar(8)  NULL 
)
go


ALTER TABLE Especialidad
	ADD CONSTRAINT XPKEspecialidad PRIMARY KEY (Id_Especialidad ASC)
go


CREATE TABLE EspecialidadxDoctor
(
	Id_Doctor            int  NOT NULL ,
	Id_Especialidad      int  NOT NULL 
)
go


ALTER TABLE EspecialidadxDoctor
	ADD CONSTRAINT XPKEspecialidadxDoctor PRIMARY KEY (Id_Doctor ASC,Id_Especialidad ASC)
go


CREATE TABLE ExamenFisico
(
	Id_ExamenFisico      int IDENTITY (1,1) ,
	Temperatura          varchar(2)  NULL ,
	FrecuenciaCardiaca   varchar(3)  NULL ,
	Pulso                varchar(10)  NULL ,
	FrecuenciaRespiratoria varchar(10)  NULL ,
	PresionArterial      varchar(10)  NULL ,
	Peso                 varchar(5)  NULL ,
	Talla                varchar(5)  NULL ,
	OtrosExamenes        varchar(1000)  NULL 
)
go


ALTER TABLE ExamenFisico
	ADD CONSTRAINT XPKExamenFisico PRIMARY KEY (Id_ExamenFisico ASC)
go


CREATE TABLE FormularioHIS
(
	Id_FormularioHIS     int IDENTITY (1,1) ,
	Turno                char(18)  NULL ,
	Fecha                char(18)  NULL ,
	CodDepartamento      char(18)  NULL ,
	CodProvincia         char(18)  NULL ,
	CodDistrito          char(18)  NULL ,
	CodEstablecimiento   char(18)  NULL ,
	Especialidad         char(18)  NULL ,
	ResponsableAtencion  char(18)  NULL ,
	NumeroHC             char(18)  NULL ,
	CodDistritoProcedencia char(18)  NULL ,
	Edad                 char(18)  NULL ,
	Sexo                 char(18)  NULL ,
	Establecimiento      char(18)  NULL ,
	Servicio             char(18)  NULL ,
	Id_Cie10             int  NULL ,
	TipoDiagnostico      char(18)  NULL 
)
go


ALTER TABLE FormularioHIS
	ADD CONSTRAINT XPKFormularioHIS PRIMARY KEY (Id_FormularioHIS ASC)
go


CREATE TABLE FuncionesBiologicas
(
	Id_FuncionesBiologicas char(18)  NOT NULL ,
	Apetito              char(18)  NULL ,
	Sed                  char(18)  NULL ,
	Orina                char(18)  NULL ,
	Deposiciones         char(18)  NULL 
)
go


ALTER TABLE FuncionesBiologicas
	ADD CONSTRAINT XPKFuncionesBiologicas PRIMARY KEY (Id_FuncionesBiologicas ASC)
go


CREATE TABLE HistoriaClinica
(
	Id_HistoriaClinica   int IDENTITY (1,1) ,
	Id_Paciente          int  NOT NULL ,
	FechaRegistro        datetime  NOT NULL ,
	UsuarioCreacion      int  NOT NULL ,
	Numero               varchar(10)  NULL ,
	Id_Antecedentes      int  NULL 
)
go


ALTER TABLE HistoriaClinica
	ADD CONSTRAINT XPKHistoriaClinica PRIMARY KEY (Id_HistoriaClinica ASC)
go


CREATE TABLE Horario
(
	Id_Horario           char(18)  NOT NULL 
)
go


ALTER TABLE Horario
	ADD CONSTRAINT XPKHorario PRIMARY KEY (Id_Horario ASC)
go


CREATE TABLE LugarNacimiento
(
	Id_LugarNacimiento   int IDENTITY (1,1) ,
	Pais                 varchar(40)  NULL ,
	Departamento         varchar(40)  NULL ,
	Provincia            varchar(40)  NULL ,
	Distrito             varchar(40)  NULL 
)
go


ALTER TABLE LugarNacimiento
	ADD CONSTRAINT XPKLugarNacimiento PRIMARY KEY (Id_LugarNacimiento ASC)
go


CREATE TABLE Paciente
(
	Id_Paciente          int  NOT NULL ,
	Ocupacion            char(18)  NULL ,
	Raza                 char(18)  NULL ,
	Idioma               char(18)  NULL ,
	Religion             char(18)  NULL ,
	GrupoSanguineo       char(18)  NULL ,
	FactorSanguineo      char(18)  NULL 
)
go


ALTER TABLE Paciente
	ADD CONSTRAINT XPKPaciente PRIMARY KEY (Id_Paciente ASC)
go


CREATE TABLE PacientesAtendidos
(
	Id_PacientesAtendidos int IDENTITY (1,1) ,
	Id_Doctor            int  NOT NULL ,
	Id_Paciente          int  NOT NULL ,
	FechaRegistro        datetime  NOT NULL 
)
go


ALTER TABLE PacientesAtendidos
	ADD CONSTRAINT XPKPacientesAtendidos PRIMARY KEY (Id_PacientesAtendidos ASC)
go


CREATE TABLE Pais
(
	Id_Pais              int IDENTITY (1,1) ,
	Nombre               varchar(40)  NULL 
)
go


ALTER TABLE Pais
	ADD CONSTRAINT XPKPais PRIMARY KEY (Id_Pais ASC)
go


CREATE TABLE Perfil
(
	Id_Perfil            int IDENTITY (1,1) ,
	Nombre               varchar(30)  NOT NULL ,
	TipoPersonal         varchar(15)  NOT NULL ,
	Estado               varchar(8)  NULL 
)
go


ALTER TABLE Perfil
	ADD CONSTRAINT XPKPerfil PRIMARY KEY (Id_Perfil ASC)
go


CREATE TABLE Persona
(
	Id_Persona           int IDENTITY (1,1) ,
	Paterno              varchar(30)  NULL ,
	Materno              varchar(30)  NULL ,
	Nombres              varchar(60)  NULL ,
	Sexo                 char(1)  NULL ,
	Id_TipoDocumento     int  NULL ,
	Numero_Documento     varchar(20)  NULL ,
	EstadoCivil          varchar(10)  NULL ,
	Telefono             varchar(8)  NULL ,
	Celular              varchar(10)  NULL ,
	Email                varchar(60)  NULL ,
	Id_LugarNacimiento   int  NULL ,
	Id_Domicilio         int  NULL ,
	TipoPersona          varchar(8)  NULL ,
	FechaRegistro        char(18)  NULL ,
	FechaNacimiento      datetime  NULL 
)
go


ALTER TABLE Persona
	ADD CONSTRAINT XPKPersona PRIMARY KEY (Id_Persona ASC)
go


CREATE TABLE Personal
(
	Id_Personal          int  NOT NULL ,
	Usuario              varchar(20)  NULL ,
	Contrasena           varchar(20)  NULL ,
	Estado               varchar(8)  NULL ,
	TipoPersonal         varchar(14)  NULL ,
	Id_Horario           char(18)  NULL ,
	Id_Perfil            int  NULL 
)
go


ALTER TABLE Personal
	ADD CONSTRAINT XPKPersonal PRIMARY KEY (Id_Personal ASC)
go


CREATE TABLE Tecnico
(
	Id_Tecnico           int  NOT NULL ,
	Id_AreaMedica        int  NULL 
)
go


ALTER TABLE Tecnico
	ADD CONSTRAINT XPKTecnico PRIMARY KEY (Id_Tecnico ASC)
go


CREATE TABLE TipoDocumento
(
	Id_TipoDocumento     int IDENTITY (1,1) ,
	Nombre               varchar(30)  NULL ,
	Descripcion          varchar(100)  NULL ,
	NumeroDigitos        int  NULL ,
	Estado               varchar(8)  NULL 
)
go


ALTER TABLE TipoDocumento
	ADD CONSTRAINT XPKTipoDocumento PRIMARY KEY (Id_TipoDocumento ASC)
go


CREATE TABLE Ubigeo
(
	Id_Ubigeo            int IDENTITY (1,1) ,
	CodDepartamento      varchar(2)  NULL ,
	CodProvincia         varchar(2)  NULL ,
	CodDistrito          varchar(2)  NULL ,
	Descripcion          varchar(40)  NULL 
)
go


ALTER TABLE Ubigeo
	ADD CONSTRAINT XPKUbigeo PRIMARY KEY (Id_Ubigeo ASC)
go


CREATE TABLE Ventana
(
	Id_Ventana           int IDENTITY (1,1) ,
	Nombre               varchar(50)  NULL 
)
go


ALTER TABLE Ventana
	ADD CONSTRAINT XPKVentana PRIMARY KEY (Id_Ventana ASC)
go


CREATE TABLE VentanasxPerfil
(
	Id_Ventana           int  NOT NULL ,
	Id_Perfil            int  NOT NULL 
)
go


ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT XPKVentanasxPerfil PRIMARY KEY (Id_Ventana ASC,Id_Perfil ASC)
go



ALTER TABLE Administrativo
	ADD  FOREIGN KEY (Id_Administrativo) REFERENCES Personal(Id_Personal)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE Administrativo
	ADD CONSTRAINT R_38 FOREIGN KEY (Id_AreaAdministrativa) REFERENCES AreaAdministrativa(Id_AreaAdministrativa)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE AreaAdministrativa
	ADD  FOREIGN KEY (Id_AreaAdministrativa) REFERENCES Area(Id_Area)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go



ALTER TABLE AreaMedica
	ADD  FOREIGN KEY (Id_AreaMedica) REFERENCES Area(Id_Area)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go



ALTER TABLE Cita
	ADD CONSTRAINT R_40 FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Cita
	ADD CONSTRAINT R_41 FOREIGN KEY (Id_Doctor) REFERENCES Doctor(Id_Doctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Consulta
	ADD CONSTRAINT R_42 FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Consulta
	ADD CONSTRAINT R_43 FOREIGN KEY (Id_Doctor) REFERENCES Doctor(Id_Doctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE DetalleHorario
	ADD CONSTRAINT R_55 FOREIGN KEY (Id_Horario) REFERENCES Horario(Id_Horario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Diagnóstico
	ADD CONSTRAINT R_44 FOREIGN KEY (Id_Cie10) REFERENCES Cie10(Id_Cie10)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Doctor
	ADD  FOREIGN KEY (Id_Doctor) REFERENCES Personal(Id_Personal)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE Doctor
	ADD CONSTRAINT R_31 FOREIGN KEY (Id_AreaMedica) REFERENCES AreaMedica(Id_AreaMedica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Enfermera
	ADD  FOREIGN KEY (Id_Enfermera) REFERENCES Personal(Id_Personal)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE Enfermera
	ADD CONSTRAINT R_36 FOREIGN KEY (Id_AreaMedica) REFERENCES AreaMedica(Id_AreaMedica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Episodio
	ADD CONSTRAINT R_45 FOREIGN KEY (Id_Diagnostico) REFERENCES Diagnóstico(Id_Diagnostico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Episodio
	ADD CONSTRAINT R_49 FOREIGN KEY (Id_EnfermedadActual) REFERENCES EnfermedadActual(Id_EnfermedadActual)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Episodio
	ADD CONSTRAINT R_50 FOREIGN KEY (Id_FuncionesBiologicas) REFERENCES FuncionesBiologicas(Id_FuncionesBiologicas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Episodio
	ADD CONSTRAINT R_51 FOREIGN KEY (Id_ExamenFisico) REFERENCES ExamenFisico(Id_ExamenFisico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Episodio
	ADD CONSTRAINT R_52 FOREIGN KEY (DoctorRegistro) REFERENCES Doctor(Id_Doctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE EpisodiosxHistoriaClinica
	ADD CONSTRAINT R_22 FOREIGN KEY (Id_HistoriaClinica) REFERENCES HistoriaClinica(Id_HistoriaClinica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE EpisodiosxHistoriaClinica
	ADD CONSTRAINT R_23 FOREIGN KEY (Id_Episodio) REFERENCES Episodio(Id_Episodio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE EspecialidadxDoctor
	ADD CONSTRAINT R_63 FOREIGN KEY (Id_Doctor) REFERENCES Doctor(Id_Doctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE EspecialidadxDoctor
	ADD CONSTRAINT R_64 FOREIGN KEY (Id_Especialidad) REFERENCES Especialidad(Id_Especialidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE FormularioHIS
	ADD CONSTRAINT R_60 FOREIGN KEY (Id_Cie10) REFERENCES Cie10(Id_Cie10)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_19 FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_20 FOREIGN KEY (UsuarioCreacion) REFERENCES Personal(Id_Personal)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE HistoriaClinica
	ADD CONSTRAINT R_68 FOREIGN KEY (Id_Antecedentes) REFERENCES Antecedentes(Id_Antecedentes)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Paciente
	ADD  FOREIGN KEY (Id_Paciente) REFERENCES Persona(Id_Persona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go



ALTER TABLE PacientesAtendidos
	ADD CONSTRAINT R_25 FOREIGN KEY (Id_Doctor) REFERENCES Doctor(Id_Doctor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE PacientesAtendidos
	ADD CONSTRAINT R_26 FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Persona
	ADD CONSTRAINT R_15 FOREIGN KEY (Id_TipoDocumento) REFERENCES TipoDocumento(Id_TipoDocumento)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Persona
	ADD CONSTRAINT R_16 FOREIGN KEY (Id_LugarNacimiento) REFERENCES LugarNacimiento(Id_LugarNacimiento)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Persona
	ADD CONSTRAINT R_17 FOREIGN KEY (Id_Domicilio) REFERENCES Domicilio(Id_Domicilio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Personal
	ADD  FOREIGN KEY (Id_Personal) REFERENCES Persona(Id_Persona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE Personal
	ADD CONSTRAINT R_57 FOREIGN KEY (Id_Horario) REFERENCES Horario(Id_Horario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Personal
	ADD CONSTRAINT R_67 FOREIGN KEY (Id_Perfil) REFERENCES Perfil(Id_Perfil)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Tecnico
	ADD  FOREIGN KEY (Id_Tecnico) REFERENCES Personal(Id_Personal)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE Tecnico
	ADD CONSTRAINT R_37 FOREIGN KEY (Id_AreaMedica) REFERENCES AreaMedica(Id_AreaMedica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT R_65 FOREIGN KEY (Id_Ventana) REFERENCES Ventana(Id_Ventana)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE VentanasxPerfil
	ADD CONSTRAINT R_66 FOREIGN KEY (Id_Perfil) REFERENCES Perfil(Id_Perfil)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

