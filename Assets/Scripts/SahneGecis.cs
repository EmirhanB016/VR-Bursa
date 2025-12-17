using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public void SahneyeGit(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
}