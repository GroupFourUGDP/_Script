#region BaseController:TIME

/*----------------------------------------------------------------
// 文件名称：BaseController
// 创 建 者：TouMing
// 创建时间：TIME
//===============================================================
// 功能描述：
//		
//
//----------------------------------------------------------------*/

#endregion

using System;
using System.Windows.Input;
using UnityEngine;
using Factory;

public  class BaseController : MonoBehaviour
{
    protected CharacterController cc;
    public CharacterController CC { get => cc; }
    public CharacterData_SO ExampleDataSo;
    public CharacterData_SO BaseDataSo;
    public Vector3 velocityDriction = new Vector3();



    protected IMoveCommand move;
    protected IMoveCommand sprint;
    public  float Speed { get; set; }

    public  float JumpSpeed { get; set; }

    protected virtual void Awake()
    {
        BaseDataSo = GameObject.Instantiate(ExampleDataSo);
        Speed = BaseDataSo.speed;
        // JumpSpeed = BaseDataSo.jumpSpeed;
        move = CommandFactory.MoveCommandCreat(MoveCommand.Move);
        sprint = CommandFactory.MoveCommandCreat(MoveCommand.Sprint);
    }

    protected virtual void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    protected virtual void Update()
    {
        // LockRosition();
        IMoveCommand command = null;
        command = CommandInput();
        if(command!=null)
            command?.Execute(this);
    }

    private void LockRosition()
    {
        transform.localRotation = Quaternion.Euler(transform.rotation.x,transform.rotation.y,0);
    }

    protected virtual IMoveCommand CommandInput()
    {
        return null;
    }

    public virtual void BaseMove(BaseController controller)
    {
        
    }

    public virtual void Sprint(BaseController controller)
    {
    }
}
