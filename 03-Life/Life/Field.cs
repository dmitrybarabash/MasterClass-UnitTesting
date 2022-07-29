using System;
using System.Threading;

namespace Life;

public class Field
{
    private readonly int _height;
    private readonly int _width;
    private int _generationDelta;

    public bool[,] Cells { get; private set; }

    public Field() : this(20, 80) =>
        InitialFill();

    public Field(int height, int width)
    {
        _height = height;
        _width = width;
        Cells = new bool[_height, _width];
        _generationDelta = 0;
    }

    private void InitialFill()
    {
        var r = new Random();
        for (int y = 0; y < _height; y++)
            for (int x = 0; x < _width; x++)
                Cells[y, x] = r.Next(1, 5) == 1;
    }

    public int GetNeighbourCount(int y, int x)
    {
        int result = 0;
        for (int yy = y - 1; yy <= y + 1; yy++)
        {
            for (int xx = x - 1; xx <= x + 1; xx++)
            {
                if (!(xx == x && yy == y))
                {
                    int realY = yy, realX = xx;

                    if (yy == -1) realY = _height - 1;
                    if (yy == _height) realY = 0;
                    if (xx == -1) realX = _width - 1;
                    if (xx == _width) realX = 0;

                    if (Cells[realY, realX])
                        result++;
                }
            }
        }
        return result;
    }

    public bool IsToLive(int y, int x)
    {
        var neighbours = GetNeighbourCount(y, x);
        return
            (!Cells[y, x] && neighbours == 3) ||
            (Cells[y, x] && (neighbours == 2 || neighbours == 3));
    }

    public void DieOrLive(int y, int x) =>
        Cells[y, x] = IsToLive(y, x);

    public void NextGeneration()
    {
        bool[,] newCells = (bool[,])Cells.Clone();
        _generationDelta = 0;

        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
            {
                newCells[y, x] = IsToLive(y, x);
                if (Cells[y, x] != newCells[y, x])
                    _generationDelta++;
            }
        }

        Cells = newCells;
    }

    public bool AreAllDead()
    {
        for (int y = 0; y < _height; y++)
            for (int x = 0; x < _width; x++)
                if (Cells[y, x])
                    return false;
        return true;
    }

    public bool IsGameOver()
    {
        // Игра прекращается, если:
        //   - на поле не останется ни одной «живой» клетки;
        //   - если при очередном шаге ни одна из клеток не меняет своего состояния
        //     (складывается стабильная конфигурация);
        //   - конфигурация на очередном шаге в точности (без сдвигов и поворотов)
        //     повторит себя же на одном из более ранних шагов (складывается
        //     периодическая конфигурация).
        return AreAllDead() || _generationDelta == 0;
    }

    public void Run()
    {
        do
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(Cells[y, x] ? "*" : " ");
                }
            }
            Thread.Sleep(500);
            NextGeneration();
        }
        while (!IsGameOver());
    }
}
