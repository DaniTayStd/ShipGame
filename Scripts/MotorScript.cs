using UnityEngine;
using System.Collections;

public class MotorScript : MonoBehaviour {

	public float speed = 50.0f;


	//private float rotation = 2.0f;

	// Use this for initialization
	void Start () {
		Debug.Log (speed);
	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log ("Speed Increased: " + speed);

		//Mauricio: Increase Speed
		if(Input.GetKeyDown(KeyCode.W))
		{

			speed++;
			speed = speed * Time.time;

		}
		else //once W is released, the speed will decrease back to regular
		{

			if(speed <= 50.0f)//increase speed if too slow
			{
				speed++;
			}
			if (speed >= 300.0f)//keeps speed less than 300
			{
				speed = 300.0f;
			}
		}

		//Mauricio Decrease Speed
		if(Input.GetKeyDown (KeyCode.S))
		{
			speed--;
			speed = speed / Time.time;
		}
		else//once S is released, the speed will increase back to regular
		{

			if(speed >= 50.0f )
			{
				speed--;
			}
		}

		//Mauricio: Plane Pitch Left/Right
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("Turning Left: ");
			transform.Rotate(transform.position,-LeftPitch);
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			Debug.Log("Turning Right: ");
			transform.Rotate(transform.position,RightPitch);
		}

	}

	void FixedUpdate() {

		transform.Translate(0,0,speed *Time.deltaTime);
	}

	void Rotation() {
		/*
		relPos = fEnemy.transform.position - transform.position;
		relPos.y = 0;
		Quaternion targetRotation = Quaternion.LookRotation(relPos);
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed);
		
		relPos2 = fEnemy.transform.position - turretSpawn.transform.position;
		Quaternion targetRotation2 = Quaternion.LookRotation(relPos2);
		turretSpawn.transform.rotation = Quaternion.Lerp(turretSpawn.transform.rotation, targetRotation2, Time.deltaTime * rotSpeed);
		*/
	}
}
