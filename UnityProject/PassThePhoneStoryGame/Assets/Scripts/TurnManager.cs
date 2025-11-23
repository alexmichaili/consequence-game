using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TurnManager : MonoBehaviour
{
    private int currentPlayer = 1;
    private int currentRound = 1;

    public TMP_InputField inputField;
    public TMP_Text titleText;
    public TMP_Text finalStoryText;

    public GameObject writePanel;
    public GameObject passPanel;
    public TMP_Text passText;
    public GameObject finalPanel;

    private List<string> story = new List<string>();

    void Start()
    {
        ShowWriteScreen();
    }

    public void SubmitLine()
    {
        story.Add($"Player {currentPlayer}: {inputField.text}");
        inputField.text = "";

        writePanel.SetActive(false);

        passText.text = $"Pass the phone to Player {NextPlayer()}";
        passPanel.SetActive(true);
    }

    public void ContinueToNextPlayer()
    {
        currentPlayer++;

        if (currentPlayer > SetupMenu.totalPlayers)
        {
            currentPlayer = 1;
            currentRound++;
        }

        if (currentRound > SetupMenu.totalRounds)
        {
            ShowFinalStory();
            return;
        }

        passPanel.SetActive(false);
        ShowWriteScreen();
    }

    void ShowWriteScreen()
    {
        writePanel.SetActive(true);
        finalPanel.SetActive(false);
        inputField.text = "";
        titleText.text = $"Player {currentPlayer} – Round {currentRound}";
    }

    void ShowFinalStory()
    {
        passPanel.SetActive(false);
        writePanel.SetActive(false);

        finalPanel.SetActive(true);
        finalStoryText.text = string.Join("\n", story);
    }

    int NextPlayer()
    {
        int next = currentPlayer + 1;
        if (next > SetupMenu.totalPlayers) next = 1;
        return next;
    }

    // add these functions inside the TurnManager class:
    public void RestartGame()
    {
        // Restart the experience from Setup scene
        SceneManager.LoadScene("Setup");
    }

    public void ExitGame()
    {
        // Go back to the main menu
        SceneManager.LoadScene("MainMenu");
    }

}
