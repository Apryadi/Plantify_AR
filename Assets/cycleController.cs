using UnityEngine;
using System.Collections;

public class CycleObjects : MonoBehaviour
{
    public GameObject[] objects; // isi 4 object di inspector
    private int index = 0;
    private bool isCycling = false; // mencegah spam klik

    void Start()
    {
        // Matikan semua object dulu
        foreach (GameObject obj in objects)
            obj.SetActive(false);

        // Tampilkan object pertama
        if (objects.Length > 0)
            objects[0].SetActive(true);
    }

    // Fungsi dipanggil ketika tombol ditekan
    public void NextObject()
    {
        // Cegah tombol ditekan saat masih delay
        if (!isCycling)
        {
            StartCoroutine(CycleWithDelay());
        }
    }

    IEnumerator CycleWithDelay()
    {
        isCycling = true;

        // Delay 3 detik
        yield return new WaitForSeconds(2f);

        // Sembunyikan object saat ini
        objects[index].SetActive(false);

        // Geser ke object berikutnya
        index = (index + 1) % objects.Length;

        // Tampilkan object baru
        objects[index].SetActive(true);

        isCycling = false;
    }
}
