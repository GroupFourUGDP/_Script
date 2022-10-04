#region CommandList:TIME

/*----------------------------------------------------------------
// 文件名称：CommandList
// 创 建 者：TouMing
// 创建时间：TIME
//===============================================================
// 功能描述：
//		
//
//----------------------------------------------------------------*/

#endregion

using UnityEngine;

public static class CommandList
{
    
    public class Move:CommandBase
    {
        private CharacterController cc;
        
        public override void Execute(BaseController controller)
        {
            controller.BaseMove(controller);
        }
    }
    public class Sprint:CommandBase
    {
        private CharacterController cc;
        
        public override void Execute(BaseController controller)
        {
            controller.Sprint(controller);
        }
    }

}
