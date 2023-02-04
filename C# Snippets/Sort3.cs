 public static void Sort3(float x, float y, float z, out float min, out float mid, out float max)
{
    if (x > y)
    {
        if (y > z)
        {
            max = x;
            mid = y;
            min = z;
        }
        else//dY is the smallest
        {
            min = y;

            if (x > z)
            {
                max = x;
                mid = z;
            }
            else//dX is the middle
            {
                max = z;
                mid = x;
            }
        }
    }
    else//dY is bigger than dX
    {
        if (x > z)
        {
            max = y;
            mid = x;
            min = z;
        }
        else//dX is the smallest
        {
            min = x;

            if (y > z)
            {
                max = y;
                mid = z;
            }
            else
            {
                max = z;
                mid = y;
            }
        }
    }
}
