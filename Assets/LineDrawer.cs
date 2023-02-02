using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{

    [SerializeField] private LineRenderer _leftSideLineRenderer;
    [SerializeField] private LineRenderer _rightSideLineRenderer;

    [SerializeField] private Transform[] _leftSidePoints;
    [SerializeField] private Transform[] _rightSidePoints;

    private void Update()
    {
        SetLinePosition(_leftSideLineRenderer, _leftSidePoints);
        SetLinePosition(_rightSideLineRenderer, _rightSidePoints);
    }

    private void SetLinePosition(LineRenderer line, Transform[] points)
    {
        Vector3 p1 = points[0].position;
        Vector3 p2 = points[1].position;

        p1.z = 0f;
        p2.z = 0f;

        line.SetPosition(0, p1);
        line.SetPosition(1, p2);
    }
}
