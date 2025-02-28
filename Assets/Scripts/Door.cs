using UnityEngine;

public class DoorEnabler: MonoBehaviour
{
	[SerializeField] GameObject Door;

	private void OnTriggerEnter(Collider other)
	{
		Door.SetActive(true);
	}
}
