using UnityEngine;

public class Hallway : MonoBehaviour
{
    public float moveSpeed;

    private void Update()
    {
        if (GameManager.Instance.isExplore)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

            if (transform.position.z <= -12f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
