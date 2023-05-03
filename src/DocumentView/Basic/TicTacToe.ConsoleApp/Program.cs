using TicTacToe.ConsoleApp.Views;

TicTacToe.TicTacToe ticTacToe = new TicTacToe.TicTacToe();
ConsoleView consoleView = new ConsoleView(ticTacToe.Game);

ticTacToe.GameView = consoleView;
ticTacToe.Run();
