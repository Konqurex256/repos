using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    private bool isMoving;
    private Vector2 input;
    private Animator animator;
    public LayerMask solidObjectsLayer;

    // Update is called once per frame

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if(input.x != 0 ) { input.y = 0; }

            if(input != Vector2.zero)
            {
                animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveY", input.y);

                var TargetPos = transform.position;
                TargetPos.x += input.x;
                TargetPos.y += input.y;

                if(isWalkable(TargetPos))
                    StartCoroutine(Move(TargetPos)); 
            }
        }

        animator.SetBool("isMoving", isMoving);
    }

    IEnumerator Move (Vector3 TargetPos)
    {
        isMoving = true;
        while ((TargetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = TargetPos;
        
        isMoving = false;
    }

    private bool isWalkable(Vector3 TargetPos)
    {
        if(Physics2D.OverlapCircle(TargetPos, 0.1f, solidObjectsLayer) != null)
        {
            return false;
        }
        return true;
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}
}
