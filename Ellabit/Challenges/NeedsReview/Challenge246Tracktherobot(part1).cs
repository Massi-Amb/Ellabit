﻿namespace Ellabit.Challenges
{
    public class Challenge246Tracktherobotpart1 : IChallenge
    {
        public string? Header { get; set; } = "Track the robot (part 1)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int[] TrackRobot(string[] instructions) {
		
	}
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"A robot has been given a list of movement instructions. Each instruction is either left, right, up or down, followed by a distance to move. The robot starts at [0, 0]. You want to calculate where the robot will end up and return its final position as an array.

To illustrate, if the robot is given the following instructions:

new string[] { ""right 10"", ""up 50"", ""left 30"", ""down 10"" }
It will end up 20 left and 40 up from where it started, so we return int[] { -20, 40 }.

Examples
TrackRobot(new string[] { ""right 10"", ""up 50"", ""left 30"", ""down 10"" }) ➞ int[] { -20, 40 }

TrackRobot(new string[] { }) ➞ int[] { 0, 0 }
// If there are no instructions, the robot doesn't move.

TrackRobot(new string[] { ""right 100"", ""right 100"", ""up 500"", ""up 10000"" }) ➞ new int[] { 200, 10500 }
Notes
The only instructions given will be left, right, up or down.
The distance after the instruction is always a positive whole number.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
}
}
