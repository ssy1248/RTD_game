using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRenderer;
	public Waypoints way;

	void Start()
	{
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetColors(Color.red, Color.yellow);
		lineRenderer.SetWidth(0.1f, 0.1f);

		//for (int i = 0; i <; i++)
		//{
		//	lineRenderer.SetPosition(i, points[i].position);
		//	lineRenderer.SetPosition(i + 1, points[i + 1].position);
		//}
	}


	void Update()
    {
        
    }
}
