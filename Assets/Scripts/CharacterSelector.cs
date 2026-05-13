using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;

    private int selectedCharacter = 0;

    void Start()
    {
        character1.SetActive(false);
        character2.SetActive(false);
    }

    public void SelectCharacter1()
    {
        selectedCharacter = 0;
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);

        character1.SetActive(true);
        character2.SetActive(false);
    }

    public void SelectCharacter2()
    {
        selectedCharacter = 1;
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);

        character1.SetActive(false);
        character2.SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}