using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;

    void Start()
    {
        // TUGAS 5: Hitung jumlah koin di scene saat mulai secara otomatis
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        Debug.Log("Total koin yang harus dikumpulkan: " + totalKoin);
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;
        Debug.Log("Koin dikumpulkan: " + koinTerkumpul + " / " + totalKoin);

        // TUGAS 5: Jika koinTerkumpul sama dengan totalKoin, panggil Menang()
        if (koinTerkumpul >= totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");
    }
}