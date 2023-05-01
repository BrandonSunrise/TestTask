using System;

public class HedgehogsColor
{
    public static int MinimumMeetings(int desiredColor, int[] hedgehogs)
    {
        int otherColor1 = (desiredColor + 1) % 3;
        int otherColor2 = (desiredColor + 2) % 3;
        int meetings = 0;

        while (hedgehogs[desiredColor] != 0)
        {
            if (hedgehogs[otherColor1] == 0 && hedgehogs[otherColor2] == 0)
            {
                return -1;
            }

            if (hedgehogs[otherColor1] >= hedgehogs[otherColor2])
            {
                hedgehogs[desiredColor] += hedgehogs[otherColor2];
                hedgehogs[otherColor1] -= hedgehogs[otherColor2];
                hedgehogs[otherColor2] = 0;
            }
            else
            {
                hedgehogs[desiredColor] += hedgehogs[otherColor1];
                hedgehogs[otherColor2] -= hedgehogs[otherColor1];
                hedgehogs[otherColor1] = 0;
            }

            meetings++;
        }

        return meetings;
    }
}