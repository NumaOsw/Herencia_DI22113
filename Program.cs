using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    //Definicion de atributos
    //Atributos de definicion ninguno
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso        tipo de dato          nombre de dato
        protected               int                     valor1;
        protected               int                      valor2;
        protected               int                     resultado;

        //comentsario desde web
        public int Valor1 //Caja de memoria
        {
            get { return valor1; } //vamos por el valor
            set { valor1 = value; }// de la caja de texto, lo guardamos en memoria
        }
        public int Valor2 //Caja de memoria
        {
            get { return valor2; } //vamos por el valor
            set { valor2 = value; }// de la caja de texto, lo guardamos en memoria
        }
        public int Resultado //Caja de memoria
        {
            get { return resultado; } //vamos por el valor
            set { resultado = value; }// de la caja de texto, lo guardamos en memoria
        }
    }
    //esto es un comentario nuevo 26 de abril
    //esto es un segunod comentario nuevo 26 de abril

    // Metodos o funciones de operaciones
    /*Metodos a continuacion
     * son funciones para obtener
     * de la caja de la variable indicada
     * memoria dentro de la variable indicada*/
    // *********************************************//
    //Creamos a los hijos, metodos de crear datos
    class Suma : operacion //Los : nos permiten usar
                           //Lo que tiene la operacion
    {
        /* Las clases hijas tambien pueden tener sus propios atributos y metodos pueden
         * tener variables de usos solamente para la clase hijo declarar variables
         * de esta clase, atributos de esta clase, metodos de clase*/
        public int operacion(int v1, int v2)
        {
            valor1 = v1; //Accedemos al contructor
            valor2 = v2;
            return resultado = valor1 + valor1;
        }
     }
    class Restar : operacion
    {
        public int operacion(int v1, int v2)
        {
            valor1 = v1; //Accedemos al contructor
            valor2 = v2;
            return resultado = valor1 - valor1;
        }

    }
    class Multiplicacion : operacion
    {
        public int operacion(int v1, int v2)
        {
            valor1 = v1; //Accedemos al contructor
            valor2 = v2;
            return resultado = valor1 * valor1;
        }

    }



    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
