using System.Collections;
using UnityEngine;

public class UIButtonShowPlayHide : MonoBehaviour
{
    public GameObject targetObject;
    public Animator animator;
    public string triggerName = "PlayAnim";

    private bool isPlaying = false;

    void Start()
    {
        targetObject.SetActive(false); // mulai invisible
    }

    public void PlaySequence()
    {
        if (!isPlaying)
        {
            StartCoroutine(Sequence());
        }
    }

    IEnumerator Sequence()
    {
        isPlaying = true;

        targetObject.SetActive(true); // visible
        animator.SetTrigger(triggerName);

        yield return null; // tunggu animator update
        float animLength = animator.GetCurrentAnimatorStateInfo(0).length;

        yield return new WaitForSeconds(animLength);

        targetObject.SetActive(false); // invisible lagi
        isPlaying = false;
    }
}
