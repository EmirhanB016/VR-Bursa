using UnityEngine;

public class SokakGecis : MonoBehaviour
{
    [Header("Ayarlar")]
    public Material yeniGokyuzu;      
    public GameObject suAnkiKutu;     
    public GameObject gidilecekKutu;  

    public void Ilerle()
    {
        RenderSettings.skybox = yeniGokyuzu;
        DynamicGI.UpdateEnvironment();

        if (suAnkiKutu != null)
        {
            suAnkiKutu.SetActive(false);
        }

        if (gidilecekKutu != null)
        {
            gidilecekKutu.SetActive(true);
        }
    }
}