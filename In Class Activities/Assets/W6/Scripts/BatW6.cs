using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    private bool enable;

    public void BatStop()
    {
        enable = false;
    }

    public void BatGo(Transform _playerPosition)
    {
        enable true;
        _player = _playerPosition;
    }

    private void Start()
    {
        enable = false;
    }

    private void Update()
    {
        if(enable)
        {
            transform.position = Vector3.MoveTowards(trasnform.position, _player.position, _speed * Time.deltaTime)
        }
    }
}
