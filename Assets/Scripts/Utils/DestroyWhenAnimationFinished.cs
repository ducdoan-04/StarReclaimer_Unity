using System.Collections;
using UnityEngine;

public class DestroyWhenAnimationFinished : MonoBehaviour
{
    private Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
        Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
    }

    // IEnumerator Deactivate(){
    //     yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
    //     gameObject.SetActive(false);
    // }
}
