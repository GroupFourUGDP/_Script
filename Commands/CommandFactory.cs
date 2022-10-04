#region CommandFactory:2022年08月07日 星期日 03:10

/*----------------------------------------------------------------
// 文件名称：CommandFactory
// 创 建 者：TouMing
// 创建时间：2022年08月07日 星期日 03:10
//===============================================================
// 功能描述：
//		
//
//----------------------------------------------------------------*/

#endregion

namespace Factory
{
    public static class CommandFactory
    {
        public static IMoveCommand MoveCommandCreat(MoveCommand command)
        {
            switch (command)
            {
                case MoveCommand.Move: return new CommandList.Move();
                case MoveCommand.Sprint: return new CommandList.Sprint();
                default:
                    return null;
            }
        }
        
    }

    public enum MoveCommand
    {
        MoveForward,
        MoveBack,
        MoveRight,
        MoveLeft,
        Move,
        Sprint
        
    }
    
}
