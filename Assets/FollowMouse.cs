using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
	public float distance = 9.0f;
    public float xBord;
    public float yBord;
    private float freezzZ = -1f;
	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
        if (Input.GetMouseButton(0))
        {
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = distance;
			transform.position = Vector3.Lerp(transform.position, Camera.main.ScreenToWorldPoint(mousePosition), 0.05f);
            Debug.Log(mousePosition);
        }

        //if(transform.position.x < -xBord)
        //    {
        //    Input.GetMouseButtonUp(0);
        //}
        //if (transform.position.x > xBord)
        //{
        //    Input.GetMouseButtonUp(0);
        //}
        //if (transform.position.y < -yBord)
        //{
        //    Input.GetMouseButtonUp(0);
        //}
        //if (transform.position.y > yBord)
        //{
        //    Input.GetMouseButtonUp(0);
        //}

        if (transform.position.x < -xBord)
        {
            transform.position = new Vector3(-xBord, transform.position.y, freezzZ);
        }
        if (transform.position.x > xBord)
        {
            transform.position = new Vector3(xBord, transform.position.y, freezzZ);
        }
        if (transform.position.y < -yBord)
        {
            transform.position = new Vector3(transform.position.x, -yBord, freezzZ);
        }
        if (transform.position.y > yBord)
        {
            transform.position = new Vector3(transform.position.x, yBord, freezzZ);
        }
    }
}