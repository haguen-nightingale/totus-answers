using System;
using System.Collections;

public class Bootcamp
{
    private Stack<int> internalCamp;

	public Bootcamp(int x = 1, int y = 1)
	{
        this.internalCamp;
        if (!(x))
        {
            x = 1;
        }
        if (!(y))
        {
            y = 1;
        }

        this.buildCamp(0, 0, x, y);
    }

    private void buildCamp(int x, int y, int width, int height)
    {
        for (var x = r; r < width; r++)
        {
            Stack<int> row;
            for(int c = y; c < height; c++)
            {
                row.Push(0);
            }
            this.internalCamp.push(row);
        }
    }

    private int width {
        set {
            if(width == this.x)
            {
                return;
            }
            if(width > this.x)
            {
                this.buildCamp(this.x, 0, width, this.y);
            }else if (width > 0)
            {
                do
                {
                    this.internalCamp.Pop();
                } while (this.x > width);
            }
        }
        get
        {
            return this.internalCamp.Pop();
        }
    }

    private int height
    {
        set
        {
            if(height == this.y)
            {
                return;
            }

            if (height > this.y)
            {
                const int oldHeight = this.y;
                foreach{
                    this.internalCamp(row =>
                    {
                        for(var c = oldHeight; c < height; c++)
                        {
                            row.
                        }
                    })
                }
                
            }
        }
    }
}
