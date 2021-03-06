using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
	public float speed = 1f;

    void Update()
    {
		float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		transform.Translate(horizontal, vertical, 0f);
	}
	void OnTriggerEnter2D()
	{

		Destroy(gameObject);
	}
}
