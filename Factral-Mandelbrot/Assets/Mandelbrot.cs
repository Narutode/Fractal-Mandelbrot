using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Mandelbrot : MonoBehaviour
{
    double height, width;

    private double rStart, iStart;
    
    private int maxIterations;

    private int zoom;

    private Texture2D display;

    public Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        width = 4.5;
        height = width * (Screen.height / Screen.width);
        rStart = -2.0;
        iStart = -1.25;
        zoom = 10;
        maxIterations = 100;
        display = new Texture2D(Screen.width, Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MandelbrotFunction(double x, double y)
    {
        int iteration = 0;
        Complex z = new Complex(0, 0);

        for (int i = 0; i != maxIterations; i++)
        {
            z = z * z + new Complex(x, y);

            if (Complex.Abs(z) > 2)
            {
                break;
            }
            else
            {
                iteration++;
            }
        }

        return iteration;
    }
}
