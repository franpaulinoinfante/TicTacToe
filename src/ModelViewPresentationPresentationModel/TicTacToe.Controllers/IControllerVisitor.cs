namespace TicTacToe.Controllers;

public interface IControllerVisitor
{
    public void Visit(StartController startController);
    public void Visit(PlayController startController);
    public bool Visit(ResumeController resumeController);

}
