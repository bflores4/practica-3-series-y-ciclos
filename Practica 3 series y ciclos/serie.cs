using System;

namespace Practica_3_series_y_ciclos
{
    class serie
    {
        private int _numRepeticiones;
        private int _valorDex;
        private double _suma;

        const double radianes = Math.PI / 180.00;

        public int numRepeticiones
        { get { return _numRepeticiones; } }

        public int valorDeX
        { get { return _valorDex; } }

        public double suma
        { get { return _suma; } }

        public serie()
        {
            _numRepeticiones = 0;
            _valorDex = 0;
            _suma = 0;
        }

        public serie (int numRepeticiones, int valorDeX ,int suma)
        {
            _numRepeticiones = numRepeticiones;
            _valorDex = valorDeX;
            _suma = suma;
        }

        private int factorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
                factorial *= i;
            return factorial;
        }

        private double elevarPotencia(int numero, int potencia)
        {return (Math.Pow(numero, potencia));}

        
        public double serieLogaritmoNatural(int x, int repeticiones)
        {
            double suma = 0;
            for (int posicion = 1; posicion <= repeticiones; posicion++)
            {
                    suma +=  (1.0/posicion)* Math.Pow(((x - 1.0) / x), posicion);
            }
            return suma;
        }
        

        public double serieSeno(int x, int repeticiones)
        {
            double suma = 0;
            for (int posicion = 1; posicion <= repeticiones; posicion++)
            {
                if ((posicion % 2) == 0)
                {
                    _suma -= elevarPotencia(x, (posicion*2)-1) / factorial((posicion * 2) - 1);
                }
                else
                {
                    _suma += elevarPotencia(x, (posicion * 2) - 1) / factorial((posicion * 2) - 1);
                }
            }
            return _suma * radianes;
        }

        public double serieCoseno(int x, int repeticiones)
        {
            _suma = 0;
            for(int posicion=0; posicion < repeticiones; posicion++)
            {
                if ((posicion % 2) == 0)
                {
                    _suma += elevarPotencia(x, posicion*2) / factorial(posicion*2);
                }
                else
                {
                    _suma -= elevarPotencia(x, posicion*2) / factorial(posicion*2);
                }
            }
            return _suma  * radianes;
        }

    }
}
