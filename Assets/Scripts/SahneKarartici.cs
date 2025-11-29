using UnityEngine;
using UnityEngine.UI; // UI resmini kontrol etmek için
using UnityEngine.SceneManagement; // Sahne değiştirmek için
using System.Collections; // Zaman ayarlı işlemler (Coroutine) için gerekli

public class SahneKarartici : MonoBehaviour
{
    public Image siyahPerdeResmi; // Inspector'dan siyah resmi buraya atacağız
    public float gecisSuresi = 1.0f; // Kaç saniyede kararsın?

    void Start()
    {
        // Sahne ilk açıldığında otomatik olarak aydınlanmaya başla
        // Eğer perde atanmamışsa hata vermesin diye kontrol ediyoruz
        if (siyahPerdeResmi != null)
        {
             StartCoroutine(Aydinlan());
        }
    }

    // Butonlara bu fonksiyonu bağlayacağız
    public void KarartVeGit(string sahneAdi)
    {
        StartCoroutine(KararVeYukle(sahneAdi));
    }

    // Yavaşça aydınlanma işlemi (Fade In)
    IEnumerator Aydinlan()
    {
        float gecenSure = 0f;
        Color anlikRenk = siyahPerdeResmi.color;
        while (gecenSure < gecisSuresi)
        {
            gecenSure += Time.deltaTime;
            // Alpha değerini 1'den (siyah) 0'a (şeffaf) doğru azalt
            anlikRenk.a = Mathf.Lerp(1f, 0f, gecenSure / gecisSuresi);
            siyahPerdeResmi.color = anlikRenk;
            yield return null; // Bir sonraki kareyi bekle
        }
         // İşlem bitince tam şeffaf olduğundan emin ol ve tıklamaları engelleme
         anlikRenk.a = 0f;
         siyahPerdeResmi.color = anlikRenk;
         siyahPerdeResmi.raycastTarget = false; 
    }

    // Yavaşça kararma ve sahne yükleme işlemi (Fade Out)
    IEnumerator KararVeYukle(string sahneAdi)
    {
        siyahPerdeResmi.raycastTarget = true; // Kararırken oyuncu başka yere tıklayamasın
        float gecenSure = 0f;
        Color anlikRenk = siyahPerdeResmi.color;
        while (gecenSure < gecisSuresi)
        {
            gecenSure += Time.deltaTime;
            // Alpha değerini 0'dan (şeffaf) 1'e (siyah) doğru artır
            anlikRenk.a = Mathf.Lerp(0f, 1f, gecenSure / gecisSuresi);
            siyahPerdeResmi.color = anlikRenk;
            yield return null;
        }
        // İşlem bitince tam siyah olduğundan emin ol
        anlikRenk.a = 1f;
        siyahPerdeResmi.color = anlikRenk;
        
        // Ve nihayet sahneyi yükle
        SceneManager.LoadScene(sahneAdi);
    }
}