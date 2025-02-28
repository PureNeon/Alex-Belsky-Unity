using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] float _fireForce;
    [SerializeField] float _timer;
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _offset;
	[SerializeField] int _boostEveryNShoot;

	private float _delay;
    private float fireCount = 0;

	private void Start()
	{
        //Костыль. Когда счётчик равен 0, сила выстрела занижается в 2 раза, но если выставлять счётчик выше -1, то в первом цикле усиление выстрела произойдёт раньше чем N.
		_fireForce *= 2;
	}

	private void Update()
    {
        //Усиление каждого N-его выстрела выстрела.
		if (fireCount == _boostEveryNShoot)
        {
            fireCount = -1;
            _fireForce *= 2;
        }

        if (_delay <= 0)
        {
            var GO = Instantiate(_prefab, _offset.position, _offset.rotation);
            GO.GetComponent<Rigidbody>().AddForce(GO.transform.forward * _fireForce, ForceMode.Impulse);
            _delay = _timer;
			
			if (fireCount == 0)
            {
                _fireForce /= 2;
            }

			fireCount++;
		}
        _delay -= Time.deltaTime;

	}
}
