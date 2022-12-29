using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int score ;

    private GameObject _last = null;

    [SerializeField] GameObject getStarted;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject game;
    [SerializeField] GameObject result;
    [SerializeField] GameObject levels;

    [Space(10)]
    [SerializeField] GameObject settings;

    [Space(10)]
    [SerializeField] Text scoreText;

    public static Action<bool> OnGameEnd { get; set; }

    private void Awake()
    {
        OpenWindow(0);
    }

    public void OpenMenu()
    {
        OpenWindow(0);
        game.SetActive(false);

        GameManager.Instance.DestroyOld();
    }

    public void StartGameOnClick()
    {
        score = 0;

        scoreText.text = $"{score}";
        GameManager.Instance.StartGame();

        OpenWindow(3);
    }

    public void OpenWindow(int windowIndex)
    {
        if(_last && windowIndex != 4)
        {
            _last.SetActive(false);
        }

        switch(windowIndex)
        {
            case 0: _last = getStarted; break;
            case 1: _last = menu; break;
            case 2: _last = game; break;
            case 3: _last = levels; break;
            case 4: _last = result; break;
        }

        _last.SetActive(true);
        if(windowIndex == 1)
        {
            FindObjectOfType<RewardManager>().Check();
        }
    }

    public void ShowOptions(bool IsOpen)
    {
        settings.SetActive(IsOpen);
    }
}