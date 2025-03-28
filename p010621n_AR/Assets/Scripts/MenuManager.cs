using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadShooting()
    {
        SceneManager.LoadScene("ShootingScene");
    }

    public void Loadface()
    {
        SceneManager.LoadScene("FaceTracking");
    }
    public void LoadImage()
    {
        SceneManager.LoadScene("ImageTrackingScene");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
