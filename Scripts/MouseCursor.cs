using UnityEngine;
using System.Collections;

public class MouseCursor : MonoBehaviour {

	private int cursorWidth = 32;
	private int cursorHeight = 32;
	public Texture2D cursorImage;
	
	void Start()
	{
		Screen.showCursor = false;
	}
	
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
	}
}
