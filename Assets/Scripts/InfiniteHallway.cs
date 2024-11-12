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
        while (true)
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
            obj.transform.position = transform.position;
            obj.transform.rotation = transform.rotation;
            obj.SetActive(true);
        }
        else
        {
            Debug.LogWarning("풀에 사용 가능한 오브젝트가 없습니다.");
        }
    }
}
