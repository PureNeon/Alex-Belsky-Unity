using UnityEngine;



public class Scaling : MonoBehaviour
{
	[SerializeField] float min;
	[SerializeField] float max;
	[SerializeField] float speed;

	bool plus = false;

	Transform tr;

	public void Start()
	{
		tr = GetComponent<Transform>();
	}

	public void Update()
	{
		if (tr.localScale.x != tr.localScale.z) { tr.localScale = new Vector3(tr.localScale.x, 0.1f, tr.localScale.x); }

		if (tr.localScale.x > max) { plus = false; }
		if (tr.localScale.x < min) { plus = true; }

		if (plus) { tr.localScale += new Vector3(0.1f, 0, 0.1f) * speed; }
		else { tr.localScale -= new Vector3(0.1f, 0, 0.1f) * speed; }
	}
}
