using System.Collections;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stage : MonoBehaviour
{
    public int StageNumber;
    public float Progress;
    public float MaxProgress = 100f;

    public bool isCompleted;
    public bool ShopFound;

    private float encounter1;
    private float encounter2;
    private float encounter3;
    private float encounter4;
    private float encounter5;

    public Image ProgressImage;
    public TextMeshProUGUI ProgressText;
    public TextMeshProUGUI StageText;

    public delegate void OnExploreEventHandler();
    public event OnExploreEventHandler OnExplore;

    public Stage(int stageNumber)
    {
        encounter1 = Random.Range(10f, MaxProgress);
        encounter2 = Random.Range(10f, MaxProgress);
        encounter3 = Random.Range(10f, MaxProgress);
        encounter4 = Random.Range(10f, MaxProgress);
        encounter5 = Random.Range(10f, MaxProgress);

        Progress = 0;
        ShopFound = false;
        isCompleted = false;
    }

    public void Explore()
    {
        OnExplore?.Invoke();
        StartCoroutine(CoExplore());
    }

    public IEnumerator CoExplore()
    {
        while (GameManager.Instance.isExplore)
        {
            Progress += 1f;
            if (Progress >= MaxProgress)
            {
                NextStage();
                UpdateUI();
                yield return new WaitForSeconds(1f);
                GameManager.Instance.Explore();
            }
            else
            {
                UpdateUI();
                yield return new WaitForSeconds(0.2f);
            }
            
        }

    }

    public void NextStage()
    {
        GameManager.Instance.isExplore = false;
        Progress = 0;
        StageNumber++;
        //TODO Togle UI
    }

    private void UpdateUI()
    {
        if (ProgressImage != null)
        {
            ProgressImage.fillAmount = Progress / MaxProgress;
        }

        if (ProgressText != null)
        {
            ProgressText.text = $"{Progress} / {MaxProgress}";
        }

        if(StageText != null)
        {
            StageText.text = "Stage" + StageNumber;
        }
    }
}