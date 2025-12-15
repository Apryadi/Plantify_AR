using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonCooldown : MonoBehaviour
{
    public Button button;
    public float cooldownTime = 2f;

    void Awake()
    {
        if (button == null)
            button = GetComponent<Button>();
    }

    public void OnButtonClick()
    {
        if (!button.interactable)
            return;

        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {
        button.interactable = false;
        yield return new WaitForSeconds(cooldownTime);
        button.interactable = true;
    }
}
