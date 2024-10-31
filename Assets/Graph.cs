using System;
using UnityEngine;

public class Graph : MonoBehaviour
{
    int orderInLayer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrawGrid(1, 100, Color.gray, 0.03f);
        DrawAxis();

        //DrawFunctionGraph((x) => x, -30, 30, 0.1f, new Color(0.25f, 0.25f, 0.25f), 0.2f, false);
        //DrawFunctionGraph(Square, 0, 10, 0.1f, new Color(1, 0.5f, 0), 0.1f, false);
        //DrawFunctionGraph(LineEquation, -10, 10, 0.1f, new Color(1, 0.5f, 0), 0.1f, false);
        //DrawFunctionGraph(LineEquation2, -10, 10, 0.1f, new Color(0.5f, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Square2, -10, 10, 0.1f, new Color(0.5f, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Sqrt, 0, 10, 0.1f, new Color(0.5f, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Fusion, -10, 10, 0.02f, new Color(1, 0, 0), 0.1f, false);
        //DrawFunctionGraph(Fusion2, -10, 10, 0.02f, new Color(1, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Circle1, -1f, 1f, 0.01f, new Color(1, 0, 0), 0.1f, false);
        //DrawFunctionGraph(Circle2, -1f, 1f, 0.01f, new Color(1, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Mathf.Sin, -15, 15, 0.01f, new Color(1, 0, 1), 0.1f, false);
        //DrawFunctionGraph(Mathf.Cos, -15, 15, 0.01f, new Color(1, 1, 0), 0.1f, false);
        //DrawFunctionGraph(Exponential, -4f, 4, 0.01f, new Color(1f, 0.5f, 0), 0.2f, false);
        //DrawFunctionGraph(Logarithm, 0.01f, 30, 0.01f, new Color(0.5f, 1f, 0), 0.2f, false);
        //DrawFunctionGraph((x)=>x*Mathf.Log(x), 0.01f, 30, 0.01f, new Color(0.5f, 1f, 0), 0.2f, false);
        //DrawFunctionGraph((x)=>x*x, 0.01f, 30, 0.01f, new Color(0.5f, 1f, 0), 0.2f, false);
        //DrawFunctionGraph(RandomCurve, 0, Mathf.PI * 5, 0.01f, new Color(0.5f, 1f, 0), 0.05f);
        //DrawPoint(new Vector2(1, 2), Color.red);
        //DrawPoint(new Vector3(4, 5), Color.blue);

        //DrawPoint(Vector2.Lerp(new Vector2(1, 2), new Vector2(4, 5), -1), Color.magenta);
        //DrawPoint(Vector2.Lerp(new Vector2(1, 2), new Vector2(4, 5), 2), Color.magenta);
        //DrawFunctionGraph(ArithmeticSequence, 1, 100, 1, Color.red, 0.5f, true);
        //DrawFunctionGraph(SumOfArithmeticSequence, 1, 100, 1, Color.magenta, 0.5f, true);
        //DrawFunctionGraph(GeometricSequence1, 1, 100, 1, Color.blue, 0.5f, true);
        //DrawFunctionGraph(SumOfGeometricSequence1, 1, 100, 1, Color.cyan, 0.5f, true);
        //DrawFunctionGraph(GeometricSequence2, 1, 100, 1, Color.green, 0.5f, true);
        //DrawFunctionGraph(SumOfGeometricSequence2, 1, 100, 1, Color.yellow, 0.5f, true);
        //Vector2 v1 = new Vector2(3, 2);
        //Vector2 v2 = new Vector2(1, 4);

        //DrawLine(Vector2.zero, v1, Color.red);
        //DrawLine(Vector2.zero, v2, Color.red);

        //Vector2 v3 = v1+ v2;

        //DrawLine(Vector2.zero, v3, Color.blue);

        //Vector2 v4 = v1 - v2;

        //DrawLine(Vector2.zero, v4, Color.black);

        //Vector2 v5 = 2 * v1;

        //DrawLine(Vector2.zero, v5, Color.magenta);

        DrawLine(Vector2.zero, Vector2.up, Color.cyan);
        DrawLine(Vector2.zero, Vector2.right, Color.blue);

    }

    float GeometricSequence1(float n)
    {
        return Mathf.Pow(1.1f, n-1); 
    }

    float SumOfGeometricSequence1(float n)
    {
        return (1 - Mathf.Pow(1.1f, n)) / (1 - 1.1f);
    }

    float GeometricSequence2(float n)
    {
        return Mathf.Pow(0.9f, n - 1);
    }

    float SumOfGeometricSequence2(float n)
    {
        return (1 - Mathf.Pow(0.9f, n)) / (1 - 0.9f);
    }

    float ArithmeticSequence(float n)
    {
        return 1.1f * n;
    }

    float SumOfArithmeticSequence(float n)
    {
        return n * (n + 1) * 1.1f / 2;
    }

    Vector2 RandomCurve(float t)
    {
        float x = Mathf.Cos(t) * t;
        float y = Mathf.Sin(t) * t;
        return new Vector2(x, y);
    }

    float Exponential(float x)
    {
        return Mathf.Pow(2, x);
    }

    float Logarithm(float x)
    {
        return Mathf.Log(x);
    }

    float Circle1(float x)
    {
        return Mathf.Sqrt(1 - x * x);
    }

    float Circle2(float x)
    {
        return -Mathf.Sqrt(1 - x * x);
    }

    float Sin(float x)
    {
        return Mathf.Sin(x);
    }

    float Fusion(float x)
    {
        return Sin(Square(x));
    }

    float Fusion2(float x)
    {
        return Square(Sin(x));
    }

    float LineEquation(float x)
    {
        return 1f / 2 * x - 2;
    }

    float LineEquation2(float x)
    {
        return 1f / 2 * (x - 2) - 2;
    }

    float Square(float x)
    {
        return x * x;
    }

    float Sqrt(float x)
    {
        return Mathf.Sqrt(x);
    }

    float Square2(float x)
    {
        x -= 3;
        return x * x - 2;
    }

    float ThirdRandomFunc(float x)
    {
        return 1f / 3 * x * x * x - 2 * x * x - 1 * x + 2;
    }

    #region
    void DrawAxis()
    {
        DrawLine(new Vector3(-100, 0, 0), new Vector3(100, 0, 0), Color.red, 0.1f);
        DrawLine(new Vector3(0, -100, 0), new Vector3(0, 100, 0), Color.green, 0.1f);
    }

    void DrawGrid(float gridSize, int gridCount, Color color, float thickness)
    {
        for (int i = -gridCount; i <= gridCount; i++)
        {
            float t = thickness;
            if (i % 5 == 0)
            {
                t *= 2;
            }
            DrawLine(new Vector3(i * gridSize, -gridCount * gridSize),
                new Vector3(i * gridSize, gridCount * gridSize),
                color, t);
            DrawLine(new Vector3(-gridCount * gridSize, i * gridSize),
                new Vector3(gridCount * gridSize, i * gridSize),
                color, t);
        }
    }

    void DrawPoint(Vector3 position, Color color, float size = 0.15f)
    {
        GameObject point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        point.transform.position = position;
        point.transform.localScale = new Vector3(size, size, size);
        Renderer renderer = point.GetComponent<Renderer>();
        renderer.material.color = color;
        // renderer.sortingOrder = orderInLayer; // 없어도 선 위에 나타남
        // orderInLayer++;
    }

    void DrawLine(Vector3 start, Vector3 end, Color color, float thickness = 0.05f)
    {
        GameObject lineObj = new GameObject("Line");
        LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, end);
        lineRenderer.startWidth = thickness;
        lineRenderer.endWidth = thickness;
        lineRenderer.material.color = color;
        lineRenderer.sortingOrder = orderInLayer;
        orderInLayer++;
    }

    void DrawFunctionGraph(Func<float, float> function, float start, float end, float step, Color color, float thickness, bool usePoint)
    {
        if (usePoint)
        {
            for (float i = start; i <= end; i += step)
            {
                float y = function(i);
                DrawPoint(new Vector3(i, y, 0), color, thickness);
            }
        }
        else
        {
            int pointCount = Mathf.CeilToInt((end - start) / step);

            GameObject lineObj = new GameObject("FunctionGraph");
            LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

            lineRenderer.startWidth = thickness;
            lineRenderer.endWidth = thickness;
            lineRenderer.material.color = color;
            lineRenderer.sortingOrder = orderInLayer;
            orderInLayer++;
            int index = 0;
            for (float i = start; i <= end; i += step)
            {
                lineRenderer.positionCount = index + 1;
                float y = function(i);
                lineRenderer.SetPosition(index, new Vector3(i, y, 0));
                index++;
            }
        }
    }

    void DrawFunctionGraph(Func<float, Vector2> function, float start, float end, float step, Color color, float thickness, bool usePoint = false)
    {
        int pointCount = Mathf.CeilToInt((end - start) / step);

        GameObject lineObj = new GameObject("FunctionGraph");
        LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

        lineRenderer.startWidth = thickness;
        lineRenderer.endWidth = thickness;
        lineRenderer.material.color = color;
        lineRenderer.sortingOrder = orderInLayer;
        orderInLayer++;
        int index = 0;
        for (float i = start; i <= end; i += step)
        {
            lineRenderer.positionCount = index + 1;
            Vector2 p = function(i);
            lineRenderer.SetPosition(index, p);
            index++;
        }
    }
    #endregion
}
