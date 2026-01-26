using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yönetimi için gerekli kütüphane

public class SahneGecis : MonoBehaviour
{
    // Bu fonksiyona gitmek istediğimiz sahnenin adını yazacağız
    public void SahneyeGit(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
}