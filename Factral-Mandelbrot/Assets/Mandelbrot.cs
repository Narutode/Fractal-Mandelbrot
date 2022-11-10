using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using Vector4 = UnityEngine.Vector4;

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

    Color SetColor(int value)
    {
        Vector4 CalcColor = new Vector4(0, 0, 0, 1f);

        if (value != maxIterations)
        {
            int colorNr = value % 16;

            switch (colorNr)
            {
                case 0:
                {
                    CalcColor[0] = 66f / 255f;
                    CalcColor[1] = 30f / 255f;
                    CalcColor[2] = 15f / 255f;
                    break;
                }
                case 1:
                {
                    CalcColor[0] = 25f / 255f;
                    CalcColor[1] = 7f / 255f;
                    CalcColor[2] = 26f / 255f;
                    break;
                }
                case 2:
                {
                    CalcColor[0] = 9f / 255f;
                    CalcColor[1] = 1f / 255f;
                    CalcColor[2] = 47f / 255f;
                    break;
                }
                case 3:
                {
                    CalcColor[0] = 4f / 255f;
                    CalcColor[1] = 4f / 255f;
                    CalcColor[2] = 73f / 255f;
                    break;
                }
                case 4:
                {
                    CalcColor[0] = 0f / 255f;
                    CalcColor[1] = 7f / 255f;
                    CalcColor[2] = 100f / 255f;
                    break;
                }
                case 5:
                {
                    CalcColor[0] = 12f / 255f;
                    CalcColor[1] = 44f / 255f;
                    CalcColor[2] = 138f / 255f;
                    break;
                }
                case 6:
                {
                    CalcColor[0] = 24f / 255f;
                    CalcColor[1] = 82f / 255f;
                    CalcColor[2] = 177f / 255f;
                    break;
                }
                case 7:
                {
                    CalcColor[0] = 57f / 255f;
                    CalcColor[1] = 125f / 255f;
                    CalcColor[2] = 209f / 255f;
                    break;
                }
                case 8:
                {
                    CalcColor[0] = 134f / 255f;
                    CalcColor[1] = 181f / 255f;
                    CalcColor[2] = 229f / 255f;
                    break;
                }
                case 9:
                {
                    CalcColor[0] = 211f / 255f;
                    CalcColor[1] = 236f / 255f;
                    CalcColor[2] = 248f / 255f;
                    break;
                }
                case 10:
                {
                    CalcColor[0] = 241f / 255f;
                    CalcColor[1] = 233f / 255f;
                    CalcColor[2] = 191f / 255f;
                    break;
                }
                case 11:
                {
                    CalcColor[0] = 248f / 255f;
                    CalcColor[1] = 201f / 255f;
                    CalcColor[2] = 95f / 255f;
                    break;
                }
                case 12:
                {
                    CalcColor[0] = 255f / 255f;
                    CalcColor[1] = 170f / 255f;
                    CalcColor[2] = 0f / 255f;
                    break;
                }
                case 13:
                {
                    CalcColor[0] = 204f / 255f;
                    CalcColor[1] = 128f / 255f;
                    CalcColor[2] = 0f / 255f;
                    break;
                }
                case 14:
                {
                    CalcColor[0] = 153f / 255f;
                    CalcColor[1] = 87f / 255f;
                    CalcColor[2] = 0f / 255f;
                    break;
                }
                case 15:
                {
                    CalcColor[0] = 106f / 255f;
                    CalcColor[1] = 52f / 255f;
                    CalcColor[2] = 3f / 255f;
                    break;
                }
            }
        }

        return CalcColor;
    }
}
