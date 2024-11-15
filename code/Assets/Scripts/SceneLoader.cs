using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static string level;
    public static string map;
    public string currentLevel;

    // Track which players have started the game
    private int playersReady = 0;  // Counter for how many players are ready

    public void SetLevel(string thisLevel)
    {
        level = thisLevel;
    }

    public void CharacterSelect()
    {
        SceneManager.LoadScene("Player1Selector");
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(level);
    }

    public void SetMap(string thismap)
    {
        map = thismap;
    }

    public void StartMap()
    {
        SceneManager.LoadScene(map);
    }

    private void Update()
    {
        // Increment the playersReady counter based on input
        if (currentLevel.Equals("Player1Selector"))
        {
            if (Input.GetButtonDown("P1_Start") && playersReady < 2)
            {
                playersReady++;
                if (playersReady >= 2) // If two players are ready, move to the map
                {
                    StartMap();
                }
            }
        }
        else if (currentLevel.Equals("Player2Selector"))
        {
            if (Input.GetButtonDown("P2_Start") && playersReady < 2)
            {
                playersReady++;
                if (playersReady >= 2)
                {
                    StartMap();
                }
            }
        }
        else if (currentLevel.Equals("Player3Selector"))
        {
            if (Input.GetButtonDown("P3_Start") && playersReady < 2)
            {
                playersReady++;
                if (playersReady >= 2)
                {
                    StartMap();
                }
            }
        }
        else if (currentLevel.Equals("Player4Selector"))
        {
            if (Input.GetButtonDown("P4_Start") && playersReady < 2)
            {
                playersReady++;
                if (playersReady >= 2)
                {
                    StartMap();
                }
            }
        }
    }
}
