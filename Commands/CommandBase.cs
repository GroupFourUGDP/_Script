using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class CommandBase:IMoveCommand
{
    public CharacterData_SO DataSo { get; set; }
    public abstract void Execute(BaseController controller);
}
//w键，前进
//S键，后退
//A键，左移动
//D键，右移动
//shift,向着当前速度方向进行一次冲刺 未实现
