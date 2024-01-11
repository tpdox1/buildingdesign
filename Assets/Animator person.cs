using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPerson : MonoBehaviour
{
    public Animator animatorController;

    void Start()
    {
        StartCoroutine(DoSomethingWithDelay());
    }

    IEnumerator DoSomethingWithDelay()
    {
        yield return new WaitForSeconds(3.0f);

        animatorController.SetTrigger("New Trigger");

        Debug.Log("Три секунды прошло, newtrigger активирован!");
    }

}
