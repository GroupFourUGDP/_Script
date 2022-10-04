using System;
using System.Collections;
using AmplifyShaderEditor;
using Cinemachine;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : BaseController
{
    [SerializeField]
    private GameObject cinemachine;
    [SerializeField]
    private Transform FirstPerson;

    // private CharacterController cc;
    // private Rigidbody rigidbody;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float speed;


    protected override void Start()
    {
        base.Start();
    }


    private void Update()
    {
        velocityDriction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocityDriction += new Vector3(Camera.main.transform.forward.x,
                transform.forward.y, Camera.main.transform.forward.z);
        }

        if (Input.GetKey(KeyCode.A))
            velocityDriction+=new Vector3(-Camera.main.transform.right.x,-transform.forward.y,-Camera.main.transform.right.z);
        if (Input.GetKey(KeyCode.D))
            velocityDriction+=new Vector3(Camera.main.transform.right.x,transform.forward.y,Camera.main.transform.right.z);
        if (Input.GetKey(KeyCode.S))
            velocityDriction+=new Vector3(-Camera.main.transform.forward.x,-transform.forward.y,-Camera.main.transform.forward.z);

        velocityDriction =velocityDriction.normalized+ transform.position;
        if (velocityDriction != Vector3.zero + transform.position)
            move.Execute(this);
        else
            CC.SimpleMove(Vector3.zero);
        if (Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.S))
        {
            DOTween.Kill("PlayerRosition");
        }
        
        if (FirstPerson != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                OnChangeVisual();
            }
        }
    }

    public override void BaseMove(BaseController controller)
    {
        controller.gameObject.transform.DOLookAt(controller.velocityDriction,2).SetId("PlayerRosition");
        controller.CC.SimpleMove(transform.forward * controller.Speed);
    }

    public override void Sprint(BaseController controller)
    {
        controller.CC.SimpleMove(controller.velocityDriction * controller.Speed);
    }
    
    /// <summary>
    /// 改变视角
    /// </summary>
    void OnChangeVisual()
    {
        if(cinemachine!=null)
        {
            if (cinemachine.activeSelf)
            {
                cinemachine.SetActive(false);
                Camera.main.transform.position = FirstPerson.position;
                Camera.main.transform.rotation = FirstPerson.rotation;
            }
            else
            {
                cinemachine.SetActive(true);
            }
        }
        else
        {
            Debug.LogError("哥，你Cinemachine忘了赋值");
        }
    }
    private void OnEnable()
    {


    }

  

    private void OnDisable()
    {
        
    }

    public void OnWalk(InputAction.CallbackContext ctx)
    {
        //A x = -1;
        //D x = 1
        //W y = 1
        //S y = -1
        // Vector2 WASD = ctx.ReadValue<Vector2>();
        // if (WASD.y == 1)
        //     walkDirection += transform.forward;
        // if (WASD.y == -1)
        //     walkDirection += -transform.forward;
        // if (WASD.x == 1)
        //     walkDirection += transform.right;
        // if (WASD.x == -1)
        //     walkDirection += -transform.right;
        // if (WASD.x == 0)
        //     walkDirection.x = 0;
        // if (WASD.y == 0)
        //     walkDirection.z = 0;
        // walkDirection += new Vector3(ctx.ReadValue<Vector2>().x, 0, ctx.ReadValue<Vector2>().y);
        // Debug.Log(ctx.ReadValue<Vector2>().x+"|"+ctx.ReadValue<Vector2>().y);
    }


    

}