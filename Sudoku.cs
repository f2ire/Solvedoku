namespace Solvedoku;

public class Sudoku
{
    public readonly Cell[,] Cells = new Cell[9, 9];
    public readonly List<Rule> Rules = new ();    
    public Sudoku()
    {
    }
}