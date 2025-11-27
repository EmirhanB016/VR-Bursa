using UnityEngine;

public class Look : MonoBehaviour
{
    // Kamera referansını otomatik bulacağız
    private Camera mainCamera;

    void Start()
    {
        // Sahnedeki ana kamerayı bul
        mainCamera = Camera.main;
    }

    void LateUpdate()
    {
        // Eğer kamera varsa, bu obje ona baksın
        if (mainCamera != null)
        {
            // Kameraya doğru dön, ama sadece Y ekseninde (isteğe bağlı)
            // Tam olarak kameraya bakması için:
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
                             mainCamera.transform.rotation * Vector3.up);
        }
    }
}