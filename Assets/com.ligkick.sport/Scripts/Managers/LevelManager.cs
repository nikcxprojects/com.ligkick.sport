using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int currentKicks;
    [SerializeField] Color active;

    [Space(10)]
    [SerializeField] int[] kicks;
    [SerializeField] Image[] levels;

    private void Start()
    {
        SetLevel(0);
    }

    public void SetLevel(int levelIndex)
    {
        currentKicks = kicks[levelIndex];
        for(int i = 0; i < levels.Length; i++)
        {
            levels[i].color = levels[i].transform.GetSiblingIndex() == levelIndex ? active : Color.white;
        }
    }
}
