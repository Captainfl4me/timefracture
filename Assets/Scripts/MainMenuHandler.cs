using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField]
    private int sceneToLoadIndex = 0;
    private bool isSceneLoading = false;

    [SerializeField]
    private GameObject mainButtonList;
    [SerializeField]
    private GameObject mainSettingsPanel;

    public void Start()
    {
        mainButtonList.SetActive(true);
        mainSettingsPanel.SetActive(false);
    }

    public void StartGame()
    {
        if (isSceneLoading)
            return;

        Debug.Log("Starting game...");
        isSceneLoading = true;
        StartCoroutine(LoadGameScene());
    }

    IEnumerator LoadGameScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoadIndex, LoadSceneMode.Single);

        while (!asyncLoad.isDone)
        {
            isSceneLoading = false;
            Debug.Log("Done!");
            yield return null;
        }
    }

    public void ClosePanels()
    {
        mainButtonList.SetActive(true);
        mainSettingsPanel.SetActive(false);        
    }

    public void OpenSettingPanel()
    {
        mainButtonList.SetActive(false);
        mainSettingsPanel.SetActive(true);        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
