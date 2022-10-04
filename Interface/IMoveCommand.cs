public interface IMoveCommand
{
    CharacterData_SO DataSo { get; set; }
    void Execute(BaseController controller);
}