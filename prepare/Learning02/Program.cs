using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Designer";
        job2._startYear = 2008;
        job2._endYear = 2016;
        
        // Verifying that i can display the company names
        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");

        //Verifying I can view all the job details
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._person = "Reynaldo";


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Verifying that I can access the job titles 
        //Console.WriteLine($"{resume._jobs[1]._jobTitle}");

        resume.DisplayResume();
    }

    
}