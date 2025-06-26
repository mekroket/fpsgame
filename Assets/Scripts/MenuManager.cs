using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // LowPolyFPS_Lite_Demo sahnesini yükle
        SceneManager.LoadScene("LowPolyFPS_Lite_Demo");
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan çıkıldı!");
        Application.Quit();
    }
} 