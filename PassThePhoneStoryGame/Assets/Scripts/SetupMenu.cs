using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SetupMenu : MonoBehaviour
{
    public TMP_InputField playersInput;
    public TMP_InputField roundsInput;

    public static int totalPlayers;
    public static int totalRounds;

    public void StartStory()
    {
        totalPlayers = int.Parse(playersInput.text);
        totalRounds = int.Parse(roundsInput.text);

        SceneManager.LoadScene("GameRoom");
    }
}
