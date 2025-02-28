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
        //�������. ����� ������� ����� 0, ���� �������� ���������� � 2 ����, �� ���� ���������� ������� ���� -1, �� � ������ ����� �������� �������� ��������� ������ ��� N.
		_fireForce *= 2;
	}

	private void Update()
    {
        //�������� ������� N-��� �������� ��������.
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
