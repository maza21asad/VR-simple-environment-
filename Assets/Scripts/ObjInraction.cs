using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInraction : MonoBehaviour
{
    public float degreePerSecond;
	private int RotateDirection = 1;
	//Color LightBlue = new Color(0.098f, 0.612f, 0.973f);
	Color OriginalColor;
	
    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateDirection * degreePerSecond * Time.deltaTime, 0);
    }
	
	public void TeleportA()
	{
		Vector3 newPos1;
		newPos1 = new Vector3(Random.Range(-1f,-14f), Random.Range(1f,8f), Random.Range(-4f,4f));
		transform.position = newPos1;
		
	}
	
	public void TeleportB()
	{
		Vector3 newPos2;
		newPos2 = new Vector3(Random.Range(-16f,-24f), Random.Range(1f,8f), Random.Range(-4f,4f));
		transform.position = newPos2;
		
	}
	
	public void TeleportCylinder()
	{
		Vector3 newPos3;
		newPos3 = new Vector3(-20f,1f,10f);
		transform.position = newPos3;
	}
	
	
	public void ChangeDirection()
	{
		RotateDirection = -1;
		degreePerSecond = degreePerSecond * 2;
		//GetComponent<Renderer>().material.color = Color.yellow;
	}
	
	public void RevertDirection()
	{
		RotateDirection = 1;
		degreePerSecond = degreePerSecond / 2;
		GetComponent<Renderer>().material.color = OriginalColor;
	}
}
