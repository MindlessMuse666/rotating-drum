using UnityEngine;

namespace Sphere
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _countForSpawn = 5;

        private void Awake()
        {
            for (var i = 0; i < _countForSpawn; i++)
            {
                var newSphere = Instantiate(_prefab);
                newSphere.transform.position = new Vector3(Random.Range(-1f, 1f), Random.Range(3f, 4f), 0);
            }
        }
    }
}