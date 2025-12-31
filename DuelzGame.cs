using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public enum GameMode { Duel1v1, Team2v2, Team4v4 }

public class DuelzGame : MonoBehaviour
{
    public static DuelzGame Instance;

    public GameMode currentMode = GameMode.Duel1v1;
    public float matchTimer = 600f;
    public int roundsToWin = 3;

    public Dictionary<int, int> teamScores = new Dictionary<int, int>();

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        teamScores[0] = 0;
        teamScores[1] = 0;
    }

    void Update()
    {
        matchTimer -= Time.deltaTime;
        if (matchTimer <= 0)
        {
            EndMatch();
        }
    }

    public void AddScore(int team)
    {
        teamScores[team]++;
        if (currentMode == GameMode.Duel1v1 && teamScores[team] >= roundsToWin)
            EndMatch();
    }

    void EndMatch()
    {
        Debug.Log("MATCH OVER");
        Time.timeScale = 0;
    }
}
