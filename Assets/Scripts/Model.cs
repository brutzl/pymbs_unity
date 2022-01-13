using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathNet.Numerics.LinearAlgebra;


/// <summary>
/// Wie kann so ein Modell aussehen?
/// </summary>
public class Model : object
{
    public Matrix<double> T_visual_1;
    public Vector<double> r_visual_1;

    public int Visuals(Vector<double> y)
    {
        return 0;
    }


    public int DerState()
    {
        return 0;
    }


    public int Sensors()
    {
        return 0;
    }
}
