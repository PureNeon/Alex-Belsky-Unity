using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class Rotating : MonoBehaviour
{
    [SerializeField] float RotateSpeed;
	Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
    {
        rb.angularVelocity = new Vector3(0,1,0) * RotateSpeed * Time.deltaTime;
    }
}

