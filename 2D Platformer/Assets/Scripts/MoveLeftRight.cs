using UnityEngine;
using System.Collections;

public class MoveLeftRight : MonoBehaviour 
{
	public float speed = 1.0f;
	public string axisName = "Horizontal";

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.deltaTime;
	}
}
