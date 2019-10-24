using System;

public class Course
{
    string name;
    bool isTaken, fall, spring, summer, onDemand;
    List<Course> CoReqs, PreReqs, PostReqs;


	public Course(string name, bool isTaken, bool fall, bool spring, bool summer, bool onDemand, List<Course> CoReqs, List<Course> PreReqs, List<Course> PostReqs)
	{
        this.name = name;
        this.isTaken = isTaken;
        this.fall = fall;
        this.spring = spring;
        this.summer = summer;
        this.onDemand = onDemand;
        this.CoReqs = CoReqs;
        this.PreReqs = PreReqs;
        this.PostReqs = PostReqs;
	}
}
