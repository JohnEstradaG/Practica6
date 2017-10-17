using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    [Table("DBPractica")]
    public class BaseDatos
    {

        string matricula;
        string nombre;
        string apellido_pat;
        string apellido_mat;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;

        // AGREGA ATRIBUTOS LLAVE PRIMARIA "se agregan mas atributos solo poniendo coma"
        [PrimaryKey, Unique, MaxLength(8)]
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        //AGREGA ATRIBUTOS A STRIGN DATO1 LIMITACION DE CARATERES

        [Column("Nombre"), MaxLength(20)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [Column("Apellido_Paterno"), MaxLength(20)]
        public string ApellidoPaterno
        {
            get { return apellido_pat; }
            set { apellido_pat = value; }
        }

        [Column("Apellido_Materno"), MaxLength(20)]
        public string ApellidoMaterno
        {
            get { return apellido_mat; }
            set { apellido_mat = value; }
        }

        [Column("Direccion"), MaxLength(50)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [Column("Telefono"), MaxLength(20)]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [Column("Carrera"), MaxLength(20)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [Column("Semestre"), MaxLength(20)]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [Column("Correo"), MaxLength(20)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [Column("Github"), MaxLength(20)]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }
    }
}