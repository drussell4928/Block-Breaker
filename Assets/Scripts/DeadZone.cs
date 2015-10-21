using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

	void OnTriggerEnter (Collider coll)
	{
		GM.instance.LoseLife ();
	}
}
