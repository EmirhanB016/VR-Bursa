using UnityEngine;

public class SokakGecis : MonoBehaviour
{
    [Header("Ayarlar")]
    public Material yeniGokyuzu;      // Gideceğimiz yerin fotoğrafı
    public GameObject suAnkiKutu;     // İçinde olduğumuz kutu (Kapanacak)
    public GameObject gidilecekKutu;  // Gideceğimiz kutu (Açılacak)

    // Bu fonksiyonu oka tıklayınca çalıştıracağız
    public void Ilerle()
    {
        // 1. Gökyüzü resmini değiştir
        RenderSettings.skybox = yeniGokyuzu;
        DynamicGI.UpdateEnvironment(); // Işıklandırmayı güncelle

        // 2. Eski kutuyu gizle (İçindeki oklar ve bilgiler kaybolur)
        if (suAnkiKutu != null)
        {
            suAnkiKutu.SetActive(false);
        }

        // 3. Yeni kutuyu aç (Yeni oklar ve bilgiler gelir)
        if (gidilecekKutu != null)
        {
            gidilecekKutu.SetActive(true);
        }
    }
}