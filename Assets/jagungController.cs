using UnityEngine;
using System.Collections;

public class JagungGrowthStageController : MonoBehaviour
{
    public GameObject[] growthStages; // Tahap pertumbuhan jagung yang akan ditampilkan
    private int currentStageIndex = 0;
    private bool isTransitioning = false; // Cegah multiple clicks selama transisi

    void Start()
    {
        // Sembunyikan semua tahap pertumbuhan
        foreach (GameObject stage in growthStages)
            stage.SetActive(false);

        // Tampilkan tahap pertumbuhan awal
        if (growthStages.Length > 0)
            growthStages[0].SetActive(true);
    }

    // Dipanggil ketika tombol untuk menampilkan tahap berikutnya ditekan
    public void ShowNextGrowthStage()
    {
        // Hindari input selama tahap transisi sedang berlangsung
        if (!isTransitioning)
        {
            StartCoroutine(ProgressToNextStageWithDelay());
        }
    }

    IEnumerator ProgressToNextStageWithDelay()
    {
        isTransitioning = true;

        // Tunggu sebelum menunjukkan tahap berikutnya
        yield return new WaitForSeconds(2f);

        // Sembunyikan tahap pertumbuhan yang sedang ditampilkan
        growthStages[currentStageIndex].SetActive(false);

        // Pindah ke indeks tahap berikutnya
        currentStageIndex = (currentStageIndex + 1) % growthStages.Length;

        // Tampilkan tahap pertumbuhan baru
        growthStages[currentStageIndex].SetActive(true);

        isTransitioning = false;
    }
}
