using UnityEngine;
using System.Collections;

public class cursorType : MonoBehaviour {

/**********************************************
Attach this script to a sphere or  some object.
Make sure the object has a collider on it.
Then move the mouse to the object and away from it. 
That's how the functions work.
************************************************/

    //kljdjklafodfjmkfdsl;jfsdljdso

	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
	}

	void OnMouseExit()
	{
		renderer.material.color = Color.yellow;
	}
}
