using UnityEngine;
using UnityEngine.UI;

public class SesKontrol : MonoBehaviour
{
    private AudioSource sesKaynagi;

    void Start()
    {
        // Butonun üzerindeki AudioSource'u otomatik bul
        sesKaynagi = GetComponent<AudioSource>();
    }

    // Bu fonksiyonu butona bağlayacağız
    public void SesAcKapa()
    {
        if (sesKaynagi.isPlaying)
        {
            // Çalıyorsa durdur
            sesKaynagi.Pause(); // İstersen .Stop() da yapabilirsin
        }
        else
        {
            // Susuyorsa çal
            sesKaynagi.Play();
        }
    }

    // KRİTİK BÖLÜM:
    // Bilgi kutusu (veya bu buton) kapandığı anda sesi sustur.
    // Böylece oyuncu kutuyu kapatınca ses arkada devam etmez.
    void OnDisable()
    {
        if (sesKaynagi != null)
        {
            sesKaynagi.Stop();
        }
    }
}