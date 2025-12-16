using UnityEngine;
using System.Collections;

public class CycleObjects : MonoBehaviour
{
    public GameObject[] objects;
    private int index = 0;
    private bool isCycling = false;

    void Start()
    {
        foreach (GameObject obj in objects)
            obj.SetActive(false);

        if (objects.Length > 0)
            objects[0].SetActive(true);
    }

    public void NextObject()
    {
        // Jika sedang delay ATAU sudah di object terakhir → stop
        if (isCycling || index >= objects.Length - 1)
            return;

        StartCoroutine(CycleWithDelay());
    }

    IEnumerator CycleWithDelay()
    {
        isCycling = true;

        yield return new WaitForSeconds(2f);

        // Matikan object sekarang
        objects[index].SetActive(false);

        // Naikkan index (tanpa modulo)
        index++;

        // Nyalakan object baru 
        objects[index].SetActive(true);

        isCycling = false;
    }
}
