using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigatorMovement : MonoBehaviour
{
	public static NavigatorMovement instance = null;

    private Transform target;

    [HideInInspector]
    private float moveSpeed = 20f;
	private int wavepointIndex = 0;

	public bool IsEnd = false;

	public bool End { get { return IsEnd; } }

    void Awake()
    {
		if (instance != null)
		{
			Debug.LogError("More than one NavigatorMoveMent in scene!");
			return;
		}
		instance = this;
	}

    void Start()
    {
        target = Waypoints.points[0];
    }

	void Update()
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 0.4f)
		{
			GetNextWaypoint();
		}

	}

	void GetNextWaypoint()
	{
		if (wavepointIndex >= Waypoints.points.Length - 1)
		{
			EndPath();
			return;
		}

		wavepointIndex++;
		target = Waypoints.points[wavepointIndex];
	}

	void EndPath()
	{
		IsEnd = true;
		Destroy(gameObject);
	}
}
