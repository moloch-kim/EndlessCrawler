using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public InfiniteHallway infiniteHallway;
    public Stage stage;

    private void Start()
    {
        infiniteHallway.OnExplore += GameManager.Instance.Explore;
        stage.OnExplore += GameManager.Instance.Explore;

        infiniteHallway.Explore();
        stage.Explore();
    }

    private void OnDestroy()
    {
        infiniteHallway.OnExplore -= GameManager.Instance.Explore;
        stage.OnExplore -= GameManager.Instance.Explore;
    }
}
