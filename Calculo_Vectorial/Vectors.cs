using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculo_Vectorial
{
    internal class Vectors
    {
        //suma de vectores de n dimensiones
        public float[] addition(float[] _vector1, float[] _vector2)
        {
            int n1 = _vector1.Length;
            int n2 = _vector2.Length;

            if (n1 != n2)
            {
                return null;
            }

            float[] vector3 = new float[n1];
            for (int i = 0; i < n1; i++)
            {
                vector3[i] = _vector1[i] + _vector2[i];
            }

            return vector3;
        }

        public float[] additionV(float[] _vector1, float[] _vector2, float[] _vector3)
        {
            int n1 = _vector1.Length;
            int n2 = _vector2.Length;
            int n3 = _vector3.Length;

            if (n1 != n2 )
            {
                return null;
            }
            float[] vector4 = new float[n1];
            for (int i = 0; i < n1; i++)
            {
                vector4[i] = _vector1[i] + _vector2[i] + _vector3[i];
            }

            return vector4;
        }

        //resta de vectores de n dimensiones 
        public float[] subtraction(float[] _vector1, float[] _vector2)
        {
            int n1 = _vector1.Length;
            int n2 = _vector2.Length;

            if (n1 != n2)
            {
                return null;
            }
            float[] vector3 = new float[n1];
            for (int i = 0; i < n1; i++)
            {
                vector3[i] = _vector1[i] - _vector2[i];
            }

            return vector3;
        }


        //declaracion de errores en booleano 
        public bool mistake;

        //producto punto de vectores 
        public float ProductP(float[] _vector1, float[] _vector2)
        {
            int n1 = _vector1.Length;
            int n2 = _vector2.Length;

            if (n1 != n2)
            {
                mistake = true;
                return 0;
            }

            float ProPoint = 0;
            for (int i = 0; i < n1; i++)
            {
                ProPoint  += _vector1[i] * _vector2[i];
            }
            mistake = false;
            return ProPoint;
        }

    }
}
