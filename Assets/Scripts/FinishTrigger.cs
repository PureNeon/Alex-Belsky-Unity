using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
	private float Timer = 0;

	private void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent<PlayerMovement>(out _))
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			SceneManager.LoadScene(0);
		}
	}
}
