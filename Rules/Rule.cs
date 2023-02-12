namespace Solvedoku;

public abstract class Rule
{
    public readonly Sudoku Sudoku;
    protected Rule(Sudoku sudoku)
    {
        Sudoku = sudoku;
    }
}