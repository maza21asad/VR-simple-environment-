using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObj : MonoBehaviour
{
    public GameObject ObjectToGrab;
	public GameObject myHand;
	bool isOnHand = false;
	Vector3 objPos;
	Color OriginalColor;
	
    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = ObjectToGrab.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Fire1"))
		{
			if (!isOnHand)	//Grab action
			{
				ObjectToGrab.transform.SetParent(myHand.transform);
				ObjectToGrab.transform.localPosition = myHand.transform.localPosition;
				ObjectToGrab.GetComponent<Renderer>().material.color = Color.yellow;
				isOnHand = true;
			}
			else if (isOnHand)	//Release action
			{
				objPos = ObjectToGrab.transform.position;
				ObjectToGrab.transform.SetParent(null);
				ObjectToGrab.transform.localPosition = objPos;
				ObjectToGrab.GetComponent<Renderer>().material.color = OriginalColor;
				this.GetComponent<HoldObj>().enabled = false;
				isOnHand = false;
			}
		}
    }
}
