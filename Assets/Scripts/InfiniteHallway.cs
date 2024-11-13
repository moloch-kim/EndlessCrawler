using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class InfiniteHallway : MonoBehaviour
{
    public ObjectPool pool;
    public float spawnRate;

    void Start()
    {
        StartCoroutine(CoSpawnObjects());
    }

    IEnumerator CoSpawnObjects()
    {
        while (GameManager.Instance.isExplore)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnObject()
    {
        GameObject obj = pool.GetObject();

        if (obj != null)
        {
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, +transform.position.z + 6f);
            obj.transform.rotation = transform.rotation;
            obj.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Ǯ�� ��� ������ ������Ʈ�� �����ϴ�.");
        }
    }
}
